namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class Usuario
    {
        private string v;

        [Key]
        public int codigoUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string llogin { get; set; }

        [Required]
        [StringLength(30)]
        public string senha { get; set; }

        [Required]
        [StringLength(11)]
        public string cpfUsuario { get; set; }

        [Required]
        [StringLength(150)]
        public string nomecompleto { get; set; }

        public bool? statusUsuario { get; set; }

        public int? codigoPerfil { get; set; }

        public virtual perfil perfil { get; set; }

        public Usuario(string llogin,string senha,string cpfUsuario,string nomeCompleto,bool statusUsuario,int codigoPerfil)
        {
            this.llogin = llogin;
            this.senha = senha;
            this.cpfUsuario = cpfUsuario;
            this.nomecompleto = nomeCompleto;
            this.statusUsuario = statusUsuario;
            this.codigoPerfil = codigoPerfil;
        }
        public Usuario(string nomecompleto)
        {
            this.nomecompleto = nomecompleto;
        }
        public bool cadastrarUsuario(Usuario usuario)
        {

            return true;
        }
    }
    
}
