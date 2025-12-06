using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int number = int.Parse(Console.ReadLine());

        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10; 
            reversed = reversed * 10 + digit;
            number = number / 10;    
        
        }

        Console.WriteLine("Odwrócona liczba: " + reversed);
    }
}
     