namespace BasisKnowledgeSMue;

public class Dog : AAnimal
{
    public Dog(string name) : base(name)
    {
    }

    public override void Speak()
    {
        Console.WriteLine("Woof!"); 
    }
}