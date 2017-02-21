namespace Winetech
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cliente")]
    public partial class cliente
    {
        private string nomeFantasiaCliente;
        private string nomeCompletoCliente;
        private string cnpj;
        private string email;
        private double limiteCredito;
        private int codigoPedido;

        public cliente(string razaoSocial, string nomeFantasiaCliente, string nomeCompletoCliente, string rG, string cPF, DateTime dataNascimento, string cnpj, string email, bool statusCliente, double limiteCredito, int codigoPedido, int codigoEnderecoCliente, int codigoContatoCliente)
        {
            razaosocial = razaoSocial;
            this.nomeFantasiaCliente = nomeFantasiaCliente;
            this.nomeCompletoCliente = nomeCompletoCliente;
            rg = rG;
            cpf = cPF;
            datanascimento = dataNascimento;
            this.cnpj = cnpj;
            this.email = email;
            statuscliente = statusCliente;
            this.limiteCredito = limiteCredito;
            this.codigoPedido = codigoPedido;
            this.codigoEnderecoCliente = codigoEnderecoCliente;
            this.codigoContatoCliente = codigoContatoCliente;
        }

        [Key]
        public int codigoCliente { get; set; }

        [Required]
        [StringLength(300)]
        public string razaosocial { get; set; }

        [Required]
        [StringLength(80)]
        public string nomefantasia { get; set; }

        [Required]
        [StringLength(150)]
        public string nomecompleto { get; set; }

        [Required]
        [StringLength(14)]
        public string rg { get; set; }

        [Required]
        [StringLength(11)]
        public string cpf { get; set; }

        [Column(TypeName = "date")]
        public DateTime datanascimento { get; set; }

        [Required]
        [StringLength(14)]
        public string cnpjcliente { get; set; }

        [Required]
        [StringLength(150)]
        public string emailcliente { get; set; }

        public bool? statuscliente { get; set; }

        [Column(TypeName = "money")]
        public decimal limitecredito { get; set; }

        public int? codigoEnderecoCliente { get; set; }

        public int? codigoContatoCliente { get; set; }

        public int? codigoPedidoCliente { get; set; }

        public virtual contatoCliente contatoCliente { get; set; }

        public virtual enderecoCliente enderecoCliente { get; set; }

        public virtual pedidoCliente pedidoCliente { get; set; }
    }
}
