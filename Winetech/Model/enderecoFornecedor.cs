namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("enderecoFornecedor")]
    public partial class enderecoFornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enderecoFornecedor()
        {
            fornecedor = new HashSet<fornecedor>();
        }

        [Key]
        public int codigoEnderecoFornecedor { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [StringLength(50)]
        public string cidade { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(150)]
        public string rua { get; set; }

        [StringLength(4)]
        public string numero { get; set; }

        [StringLength(30)]
        public string complemento { get; set; }

        public bool? statusEnderecoFornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fornecedor> fornecedor { get; set; }
    }
}
