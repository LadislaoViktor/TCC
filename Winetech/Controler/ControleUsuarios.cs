using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winetech.Model;

namespace Winetech.Controler
{
    class ControleUsuarios
    {
        public bool cadastrarUsuários(Usuario usuario)
        {
              if (validarCamposObrigatorios(usuario) == true)
              {
                  usuario.cadastrarUsuario(usuario);
                  return true;
              }
              else
            return false;
        }
        public bool validarCamposObrigatorios(Usuario usuario)
        {
            if (usuario.nomeCompleto == "")
                return false;
            return true;
        }
        public List<Usuario> pesquisarUsuarios(Usuario usuario) {
            if (usuario.nomeCompleto==null)
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
