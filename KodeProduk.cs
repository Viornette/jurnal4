using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300145
{
    internal class KodeProduk
    {
        public static string getKodeProduk(string produk)
        {
            string[] produkElektronik = { "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera" };
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };
            int index = 0;

            for (int i = 0; i < produkElektronik.Length; i++)
            {
                if (produk == produkElektronik[i])
                {
                    index = i;
                    break;
                }
            }
            return kodeProduk[index];
        }
    }
}
