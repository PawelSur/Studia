using System;
using System.Collections.Generic;


public class Program
{
    public static int wallet = 0;
    static List<string> name = new List<string>();
    static List<int> amount = new List<int>();
    static List<int> price = new List<int>();

    static void Main(string[] args)
    {
        Console.WriteLine("\nWitaj w magazynie!");
        while (true)
        {
            menu(name, amount, price);
        }
    }

    public static void menu(List<string> name, List<int> amount, List<int> price)
    {
        
        Console.WriteLine("Wybierz opcję:");
        Console.WriteLine("1. Kup produkt");
        Console.WriteLine("2. Dodaj produkt");
        Console.WriteLine("3. Wyświetl stan portfela");
        Console.WriteLine("4. Wyjście");

        switch (Console.ReadLine())
        {
            case "1":
                buyProduct(name, amount, price);
                break;
            case "2":
                addProduct(name, amount, price);
                break;
            case "3":
                showWallet();
                break;
            
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                break;
        }
    }

    public static void buyProduct(List<string> name, List<int> amount, List<int> price)
    {
        for (int i = 0; i < name.Count; i++)
        {
            Console.WriteLine($"{name[i]} - Ilość: {amount[i]}, Cena: {price[i]} zł");
        }
        Console.WriteLine("Podaj nazwę produktu do zakupu:");
        string productName = Console.ReadLine();

        int index = name.IndexOf(productName);
        if (index == -1)
        {
            Console.WriteLine("Produkt nie znaleziony.\n");
            return;
        }

        Console.WriteLine("Podaj ilość do zakupu:");
        int productAmount = int.Parse(Console.ReadLine());

        if (amount[index] < productAmount)
        {
            Console.WriteLine("Niewystarczająca ilość produktu na stanie.\n");
            return;
        }

        amount[index] -= productAmount;
        int totalPrice = productAmount * price[index];
        wallet += totalPrice;
        Console.WriteLine($"Zakupiono {productAmount} sztuk {productName} za {totalPrice} zł. \n");
    }

    public static void addProduct(List<string> name, List<int> amount, List<int> price)
    {
        Console.WriteLine("Podaj nazwę produktu do dodania:");
        string productName = Console.ReadLine();
        if (name.Contains(productName))
        {
            int id = name.IndexOf(productName);
        Console.WriteLine("Podaj ilość produktu do dodania:");
        int productAmount = int.Parse(Console.ReadLine());
        amount[id]  += productAmount;

        

        Console.WriteLine("Produkt dodany!\n");
            return;
        }
        else{
            name.Add(productName);
            Console.WriteLine("Podaj ilość produktu do dodania:");
            int productAmount = int.Parse(Console.ReadLine());
            amount.Add(productAmount);

            Console.WriteLine("Podaj cenę produktu do dodania:");
            int productPrice = int.Parse(Console.ReadLine());
            price.Add(productPrice);

            Console.WriteLine("Produkt dodany!\n");
        }
        
    }

    public static void showWallet()
    {
        Console.WriteLine($"Stan portfela: {wallet} zł");
    }

    
}
