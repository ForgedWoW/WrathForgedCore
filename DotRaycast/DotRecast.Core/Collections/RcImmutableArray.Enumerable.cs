using System;
using System.Collections;
using System.Collections.Generic;

namespace DotRecast.Core.Collections;

public readonly partial struct RcImmutableArray<T>
{
    public IEnumerator<T> GetEnumerator() => EnumeratorObject.Create(_array);

    IEnumerator IEnumerable.GetEnumerator() => EnumeratorObject.Create(_array);

    private sealed class EnumeratorObject : IEnumerator<T>
    {
        private static readonly IEnumerator<T> EmptyEnumerator = new EnumeratorObject(Empty._array!);
        private readonly T[] _array;
        private int _index;

        internal static IEnumerator<T> Create(T[] array) => array.Length != 0 ? new EnumeratorObject(array) : EmptyEnumerator;

        private EnumeratorObject(T[] array)
        {
            _index = -1;
            _array = array;
        }

        public T Current => unchecked((uint)_index) < (uint)_array.Length ? _array[_index] : throw new InvalidOperationException();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            var newIndex = _index + 1;
            var length = _array.Length;

            if ((uint)newIndex <= (uint)length)
            {
                _index = newIndex;
                return (uint)newIndex < (uint)length;
            }

            return false;
        }

        void IEnumerator.Reset() => _index = -1;
    }
}