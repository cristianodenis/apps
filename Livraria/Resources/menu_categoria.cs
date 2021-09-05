using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Livraria.Resources
{
    public partial class menu_categoria : UserControl
    {
        public menu_categoria()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void verificar_campo_selecionado()
        {
            Aventura.Checked = true;
            Acao.Checked = true;
            Guerra.Checked = true;
            Historia.Checked = true;
            Drama.Checked = true;
            Ficcao.Checked = true;
        }
        private void carregando_categoria()
        {
            if (Aventura.Checked.ToString() == "false" || Acao.Checked.ToString() == "false" || Guerra.Checked.ToString() == "false"
                || Historia.Checked.ToString() == "false" || Drama.Checked.ToString() == "false" || Ficcao.Checked.ToString() == "false")
            {
                MessageBox.Show("Informe uma categoria para pesquisa!!");
            }
            
        }
        private void filtro_categoria_livros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aventura_CheckedChanged(object sender, EventArgs e)
        {
     

            if (Aventura.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                   // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'aventura' or categoria_livro = 'Aventura' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();
                    
                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }
               

            }
        }

        private void Acao_CheckedChanged(object sender, EventArgs e)
        {

            if (Acao.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                    // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'ação' or categoria_livro = 'Ação' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();

                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }


            }
        }

        private void Guerra_CheckedChanged(object sender, EventArgs e)
        {

            if (Guerra.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                    // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'guerra' or categoria_livro = 'Guerra' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();

                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }


            }
        }

        private void Historia_CheckedChanged(object sender, EventArgs e)
        {

            if (Historia.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                    // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'historia' or categoria_livro = 'história' or categoria_livro = 'Historia' or categoria_livro = 'História' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();

                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }


            }
        }

        private void Drama_CheckedChanged(object sender, EventArgs e)
        {

            if (Drama.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                    // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'Drama' or categoria_livro = 'drama' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();

                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }


            }
        }

        private void Ficcao_CheckedChanged(object sender, EventArgs e)
        {

            if (Ficcao.Checked == true)
            {
                try
                {
                    filtro_categoria_livros.Visible = true;
                    //conexao
                    conexao.Open();
                    // string aventura;
                    // comando
                    cmd.CommandText = "select * from tbl_livros where categoria_livro = 'Ficção' or categoria_livro = 'ficção' ";

                    // apontar onde comando vai ser executado
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    filtro_categoria_livros.DataSource = (dt);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                    cmd.Parameters.Clear();

                }
                finally
                {
                    conexao.Close();
                    cmd.Parameters.Clear();
                }


            }
        }

        private void limpar_CheckedChanged(object sender, EventArgs e)
        {
            filtro_categoria_livros.Visible = false;
        }
    }
}
