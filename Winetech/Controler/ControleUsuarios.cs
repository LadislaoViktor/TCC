using System.Collections.Generic;
using Winetech.Model;
namespace Winetech.Controler
{
    class ControleUsuarios
    {
        public bool cadastrarUsuários(Usuario usuario)
        {
              if (validarCamposObrigatorios(usuario) == true)
              {
                  if(usuario.cadastrarUsuario(usuario)==true)
                    return true;
                  else
                    return false;
              }
              else
            return false;
        }
        public bool validarCamposObrigatorios(Usuario usuario)
        {
            if (usuario.nomeCompleto.Length ==0)
                return false;
            else
                return true;
        }
        public List<Usuario> pesquisarUsuarios(Usuario usuario) {
            if (usuario.nomeCompleto==null)
                0
            {
                return null;
            }
            else {
                List<Usuario> Lista = new List<Usuario>();
                return Lista;
            }
                
        }
    }
}
