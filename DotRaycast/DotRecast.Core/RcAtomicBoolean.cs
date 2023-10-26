using System.Threading;

namespace DotRecast.Core;

public class RcAtomicBoolean
{
    private volatile int _location;

    public bool Set(bool v) => 0 != Interlocked.Exchange(ref _location, v ? 1 : 0);

    public bool Get() => 0 != _location;
}