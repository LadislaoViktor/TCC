using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winetech.Model
{
    class Usuario
    {
        private int CodigoUsuario { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string cpfUsuario { get; set; }
        private string nomeCompleto { get; set; }
        private bool statusUsuario { get; set; }
        private int codigoFuncao { get; set; }

        private Usuario(string login,string senha,string cpf,
            string nome,bool status,int codigoFuncao){
            this.login = login;
            this.senha = senha;

        }
        private bool validarLogin(string login, string senha)
        {

            return true;
        }  
    }
}
