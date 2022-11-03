// ----------- VARIABILI GLOBALI ------------
Autorimessa autorimessa = new Autorimessa();


// ------------- PROGRAMMA PRINCIPALE -------------
Console.WriteLine("Il tuo numero di auto a disposizione è: " + autorimessa.PostiDisponibili);

bool continua = true;

while (continua)
{
    Console.Write("Vuoi aggiungere o rimuovere un auto [aggiungi/rimuovi]? Inserisci \"esci\" per terminare: ");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "aggiungi":
            Console.WriteLine("Dimmi la modello auto: ");
            string modelloAuto = Console.ReadLine();

            Console.WriteLine("Dimmi anno di produzione dell'auto: ");
            int annoProduzione = int.Parse(Console.ReadLine());

            if(!autorimessa.AggiungiAuto(modelloAuto, annoProduzione))
            {
                Console.WriteLine("Autorimessa pinea, impossibile aggiungere auto.");
            }

            break;

        case "rimuovi":

            if (!autorimessa.RimuoviAuto())
            {
                Console.WriteLine("Non ci sono auto da rimuovere!");
            }

            break;

        case "esci":

            continua = false;
            
            break;
        default:

            Console.WriteLine("Mi dispiace non è un opzione contemplata");
            break;
    }

    Console.WriteLine("Il tuo numero di auto a disposizione è: " + autorimessa.PostiDisponibili);

    autorimessa.StampaAuto();

}

public class Auto
{

    public int AnnoDiProduzione { private get; set; }

    public string Modello { get; }

    public Auto(string modello, int annoDiProduzione)
    {
        this.Modello = modello;
        this.AnnoDiProduzione = annoDiProduzione;
    }

}

public class Autorimessa
{
    //private int massimoNumeroDiPostiAuto; //sostituita da .Lenght di autoPresenti
    public int NumeroAutoPresenti { get; private set; }

    public int PostiDisponibili { 
        get
        {
            return (autoPresenti.Length - NumeroAutoPresenti);
        } 
    }

    //LAST IN FIRST OUT = LIFO
    private Auto[] autoPresenti;

    //inizializza una autorimessa con 5 posti auto
    public Autorimessa()
    {
        //numeroAutoPresenti = 0; c'è già il default


        autoPresenti = new Auto[5];
    }

    //inizializza un'autorimessa con N posti auto
    public Autorimessa(int massimoNumeroDiPostiAuto)
    {
        //this.numeroAutoPresenti = 0; //cè già il default
        autoPresenti = new Auto[massimoNumeroDiPostiAuto];

    }

    /*
     * costruisce e aggiunge una auto nell'autorimessa,
     * se l'inserimento avviene con successo restituisce true
     * altrimenti false
     * */
    public bool AggiungiAuto(string modello, int anno)
    {
        if (NumeroAutoPresenti < autoPresenti.Length)
        {
            //Auto nuovaAuto = new Auto(modello,anno);
            autoPresenti[NumeroAutoPresenti] = new Auto(modello, anno);
            NumeroAutoPresenti++;
            return true;
        }


        return false;

    }

    public bool RimuoviAuto()
    {
        if (NumeroAutoPresenti > 0)
        {
            NumeroAutoPresenti--;
            //modelloAutoPosti[numeroAutoPresenti] = "";
            //annoDiProduzione[numeroAutoPresenti] = 0;
            autoPresenti[NumeroAutoPresenti] = null;
            return true;
        }

        return false;
    }



    public void StampaAuto()
    {
        if (NumeroAutoPresenti == 0)
        {
            Console.WriteLine("Nessuna auto presente");
        }
        else
        {
            Console.WriteLine("--- auto presenti ---");
            for (int i = 0; i < NumeroAutoPresenti; i++)
            {
                Console.WriteLine("Posto {0} - {1}", (i + 1), autoPresenti[i].Modello);
            }
            Console.WriteLine("--- ------------ ---");
        }
    }
}