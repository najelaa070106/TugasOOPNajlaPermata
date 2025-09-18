using System;

namespace TugasOOP
{
    public class order
    {
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void AddItem(string _namaMenu, double _harga)
        {
            Items.Add(new MenuItem(_namaMenu, _harga));
        }

        public void ShowOrder()
        {
            Console.WriteLine("\nPesanan Anda : ");
            double total = 0;
            foreach (var item in Items)
            {
                item.DisplayInfo();
                total += item.Harga;
            }
            Console.WriteLine("Total : Rp " + total);
        }
    }
}
