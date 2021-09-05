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
    public partial class menu_telefone : UserControl
    {
        public menu_telefone()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        private void txt_busca_tel_TextChanged(object sender, EventArgs e)
        {
            if (txt_busca_tel.Text == "")
            {
                busca_telefones.Visible = false;
                
            }
            else
            {
                busca_telefones.Visible = true;
            }
            if (txt_busca_tel.Text != "")
            {
                try
                {
                    
                    conexao.Open();
                    cmd.CommandText = "select * from tbl_telefone where nm_cliente like('" + txt_busca_tel.Text +"%')";
                    cmd.Connection = conexao;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;

                    da.Fill(dt);

                    busca_telefones.DataSource = (dt);
                    
                    conexao.Close();
                   

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

        private void messagem_para_usuario_MouseHover(object sender, EventArgs e)
        {

            MessageBox.Show("informe na barra de pesquisa para trazer todos os clientes e suas informações ==> %", "Observação*");
            txt_busca_tel.Focus();
        }
    }
}
