namespace Models;

public class Animal(string name, string sound, int legCount = 0)
{
    public string Name { get; set; } = name;
    public virtual int LegCount { get; set; } = legCount;
    public string Sound { get; set; } = sound;

    public int GetLegCount()
    {
        return this.LegCount;
    }

    public string GetName()
    {
        return this.Name;
    }
}