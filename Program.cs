var tests = int.Parse(Console.ReadLine() ?? string.Empty);

while(tests-- > 0)
{
    var cords = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    var prince = new Prince(
        Start: new Point(cords[0], cords[1]),
        End: new Point(cords[2], cords[3]));

    var numberOfPlanets = int.Parse(Console.ReadLine() ?? string.Empty);

    var planets = new Circle[numberOfPlanets];

    for(int i = 0; i < numberOfPlanets; i++)
    {
        var planetCoords = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        planets[i] = new Circle(
            Center: new Point(planetCoords[0], planetCoords[1]),
            Radius: planetCoords[2]);
    }

    Console.WriteLine($"Crosses {prince.CrossingCount(planets)} times!");  
}