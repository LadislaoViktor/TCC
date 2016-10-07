﻿using System;
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

        protected bool validarCamposObrigatorios(Usuario usuario)
        {
            if ((usuario.nomeCompleto) != null)
                return false;
            else
                return true;
        }
        protected List<Usuario> pesquisarUsuarios(Usuario usuario) {
            if (usuario.nomeCompleto == "")
            {
                List<Usuario> Lista = new List<Usuario>();
                return Lista;
            }
            else {
                return null;
            }
                
        }
    }
}
