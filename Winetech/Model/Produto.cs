namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("produto")]
    public partial class produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produto()
        {
            pedidoCliente = new HashSet<pedidoCliente>();
        }

        [Key]
        public int codigoProduto { get; set; }

        [Required]
        [StringLength(150)]
        public string nome { get; set; }

        [Required]
        [StringLength(150)]
        public string descricao { get; set; }

        [StringLength(50)]
        public string uva { get; set; }

        [StringLength(50)]
        public string classe { get; set; }

        [StringLength(2)]
        public string teor_Alcolico { get; set; }

        [StringLength(30)]
        public string tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custoUnitário { get; set; }

        [Column(TypeName = "numeric")]
        public decimal quantidadeEstoque { get; set; }

        [Column(TypeName = "money")]
        public decimal precoVenda { get; set; }

        [StringLength(3)]
        public string unidade { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataValidade { get; set; }

        public int? codigoPais { get; set; }

        public int? codigoSafra { get; set; }

        public bool? statusProduto { get; set; }

        public virtual pais pais { get; set; }

        public virtual safra safra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidoCliente> pedidoCliente { get; set; }
    }
}
