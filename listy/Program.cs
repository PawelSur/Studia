using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
    //    List<int> nums = new List<int>{1,2,3,4,5};
    //    foreach(var n in nums)
    //    {
    //     Console.WriteLine(n);
    //    }
    // List<int> numsFromUser = new List<int>();
    //   for(int i = 0; i < 5; i++)
    //   {
    //     Console.WriteLine("Podaj liczbę:");
    //     int userNum = int.Parse(Console.ReadLine());
    //     numsFromUser.Add(userNum);
    //   }
    //   Console.WriteLine("Podane liczby to:");
    //   foreach(var n in numsFromUser)
    //   {
    //     Console.WriteLine(n);       
    //   }
    //    List<int> nums = new List<int>{1,2,3,4,5};
    //    int sum = 0;
    //    foreach(var n in nums)
    //    {
    //     sum += n;
    //    }
    //    Console.WriteLine("Suma liczb to: " + sum);
    // List<int> nums = new List<int>{2,1,3,4,5};
    // int min, max;
    // min = max = nums[0];
    // foreach(var n in nums)
    // {
    
    //     if(n > max)
    //     {
    //         max = n;
    //     }
    //     if(n < min)
    //     {
    //         min = n;    
    //     }

    // }
    // Console.WriteLine("Min: " + min + ", Max: " + max);
    // List<int> nums = new List<int>{2,1,3,4,5};
    // Console.WriteLine("Podaj liczbę do sprawdzania:");
    // int userNum = int.Parse(Console.ReadLine());
    // int counter = 0;
    // foreach(var n in nums)
    // {
    //     if(n > userNum)
    //     {
    //         counter++;
    //     }
    // }
    // Console.WriteLine("Liczb większych od " + userNum + ": " + counter );
    // List<int> nums = new List<int>{2,-1,-3,4,5};
    // nums.RemoveAll(n => n < 0);
    // foreach(var n in nums)
    // {
    //     Console.WriteLine(n);   
    // }
    // List<int> nums = new List<int>{2,-1,-3,4,5};
    // nums.Sort();
    // foreach(var n in nums)
    // {
    //     Console.WriteLine(n);
    // }
    // List<int> nums = new List<int>{2,-1,-3,4,5};
    // Console.WriteLine("Podaj liczbę do znalezienia:");
    // int userNum = int.Parse(Console.ReadLine());
    // int index = nums.IndexOf(userNum);
    // if(index != -1)
    // {
    //     Console.WriteLine("Liczba znaleziona na indeksie: " + index);
    // }
    // else
    // {
    //     Console.WriteLine("Liczba nie znaleziona.");
    // }
    // List<int> nums = new List<int>{2,-1,-3,4,5,-3};
    // Console.WriteLine("Podaj liczbę do znalezienia:");
    // int userNum = int.Parse(Console.ReadLine());
    // int index = nums.IndexOf(userNum);
    // int itemsFound = 0;
    
    
    // if(index != -1)
    // {
    //     foreach(var n in nums)
    //     {
            
    //         if(n == userNum)
    //         {
    //             itemsFound++;
                
    //         }
    //     }
    //     Console.WriteLine("Znaleziono: " + itemsFound + " wystąpień.");   
    // }
    // else
    // {
    //     Console.WriteLine("Liczba nie znaleziona.");
    // }
    List<int> nums = new List<int>{2,-1,-3,4,5,-3};
    List<int> evenNums = new List<int>();
    foreach(var n in nums)
    {
        if(n % 2 == 0){
            evenNums.Add(n);
        }
    }
    foreach(var n in evenNums){
        Console.WriteLine(n);
    }
    
    }
    
}
