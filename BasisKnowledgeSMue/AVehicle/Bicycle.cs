namespace BasisKnowledgeSMue.AVehicle;

public class Bicycle : AVehicle
{
    public override void Accelerate(int increase)
    {
        if (increase > 20)
        {
            Console.WriteLine("Speed cannot be greater than 20");
            increase = 20;
        }

        Speed += increase;
        Console.WriteLine($"Speed now {Speed}");
    }
}