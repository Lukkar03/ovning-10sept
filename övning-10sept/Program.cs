using System;

class Program
{
    // Metod som returnerar true om talet är jämnt
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void Main(string[] args)
    {
        int input;

        Console.WriteLine("Skriv ett heltal (0 för att avsluta):");

        // Loop som fortsätter tills användaren skriver 0
        do
        {
            Console.Write("Tal: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("Programmet avslutas.");
                break;
            }

            // Anropa IsEven-metoden och visa resultat
            if (IsEven(input))
            {
                Console.WriteLine("Talet är jämnt.");
            }
            else
            {
                Console.WriteLine("Talet är udda.");
            }

        } while (true);
    }
}


