using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_Kelime
{
    public partial class Form_Kelime : Form
    {
        Class_VeriTabani class_VeriTabani = new Class_VeriTabani();
        Class_KelimeBulucu class_KelimeBulucu = new Class_KelimeBulucu();
        public Form_Kelime()
        {
            InitializeComponent();
        }
        void Oyna()
        {
            label_Harfler.Text = "";
            char[] Harfler = new char[8];
            Harfler = class_VeriTabani.Rastgele_Harfler();
            foreach (var Harf in Harfler)
            {
                label_Harfler.Text += Harf + " ";
            }
            label_Kelime.Text = class_KelimeBulucu.Cozum(Harfler);
            label_Puan.Text = label_Kelime.Text.Length.ToString();
        }
        
        private void Form_Kelime_Load(object sender, EventArgs e)
        {
            Oyna();
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Tekrarla_Click(object sender, EventArgs e)
        {
            Oyna();
        }
    }
}
