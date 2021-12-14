using System;

namespace Antiquitätenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double abschlag;
            double GesamtEinkaufsPreis = 0;
            double preis;
            ConsoleKeyInfo weitere;

            do
            {
                Console.WriteLine("\nBitte geben Sie das Alter der Antitquität ein: ");
                int alter = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie den Schätzwert der Antiquität in EURO, Cent Beträge bitte mit einem Komma eingeben!: ");
                double schaetzwert = Convert.ToDouble(Console.ReadLine());

                if (alter > 50)
                {
                    abschlag = schaetzwert / 100 * 10;
                    preis = Math.Round(schaetzwert - abschlag,2);
                    Console.WriteLine("\nAngebotener Preis ist: " + preis + " EURO");
                    Console.WriteLine("\nSind Sie mit dem Preis einverstanden?:\t[Y/N]");
                    ConsoleKeyInfo preisOK = Console.ReadKey();
                    if (preisOK.Key == ConsoleKey.Y)
                    {
                        GesamtEinkaufsPreis = GesamtEinkaufsPreis + preis;
                    }
                    else
                    {
                        preis = 0;
                    }
                }
                else if (alter > 25)
                {
                    abschlag = schaetzwert / 100 * 15;
                    preis = Math.Round(schaetzwert - abschlag, 2);
                    Console.WriteLine("\nAngebotener Preis ist: " + preis + " EURO");
                    Console.WriteLine("\nSind Sie mit dem Preis einverstanden?:\t[Y/N]");
                    ConsoleKeyInfo preisOK = Console.ReadKey();
                    if (preisOK.Key == ConsoleKey.Y)
                    {
                        GesamtEinkaufsPreis = GesamtEinkaufsPreis + preis;
                    }
                    else
                    {
                        preis = 0;
                    }
                }
                else
                {
                    abschlag = schaetzwert / 100 * 30;
                    preis = Math.Round(schaetzwert - abschlag, 2);
                    Console.WriteLine("\nAngebotener Preis ist: " + preis + " EURO");
                    Console.WriteLine("\nSind Sie mit dem Preis einverstanden?:\t[Y/N]");
                    ConsoleKeyInfo preisOK = Console.ReadKey();
                    if (preisOK.Key == ConsoleKey.Y)
                    {
                        GesamtEinkaufsPreis = GesamtEinkaufsPreis + preis;
                    }
                    else
                    {
                        preis = 0;
                    }
                }
                Console.WriteLine("\nMöchten Sie weitere Antiquitäten verkaufen?:\t[Y/N]");
                weitere = Console.ReadKey();
                Console.Clear();
            } while (weitere.Key == ConsoleKey.Y);

            Console.WriteLine("\nGesamteinkaufspreis ist: " + Math.Round(GesamtEinkaufsPreis,2) + " EURO");
        }
    }
}
