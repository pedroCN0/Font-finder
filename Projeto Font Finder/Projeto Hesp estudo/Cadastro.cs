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
    public partial class Cadastro : Form
    {
        private DAO dao = new DAO();
        public Cadastro()
        {
            InitializeComponent();
        }
        private void tlog_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)//evento para levar de volta ao início pré menu
        {
            if (cadnome.Text == null || cademail.Text == null || cadsenha.Text == null || cadrg.Text == null || cadcpf.Text == null)
            {
                MessageBox.Show("Existe um campo vazio!");
            }
            else
            {
                Usuario user = new Usuario();
                user.Nome = cadnome.Text;
                user.Senha = cadsenha.Text;
                user.Email = cademail.Text;
                user.Cpf = cadcpf.Text;
                user.Rg = cadrg.Text;
                int k = dao.RealizarCadastro(user);
                if (k == 0)
                {
                    MessageBox.Show("Email ou CPF já existentes no sistema!");
                }
                else
                {
                    MessageBox.Show("Usuario Cadastrado!");
                    this.Close();
                }
            }
            //Login A = new Login();
            //código(métodos da dll)
        }
        private void nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
