using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DLL
{
    public class DAO
    {/*Projeto desenvovido por dois malucos que não dormem (Bruno da Silva Costa & Pedro Campos Novais) :) */
        private MySqlConnection conexao;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private MySqlDataAdapter adaptador;
        private DataTable tabela;
        private String sql;

        public DAO()
        {
            try
            {
                //conexao = new MySqlConnection("server=localhost;uid=root;pwd=root;database=FontFinder;sslmode=none");
                conexao = new MySqlConnection("server=192.168.2.199;uid=aluno;pwd=aluno;database=FontFinder;sslmode=none");
                conexao.Open();
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
        }

        //Interações com a tabela "usuarios"------------------------------------------------------------------------------------------------------
        
        public int RealizarCadastro(Usuario user)
        {
            /*Recebe um objeto do tipo "Usuario" faz um select no banco de dados se houver linhas do comando select retorna o valor '0' senão da um 'insert'
             no banco de dados na tabela "usuarios".*/
            int a = 0;
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "select * from usuarios where cpf=@cpf or email=@email";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cpf", user.Cpf);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.ExecuteNonQuery();
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                }
                else
                {
                    read.Close();
                    sql = "insert into usuarios(nome,senha,email,cpf,rg) values (@nome,@senha,@email,@cpf,@rg)";
                    cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", user.Nome);
                    cmd.Parameters.AddWithValue("@senha", user.Senha);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@cpf", user.Cpf);
                    cmd.Parameters.AddWithValue("@rg", user.Rg);
                    cmd.ExecuteNonQuery();
                    a = 1;
                }
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                read.Close();
                conexao.Close();
            }
            return a;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public int RealizarLogin(String email, String snh)
        {
            /*Recebe duas strings para realizar um 'select' no banco de dados que se houver uma linha ele retorna o int no valor de '1' permitindo a entrada
             no menu do programa.*/
            int a = 0;
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "select * from usuarios where email=@email and senha=@senha";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", snh);
                cmd.ExecuteNonQuery();
                read = cmd.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    a = 1;
                }
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                read.Close();
                conexao.Close();
            }
            return a;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public void ExcluirCadastro(int id)
        {
            /*Recebe um numero inteiro aonde da origem a um comando sql que exclui os cadastros feitos pelo autor de 'sites' e o cadastro na tabela 'usuario'.*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "delete from site where cad_autor=@id";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                sql = "delete from usuarios where cod_registrado=@id";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        public Usuario RetornarCadastro(String email)
        {
            /*Recebe uma string contendo o email do usuario e faz retorno de um objeto "Usuario" preenchido por um reader que lê as informações relacionadas
             a aquele atributo 'email' recebido como String.*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            Usuario enviar = new Usuario();
            try
            {
                sql = "select * from usuarios where email=@email";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                read = cmd.ExecuteReader();
                read.Read();
                enviar.Id = read.GetInt32("cod_registrado");
                enviar.Nome = read.GetString("nome");
                enviar.Senha = read.GetString("senha");
                enviar.Email = read.GetString("email");
                enviar.Cpf = read.GetString("cpf");
                enviar.Rg = read.GetString("rg");
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                read.Close();
                conexao.Close();
            }
            return enviar;
        }
        //Fim.

        //Interações com a tabela "Site"-----------------------------------------------------------------------------------------------------------------
        public void RegistrarSite(Site website, Usuario user)
        {
            /*Recebe dois objetos e faz o cadastro de um site refenciando o usuario autor do cadastro por sua identificação (id)*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "insert into site(nome,nconteúdo,nconfiabilidade,nrelevancia,nentendimento,nfinal,foco,cad_autor) values (@nome,@nconteudo,@nconfiabilidade,@nrelevancia,@nentendimento,@nfinal,@foco,@autor)";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", website.Nome);
                cmd.Parameters.AddWithValue("@nconteudo", website.NotaCont);
                cmd.Parameters.AddWithValue("@nconfiabilidade", website.NotaConf);
                cmd.Parameters.AddWithValue("@nentendimento", website.NotaEntend);
                cmd.Parameters.AddWithValue("@nrelevancia", website.NotaRelev);
                cmd.Parameters.AddWithValue("@nfinal", website.NotaFinal);
                cmd.Parameters.AddWithValue("@foco", website.Foco);
                cmd.Parameters.AddWithValue("@autor", user.Id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        public DataTable MostrarSitesUsuarios(String busca)
        {
            /*Recebe uma String com a busca realizada pelo usuario, e, retorna o valor de um 'select' referenciado a tabela 'site' no banco de dados
              adaptado em 'DataTable'*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "select nome Nome,nconteúdo Nota_Conteúdo,nconfiabilidade Nota_Confiabilidade,nrelevancia Nota_de_Relevancia,nentendimento Nivel_de_Compreensão,foco Foco,nfinal Media from site where nome like '%"+busca+"%';";
                cmd = new MySqlCommand(sql, conexao);
                adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = cmd;
                tabela = new DataTable();
                adaptador.Fill(tabela);
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
            return tabela;
        }
        public void ExcluirSite(int id)
        {
            /*Recebe um numero inteiro aonde da origem a um comando sql que exclui o cadastro na tabela 'site'.*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "delete from site where id=@id";
                cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
        }
        //Fim.

        //------------------------------------------------------------------------------------------------------------------------
        public DataTable MostrarUsuariosAdmin()
        {
            /*Realiza um 'select' na tabela 'usuarios' do banco de dados e retorna os valores em um 'DataTable'*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            adaptador = new MySqlDataAdapter();
            try
            {
                sql = "select * from usuarios";
                cmd = new MySqlCommand(sql, conexao);
                adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = cmd;
                tabela = new DataTable();
                adaptador.Fill(tabela);
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
            return tabela;
        }
        //------------------------------------------------------------------------------------------------------------------------
        public DataTable MostrarSitesAdmin()
        {
            /*Realiza um 'select' na tabela 'site' do banco de dados e retorna os valores em um 'DataTable'*/
            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.Open();
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            try
            {
                sql = "select * from site";
                cmd = new MySqlCommand(sql, conexao);
                adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = cmd;
                tabela = new DataTable();
                adaptador.Fill(tabela);
            }
            catch (MySqlException E)
            {
                throw E;
            }
            finally
            {
                conexao.Close();
            }
            return tabela;
        }
    }
}