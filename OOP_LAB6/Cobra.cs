namespace OOP_LAB6;

public class Cobra : Snake
{
    public Cobra(string name = "Cobra", int age = 3, double weight = 5.0, string habitat = "Desert", bool isEndangered = false, bool isVenomous = true)
        : base(name, age, weight, habitat, isEndangered, isVenomous) {}

    public override void MakeSound() => Console.WriteLine($"{Name} makes a loud hiss.");

    public void SpitVenom() => Console.WriteLine($"{Name} is spitting venom.");
}