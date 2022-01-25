// See https://aka.ms/new-console-template for more information
List<string> planetList = new List<string>() { "Mercury", "Mars" };
planetList.Add("Jupiter");
planetList.Add("Saturn");

List<string> otherPlanets = new List<string>(){"Earth", "Venus"};

otherPlanets.AddRange(planetList);

//foreach (var planet in otherPlanets)
//{
//    Console.WriteLine(planet);
//}

planetList.Insert(1, "Venus");
planetList.Insert(2, "Earth");

//foreach (var planet in planetList)
//{
//    Console.WriteLine(planet);
//}

planetList.Add("Pluto");

List<string> rockyPlanets = planetList.GetRange(2, 2);
//foreach (var planet in rockyPlanets)
//{
//    Console.WriteLine(planet);
//}

planetList.Remove("Pluto");
foreach (var planet in planetList)
{
    Console.WriteLine(planet);
}