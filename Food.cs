using System;

namespace TugasOOP
{
    // class dengan inheritance
    public class Food : MenuItem
    {
        // encapsulation
        private bool _isSayuran;

        // getter setter
        public bool GetIsSayuran()
        {
            return _isSayuran;
        }

        public void SetIsSayuran(bool isSayuran)
        {
            _isSayuran = isSayuran;
        }

        // constructor
        public Food(string _namaMenu, decimal _harga, int _stok, bool isSayuran)
            : base(_namaMenu, _harga, _stok)
        {
            _isSayuran = isSayuran;
        }

        // polymorphism
        public override void DisplayInfo()
        {
            string sayurStatus = _isSayuran ? " (Sayuran)" : "";
            Console.WriteLine("Makanan : " + GetNamaMenu() + " - Rp " + GetHarga() + sayurStatus);
        }
    }
}
