using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj długość prostokąta: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Podaj szerokość prostokąta: ");
        double width = double.Parse(Console.ReadLine());
        for(int i=0; i<width; i++){
            for(int j=0; j<length; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
     