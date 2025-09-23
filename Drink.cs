using System;

namespace TugasOOP
{
    // class dengan inheritance
    public class Drink : MenuItem
    {
        // encapsulation
        private bool _isDingin;

        public bool GetIsDingin()
        {
            return _isDingin;
        }

        public void SetIsDingin(bool isDingin)
        {
            _isDingin = isDingin;
        }

        // constructor
        public Drink(string _namaMenu, decimal _harga,int _stok, bool isDingin)
            : base(_namaMenu, _harga, _stok)
        {
            _isDingin = isDingin;
        }

        // polymorphism
        public override void DisplayInfo()
        {
            string _tipe = _isDingin ? "Dingin" : "Panas";
            Console.WriteLine("Minuman : " + GetNamaMenu() + " (" + _tipe + ") - Rp " + GetHarga());
        }
    }
}
