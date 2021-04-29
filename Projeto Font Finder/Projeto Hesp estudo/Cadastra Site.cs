using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DLL;

namespace Projeto_Hesp_estudo
{
    public partial class Cadastra_site : Form
    {
        private DAO dao = new DAO();
        public String endemailfinal;
        public Cadastra_site()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grids G = new Grids();
            Cadastra_site D = new Cadastra_site();
            this.Hide();
            G.ShowDialog();
        }

        private void btcadsite_Click(object sender, EventArgs e)
        {
            Cadastra_site C = new Cadastra_site();
            Cadastra_site D = new Cadastra_site();
            this.Hide();
            C.ShowDialog();
        }

        private void btbuscasite_Click(object sender, EventArgs e)
        {
            busca_link C = new busca_link();
            Cadastra_site D = new Cadastra_site();
            this.Hide();
            C.ShowDialog();
        }
        private void Cadastra_site_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Site site = new Site();
            site.Nome = nomesite.Text;
            site.NotaCont = int.Parse(notaconteudo.Text);
            site.NotaConf = int.Parse(notaconfiab.Text);
            site.NotaRelev = int.Parse(notarelev.Text);
            site.NotaEntend = int.Parse(notaentend.Text);
            site.Foco = focoassunt.Text;
            site.NotaFinalDefinir();
            Usuario user = dao.RetornarCadastro(this.endemailfinal);
            dao.RegistrarSite(site,user);
            MessageBox.Show("Site Cadastrado com sucesso!");
            this.Close();
        }
    }
}
