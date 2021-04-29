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
    public partial class Login : Form
    {
        private DAO dao = new DAO();
        public Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }
        private void Entrace_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)//evento de login
        {
            // condição de tudo vazio ("Erro de usuário não cadastrado")
            int k = dao.RealizarLogin(email.Text,senha.Text);
            if (k == 0)
            {
                MessageBox.Show("Email e Senha incorretos ou cadastro inexistente!");
            }
            else
            {
                usuario = dao.RetornarCadastro(email.Text);
                Menu B = new Menu();
                B.endemail = email.Text;
                this.Hide();
                B.ShowDialog();
            }  
        }
        private void button1_Click_1(object sender, EventArgs e)//evento para levar ao cadastro
        {
            Cadastro A = new Cadastro();
            //código(métodos da dll)
            A.ShowDialog();
        }

        private void tlog_Click(object sender, EventArgs e)
        {

        }
        
        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
