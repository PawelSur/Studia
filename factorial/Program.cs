using System;

public class Program
{
    
    

    public static void Main(string[] args)
    {   
        int num;
        int silnia = 1;
        int i = 1;
        Console.WriteLine("Podaj liczbę do obliczenia silni: ");
        num = int.Parse(Console.ReadLine());
        do{
          silnia *= i;
          i++;

        }while(i <= num);
        Console.WriteLine($"Silnia z {num} to: {silnia}");
    }
}
