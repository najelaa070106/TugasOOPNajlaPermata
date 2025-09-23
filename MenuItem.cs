using System;

namespace TugasOOP
{
    // class
    public class MenuItem
    {
        // encapsulation
        private string NamaMenu;
        private decimal Harga;
        private int Stok;

        public string GetNamaMenu()
        {
            return NamaMenu;
        }

        public void SetNamaMenu(string newNamaMenu)
        {
            NamaMenu = newNamaMenu;
        }

        public decimal GetHarga()
        {
            return Harga;
        }
        public void SetHarga(decimal newHarga)
        {
            Harga = newHarga;
        }
        public int GetStok()
        {
            return Stok;
        }

        public void SetStok(int newStok)
        {
            Stok = newStok;
        }

        // constructor tanpa stok
        public MenuItem(string _namaMenu , decimal _harga)
        {
            this.NamaMenu = _namaMenu;
            this.Harga = _harga;
            this.Stok = 0;
        }

        // constructor dengan stok
        public MenuItem(string _namaMenu, decimal _harga, int _stok)
        {
            this.NamaMenu = _namaMenu;
            this.Harga = _harga;
            this.Stok = _stok;
        }

        // polymorphism
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Menu : " + NamaMenu + " - Rp " + Harga);
        }
    }
}
