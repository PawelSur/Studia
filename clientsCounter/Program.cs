using System;

public class Program
{
    

    public static void Main(string[] args)
    {
        int[] clients = new int[12];
        for(int i=0; i<12; i++){
            Console.WriteLine("Podaj liczbę klientów o godzinie " + (i+9) + ":");
            clients[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Liczba klientów w ciągu dnia:");
        for(int i=0; i<12; i++){
            Console.WriteLine("O godzinie " + (i+9) + " było " + clients[i] + " klientów.");
        }
        int totalClients = clientsCount(clients);
        Console.WriteLine("Łączna liczba klientów: " + totalClients);
        helpNeeded(clients);

    }
    public static int clientsCount(int[] clients){
        int sum = 0;
        for(int i=0; i<clients.Length; i++){
            sum += clients[i];
        }
        return sum;
        
    }
    public static void helpNeeded(int[] clients){
        for(int i=0; i<clients.Length; i++){
            if(clients[i] > 20){
                Console.WriteLine("Godzina " + (i+9) + " - duży ruch: " + clients[i] + " klientów. Potrzebna dodatkowa obsługa.");
                
            }
        }
        
    }
}
