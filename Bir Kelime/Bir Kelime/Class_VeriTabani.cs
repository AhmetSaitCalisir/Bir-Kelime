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
        private List<string> Harfler = new List<string>();
        private List<string> Kelimeler = new List<string>();

        public Class_VeriTabani()
        {
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

            HtmlWeb html = new HtmlWeb();

            foreach (var Harf in Gelen)
            {
                for (int HarfSayisi = 9; HarfSayisi > 2; HarfSayisi--)
                {
                    HtmlAgilityPack.HtmlDocument htmlDocument = html.Load("https://kelimeler.net/" + Harf + "-ile-baslayan-" + HarfSayisi.ToString() + "-harfli-kelimeler");
                    if (Harf != 'ğ')
                    {
                        foreach (HtmlNode htmlNode in htmlDocument.DocumentNode.SelectNodes("//*[@class='ListedWordLink mobile-link']"))
                        {
                            Kelimeler.Add(ReplaceText(htmlNode.InnerText));
                        }
                    }
                }
            }
            return Kelimeler;
        }

        public char[] Rastgele_Harfler()
        {
            char[] Donecek = new char[8];
            Random random = new Random();
            int rastgele;
            for (int i = 0; i < 8; i++)
            {
                rastgele = random.Next(0, Harfler.Count);
                Donecek[i] = Convert.ToChar(Harfler[rastgele]);
            }
            return Donecek;
        }

        public string ReplaceText(string _text)
        {
            _text = _text.Replace("&#199;", "Ç").Replace("&#220;", "Ü").Replace("&#214;", "Ö");
            return _text;
        }
    }
}