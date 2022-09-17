public record Circle(Point Center, int Radius)
{
    public bool Contains(Point p)
        => Center.DistanceTo(p) < Radius;
}