using Models;

internal class App
{
    private static void Main(string[] args)
    {
        var kangaroo = new Mammal("Kangaroo", "wiiii", 2);

        Console.WriteLine(kangaroo.GetName() + " has " + kangaroo.GetLegCount() + " legs");

        var clownFish = new Fish("Clown Fish", "blub blub");

        Console.WriteLine(clownFish.GetName() + " is a " + clownFish.Type + " so it has " + clownFish.GetLegCount() + " legs");
    }
}