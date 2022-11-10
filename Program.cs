

// Open the file to read from.

StreamReader stream = File.OpenText("C:\\Users\\mistre\\source\\repos\\experis4\\Livecoding\\esempio.csv");
//stream.Close();

StreamWriter altroStream = File.CreateText("C:\\Users\\mistre\\source\\repos\\experis4\\Livecoding\\esempio.csv");
altroStream.Close();

return;
//stream.ReadLine();

List<Libro> libri = new List<Libro>();

while (!stream.EndOfStream)
{
    string riga = stream.ReadLine();

    string[] info = riga.Split(",");

    //un libro è fatto di 3 informazioni che DEVONO essere correttamente strutturate nel file
    if(info.Length == 3)
    {
        string titolo = info[0];
        string autore = info[1];
        int anno = info[2] == "" ? 0 : Convert.ToInt32(info[2]);

        //pulizia
        titolo = titolo.Replace("- ", "");

        Libro libro = new Libro(titolo, autore, anno);

        libri.Add(libro);
    }

    //Console.WriteLine(riga);
}

stream.Close();

StreamWriter fileDaScrivere = File.CreateText("C:\\Users\\mistre\\source\\repos\\experis4\\Livecoding\\libri-formattati.txt");

fileDaScrivere.WriteLine("Libri formattati");
fileDaScrivere.WriteLine();

foreach (Libro libro in libri)
{
   
    fileDaScrivere.WriteLine(libro.ToString());
    fileDaScrivere.WriteLine();

}
fileDaScrivere.Close();


public class Libro
{
    private string titolo;
    private string autore;
    private int anno;

    public Libro(string titolo, string autore, int anno)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.anno = anno;
    }
    public override string ToString()
    {
        string stringa = "------ Libro ------\n";
        stringa += "Titolo:\t" + this.titolo + "\n";
        stringa += "Autore:\t" + this.autore + "\n";
        stringa += "Anno:\t" + this.anno + "\n";
        stringa += "-------------------";

        return stringa;
    }
}


























//Console.WriteLine("Inserisci un numero da 1 a 10");

//bool continua = true;

//while (continua)
//{
//	try
//	{
//		Console.WriteLine("Inserisci numeratore");
//        int numeratore = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Inserisci Denominatore");
//        int denominatore = Convert.ToInt32(Console.ReadLine());


//		int divisione = numeratore / denominatore;

//		Console.WriteLine("La divisione tra {0} e {1} è {2}", numeratore, denominatore, divisione);



//        int[] numbers = { 1, 2, 3 };

//        numbers[5]++;

//        continua = false;

//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine("error: Devi inserire un numero e non una parola");
//    }
//    catch (DivideByZeroException e)
//    {
//        Console.WriteLine("error: Non puoi dividere per 0");
//    }
//    catch (Exception e)
//    {
//        //qualunque altra eccezione che dovesse capitare
//        Console.WriteLine("Opps! Qualcosa è andato storto");
//        Console.WriteLine(e.Message);
//    }

//}



//void StampaDivisione(int numeratore, int denominatore)
//{

//    if (denominatore == 0)
//        throw new Exception();

//    Console.WriteLine(numeratore / denominatore);



//}

//void ConsoleApplication()
//{

//    Funzione2();

//}

//void Funzione2()
//{
//    try
//    {
//        Funzione3();
//    }
//    catch (Exception e)
//    {

//    }
//}

//void Funzione3()
//{
//    StampaDivisione(10, 0);


//}


//ConsoleApplication();
