using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Liczby pierwsze od 2 do " + n + ":");

        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
