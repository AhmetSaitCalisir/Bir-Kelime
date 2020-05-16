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
        public Form_Kelime()
        {
            InitializeComponent();
        }
        
        private void Form_Kelime_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
