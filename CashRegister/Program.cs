using System;


namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register reg = new Register();

            reg.AddItem(22.55);

            if (reg.NoOfItems == 1)
            {
                Console.WriteLine("Der var en vare som forventet");
            }
            else
            {
                Console.WriteLine("Der var IKKE en vare som forventet");
            }

            if (reg.GetTotal() == 22.55)
            {
                Console.WriteLine("Der var varer for 22.55 som forventet");
            }
            else
            {
                Console.WriteLine("Der var IKKE varer for 22.55 som forventet");
            }

            reg.AddItem(10.00);

            Console.WriteLine($"Register indeholder nu {reg.GetNoOfItems()} varer til ialt {reg.GetTotal()} kr.");

            try
            {
                reg.AddItem(-12.00);
                // Hvis jeg kommer hertil var der ingen exception
                Console.WriteLine("Der kom IKKE en exception som forventet");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Der kom en exception som forventet med indhold {e.Message}");
            }

        }
    }
}
