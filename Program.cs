
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Inserisci base rettangolo:");
int baseRettangolo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci altezza rettangolo:");
int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());


Rettangolo rettangoloUtente = new Rettangolo(baseRettangolo, altezzaRettangolo);


Console.WriteLine("Area rettangolo utente: " + rettangoloUtente.Area());
Console.WriteLine("Perimetro rettangolo utente: " + rettangoloUtente.Perimetro());


rettangoloUtente.Stampa();

for(int i=0; i < 100; i++)
{
    Rettangolo casuale = new Rettangolo();
    Console.WriteLine("--- rettangolo " + (i + 1) + "-----");
    casuale.Stampa();
    Console.WriteLine("----------------------------------");
}



//Consegna:
//Nel progetto csharp-geometria creare le seguenti classi
//1. Creare una classe Rettangolo con due attributi interi: **baseRettangolo * *e * *altezzaRettangolo * *.
//  Aggiungere un opportuno costruttore con parametri.
//  Aggiungere due metodi: **calcolaArea * *e * *calcolaPerimetro * *che calcolano e restituiscono, rispettivamente,
//  l’area e il perimetro del rettangolo.
//2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console,
//i valori di base e di altezza con cui istanziare un nuovo Rettangolo.
//Dopo averlo istanziato, stampate a video il perimetro e l’area.

//3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo)
//e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

//——  Rettangolo1  ——
//base: 20 cm
//altezza: 10 cm
//Perimetro: 60 cm
//Area: 200 cm2

//** BONUS**
//Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.


public class Rettangolo
{
    private int larghezza;
    private int altezza;

    /*
     *
     *Genera un rettangolo con base e altezza casuali tra
     *1 e 1000 (compreso)
     */
    public Rettangolo()
    {
        larghezza = new Random().Next(1, 1001);
        altezza = new Random().Next(1, 1001);
    }

    /*
     * genera un rettangolo specificando un valore di base e altezza
     */
    public Rettangolo(int larghezza, int altezza)
    {
        this.larghezza = larghezza;
        this.altezza = altezza;
    }

    public int Area()
    {
        return larghezza * altezza;
    }

    public int Perimetro()
    {
        return (larghezza * 2) + (altezza * 2);
    }

    public int GetLarghezza()
    {
        return this.larghezza;
    }

    public int GetAltezza()
    {
        return this.altezza;
    }

    public void SetLarghezza(int baseRettangolo)
    {
        if(baseRettangolo < 0)
        {
            this.larghezza = Math.Abs(altezza);
        }

        this.larghezza = baseRettangolo;
    }

    public void SetAltezza(int altezza)
    {
        if (altezza < 0)
        {
            this.larghezza = Math.Abs(altezza);
        }

        this.altezza = altezza;
    }

    public void Stampa() {

        //base: 20 cm
        Console.WriteLine("base:" + larghezza + "cm");
        //altezza: 10 cm
        Console.WriteLine("altezza:" + altezza + "cm") ;
        //Perimetro: 60 cm
        Console.WriteLine("perimetro:" + Perimetro() + "cm");
        //Area: 200 cm2
        Console.WriteLine("area:" + this.Area() + "cm^2");
    }
}