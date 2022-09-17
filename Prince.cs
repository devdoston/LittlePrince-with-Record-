public record Prince(Point Start, Point End)
{
    public int CrossingCount( Circle[] planets)
        => planets.Count(p => Crosses(p));

    private bool Crosses(Circle planet)
        => planet.Contains(Start) ^ planet.Contains(End);
}
