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
            if(verificaCampoPreenchido(usuario)==false)
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
        public bool verificaSenhaEContrasenha(string senha,string contraSenha)
        {
            if (senha == contraSenha)
            {
                return true;
            }
            return false;
        }
        public List<usuario> pesquisarusuario(string nome)
        {
            usuario u = new usuario(nome);
            return u.pesquisarUsuario(nome);
        }
        }
    }

