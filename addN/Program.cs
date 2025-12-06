using System;

public class Program
{
    
    

    public static void Main(string[] args)
    {   
        int suma = 0;
        int n = 0;
        Console.WriteLine("Podaj rozmiar tablicy: ");
        n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++){
            suma += i;
        }
        Console.WriteLine($"Suma elementów tablicy to: {suma}");
        
    }
}
