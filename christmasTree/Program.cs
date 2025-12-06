using System;

class Program
{
    static void Main()
    {
        int n ;
        Console.Write("Podaj wysokość piramidy: ");
        n = int.Parse(Console.ReadLine());  
        for (int i = 0; i < n; i++)
        {
            for(int j= 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < (2 * i + 1); k++)
            {
                Console.Write("*");     
            }
            Console.WriteLine();
        }
    }
}
