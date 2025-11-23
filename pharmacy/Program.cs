using System;
class Order{

    public int id;
    public int orderValue;

}
public class Program
{
    

    public static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        
        int orderVal = 0;
        int maxOrderId = -1;
        int[] stan = new int[10]; // sztuki na półce
        int[] minimum = new int[10]; // próg, poniżej którego trzeba zamówić
        int[] cena = new int[10]; // cena jednej sztuki w zł
        stan[0] = 5; minimum[0] = 3; cena[0] = 10; 
        stan[1] = 2; minimum[1] = 5; cena[1] = 20; 
        stan[2] = 10; minimum[2] = 4; cena[2] = 15;
        stan[3] = 1; minimum[3] = 2; cena[3] = 25; 
        stan[4] = 8; minimum[4] = 6; cena[4] = 30; 
        stan[5] = 0; minimum[5] = 3; cena[5] = 12; 
        stan[6] = 4; minimum[6] = 4; cena[6] = 18; 
        stan[7] = 6; minimum[7] = 5; cena[7] = 22; 
        stan[8] = 3; minimum[8] = 2; cena[8] = 16; 
        stan[9] = 7; minimum[9] = 6; cena[9] = 28; 
        for (int i = 0; i < 10; i++)
        {
            
            if(stan[i] < minimum[i])
            {
                
                int toOrder = minimum[i] - stan[i];
                Console.WriteLine("Produkt " + (i+1) + ": zamówić " + toOrder + " sztuk, koszt: " + (toOrder * cena[i]) + " zł");
                orderVal += toOrder * cena[i];
                Order newOrder = new Order()    {
                    id = i,
                    orderValue = toOrder * cena[i]
                };
                orders.Add(newOrder);
            }

        }
        for (int i = 0; i < orders.Count; i++)
        {
            
            if(orders[i].orderValue > maxOrderId)
            {

                maxOrderId = orders[i].id;

            }
        }
        Console.WriteLine("Łączna wartość zamówienia: " + orderVal + " zł");
        Console.WriteLine("Produkt o największej wartości zamówienia: Produkt " + (maxOrderId+1));
        
    }

   
}
