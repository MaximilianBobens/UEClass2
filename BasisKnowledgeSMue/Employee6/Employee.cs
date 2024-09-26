namespace BasisKnowledgeSMue;

public class Employee
{
    public static int count = 0;

    public Employee()
    {
        count++;
    }

    public static int GetCount()
    {
        return count;
    }
}