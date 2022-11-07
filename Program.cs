Banca intesa = new Banca("Intesa san Paolo");


Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);

//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito
Console.WriteLine("Creazione di un nuovo prestito");
Console.WriteLine();
Console.WriteLine("Inserisci il codice fiscale:");
string codiceFiscale = Console.ReadLine();

Cliente esistente = intesa.RicercaCliente(codiceFiscale);

if(esistente == null)
{
    Console.WriteLine("errore: Cliente non trovato!");
}
else
{

    Console.WriteLine("Ammontare del prestito: ");
    int ammontarePrestito = Convert.ToInt32(Console.ReadLine());
    Prestito nuovoPrestito = new Prestito(0,ammontarePrestito,0,new DateOnly(), esistente);

    intesa.AggiungiPrestito(nuovoPrestito);
}
