﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Runtime.InteropServices;
using Serilog;
using WrathForged.Common.Maths;
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Instance.Server.Maps.Collision.Models;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.Interfaces;

namespace WrathForged.Instance.Server.Maps.Collision;

public class BIHCalculator
{
    public BoundingIntervalHierarchy BIH { get; set; } = new();

    public BIHCalculator() { }

    public BIHCalculator(BoundingIntervalHierarchy bih) => BIH = bih;

    [StructLayout(LayoutKind.Explicit)]
    public struct FloatToIntConverter
    {
        [FieldOffset(0)] public uint IntValue;
        [FieldOffset(0)] public float FloatValue;
    }

    private struct BuildData
    {
        public int[] Indices;
        public int MaxPrims;
        public uint NumPrims;
        public AxisAlignedBox[] PrimBound;
    }

    private struct StackNode
    {
        public uint Node;
        public float Tfar;
        public float Tnear;
    }

    public void Build<T>(List<T> primitives, uint leafSize = 3, bool printStats = false) where T : ICollisionModel
    {
        if (primitives.Count == 0)
            return;

        BuildData dat;
        dat.MaxPrims = (int)leafSize;
        dat.NumPrims = (uint)primitives.Count;
        dat.Indices = new int[dat.NumPrims];
        dat.PrimBound = new AxisAlignedBox[dat.NumPrims];
        BIH.Bounds = primitives[0].Bounds;

        for (var i = 0; i < dat.NumPrims; ++i)
        {
            dat.Indices[i] = i;
            dat.PrimBound[i] = primitives[i].Bounds;
            BIH.Bounds.Merge(dat.PrimBound[i]);
        }

        List<uint> tempTree = [];
        BuildHierarchy(tempTree, dat);

        BIH.Objects = new int[dat.NumPrims];

        for (var i = 0; i < dat.NumPrims; ++i)
            BIH.Objects[i] = dat.Indices[i];

        BIH.Tree = [.. tempTree];
    }

    public void IntersectPoint(Vector3 p, IPointIntersect intersectCallback)
    {
        if (!BIH.Bounds.Contains(p))
            return;

        var stack = new StackNode[64];
        var stackPos = 0;
        var node = 0;

        while (true)
        {
            while (true)
            {
                var tn = BIH.Tree[node];
                var axis = (uint)(tn & (3 << 30)) >> 30;
                var bvh2 = Convert.ToBoolean(tn & (1 << 29));
                var offset = (int)(tn & ~(7 << 29));

                if (!bvh2)
                {
                    if (axis < 3)
                    {
                        // "normal" interior node
                        var tl = IntBitsToFloat(BIH.Tree[node + 1]);
                        var tr = IntBitsToFloat(BIH.Tree[node + 2]);

                        // point is between clip zones
                        if (tl < p.GetAt(axis) && tr > p.GetAt(axis))
                            break;

                        var right = offset + 3;
                        node = right;

                        // point is in right node only
                        if (tl < p.GetAt(axis))
                            continue;

                        node = offset; // left

                        // point is in left node only
                        if (tr > p.GetAt(axis))
                            continue;

                        // point is in both nodes
                        // push back right node
                        stack[stackPos].Node = (uint)right;
                        stackPos++;
                    }
                    else
                    {
                        // leaf - test some objects
                        var n = BIH.Tree[node + 1];

                        while (n > 0)
                        {
                            intersectCallback.PointIntersectedObject(p, BIH.Objects[offset]); // !!!
                            --n;
                            ++offset;
                        }

                        break;
                    }
                }
                else // BVH2 node (empty space cut off left and right)
                {
                    if (axis > 2)
                        return; // should not happen

                    var tl = IntBitsToFloat(BIH.Tree[node + 1]);
                    var tr = IntBitsToFloat(BIH.Tree[node + 2]);
                    node = offset;

                    if (tl > p.GetAt(axis) || tr < p.GetAt(axis))
                        break;
                }
            } // traversal loop

            // stack is empty?
            if (stackPos == 0)
                return;

            // move back up the stack
            stackPos--;
            node = (int)stack[stackPos].Node;
        }
    }

