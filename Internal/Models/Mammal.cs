namespace Models;

public class Mammal(string name, string sound, int legCount) : Animal(name, sound, legCount)
{
    public string Type = "mammal";
    public override int LegCount { get; set;} = legCount;
    
}