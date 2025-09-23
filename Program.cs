using System;

namespace TugasOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang di Cafe Vilviette!");

            var CafeLatte = new Drink("Cafe Latte", 20000, 25, true);
            var Croissant = new Food("Croissant", 25000, 10, false);

            CafeLatte.DisplayInfo();
            Croissant.DisplayInfo();

            var CustomerOrder = new Order();

            CustomerOrder.AddItem(CafeLatte, 1);
            CustomerOrder.AddItem(Croissant, 2);

            CustomerOrder.DisplayOrderSummary();

            Console.ReadKey();
        }
    }
}