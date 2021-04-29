using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Hesp_estudo
{
    public partial class Menu : Form
    {
        public String endemail;
        public Menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btlinkmenu_Click(object sender, EventArgs e)
        {
            busca_link C = new busca_link();
            Menu D = new Menu();
            this.Hide();
            C.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastra_site C = new Cadastra_site();
            C.endemailfinal = this.endemail;
            C.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (endemail == "brunosilvahue@gmail.com" || endemail == "pcnovais2002@gmail.com")
            {
                Grids G = new Grids();
                G.ShowDialog();
            }
            else
            {
                MessageBox.Show("Função exclusiva dos administradores!");
            }
        }

        private void btbuscasite_Click(object sender, EventArgs e)
        {
            busca_link C = new busca_link();
            C.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login voltar = new Login();
            this.Close();
            voltar.Show();
        }
    }
}
