
using System.Windows.Forms;

namespace Winetech.Controler
{
    class Controle_Login
    {
        string login { get; set;}
        string senha { get; set;}

        public Controle_Login(string login,string senha)
        {
            this.login = login;
            this.senha = senha;
        }
        public bool fazerLoginControl(string login, string senha)
        {
            //Usuario U = new Usuario(login,senha);
            //if (U.login.ToString().Equals("admin")) {
                return true;
            //}
            //else 
            //    return false;
        }
    }
}
