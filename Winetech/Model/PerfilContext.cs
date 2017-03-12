using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Winetech.Model;
namespace WinFormswithEFSample
{
    public class PerfilContext : DbContext
    {
        public DbSet<usuario> Usuarios { get; set; }
        public DbSet<perfil> Perfis { get; set; }
    }
}