    public void IntersectRay(Ray r, IRayIntersect rayIntersect, ref float maxDist, bool stopAtFirst = false)
    {
        var intervalMin = -1.0f;
        var intervalMax = -1.0f;
        var org = r.Origin;
        var dir = r.Direction;
        var invDir = r.InvDirection();

        for (var i = 0; i < 3; ++i)
            if (MathFunctions.fuzzyNe(dir.GetAt(i), 0.0f))
            {
                var t1 = (BIH.Bounds.Lo.GetAt(i) - org.GetAt(i)) * invDir.GetAt(i);
                var t2 = (BIH.Bounds.Hi.GetAt(i) - org.GetAt(i)) * invDir.GetAt(i);

                if (t1 > t2)
                    MathFunctions.Swap(ref t1, ref t2);

                if (t1 > intervalMin)
                    intervalMin = t1;

                if (t2 < intervalMax || intervalMax < 0.0f)
                    intervalMax = t2;

                // intervalMax can only become smaller for other axis,
                //  and intervalMin only larger respectively, so stop early
                if (intervalMax <= 0 || intervalMin >= maxDist)
                    return;
            }

        if (intervalMin > intervalMax)
            return;

        intervalMin = Math.Max(intervalMin, 0.0f);
        intervalMax = Math.Min(intervalMax, maxDist);

        var offsetFront = new uint[3];
        var offsetBack = new uint[3];
        var offsetFront3 = new uint[3];
        var offsetBack3 = new uint[3];
        // compute custom offsets from direction sign bit

        for (var i = 0; i < 3; ++i)
        {
            offsetFront[i] = FloatToRawIntBits(dir.GetAt(i)) >> 31;
            offsetBack[i] = offsetFront[i] ^ 1;
            offsetFront3[i] = offsetFront[i] * 3;
            offsetBack3[i] = offsetBack[i] * 3;

            // avoid always adding 1 during the inner loop
            ++offsetFront[i];
            ++offsetBack[i];
        }

        var stack = new StackNode[64];
        var stackPos = 0;
        var node = 0;

        while (true)
        {
            while (true)
            {
                var tn = BIH.Tree[node];
                var axis = (uint)(tn & (3 << 30)) >> 30;
                var bvh2 = Convert.ToBoolean(tn & (1 << 29));
                var offset = (int)(tn & ~(7 << 29));

                if (!bvh2)
                {
                    if (axis < 3)
                    {
                        // "normal" interior node
                        var tf = (IntBitsToFloat(BIH.Tree[(int)(node + offsetFront[axis])]) - org.GetAt(axis)) * invDir.GetAt(axis);
                        var tb = (IntBitsToFloat(BIH.Tree[(int)(node + offsetBack[axis])]) - org.GetAt(axis)) * invDir.GetAt(axis);

                        // ray passes between clip zones
                        if (tf < intervalMin && tb > intervalMax)
                            break;

                        var back = (int)(offset + offsetBack3[axis]);
                        node = back;

                        // ray passes through far node only
                        if (tf < intervalMin)
                        {
                            intervalMin = tb >= intervalMin ? tb : intervalMin;

                            continue;
                        }

                        node = offset + (int)offsetFront3[axis]; // front

                        // ray passes through near node only
                        if (tb > intervalMax)
                        {
                            intervalMax = tf <= intervalMax ? tf : intervalMax;

                            continue;
                        }

                        // ray passes through both nodes
                        // push back node
                        stack[stackPos].Node = (uint)back;
                        stack[stackPos].Tnear = tb >= intervalMin ? tb : intervalMin;
                        stack[stackPos].Tfar = intervalMax;
                        stackPos++;
                        // update ray interval for front node
                        intervalMax = tf <= intervalMax ? tf : intervalMax;
                    }
                    else
                    {
                        // leaf - test some objects
                        var n = (int)BIH.Tree[node + 1];

                        while (n > 0)
                        {
                            var hit = rayIntersect.DidRayHit(r, BIH.Objects[offset], ref maxDist, stopAtFirst);

                            if (stopAtFirst && hit)
                                return;

                            --n;
                            ++offset;
                        }

                        break;
                    }
                }
                else
                {
                    if (axis > 2)
                        return; // should not happen

                    var tf = (IntBitsToFloat(BIH.Tree[(int)(node + offsetFront[axis])]) - org.GetAt(axis)) * invDir.GetAt(axis);
                    var tb = (IntBitsToFloat(BIH.Tree[(int)(node + offsetBack[axis])]) - org.GetAt(axis)) * invDir.GetAt(axis);
                    node = offset;
                    intervalMin = tf >= intervalMin ? tf : intervalMin;
                    intervalMax = tb <= intervalMax ? tb : intervalMax;

                    if (intervalMin > intervalMax)
                        break;
                }
            } // traversal loop

            do
            {
                // stack is empty?
                if (stackPos == 0)
                    return;

                // move back up the stack
                stackPos--;
                intervalMin = stack[stackPos].Tnear;

                if (maxDist < intervalMin)
                    continue;

                node = (int)stack[stackPos].Node;
                intervalMax = stack[stackPos].Tfar;

                break;
            } while (true);
        }
    }

