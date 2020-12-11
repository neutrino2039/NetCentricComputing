public struct PointStruct
{
    public int x, y;

    public PointStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString() => $"({x}, {y})";
}
