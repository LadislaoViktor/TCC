//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winetech.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedidoCliente()
        {
            this.cliente = new HashSet<cliente>();
            this.produto = new HashSet<produto>();
        }
    
        public int codigoPedido { get; set; }
        public System.DateTime dataPedido { get; set; }
        public Nullable<bool> statusPedido { get; set; }
        public string statusPagamentoPedido { get; set; }
        public int quantidade { get; set; }
        public decimal precoUnitario { get; set; }
        public decimal totalPedido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produto { get; set; }
    }
}
