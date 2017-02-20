namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fornecedor")]
    public partial class fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fornecedor()
        {
            pedidoFornecedor = new HashSet<pedidoFornecedor>();
        }

        [Key]
        public int codigoFornecedor { get; set; }

        [StringLength(14)]
        public string cnpjFornecedor { get; set; }

        [StringLength(150)]
        public string razaoSocialFornecedor { get; set; }

        [StringLength(150)]
        public string nomeFantasiaFornecedor { get; set; }

        [StringLength(150)]
        public string emailFornecedor { get; set; }

        [StringLength(9)]
        public string telefoneFornecedor { get; set; }

        public bool? statusFornecedor { get; set; }

        public int? codigoEnderecoFornecedor { get; set; }

        public virtual enderecoFornecedor enderecoFornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidoFornecedor> pedidoFornecedor { get; set; }
    }
}
