using System.Collections.Generic;
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
            if (usuario.nomecompleto.Length==0)
                return false;
            else
                return true;
        }
        public List<Usuario> pesquisarUsuarios(Usuario usuario) {
            if (usuario.nomecompleto==null)
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
