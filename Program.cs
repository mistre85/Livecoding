
using System.Collections;

List<Immobile> immobili = new List<Immobile>();

immobili.Add(new Abitazione());
immobili.Add(new Abitazione());
immobili.Add(new Villa());
immobili.Add(new Villa());
immobili.Add(new Villa());
immobili.Add(new Box());
immobili.Add(new Box());


//agente immobiliare
foreach (Immobile im in immobili)
{
    Console.WriteLine();
    Console.WriteLine(im.Aperto ? "Aperto" : "Chiuso");

    //Console.WriteLine(im.GetType().ToString());
    im.Apri();
    Console.WriteLine(im.Aperto ? "Aperto" : "Chiuso");
}


//imprise di pulizie
List<IInterazioneAccessori> immobiliDaPulire = new List<IInterazioneAccessori>();

immobiliDaPulire.Add(new Abitazione());
immobiliDaPulire.Add(new Abitazione());
immobiliDaPulire.Add(new Villa());
immobiliDaPulire.Add(new Villa());
immobiliDaPulire.Add(new Villa());
immobiliDaPulire.Add(new Aereo());
//immobiliDaPulire.Add(new Box());


//agente immobiliare
foreach (IInterazioneAccessori item in immobiliDaPulire)
{
    item.ApriFinestra(); 
}

public interface IInterazione
{
    public void Apri();

    public  void Chiudi();
}

public interface IInterazioneAccessori
{
    public void ApriFinestra();
}

public abstract class Immobile : IInterazione
{
    public bool Aperto { get; protected set; }
    public int Codice { get; set; }
    public int Superfice { get; set; }

    //esposizione
    //luminosità

    public abstract void Apri();

    public abstract void Chiudi();

  

}

public class Box: Immobile
{
    public int NumeroPostiAuto { get; set; }

    public override void Apri()
    {
        Console.WriteLine("Telecomando attivato");
        Console.WriteLine("Box aperto");
        Aperto = true;
    }

    public override void Chiudi()
    {
        Console.WriteLine("Telecomando attivato");
        Console.WriteLine("Box chiuso");
        Aperto = false;
    }

}

public class Abitazione : Immobile , IInterazioneAccessori
{
    public int Vani { get; set; }
    public int NumeroBagni { get; set; }

    public override void Apri()
    {
        Console.WriteLine("Chiave inserita");
        Console.WriteLine("Abitazione aperta");
        Aperto = true;
    }

    public void ApriFinestra()
    {
        Console.WriteLine("Finestra aperta");
    }

    public override void Chiudi()
    {
        Console.WriteLine("Chiave inserita");
        Console.WriteLine("Abitazione chiusa");
        Aperto = false;
    }
}

public class Villa : Immobile, IInterazioneAccessori
{
    public int SuperficeGiardino { get; set; }

    public override void Apri()
    {
        Console.WriteLine("Chiave inserita");
        Console.WriteLine("Villa aperta");
        Aperto = true;
    }

    public void ApriFinestra()
    {
        Console.WriteLine("Apri finestra");
    }

    public override void Chiudi()
    {
        Console.WriteLine("Chiave inserita");
        Console.WriteLine("Villa chiusa");
        Aperto = false;
    }
}

public class Aereo : IInterazione, IInterazioneAccessori
{
    public void Apri()
    {
        //
    }

    public void ApriFinestra()
    {
       //
    }

    public void Chiudi()
    {
       //
    }
}