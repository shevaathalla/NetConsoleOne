namespace Models;

interface IAnimal{
    int GetLegCount();
    string GetName();
    string PrintSound();
}

public class Animal(string name, string sound, int legCount = 0): IAnimal
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

    public virtual string PrintSound() // virtual method to override
    {
        return $"{this.Name} says {this.Sound}";
    }
}