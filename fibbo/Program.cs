using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i <= n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}
