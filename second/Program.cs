using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int proby = 3;

        while (proby > 0)
        {
            Console.Write("Podaj nazwę użytkownika: ");
            string username = Console.ReadLine();

            Console.Write("Podaj hasło: ");
            string password = Console.ReadLine();

            bool poprawnaNazwa = username.Length >= 5;
            bool poprawneHaslo = password.Length >= 8 && password.Any(char.IsDigit);

            if (poprawnaNazwa && poprawneHaslo)
            {
                Console.WriteLine("Logowanie zakończone sukcesem");
                return; 
            }
            else
            {
                if (!poprawnaNazwa)
                {
                    Console.WriteLine("Błąd: nazwa użytkownika musi mieć co najmniej 5 znaków.");
                }

                if (!poprawneHaslo)
                {
                    Console.WriteLine("Błąd: hasło musi mieć co najmniej 8 znaków i zawierać przynajmniej jedną cyfrę.");
                }

                proby--;
                if (proby > 0)
                {
                    Console.WriteLine($"Spróbuj ponownie. Pozostało prób: {proby}\n");
                }
            }
        }

        Console.WriteLine("Przekroczono limit prób. Logowanie nieudane.");
    }
}
