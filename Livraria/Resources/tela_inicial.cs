using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Resources
{
    public partial class tela_inicial : UserControl
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        
        
    }
}
