using System;

public class Program
{
    
    

    public static void Main(string[] args)
    {   
        int num =1 ;
        while(num <=50){
            if(num % 2 ==0){
                Console.WriteLine($"{num} - parzysta");
            } else {
                Console.WriteLine($"{num} - nieparzysta");
            }
            num++;
        }
    }
}
