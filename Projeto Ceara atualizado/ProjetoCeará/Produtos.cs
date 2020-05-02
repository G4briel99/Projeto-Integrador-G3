using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCeará
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            newForm.Show();
        }

        private void btneditarprod_Click(object sender, EventArgs e)
        {
            var newForm = new Form4();
            newForm.Show();

        }
    }
}
