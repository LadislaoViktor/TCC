namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pedidoFornecedor")]
    public partial class pedidoFornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedidoFornecedor()
        {
            fornecedor = new HashSet<fornecedor>();
        }

        [Key]
        public int codigoPedidoFornecedor { get; set; }

        [Column(TypeName = "money")]
        public decimal? totalPedidoFornecedor { get; set; }

        public int? quantidadePedidoFornecedor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataCompraPedido { get; set; }

        [Column(TypeName = "money")]
        public decimal? precoUnitario { get; set; }

        public bool? statusPedidofornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fornecedor> fornecedor { get; set; }
    }
}
