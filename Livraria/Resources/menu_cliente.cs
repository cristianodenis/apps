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
    public partial class menu_cliente : UserControl
    {
        public menu_cliente()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        //SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-7JT4VLL\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void pessoa_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (pessoa_cliente.SelectedIndex == 0) //selecionado pessoa fisica
                {
                    label_cpf.Visible = true;
                    cpf_cliente.Visible = true;

                }
                else
                {

                    label_cpf.Visible = false;
                    cpf_cliente.Visible = false;
                }
                if (pessoa_cliente.SelectedIndex == 1)
                {
                    label_cnpj.Visible = true;         // selecionado pessoa jurídica
                    cnpj_cliente.Visible = true;
                }
                else
                {

                    label_cnpj.Visible = false;
                    cnpj_cliente.Visible = false;
                }
            
        }
        private void habilitarcampos()
        {
            nome_cliente.Enabled = true;
            telefone_cliente.Enabled = true;
            email_cliente.Enabled = true;
            pessoa_cliente.Enabled = true;
            cpf_cliente.Enabled = true;
            cnpj_cliente.Enabled = true;
            logradouro_cliente.Enabled = true;
            no_casa.Enabled = true;
            complemento_cliente.Enabled = true;
            bairro_cliente.Enabled = true;
            cidade_cliente.Enabled = true;
            cep_cliente.Enabled = true;
            uf_cliente.Enabled = true;
        }

            // string uf = uf_cliente_click.SelectedItem.tostring(); como capturar o valor de outro campo: SelectedItem pega o valor,tostring  converte para string 
            //MessageBox.Show(uf); mostra o valor capturado de um intem combobox
            private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            if(nome_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo nome!!", "Campo nome vasio!!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                nome_cliente.Focus();
            }
            else if (email_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo email!!", "Campo email vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                email_cliente.Focus();
            }
             if (pessoa_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo cpf/cnpj!!", "Campo cpf/cnpj vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pessoa_cliente.Focus();
            }
            else if (logradouro_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo logradouro!!", "Campo logradouro vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logradouro_cliente.Focus();
            }
            if (no_casa.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo numero!!", "Campo numero vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nome_cliente.Focus();
            }
            else if (complemento_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo complemento!!", "Complemento nome vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                complemento_cliente.Focus();
            }
            if(bairro_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo bairro!!", "Campo bairro vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bairro_cliente.Focus();
            }
            else if(cidade_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo cidade!!", "Campo cidade vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cidade_cliente.Focus();
            }
             if (cep_cliente2.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo cep!!", "Campo cep vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cep_cliente2.Focus();
            }
            else if (uf_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo cep !!", "Campo cep vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uf_cliente.Focus();
            }
             if (telefone_cliente.Text == "")
            {
                MessageBox.Show("E necessário preencher o campo telefone!!", "Campo telefone vasio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                telefone_cliente.Focus();
            }
            else
            {
                try
                {

                    string cliente = nome_cliente.Text;
                    string email = email_cliente.Text;
                    string cpf = cpf_cliente.Text;
                    string cnpj = cnpj_cliente.Text;
                    string logradouro = logradouro_cliente.Text;
                    string numero_casa = no_casa.Text;
                    string complemento = complemento_cliente.Text;
                    string bairro = bairro_cliente.Text;
                    string cidade = cidade_cliente.Text;
                    string uf = uf_cliente.Text;
                    string cep = cep_cliente2.Text;

                    cmd.CommandText = "insert into tbl_cliente (nm_cliente,ds_email,no_cpf,no_cnpj,nm_logradouro,no_logradouro,ds_complemento,nm_bairro,nm_cidade,sg_uf,no_cep) " +
                        "values (@nome,@email,@cpf,@cnpj,@logradouro,@no_casa,@complemento,@bairro,@cidade,@uf,@cep) set @cd = SCOPE_IDENTITY() ";

                    cmd.Connection = conexao;
                    

                    cmd.Parameters.AddWithValue("@nome",cliente);
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@cpf",cpf);
                    cmd.Parameters.AddWithValue("@cnpj",cnpj);
                    cmd.Parameters.AddWithValue("@logradouro",logradouro);
                    cmd.Parameters.AddWithValue("@no_casa",numero_casa);
                    cmd.Parameters.AddWithValue("@complemento",complemento);
                    cmd.Parameters.AddWithValue("@bairro",bairro);
                    cmd.Parameters.AddWithValue("@cidade",cidade);
                    cmd.Parameters.AddWithValue("@uf",uf);
                    cmd.Parameters.AddWithValue("@cep",cep);
                    cmd.Parameters.AddWithValue("@cd",0).Direction = ParameterDirection.Output;
                   

                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    
                    int cd = Convert.ToInt32(cmd.Parameters["@cd"].Value);
                    string celular = telefone_cliente.Text;
                    string nome = nome_cliente.Text;


                    cmd.CommandText = "insert into tbl_telefone(cd_cliente,no_telefone,nm_cliente)values('" + cd + "','" + celular + "','" +nome +"')"; 

                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Cadastro efetuado com sucesso!!", "Tudo certo!!", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    cmd.Parameters.Clear();
                    nome_cliente.Clear();
                    email_cliente.Clear();
                    cpf_cliente.Clear();
                    cnpj_cliente.Clear();
                    logradouro_cliente.Clear();
                    no_casa.Clear();
                    complemento_cliente.Clear();
                    bairro_cliente.Clear();
                    cidade_cliente.Clear();
                    cep_cliente2.Clear();
                    telefone_cliente.Clear();
                    uf_cliente.SelectedIndex = -1;
                    pessoa_cliente.SelectedIndex = -1;
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
                }


            }
        }

        private void busca_cliente_TextChanged(object sender, EventArgs e)
        {
            
            if (busca_cliente.Text == "")
            {
                tabela_cliente.Visible = false;  //condiçao
            }
            else
            {
                tabela_cliente.Visible = true;
            }
            if (busca_cliente.Text != "") { 

                try
                {
                    // abrindo conexao
                    conexao.Open();
                    //comando a ser executado no banco
                    cmd.CommandText = "select * from tbl_cliente where nm_cliente like ('" + busca_cliente.Text + "%')";
                    // onde o comando vai ser executado
                    cmd.Connection = conexao;

                    //instanciando sqldataadapter recebe os dados do select
                    SqlDataAdapter da = new SqlDataAdapter();
                    //instanciando datatable que representa a tabela
                    DataTable dt = new DataTable();

                    //recebendo o resultado do select
                    da.SelectCommand = cmd;
                    //preenchendo o resultado do select no datatable (fill,preenche).
                    da.Fill(dt); 
                    //mostrando onde vai ser exibida a tabela
                    tabela_cliente.DataSource = dt;
                    conexao.Close();



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
        private void carregando_cliente()
        {

            //nome do campo txtcodigo, nome do datagrid selecionando apenas uma linha sempre sera 0
            // indentificando a coluna (cells) pegando o valor e convertento para string
            
            codigo_cliente.Text = tabela_cliente.SelectedRows[0].Cells[0].Value.ToString();
            nome_cliente.Text = tabela_cliente.SelectedRows[0].Cells[1].Value.ToString();
            email_cliente.Text = tabela_cliente.SelectedRows[0].Cells[2].Value.ToString();
            cpf_cliente.Text = tabela_cliente.SelectedRows[0].Cells[3].Value.ToString();
            cnpj_cliente.Text = tabela_cliente.SelectedRows[0].Cells[4].Value.ToString();
            logradouro_cliente.Text = tabela_cliente.SelectedRows[0].Cells[5].Value.ToString();
            no_casa.Text = tabela_cliente.SelectedRows[0].Cells[6].Value.ToString();
            complemento_cliente.Text = tabela_cliente.SelectedRows[0].Cells[7].Value.ToString();
            bairro_cliente.Text = tabela_cliente.SelectedRows[0].Cells[8].Value.ToString();
            cidade_cliente.Text = tabela_cliente.SelectedRows[0].Cells[9].Value.ToString();
            uf_cliente.Text = tabela_cliente.SelectedRows[0].Cells[10].Value.ToString();
            cep_cliente2.Text = tabela_cliente.SelectedRows[0].Cells[11].Value.ToString();
            

            /* if (valor == "True")
             {
                 ativo_cliente.Checked = true;

             }
             else
             {
                 inativo_cliente.Checked = true;

             }*/
            //habilitarcampos();
        }

        private void tabela_cliente_MouseClick(object sender, MouseEventArgs e)
        {
            carregando_cliente();
        }
        private void messagem_para_usuario_MouseHover(object sender, EventArgs e)
        {

            MessageBox.Show("informe na barra de pesquisa para trazer todos os clientes e suas informações ==> %", "Observação*");
            busca_cliente.Focus();
        }

        
    }
}
