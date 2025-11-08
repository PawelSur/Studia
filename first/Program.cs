using System;

public class Program
{
    
    

    public static void Main(string[] args)
    {
        // int dateOfBirth;
        // string name;
        
        // Console.WriteLine("Podaj imie: ");
        // name = Console.ReadLine();
        
        // Console.WriteLine("Podaj rok urodzenia: ");
        // dateOfBirth = int.Parse(Console.ReadLine());
        
        // int age = 2025 - dateOfBirth;
        // Console.WriteLine($"Witaj {name}! Masz {age} lat.");
        // if(age>=18){
        //     Console.WriteLine("Jestes pelnoletni.");
        // } else {
        //     Console.WriteLine("Nie jestes pelnoletni.");
        // }
        // int height;
        
        // Console.WriteLine("witam pilotów linii lotniczych lot");
        
        
        // Console.WriteLine("Jak wysoko lecisz?");
        // height = int.Parse(Console.ReadLine());
        // if(height > 1000)
        // {
        //     Console.WriteLine("Lecisz za wysoko");
        // }
        // else if(height >= 800 && height <= 1000)
        // {
        //     Console.WriteLine("Lecisz dobrze");
        // }
        // else
        // {
        //     Console.WriteLine("Lecisz za nisko");
        // }

        int randInt = new Random().Next(1, 11);
        int userGuess;
        Console.WriteLine("Zgadnij liczbę od 1 do 10:");
        userGuess = int.Parse(Console.ReadLine());
        while(userGuess != randInt){
            if(userGuess > randInt){
            Console.WriteLine("Mniejsza");
            userGuess = int.Parse(Console.ReadLine());
        } else {
            Console.WriteLine("Większa");
            userGuess = int.Parse(Console.ReadLine());
        }
        }
        Console.WriteLine("Zgadłeś!");
        
    }
}
