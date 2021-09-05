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
    public partial class menu_autores : UserControl
    {
        public menu_autores()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void busca_autores_TextChanged(object sender, EventArgs e)
        {
            if (busca_autores.Text == "")
            {
                tabela_autores.Visible = false;
                roda_pe_inferior.Visible = true;
            }
            else
            {
                tabela_autores.Visible = true;
                roda_pe_inferior.Visible = false;
            
                try
                {
                    
                    conexao.Open(); // abrindo conexao
                    //somente os nome dos autores
                   // cmd.CommandText = "select nome_autor from tbl_livros where nome_autor like ('" + busca_autores.Text + "%')";
                    cmd.CommandText = "select * from tbl_livros where nome_autor like ('" + busca_autores.Text + "%')";
                    cmd.Connection = conexao; // indicando onde o comando vai ser executado

                    SqlDataAdapter da = new SqlDataAdapter(); // recebendo os dados do comando executado
                    DataTable dt = new DataTable(); // estrura da tabela

                    da.SelectCommand = cmd; //recebendo os dados do comando executado

                   da.Fill(dt); // preenchendo a tabela
                   tabela_autores.DataSource = (dt); // onde a tabela vai ser exibida
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
    }
}
