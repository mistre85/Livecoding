Banca intesa = new Banca("Intesa san Paolo");


Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);

//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito
Console.WriteLine("Creazione di un nuovo prestito");
Console.WriteLine();


//int stipendio = Banca.RichiediInputInt("inserisci stipendio");
string codiceFiscale = Banca.RichiediInput("inserisci codice fiscale");
Cliente esistente = intesa.RicercaCliente(codiceFiscale);

if(esistente == null)
{
    Console.WriteLine("errore: Cliente non trovato!");
}
else
{

    Console.WriteLine("Ammontare del prestito: ");
    string input = Console.ReadLine();
    int ammontarePrestito = Convert.ToInt32(input);


    Prestito nuovoPrestito = new Prestito(0,ammontarePrestito,0,new DateOnly(), esistente);

    intesa.AggiungiPrestito(nuovoPrestito);
}

Console.WriteLine("Nome\tCognome\t\tCodiceFiscale\t\tNumero Prestiti");
Console.WriteLine("Paolo\tMistretta\tmstpaaaxxll81823\t10");