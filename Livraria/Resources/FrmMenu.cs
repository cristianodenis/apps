using System;
using System.Windows.Forms;

namespace Livraria.Resources
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btnfuncionario_Click(object sender, EventArgs e)
        {
            desativardestaque();
            destaque_func.Visible = true;
            funcionariomn1.BringToFront();  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            desativardestaque();
            tela_inicial1.BringToFront();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_cliente.Visible = true;
            menu_cliente1.BringToFront();
        }

        private void btntelefone_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_telefones.Visible = true;
            menu_telefone1.BringToFront();
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_categoria.Visible = true;
            menu_categoria1.BringToFront();
        }
        private void btnautores_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_autores.Visible = true;
            menu_autores1.BringToFront();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_pedido.Visible = true;
            menu_pedido1.BringToFront();
        }

        private void btncaixa_Click(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_caixa.Visible = true;
            menu_caixa1.BringToFront();
        }

        private void btnlivros_Click_1(object sender, EventArgs e)
        {

            desativardestaque();
            destaque_livros.Visible = true;
            menu_livros1.BringToFront();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            nome_usuario.Text = login.usuario;
        }

        private void sair_frm_menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ativardestaque()
        {
            destaque_func.Visible = true;
            destaque_cliente.Visible = true;
            destaque_telefones.Visible = true;
            destaque_livros.Visible = true;
            destaque_categoria.Visible = true;
            destaque_pedido.Visible = true;
            destaque_autores.Visible = true;
            destaque_caixa.Visible = true;
        }

        private void desativardestaque()
        {
            destaque_func.Visible = false;
            destaque_cliente.Visible = false;
            destaque_telefones.Visible = false;
            destaque_livros.Visible = false;
            destaque_categoria.Visible = false;
            destaque_pedido.Visible = false;
            destaque_autores.Visible = false;
            destaque_caixa.Visible = false;
        }
    }
}
