namespace BasisKnowledgeSMue;

public abstract class AAnimal
{
    
    // Attribut für den Namen des Tiers
    protected string name;

    // Konstruktor der Basisklasse
    public AAnimal(string name)
    {
        this.name = name;
    }

    // Methode, die in der abgeleiteten Klasse überschrieben wird
    public virtual void Speak()
    {
        Console.WriteLine("Das Tier macht ein Geräusch.");
    }
}