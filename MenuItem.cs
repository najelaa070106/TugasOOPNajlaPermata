using System;

namespace TugasOOP
{
    public class MenuItem
    {
        public string NamaMenu { get; set; }
        public double Harga {  get; set; }

        public MenuItem(string _namaMenu , double _harga)
        {
            NamaMenu = _namaMenu;
            Harga = _harga;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine(NamaMenu + " - Rp " + Harga);
        }
    }
}
