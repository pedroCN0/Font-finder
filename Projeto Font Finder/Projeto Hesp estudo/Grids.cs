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
    public partial class Grids : Form
    {
        private DAO dao = new DAO();
        
        public Grids()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btcadsite_Click(object sender, EventArgs e)
        {
            
        }

        private void btbuscasite_Click(object sender, EventArgs e)
        {
            
        }

        private void usuário_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grids_Load(object sender, EventArgs e)
        {
            usuário.DataSource = dao.MostrarUsuariosAdmin();
            site.DataSource = dao.MostrarSitesAdmin();
        }

        private void site_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void site_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = (int)site.Rows[site.CurrentRow.Index].Cells[0].Value;
            DialogResult r = MessageBox.Show("Deseja remover o site de ID = " + a + "?", "Remover site", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                dao.ExcluirSite(a);
                MessageBox.Show("Site removido");
            }
            else
            {
                MessageBox.Show("Operação Cancelada!");
            }
            usuário.DataSource = dao.MostrarUsuariosAdmin();
            site.DataSource = dao.MostrarSitesAdmin();
        }

        private void usuário_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = (int)usuário.Rows[usuário.CurrentRow.Index].Cells[0].Value;
            DialogResult r = MessageBox.Show("Deseja remover o usuário de ID = " + a + "?", "Remover Usuário", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                dao.ExcluirCadastro(a);
                MessageBox.Show("Usuário removido");
            }
            else
            {
                MessageBox.Show("Operação Cancelada!");
            }
            usuário.DataSource = dao.MostrarUsuariosAdmin();
            site.DataSource = dao.MostrarSitesAdmin();
        }
    }
}
