namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pedidoCliente")]
    public partial class pedidoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedidoCliente()
        {
            cliente = new HashSet<cliente>();
            produto = new HashSet<produto>();
        }

        [Key]
        public int codigoPedido { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataPedido { get; set; }

        public bool? statusPedido { get; set; }

        [StringLength(1)]
        public string statusPagamentoPedido { get; set; }

        public int quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal precoUnitario { get; set; }

        [Column(TypeName = "money")]
        public decimal totalPedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produto { get; set; }
    }
}
