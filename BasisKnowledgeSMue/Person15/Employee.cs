namespace BasisKnowledgeSMue.Person15;

public class Employee : Person4
{
    private int salery;
    private string position;

    public Employee(string firstname, string lastname, int salery, string position) : base(firstname, lastname)
    {
        this.salery = salery;
        this.position = position;
    }

    public Employee() : base()
    {
        salery = -1;
        position = "Unknown";
    }
}