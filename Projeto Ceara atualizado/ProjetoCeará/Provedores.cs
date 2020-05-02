using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCeará
{
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new FormProvedores();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new FormProvedores();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }
    }
}
