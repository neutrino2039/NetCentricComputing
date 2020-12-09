using static System.Console;

static void Swap<Type>(ref Type a, ref Type b)
{
    Type temp = a;
    a = b;
    b = temp;
}

int a = 5, b = 10;
Swap(ref a, ref b);
WriteLine($"a = {a}, b = {b}");

string c = "Hello", d = "World";
Swap(ref c, ref d);
WriteLine($"c = {c}, d = {d}");
