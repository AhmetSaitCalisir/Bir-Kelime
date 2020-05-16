using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
namespace Agile_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Harfler = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            //int ToplamKelime = 0;
            listBox1.Items.Clear();
            HtmlWeb html = new HtmlWeb();
            
            
            foreach (var i in Harfler)
            {
                //a,a,b,b,c,d
                //listedeki bütün i ları sil
                //MessageBox.Show(i.ToString()+"\nBulunan toplam kelime "+ToplamKelime.ToString());
                for (int f =9; f>2;f--)
                {

                    HtmlAgilityPack.HtmlDocument htmlDocument = html.Load("https://kelimeler.net/" + i + "-ile-baslayan-" + f.ToString() + "-harfli-kelimeler");
                    listBox1.Items.Add(i + " ile başlayan " + f.ToString() + " harfli kelimeler");
                    if (i != "ğ")
                    {
                        foreach (HtmlNode htmlNode in htmlDocument.DocumentNode.SelectNodes("//*[@class='ListedWordLink mobile-link']"))
                        {

                            listBox1.Items.Add(ReplaceText(htmlNode.InnerText));
                            //ToplamKelime++;
                        }
                    }

                    
                }
                
            }
            //listBox1.Items.Add("Bulunan toplam kelime " + ToplamKelime.ToString());


        }
        public string ReplaceText(string _text)
        {
            _text = _text.Replace("&#199;", "Ç").Replace("&#220;","Ü").Replace("&#214;","Ö");
            return _text;
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
