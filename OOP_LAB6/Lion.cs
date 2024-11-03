namespace OOP_LAB6;

public class Lion : Animal
{
    public bool HasMane { get; set; }

    public Lion(string name = "Lion", int age = 5, double weight = 190.5, string habitat = "Savannah", bool isEndangered = false, bool hasMane = true)
        : base(name, age, weight, habitat, isEndangered)
    {
        HasMane = hasMane;
    }

    public override void MakeSound() => Console.WriteLine($"{Name} roars!");

    public void Hunt() => Console.WriteLine($"{Name} is hunting.");
}