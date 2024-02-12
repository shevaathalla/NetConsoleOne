namespace Models;

public class Fish(string name, string sound) : Animal(name, sound)
{
    public string Type { get; set;} = "fish";
    public override int LegCount { get; set;} = 0;
}