using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace Bir_Kelime
{
    class Class_VeriTabani
    {
        public List<string> Harfler = new List<string>();
        private List<string> Kelimeler = new List<string>();

        public Class_VeriTabani()
        {
            //Harfler
            Harfler.Add("a");
            Harfler.Add("b");
            Harfler.Add("c");
            Harfler.Add("d");
            Harfler.Add("e");
            Harfler.Add("f");
            Harfler.Add("g");
            Harfler.Add("ğ");
            Harfler.Add("h");
            Harfler.Add("ı");
            Harfler.Add("i");
            Harfler.Add("j");
            Harfler.Add("k");
            Harfler.Add("l");
            Harfler.Add("m");
            Harfler.Add("n");
            Harfler.Add("o");
            Harfler.Add("ö");
            Harfler.Add("p");
            Harfler.Add("r");
            Harfler.Add("s");
            Harfler.Add("ş");
            Harfler.Add("t");
            Harfler.Add("u");
            Harfler.Add("ü");
            Harfler.Add("v");
            Harfler.Add("y");
            Harfler.Add("z");
        }

        public List<string> Dondur(char[] Gelen)
        {
            Kelimeler.Clear();

            
            

            return Kelimeler;
        }
    }
}
