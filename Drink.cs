using System;

namespace TugasOOP
{
    public class Drink : MenuItem
    {
        public bool IsDingin { get; set; }

        public Drink(string _namaMenu, double _harga, bool _isDingin)
            : base(_namaMenu, _harga)
        {
            IsDingin = _isDingin;
        }

        public override void DisplayInfo()
        {
            string _tipe = IsDingin ? "Dingin" : "Panas";
            Console.WriteLine(NamaMenu + (_tipe) + " - Rp " + Harga);
        }
    }
}
