public class PointClass
{
    public int x, y;

    public PointClass(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString() => $"({x}, {y})";
}
