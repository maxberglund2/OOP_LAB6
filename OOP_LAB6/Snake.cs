namespace OOP_LAB6;

public class Snake : Animal
{
    public bool IsVenomous { get; set; }

    public Snake(string name = "Snake", int age = 2, double weight = 1.5, string habitat = "Jungle", bool isEndangered = false, bool isVenomous = true)
        : base(name, age, weight, habitat, isEndangered)
    {
        IsVenomous = isVenomous;
    }

    public override void MakeSound() => Console.WriteLine($"{Name} hisses!");

    public void Slither() => Console.WriteLine($"{Name} is slithering.");
}