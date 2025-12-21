using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wiek");
        int age = int.Parse(Console.ReadLine());
        checkAge(age);
        convertion(25);
        divisibility(10, 3);
        Console.WriteLine(checkAge(age));
    }
    static bool checkAge(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
    
    static void convertion(int celcious){
        double fahrenheit = (celcious * 9 / 5) + 32;
        Console.WriteLine($"{celcious} stopni Celsjusza to {fahrenheit} stopni Fahrenheita.");
    }
    static void divisibility(int num1, int num2){
        if(num1 % num2 == 0){
            Console.WriteLine($"{num1} jest podzielne przez {num2}");
        } else {
            Console.WriteLine($"{num1} nie jest podzielne przez {num2}");
        }
    }
}
