using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Livraria.Resources
{
    public partial class funcionariomn : UserControl
    {
        public funcionariomn()
        {
            InitializeComponent();
        }
        //estabelecer uma conexao com o banco de dados
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        //SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7JT4VLL\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        //efetuando comandos no banco
        SqlCommand cmd = new SqlCommand();//"insert into tbl_atendente (ds_login,ds_senha,nm_atendente) values (@login,@senha,@atendente)");
        //recebendo o resultado do select
        // SqlDataReader dt;

        // faz a conexao com o banco (sqlconnection), cria as variaveis,manda o comando(sqlcommand) para o banco
        // e passa os parametros.

        private void desabilitar()
        {
            txtcod.Visible = false;
            lblcodigo.Visible = false;
            nometxt.Enabled = false;
            logintxt.Enabled = false;
            senhatxt.Enabled = false;
            btnnovo.Enabled = true;
            btngravar.Enabled = true;
            btnalterar.Enabled = true;
            btnremover.Enabled = true;
            btncancelar.Enabled = true;

        }
        private void habilitar()
        {
            nometxt.Enabled = true;
            logintxt.Enabled = true;
            senhatxt.Enabled = true;
            btnnovo.Enabled = true;
            btngravar.Enabled = true;
            btnalterar.Enabled = true;
            btnremover.Enabled = true;
            btncancelar.Enabled = true;
            txtbusca.Text = "";
            coletor.DataSource = null;

        }
        private void funcionariomenu_Load(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            habilitar();


            nometxt.Enabled = true;
            logintxt.Enabled = true;
            senhatxt.Enabled = true;
            logintxt.Focus();
            ativo.Checked = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            desabilitar();

            nometxt.Clear();
            logintxt.Clear();
            senhatxt.Clear();
            ativo.Checked = true;


        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (logintxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo login.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logintxt.Focus();
            }
            else if (senhatxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo senha.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhatxt.Focus();
            }
            else if (nometxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nometxt.Focus();
            }
            else if (senhatxt.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no minímo 8 digitos.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhatxt.Focus();
            }
            else
            {
                try
                {
                    string login = logintxt.Text;
                    string senha = senhatxt.Text;
                    string nome = nometxt.Text;


                    cmd.CommandText = "insert into tbl_atendente (ds_login,ds_senha,nm_atendente) values (@login,@senha,@atendente)";

                    // passando parametros
                    //cmd.Parameters.Add("@login",SqlDbType.VarChar).value = login;  outra maneira de fazer!!
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@atendente", nome);

                    //mostrando em qual conexao vai ser executado
                    cmd.Connection = conexao;
                    //abrindo conexao
                    conexao.Open();
                    //executar sem consulta
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear(); // Limpeza de parametros


                    MessageBox.Show("Cadastro efetuado com sucesso!!");
                    logintxt.Clear();
                    senhatxt.Clear();
                    nometxt.Clear();
                    nometxt.Focus();




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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (txtbusca.Text != "")
            {
                coletor.Visible = true;
            }
            else
            {
                coletor.Visible = false;
            }

                if (txtbusca.Text != "")
            {
                try
                {
                    conexao.Open();
                    cmd.CommandText = "select * from tbl_atendente where nm_atendente  like ('" + txtbusca.Text + "%')";
                    cmd.Connection = conexao;

                    //recebe os dados de uma tabela apos a execuçao de um select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //o objeto datatable pode representar uma ou mais tabelas de dados, as quais permanecem alocadas em memoria
                    //e pode ser manipulado atraves de metodos
                    DataTable db = new DataTable();

                    // fill para preencher os dados de uma tabela datatable
                    //recebendo os dados da instruçao select
                    da.SelectCommand = cmd;
                    da.Fill(db); //preenchendo o datatable
                    coletor.DataSource = db; // destino dos dados
                    conexao.Close();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }

            }
            else
            {

                coletor.DataSource = null; // nao vai exibir nenhuma informaçao no datagrid
            }

        }

        private void manipulardados()
        {

            txtcod.Visible = true;
            lblcodigo.Visible = true;
            btnalterar.Enabled = true;
            btncancelar.Enabled = true;
            btnremover.Enabled = true;
            btnnovo.Enabled = false;
            btngravar.Enabled = false;
            nometxt.Enabled = true;
            logintxt.Enabled = true;
            senhatxt.Enabled = true;
        }
        private void carregando_atendente()
        {

            //nome do campo lblcodigo, nome do datagrid selecionando apenas uma linha sempre sera 0
            // indentificando a coluna (cells) pegando o valor e convertento para string
            lblcodigo.Text = coletor.SelectedRows[0].Cells[0].Value.ToString();
            logintxt.Text = coletor.SelectedRows[0].Cells[1].Value.ToString();
            senhatxt.Text = coletor.SelectedRows[0].Cells[2].Value.ToString();
            nometxt.Text = coletor.SelectedRows[0].Cells[3].Value.ToString();
            string valor = coletor.SelectedRows[0].Cells[4].Value.ToString();

            if (valor == "True")
            {
                ativo.Checked = true;

            }
            else
            {
                inativo.Checked = true;

            }

            manipulardados();

        }
        private void coletor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregando_atendente();

            if (ativo.Checked)
            {
                btnremover.Enabled = true;
            }
            else
            {
                btnremover.Enabled = false;
            }

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (logintxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo login.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logintxt.Focus();
            }
            else if (senhatxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo senha.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhatxt.Focus();
            }
            else if (senhatxt.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no minímo 8 digitos.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                senhatxt.Focus();
            }
            else if (nometxt.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nometxt.Focus();
            }

            else
            {
                try
                {
                    string login = logintxt.Text;
                    string senha = senhatxt.Text;
                    string nome = nometxt.Text;
                    int cd = int.Parse(lblcodigo.Text);

                    cmd.CommandText = "update tbl_atendente set ds_login=@login,ds_senha=@senha,nm_atendente=@atendente,ds_status=1 where cd_atendente=@cd";

                    //string sql = "insert into tbl_atendente (ds_nome,ds_login,ds_senha) values (@login,@senha,@atendente)";

                    // passando parametros
                    //cmd.Parameters.Add("@login",SqlDbType.VarChar).value = login;  outra maneira de fazer!!
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@atendente", nome);
                    cmd.Parameters.AddWithValue("@cd", cd);

                    //mostrando em qual conexao vai ser executado
                    cmd.Connection = conexao;
                    //abrindo conexao
                    conexao.Open();
                    //executar sem consulta
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear(); //Limpeza de parametros



                    logintxt.Clear();
                    senhatxt.Clear();
                    nometxt.Clear();

                    if (inativo.Checked == true)
                    {
                        MessageBox.Show("Status alterado para ativo", "Status ativo!!");
                        txtbusca.Text = "";
                        nometxt.Focus();
                    }

                    MessageBox.Show("dados alterados com sucesso !!", "status ativo");
                    txtbusca.Text = "";
                    nometxt.Focus();


                }



                catch (SqlException erro)
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnremover_Click_1(object sender, EventArgs e)
        {
            if (lblcodigo.Text == "")
            {
                MessageBox.Show("Informe o campo a ser excluido:", "campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbusca.Focus();
            }
            else
            {

                try
                {
                    int c = int.Parse(lblcodigo.Text);
                    cmd.CommandText = "delete from tbl_atendente  where cd_atendente=@cl";

                    cmd.Parameters.AddWithValue("@cl", c);

                    logintxt.Clear();
                    senhatxt.Clear();
                    nometxt.Clear();

                    cmd.Connection = conexao;
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    txtbusca.Text = "";
                    MessageBox.Show("usuário removido da lista!!", "removido!!", MessageBoxButtons.OK);
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

        private void btnretornar_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void messagem_para_usuario_MouseHover(object sender, EventArgs e)
        {

            MessageBox.Show("informe na barra de pesquisa para trazer todos os clientes e suas informações ==> %", "Observação*");
            txtbusca.Focus();
        }
    }
}
