namespace OOP_LAB6;

public class Python : Snake
{
    public Python(string name = "Python", int age = 4, double weight = 10.0, string habitat = "Jungle", bool isEndangered = false, bool isVenomous = false)
        : base(name, age, weight, habitat, isEndangered, isVenomous) {}

    public override void MakeSound() => Console.WriteLine($"{Name} makes a low hiss.");

    public void Constrict() => Console.WriteLine($"{Name} is constricting.");
}