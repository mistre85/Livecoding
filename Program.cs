////agenzia immobiliare
//Si vuole progettare un'applicazione in grado di gestire un'agenzia immobiliare.
//Gli immobili sono caratterizzati da:

//- un codice alfanumerico,
//- indirizzo,
//- cap,
//- città
//- una superficie espressa in mq attraverso un numero intero.

//Immobile im = new Immobile("112022");
Box bx = new Box(new Random().Next(0, 100000).ToString());
Abitazione ab = new Abitazione(new Random().Next(0, 100000).ToString());
Villa vl = new Villa(new Random().Next(0, 100000).ToString());

//Console.WriteLine(im.ToString());
Console.WriteLine(bx.ToString());
Console.WriteLine(ab.ToString());
Console.WriteLine(vl.ToString());

List<Immobile> immobili = new List<Immobile>();

immobili.Add(vl);
immobili.Add(ab);
immobili.Add(bx);


//Console.WriteLine("Scrivi l'immobile da cercare:");
//string codiceUtente = Console.ReadLine();

foreach(Immobile item in immobili)
{
  //  if(item.Codice == codiceUtente)
    {
    
        Console.WriteLine("Trovato immobile: {0} di tipi {1}" , item.ToString(), item.GetType().ToString());

    }
    
}

Villa primoImmobile = (Villa)immobili[0];
Console.WriteLine(primoImmobile.ToString());


public class Immobile
{
    //alfanumerico
    public string Codice { get; set; }
    public string Indirizzo { get; set; }
    public string Cap { get; set; }
    public string Città { get; set; }

    //metri quadrati
    public int Superficie { get; set; }

    public Immobile(string codice)
    {
        Codice = codice;
    }

    public override string ToString()
    {
        return "IM" + Codice;
    }

}

public class Box : Immobile
{
    public int PostiAuto { get; set; }
    public Box(string codice) : base(codice)
    {
    }

    public override string ToString()
    {
        return "BX" + Codice;
    }
}

public class Abitazione : Immobile
{
    public int NumeroVani { get; set; }
    public int NumeroBagni { get; set; }

    public Abitazione(string codice) : base(codice)
    {
    }

    public override string ToString()
    {
        return "AB" + Codice;
    }
}

public class Villa : Abitazione
{
   
    public int SuperficieGiardino { get; set; }

    public Villa(string codice) : base(codice)
    {
    }

    public override string ToString()
    {
        return "VL" + Codice;
    }

}

//Definire all’interno della classe Immobile un attributo per memorizzare il numero di persone interessate all’acquisto e aggiungere un metodo per incrementare questo numero.

//L'agenzia gestisce diverse tipologie di immobili:

//- Box
//- Abitazione
//- Ville.

//Per i box è riportato il numero di posti auto.
//Per le abitazioni è riportato il numero di vani e il numero di bagni.
//Per le ville è previsto, in aggiunta rispetto all'abitazione, la dimensione in mq di giardino.

//Ridefinire per ciascuna delle tre classi il metodo ToString() in modo da fornire una descrizione completa dell'immobile.

//**BONUS:**
//Definire una funzione di ricerca per gli immobili,
//che preso in input un codice alfanumerico restituisce l’immobile corrispondente.
//Se l’immobile non viene trovato restituisce null.