using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winetech.Controler;
using Winetech.WinetechDataSetTableAdapters;
using System.Windows.Forms;

namespace Winetech.Controler
{
    class Controle_Login
    {
        public bool fazerLoginControl(string login, string senha)
        {
            string testaLogin=login ;
            if(testaLogin == login)
            {
                return true;
            }
            else
            return false;
        }
    }
}
