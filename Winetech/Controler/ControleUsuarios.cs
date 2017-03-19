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
            if (usuario.nomecompleto.ToString() == string.Empty)
                return false;
            if (usuario.cpfUsuario.ToString()==string.Empty)
                return false;
            if(usuario.llogin.ToString()==string.Empty)
                return false;
            else
                return true;
        }
        public bool verificaCampoPreenchido(usuario u)
        {
            if (u.nomecompleto.ToString()== string.Empty ){
                return false;
            }
            else
                return true;
        }
        public List<usuario> pesquisarusuario(string nome)
        {
            usuario u = new usuario(nome);
            return u.pesquisarUsuario(nome);
        }
        }
    }

