namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class usuario
    {
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
    }
}
