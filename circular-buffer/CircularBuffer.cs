public class CircularBuffer<T>
{
    private T[] Buffer;
    private int capacity;
    private int oldest_index;
    private int write_index;
    public CircularBuffer(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(capacity, 1);
        this.capacity = capacity;
        Buffer = new T[capacity];
        oldest_index = 0;
        write_index = 0;
    }

    public T Read()
    {
        var value = Buffer[oldest_index];
        if (EqualityComparer<T>.Default.Equals(value, default))
            throw new InvalidOperationException("Buffer is empty.");
        Buffer[oldest_index] = default!;
        oldest_index = GetNextIndex(oldest_index);
        return value;
    }

    public void Write(T value)
    {
        if (IsFull())
            throw new InvalidOperationException("Buffer is full.");
        Buffer[write_index] = value;
        write_index = GetNextIndex(write_index);
    }

    public void Overwrite(T value)
    {
        if (IsFull())
        {
            Buffer[oldest_index] = value;
            oldest_index = GetNextIndex(oldest_index);
        }
        else
        {
            Buffer[write_index] = value;
            write_index = GetNextIndex(write_index);
        }
    }

    public void Clear()
    {
        Buffer = new T[capacity];
        oldest_index = 0;
        write_index = 0;
    }
    private bool IsFull() => Buffer.All(b => !EqualityComparer<T>.Default.Equals(b, default));
    private int GetNextIndex(int index) => (index + 1) % capacity;
}