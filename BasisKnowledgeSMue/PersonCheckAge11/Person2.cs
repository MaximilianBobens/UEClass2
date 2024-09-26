namespace BasisKnowledgeSMue.Person11;

public class Person2
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (age < 0 || age > 150)
            {
                throw new Exception("not in range");
            }

            age = value;
        }
    }
}