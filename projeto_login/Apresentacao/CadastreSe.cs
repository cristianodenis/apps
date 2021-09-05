using projeto_login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_login.Apresentacao
{
   
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void cadastrar_login_senha_Click(object sender, EventArgs e)
        {
            controle ctl = new  controle();
            string mensagem = ctl.cadastrar(cadastrarlogin.Text, cadastrarsenha.Text, confirmarsenha.Text);
            if (ctl.tem)//mesagem de sucesso!!
            {
             
                MessageBox.Show(mensagem,"Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ctl.mensagem);//mensagem de erro!!
            }
        }
    }
}