    public int PrimCount() => BIH.Objects.Length;

    private void BuildHierarchy(List<uint> tempTree, BuildData dat)
    {
        // create space for the first node
        tempTree.Add(3u << 30); // dummy leaf
        tempTree.Add(0);
        tempTree.Add(0);

        // seed box
        AaBound gridBox = new()
        {
            Lo = BIH.Bounds.Lo,
            Hi = BIH.Bounds.Hi
        };

        // seed subdivide function
        Subdivide(0, (int)(dat.NumPrims - 1), tempTree, dat, gridBox, gridBox, 0, 1);
    }

    private static void CreateNode(List<uint> tempTree, int nodeIndex, int left, int right)
    {
        // write leaf node
        tempTree[nodeIndex + 0] = (uint)((3 << 30) | left);
        tempTree[nodeIndex + 1] = (uint)(right - left + 1);
    }

    private static uint FloatToRawIntBits(float f)
    {
        FloatToIntConverter converter = new()
        {
            FloatValue = f
        };

        return converter.IntValue;
    }

    private static float IntBitsToFloat(uint i)
    {
        FloatToIntConverter converter = new()
        {
            IntValue = i
        };

        return converter.FloatValue;
    }

    private static void Subdivide(int left, int right, List<uint> tempTree, BuildData dat, AaBound gridBox, AaBound nodeBox, int nodeIndex, int depth)
    {
        if (right - left + 1 <= dat.MaxPrims || depth >= 64)
        {
            // write leaf node
            CreateNode(tempTree, nodeIndex, left, right);

            return;
        }

        // calculate extents
        int axis = -1, prevAxis, rightOrig;

        var prevClip = float.NaN;
        float split = float.NaN, prevSplit;
        var wasLeft = true;

        float clipL;

        float clipR;
        while (true)
        {
            prevAxis = axis;
            prevSplit = split;

            // perform quick consistency checks
            _ = gridBox.Hi - gridBox.Lo;

            for (var i = 0; i < 3; i++)
                if (nodeBox.Hi.GetAt(i) < gridBox.Lo.GetAt(i) || nodeBox.Lo.GetAt(i) > gridBox.Hi.GetAt(i))
                    Log.Logger.Error("Reached tree area in error - discarding node with: {0} objects", right - left + 1);

            // find longest axis
            split = 0.5f * (gridBox.Lo.GetAt(axis) + gridBox.Hi.GetAt(axis));
            // partition L/R subsets
            clipL = float.NegativeInfinity;
            clipR = float.PositiveInfinity;
            rightOrig = right; // save this for later
            var nodeL = float.PositiveInfinity;
            var nodeR = float.NegativeInfinity;

            for (var i = left; i <= right;)
            {
                var obj = dat.Indices[i];
                var minb = dat.PrimBound[obj].Lo.GetAt(axis);
                var maxb = dat.PrimBound[obj].Hi.GetAt(axis);
                var center = (minb + maxb) * 0.5f;

                if (center <= split)
                {
                    // stay left
                    i++;

                    if (clipL < maxb)
                        clipL = maxb;
                }
                else
                {
                    // move to the right most
                    (dat.Indices[i], dat.Indices[right]) = (dat.Indices[right], dat.Indices[i]);
                    right--;

                    if (clipR > minb)
                        clipR = minb;
                }

                nodeL = Math.Min(nodeL, minb);
                nodeR = Math.Max(nodeR, maxb);
            }

            // check for empty space
            if (nodeL > nodeBox.Lo.GetAt(axis) && nodeR < nodeBox.Hi.GetAt(axis))
            {
                var nodeBoxW = nodeBox.Hi.GetAt(axis) - nodeBox.Lo.GetAt(axis);
                var nodeNewW = nodeR - nodeL;

                // node box is too big compare to space occupied by primitives?
                if (1.3f * nodeNewW < nodeBoxW)
                {
                    var nextIndex1 = tempTree.Count;
                    // allocate child
                    tempTree.Add(0);
                    tempTree.Add(0);
                    tempTree.Add(0);
                    // write bvh2 clip node
                    tempTree[nodeIndex + 0] = (uint)((axis << 30) | (1 << 29) | nextIndex1);
                    tempTree[nodeIndex + 1] = FloatToRawIntBits(nodeL);
                    tempTree[nodeIndex + 2] = FloatToRawIntBits(nodeR);
                    // update node box and recurse
                    nodeBox.Lo.SetAt(nodeL, axis);
                    nodeBox.Hi.SetAt(nodeR, axis);
                    Subdivide(left, rightOrig, tempTree, dat, gridBox, nodeBox, nextIndex1, depth + 1);

                    return;
                }
            }

            // ensure we are making progress in the subdivision
            if (right == rightOrig)
            {
                // all left
                if (prevAxis == axis && MathFunctions.fuzzyEq(prevSplit, split))
                {
                    // we are stuck here - create a leaf
                    CreateNode(tempTree, nodeIndex, left, right);

                    return;
                }

                if (clipL <= split)
                {
                    // keep looping on left half
                    gridBox.Hi.SetAt(split, axis);
                    prevClip = clipL;
                    wasLeft = true;

                    continue;
                }

                gridBox.Hi.SetAt(split, axis);
                prevClip = float.NaN;
            }
            else if (left > right)
            {
                // all right
                right = rightOrig;

                if (prevAxis == axis && MathFunctions.fuzzyEq(prevSplit, split))
                {
                    // we are stuck here - create a leaf
                    CreateNode(tempTree, nodeIndex, left, right);

                    return;
                }

                if (clipR >= split)
                {
                    // keep looping on right half
                    gridBox.Lo.SetAt(split, axis);
                    prevClip = clipR;
                    wasLeft = false;

                    continue;
                }

                gridBox.Lo.SetAt(split, axis);
                prevClip = float.NaN;
            }
            else
            {
                // we are actually splitting stuff
                if (prevAxis != -1 && !float.IsNaN(prevClip))
                {
                    // second time through - lets create the previous split
                    // since it produced empty space
                    var nextIndex0 = tempTree.Count;
                    // allocate child node
                    tempTree.Add(0);
                    tempTree.Add(0);
                    tempTree.Add(0);

                    if (wasLeft)
                    {
                        // create a node with a left child
                        // write leaf node
                        tempTree[nodeIndex + 0] = (uint)((prevAxis << 30) | nextIndex0);
                        tempTree[nodeIndex + 1] = FloatToRawIntBits(prevClip);
                        tempTree[nodeIndex + 2] = FloatToRawIntBits(float.PositiveInfinity);
                    }
                    else
                    {
                        // create a node with a right child
                        // write leaf node
                        tempTree[nodeIndex + 0] = (uint)((prevAxis << 30) | (nextIndex0 - 3));
                        tempTree[nodeIndex + 1] = FloatToRawIntBits(float.NegativeInfinity);
                        tempTree[nodeIndex + 2] = FloatToRawIntBits(prevClip);
                    }

                    // count stats for the unused leaf
                    depth++;
                    // now we keep going as we are, with a new nodeIndex:
                    nodeIndex = nextIndex0;
                }

                break;
            }
        }

        // compute index of child nodes
        var nextIndex = tempTree.Count;
        // allocate left node
        var nl = right - left + 1;
        var nr = rightOrig - (right + 1) + 1;

        if (nl > 0)
        {
            tempTree.Add(0);
            tempTree.Add(0);
            tempTree.Add(0);
        }
        else
            nextIndex -= 3;

        // allocate right node
        if (nr > 0)
        {
            tempTree.Add(0);
            tempTree.Add(0);
            tempTree.Add(0);
        }

        // write leaf node
        tempTree[nodeIndex + 0] = (uint)((axis << 30) | nextIndex);
        tempTree[nodeIndex + 1] = FloatToRawIntBits(clipL);
        tempTree[nodeIndex + 2] = FloatToRawIntBits(clipR);
        // prepare L/R child boxes
        var gridBoxL = gridBox;
        var gridBoxR = gridBox;
        var nodeBoxL = nodeBox;
        var nodeBoxR = nodeBox;

        gridBoxR.Lo.SetAt(split, axis);
        gridBoxL.Hi.SetAt(split, axis);
        nodeBoxL.Hi.SetAt(clipL, axis);
        nodeBoxR.Lo.SetAt(clipR, axis);

        // recurse
        if (nl > 0)
            Subdivide(left, right, tempTree, dat, gridBoxL, nodeBoxL, nextIndex, depth + 1);

        if (nr > 0)
            Subdivide(right + 1, rightOrig, tempTree, dat, gridBoxR, nodeBoxR, nextIndex + 3, depth + 1);
    }
}

