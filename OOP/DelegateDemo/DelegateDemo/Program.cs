using static System.Console;
using static Helper;

static void PrintArray(int[] array)
{
    WriteLine(string.Join(", ", array));
}

int[] data = { 1, 2, 3, 4, 5 };
PrintArray(data);

ForEach(data, Double);
PrintArray(data);

ForEach(data, Half);
PrintArray(data);

// anonymous delegate
ForEach(data, delegate (ref int item) {
    item *= 10;
});
PrintArray(data);

// lamda expression
ForEach(data, (ref int item) => {
    item /= 10;
});
PrintArray(data);
