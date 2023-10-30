// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Interfaces;

namespace WrathForged.Instance.Server.Maps.Collision;

public class BIHWrap<T> where T : ICollisionModel
{
    private readonly Dictionary<T, int> _obj2Idx = [];
    private readonly List<T> _objects = [];
    private readonly HashSet<T> _objectsToPush = [];
    private readonly BIHCalculator _tree = new();
    private int _unbalancedTimes;

    public void Balance()
    {
        if (_unbalancedTimes == 0)
            return;

        lock (_objects)
        {
            _unbalancedTimes = 0;
            _objects.Clear();
            _objects.AddRange(_obj2Idx.Keys);
            _objects.AddRange(_objectsToPush);

            _tree.Build(_objects);
        }
    }

    public void Insert(T obj)
    {
        ++_unbalancedTimes;

        lock (_objects)
            _ = _objectsToPush.Add(obj);
    }

    public void IntersectPoint(Vector3 point, IWorkerCallback intersectCallback)
    {
        lock (_objects)
        {
            Balance();
            MdlCallback callback = new(intersectCallback, _objects, _objects.Count);
            _tree.IntersectPoint(point, callback);
        }
    }

    public void IntersectRay(Ray ray, IWorkerCallback intersectCallback, ref float maxDist)
    {
        lock (_objects)
        {
            Balance();
            MdlCallback tempCb = new(intersectCallback, _objects, _objects.Count);
            _tree.IntersectRay(ray, tempCb, ref maxDist, true);
        }
    }

    public class MdlCallback(IWorkerCallback callback, List<T> objectsArray, int size) : IRayIntersect, IPointIntersect
    {
        private readonly IWorkerCallback _callback = callback;
        private readonly List<T> _objects = objectsArray;
        private readonly int _objectsSize = size;

        public bool DidRayHit(Ray ray, int idx, ref float maxDistance, bool stopAtFirstHit)
        {
            if (idx >= _objectsSize)
                return false;

            var obj = _objects[idx];

            return obj != null && _callback.DidRayObjectIntersect(ray, obj, ref maxDistance);
        }

        /// Intersect point
        public void PointIntersectedObject(Vector3 p, int idx)
        {
            if (idx >= _objectsSize)
                return;

            if (_objects[idx] is GameObjectCollisionModel obj)
                _callback.GameObjectIntersectedObject(p, obj);
        }
    }
}