public class Helper
{
    public delegate void Callback(ref int item);

    public static void ForEach(int[] array, Callback callback)
    {
        for (int i = 0; i < array.Length; i++)
            callback(ref array[i]);
    }

    public static void Double(ref int item)
    {
        item *= 2;
    }

    public static void Half(ref int item)
    {
        item /= 2;
    }
}
