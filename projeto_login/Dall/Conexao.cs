using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_login.Dall
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-GNF0QU2\SQLEXPRESS;Initial Catalog=projeto_login;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
           if(con.State == System.Data.ConnectionState.Closed)
            {
                 con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
