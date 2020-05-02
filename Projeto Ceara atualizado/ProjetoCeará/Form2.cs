using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoCeará
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wsg,int wparam,int lparam);
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PainelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vendas());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormInPanel(object FormFilho)
        {
            if (this.PainelCentral.Controls.Count > 0)
                this.PainelCentral.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelCentral.Controls.Add(fh);
            this.PainelCentral.Tag = fh;
            fh.Show();
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Produtos());
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form3());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form3());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Provedores());
        }
    }
}
