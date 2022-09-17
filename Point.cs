public record Point(int x, int y)
{
    public double DistanceTo (Point b)
        => Math.Sqrt(Math.Pow(b.x - x,2) + Math.Pow(b.y - y,2));
}