

Console.WriteLine("Inserisci un numero da 1 a 10");

bool continua = true;

while (continua)
{
	try
	{
		Console.WriteLine("Inserisci numeratore");
        int numeratore = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci Denominatore");
        int denominatore = Convert.ToInt32(Console.ReadLine());


		int divisione = numeratore / denominatore;

		Console.WriteLine("La divisione tra {0} e {1} è {2}", numeratore, denominatore, divisione);
    
       

        int[] numbers = { 1, 2, 3 };

        numbers[5]++;

        continua = false;

    }
    catch (FormatException e)
    {
        Console.WriteLine("error: Devi inserire un numero e non una parola");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("error: Non puoi dividere per 0");
    }
    catch (Exception e)
    {
        //qualunque altra eccezione che dovesse capitare
        Console.WriteLine("Opps! Qualcosa è andato storto");
        Console.WriteLine(e.Message);
    }

}



void StampaDivisione(int numeratore, int denominatore)
{

    if (denominatore == 0)
        throw new Exception();

    Console.WriteLine(numeratore / denominatore);



}

void ConsoleApplication()
{

    Funzione2();

}

void Funzione2()
{
    try
    {
        Funzione3();
    }
    catch (Exception e)
    {

    }
}

void Funzione3()
{
    StampaDivisione(10, 0);


}


ConsoleApplication();
