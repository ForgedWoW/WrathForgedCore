using System;

namespace DotRecast.Core;

public struct RcAnonymousDisposable(Action dispose) : IDisposable
{
    private Action _dispose = dispose;

    public void Dispose()
    {
        _dispose?.Invoke();
        _dispose = null;
    }
}