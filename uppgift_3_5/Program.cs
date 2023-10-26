using System;

namespace uppgift3_5;
class Program
{
    static void Main()
    {
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());

        Console.Write("Ange det andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Välj ett räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        Console.Write("Ange ditt val (1-4): ");
        int val = int.Parse(Console.ReadLine());

        double resultat = 0;

        switch (val)
        {
            case 1:
                resultat = tal1 + tal2;
                Console.WriteLine("Resultatet av additionen är: " + resultat);
                break;
            case 2:
                resultat = tal1 - tal2;
                Console.WriteLine("Resultatet av subtraktionen är: " + resultat);
                break;
            case 3:
                resultat = tal1 * tal2;
                Console.WriteLine("Resultatet av multiplikationen är: " + resultat);
                break;
            case 4:
                if (tal2 != 0)
                {
                    resultat = tal1 / tal2;
                    Console.WriteLine("Resultatet av divisionen är: " + resultat);
                }
                else
                {
                    Console.WriteLine("Division med noll är ej tillåtet.");
                }
                break;
            default:
                Console.WriteLine("Ogiltigt val. Ange en siffra mellan 1 och 4.");
                break;
        }
    }
}