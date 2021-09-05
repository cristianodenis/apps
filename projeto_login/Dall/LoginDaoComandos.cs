using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_login.Dall
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = ""; // tudo ok!!
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarlogin(string login,string senha)
        {
            //procurar no banco de dados se existi esse login e senha
           
            cmd.CommandText = "select * from login_senha where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                
                if(dr.HasRows) //se foi encontrado!!
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o banco de dados!!";
            }
            return tem;
        }
        public string cadastrar(string email,string senha,string confsenha)
        {
            tem = false;
            //comandos para inserir no banco
            if (senha.Equals(confsenha))
            {
                cmd.CommandText = "insert into login_senha (email,senha) values (@email,@senha)";

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o banco de dados!!";
                }
            } else
            {
                this.mensagem = "Senhas não correspondem!!";
            }
            return mensagem;

        }
    }
}
