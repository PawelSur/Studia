using System;

class Program
{
    static void Main()
    {
       Random rand = new Random();
         int numberToGuess = rand.Next(1, 101);
        int userGuess = 0;
        do{
            Console.Write("Zgadnij liczbę od 1 do 100: ");
            userGuess = int.Parse(Console.ReadLine());
            if(userGuess < numberToGuess){
                Console.WriteLine("Za nisko!");
            } else if(userGuess > numberToGuess){
                Console.WriteLine("Za wysoko!");
            } else {
                Console.WriteLine("Gratulacje! Zgadłeś liczbę!");
            }
        }while(userGuess != numberToGuess);
    }
}
