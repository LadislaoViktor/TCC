namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("enderecoCliente")]
    public partial class enderecoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enderecoCliente()
        {
            cliente = new HashSet<cliente>();
        }

        [Key]
        public int codigoEnderecoCliente { get; set; }

        [Required]
        [StringLength(2)]
        public string estado { get; set; }

        [Required]
        [StringLength(50)]
        public string cidade { get; set; }

        [Required]
        [StringLength(50)]
        public string bairro { get; set; }

        [Required]
        [StringLength(8)]
        public string CEP { get; set; }

        [Required]
        [StringLength(150)]
        public string rua { get; set; }

        [Required]
        [StringLength(4)]
        public string numero { get; set; }

        [Required]
        [StringLength(30)]
        public string Complemento { get; set; }

        public bool statusEnderecoCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }
    }
}
