namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contatoCliente")]
    public partial class contatoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contatoCliente()
        {
            cliente = new HashSet<cliente>();
        }

        [Key]
        public int codigoContatoCliente { get; set; }

        [Required]
        [StringLength(3)]
        public string dddCliente { get; set; }

        [Required]
        [StringLength(9)]
        public string numeroContatoCliente { get; set; }

        public bool? statusContatoCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }
    }
}
