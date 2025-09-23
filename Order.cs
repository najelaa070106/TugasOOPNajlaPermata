using System;
using System.Collections.Generic;

namespace TugasOOP
{
    // class dengan composition
    public class Order
    {
        private List<MenuItem> _items;
        public Order()
        {
            _items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item, int quantity)
        {
            if (item.GetStok() >= quantity)
            {
                for (int i = 0; i < quantity; i++)
                {
                    _items.Add(item);
                }
                item.SetStok(item.GetStok() - quantity);
                Console.WriteLine(quantity + " " + item.GetNamaMenu() + " ditambahkan ke pesanan.");
                Console.WriteLine("Sisa stok " + item.GetNamaMenu() + " : " + item.GetStok());
            }
            else
            {
                Console.WriteLine("Stok " + item.GetNamaMenu() + " tidak mencukupi! (Stok tersedia : " + item.GetStok() + ")");
            }
        }
        

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.GetHarga();
            }
            return total;
        }

        public void DisplayOrderSummary()
        {
            Console.WriteLine("\n--- Pesanan ---");
            foreach (var item in _items)
            {
                Console.WriteLine("- " + item.GetNamaMenu() + " - Rp " + item.GetHarga());
            }
            Console.WriteLine("Total : " + CalculateTotal());
            Console.WriteLine("--------------------------");
        }
    }
}
