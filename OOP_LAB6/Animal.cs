namespace OOP_LAB6;

public class Animal
{
    // Egenskaper som alla djur delar
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Habitat { get; set; }
    public bool IsEndangered { get; set; }

    // Konstruktor för att skapa nya djur
    public Animal(string name, int age, double weight, string habitat, bool isEndangered)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Habitat = habitat;
        IsEndangered = isEndangered;
    }
    
    public virtual void Eat() => Console.WriteLine($"{Name} is eating.");
    public virtual void Sleep() => Console.WriteLine($"{Name} is sleeping.");
    public virtual void Move() => Console.WriteLine($"{Name} is moving.");
    public virtual void MakeSound() => Console.WriteLine($"{Name} makes a sound.");
}