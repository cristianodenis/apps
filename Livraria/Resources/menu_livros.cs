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
    public partial class menu_livros : UserControl
    {
        public menu_livros()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void carregando_livros()
        {
            label_livros.Visible = true;
            codigo_livros.Visible = true;
            codigo_livros.Text = tabela_livros.SelectedRows[0].Cells[0].Value.ToString();
            nome_livro.Text = tabela_livros.SelectedRows[0].Cells[1].Value.ToString();
            nome_autor.Text = tabela_livros.SelectedRows[0].Cells[2].Value.ToString();
            categoria_livro.Text = tabela_livros.SelectedRows[0].Cells[3].Value.ToString();
           quantidade_livros.Text = tabela_livros.SelectedRows[0].Cells[4].Value.ToString();
        }

    private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            if (nome_livro.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!!");
                nome_livro.Focus();
            }
            else if(nome_autor.Text == "")
            {
                MessageBox.Show("Preencha o campo autor!!");
                nome_autor.Focus();
            }
            if (categoria_livro.Text == "")
            {
                MessageBox.Show("Preencha o campo categoria!!");
                categoria_livro.Focus();
            }
            else if (quantidade_livros.Text == "")
            {
                MessageBox.Show("Preencha o campo quantidade!!");
                quantidade_livros.Focus();
            }
            else
            {
                try
                {
                    //variaveis para receber as do banco
                    string livro = nome_livro.Text;
                    string autor = nome_autor.Text;
                    string categoria = categoria_livro.Text;
                    string quantidade = quantidade_livros.Text;
                    //int quantidade = Convert.ToInt32(quantidade_livros);

                    //comando para o banco
                    cmd.CommandText = "insert into tbl_livros (nome_livro,nome_autor,categoria_livro,quantidade) values (@nome_livro,@nome_autor,@categoria,@quantidade)";
                    //parametros
                    cmd.Connection = conexao;
                    cmd.Parameters.AddWithValue("@nome_livro",livro);
                    cmd.Parameters.AddWithValue("@nome_autor",autor);
                    cmd.Parameters.AddWithValue("categoria",categoria);
                    cmd.Parameters.AddWithValue("@quantidade",quantidade);
                    //abrir conexao e mandar executar
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!!","Tudo certo!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    nome_livro.Clear();
                    nome_autor.Clear();
                    categoria_livro.Clear();
                    quantidade_livros.Clear();
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

        private void busca_livros_TextChanged(object sender, EventArgs e)
        {
            if (busca_livros.Text == "")
            {
                tabela_livros.Visible = false;
            }
            else
            {
                tabela_livros.Visible = true;
            //}
            //if (busca_livros.Text != "" ) { 

                try
                {

                    
                    cmd.Connection = conexao;
                    conexao.Open();

                    cmd.CommandText = "select * from tbl_livros where nome_autor like ('" + busca_livros.Text + "%')";

                    SqlDataAdapter da = new SqlDataAdapter(); //recebe o select do banco
                    DataTable dt = new DataTable(); // estrutura da tabela
                    da.SelectCommand = cmd; // recebendo a consulta do banco
                    da.Fill(dt); // fill preenche os do (da) no (dt)
                    tabela_livros.DataSource = (dt); //indica onde os dados irao aparecer

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                   
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void tabela_livros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregando_livros();
        }

        private void tabela_livros_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            carregando_livros();
        }

        private void messagem_para_usuario_MouseHover(object sender, EventArgs e)
        {

            MessageBox.Show("informe na barra de pesquisa para trazer todos os clientes e suas informações ==> %", "Observação*");
            busca_livros.Focus();
        }
    }
}
