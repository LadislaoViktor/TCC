using System.Collections.Generic;
using Winetech.Model;

namespace Winetech.Controler
{
    class ControleUsuarios
    {
        public bool cadastrarUsuários(usuario usuario)
        {
              if (validarCamposObrigatorios(usuario) == true)
              {
                  if(usuario.inserir(usuario)==true)
                    return true;
                  else
                    return false;
              }
              else
            return false;
        }
        public bool validarCamposObrigatorios(usuario usuario)
        {
            if (usuario.nomecompleto.Length==0)
                return false;
            else
                return true;
        }
        public bool verificaCampoPreenchido(usuario u)
        {
            if (u.nomecompleto == null){
                return false;
            }
            else
                return true;
        }
        public bool pesquisarUsuario(string nome) {
            return true;
        }
    }
}
