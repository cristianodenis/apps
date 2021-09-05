using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Livraria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string usuario; // posso chamar em outra area static
        public static string cod_usuario;

        //using System.Data.SqlClient; biblioteca que sustenta as operaçoes abaixo
        //faz a conexao com o banco de dados
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
       // SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7JT4VLL\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        //executa os comandos no banco de dados
        SqlCommand cmd = new SqlCommand();
        //responsavel por receber os dados de uma tabela apos uma execuçao do select 
        // SqlDataReader dr;

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtacessar_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" || txtsenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!!", "Campos obrigatórios!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //abrindo a conexao com o banco de dados
                    conexao.Open();
                    // efetuando comando no banco de dados
                    cmd.CommandText = "select * from tbl_atendente where ds_login = ('" + txtlogin.Text + "') and ds_senha = ('" + txtsenha.Text + "')and ds_status = 1";
                    //informando que o comando sql vai ser executado na conexao que esta aberta ja com o caminho para o banco de dados.
                    cmd.Connection = conexao;
                    //dr = cmd.ExecuteReader();
                    SqlDataAdapter dtp = new SqlDataAdapter(cmd);
                    DataTable db = new DataTable(); //criar tabela
                    dtp.Fill(db); //preenche os dados dtp na tabela db

                    //verifica se a linhas no banco de dados
                    if (db.Rows.Count > 0)
                    {
                        usuario = db.Rows[0]["ds_login"].ToString();
                        cod_usuario = db.Rows[0]["cd_atendente"].ToString(); // validaçao para acessar o sistema
                        // so encontrou com resources
                        Resources.FrmMenu menu = new Resources.FrmMenu();
                        //apresenta a tela
                        menu.Show();
                        
                        //oculta a tela anterior
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("usuário ou senha incorretos!!", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //limpa os campos
                        txtlogin.Clear();
                        txtsenha.Clear();
                        //foca no campo indicado
                        txtlogin.Focus();
                    }
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

        private void txtcadeado_MouseDown(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
        }

        private void txtcadeado_MouseUp(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
