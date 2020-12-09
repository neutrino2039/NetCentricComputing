using System;

public class List<T>
{
    private const int DEFAULT_CAPACITY = 2;
    private T[] data = new T[DEFAULT_CAPACITY];

    public int Capacity { get; set; } = DEFAULT_CAPACITY;

    public int Count { get; private set; } = 0;

    public void Add(T item)
    {
        if(Capacity == Count)
        {
            Capacity *= 2;
            var temp = new T[Capacity];
            Array.Copy(data, temp, data.Length);
            data = temp;
        }
        data[Count++] = item;
    }

    public T this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}
