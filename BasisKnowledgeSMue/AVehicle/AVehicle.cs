namespace BasisKnowledgeSMue.AVehicle;

public abstract class AVehicle
{
    public int Speed { get; set; }
    public abstract void Accelerate(int increase);
}