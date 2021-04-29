using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;

namespace Projeto_Hesp_estudo
{
    public partial class busca_link : Form
    {
        private DAO dao = new DAO();
        public busca_link()
        {
            InitializeComponent();
        }

        private void btcadsite_Click(object sender, EventArgs e)
        {
            Cadastra_site C = new Cadastra_site();
            busca_link D = new busca_link();
            this.Hide();
            C.ShowDialog();
        }

        private void btbuscasite_Click(object sender, EventArgs e)
        {
            busca_link C = new busca_link();
            busca_link D = new busca_link();
            this.Hide();
            C.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Grids C = new Grids();
            busca_link D = new busca_link();
            this.Hide();
            C.ShowDialog();
        }

        private void tblink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabela = dao.MostrarSitesUsuarios(tbbusca.Text);
            dgvpesquisa.DataSource = tabela;
            tbbusca.Text = "";
        }

        private void dgvpesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
