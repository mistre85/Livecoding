// classe astratta

//Animale animale = new Animale();

Mucca mucca = new Mucca();

mucca.FaiVerso();

public abstract class Animale
{

    //metodo astratto
    public abstract void FaiVerso();

    //metodo normale
    public void Dormi()
    {
        Console.WriteLine("Zzzzzz");
    }
}

// classe derivata
public class Mucca : Animale
{
    //override
    public override void FaiVerso()
    {
        Console.WriteLine("Muuu");
    }
}