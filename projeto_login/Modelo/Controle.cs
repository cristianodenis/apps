using projeto_login.Dall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_login.Modelo
{
  public  class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar2(string login,string senha)
        {
            LoginDaoComandos logindao = new LoginDaoComandos();
            tem = logindao.verificarlogin(login, senha);
            if(!logindao.mensagem.Equals(""))
            {
                this.mensagem = logindao.mensagem;
            }
            return tem;
        }
        public string cadastrar(string email,string senha,string conflogin)
        {
            LoginDaoComandos lgn = new LoginDaoComandos();
            this.mensagem = lgn.cadastrar(email,senha,conflogin);
            if(lgn.tem)//a mensagem, que vir de sucesso!!
            {
                this.tem = true;
            }
            return mensagem;
        }

    }
}
