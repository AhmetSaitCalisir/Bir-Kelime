using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_Kelime
{
    class Class_KelimeBulucu
    {
        private Class_VeriTabani veriTabani = new Class_VeriTabani();
        public string Cozum(Char[] Gelen)
        {
            string Bulunan = "Bulunamadı";
            int Puan = 0;
            string GeciciKelime;
            List<string> Kelimeler = veriTabani.Dondur(Gelen);
            foreach (string Kelime in Kelimeler)
            {
                GeciciKelime = Kelime.ToLower();
                foreach (char Harf in Gelen)
                {
                    GeciciKelime = GeciciKelime.Replace(Harf.ToString(), "");
                }
                if (GeciciKelime.Length <= 1)
                {
                    if (Puan < Kelime.Length)
                    {
                        Puan = Kelime.Length;
                        Bulunan = Kelime;
                    }
                }
                if (Puan>=8)
                {
                    return Bulunan;
                }
            }
            return Bulunan;
        }
    }
}
