namespace BasisKnowledgeSMue;

public class Car
{
    public Car(){}
    private string name;
    private string model;
    private int year;
    public string Model { get; set; }

    public int Year
    {
        get
        {
            return year;
        }

        set
        {
            if (value < 1886 || value > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException("Year must be between 1886 and 1999");
            }
            year = value;
        }
    }
   
}