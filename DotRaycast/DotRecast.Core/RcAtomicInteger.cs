using System.Threading;

namespace DotRecast.Core;

public class RcAtomicInteger(int location)
{
    private volatile int _location = location;

    public RcAtomicInteger() : this(0)
    {
    }

    public int IncrementAndGet() => Interlocked.Increment(ref _location);

    public int GetAndIncrement()
    {
        var next = Interlocked.Increment(ref _location);
        return next - 1;
    }

    public int DecrementAndGet() => Interlocked.Decrement(ref _location);

    public int Read() => _location;

    public int GetSoft() => _location;

    public int Exchange(int exchange) => Interlocked.Exchange(ref _location, exchange);

    public int Decrease(int value) => Interlocked.Add(ref _location, -value);

    public int CompareExchange(int value, int comparand) => Interlocked.CompareExchange(ref _location, value, comparand);

    public int Add(int value) => Interlocked.Add(ref _location, value);
}