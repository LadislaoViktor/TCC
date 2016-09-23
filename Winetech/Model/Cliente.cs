using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Winetech.Model
{
    class Cliente
    {
        private int codigoCliente { get; set; }
        private string razaoSocial { get; set; }
        private string nomeFantasiaCliente { get; set; }
        private string nomeCompletoCliente { get; set; }
        private string rG { get; set; }
        private string cPF { get; set; }
        private DateTime dataNascimento { get; set; }
        private string cnpj { get; set; }
        private string email { get; set; }
        private bool statusCliente { get; set; }
        private double limiteCredito { get; set; }
        private int codigoPedido { get; set; }
        private int codigoEnderecoCliente { get; set; }
        private int codigoContatoCliente { get; set; }

        public Cliente(int codigoCliente, string razaoSocial, 
            string nomeFantasiaCliente, string nomeCompletoCliente,
            string rG, string cPF, DateTime dataNascimento,
            string cnpj, string email, bool statusCliente,
            double limiteCredito, int codigoPedido,
            int codigoEnderecoCliente, int codigoContatoCliente)
        {
            this.codigoCliente = codigoCliente;
            this.razaoSocial = razaoSocial;
            this.nomeFantasiaCliente = nomeFantasiaCliente;
            this.nomeCompletoCliente = nomeCompletoCliente;
            this.rG = rG;
            this.cPF = cPF;
            this.dataNascimento = dataNascimento;
            this.cnpj = cnpj;
            this.email = email;
            this.statusCliente = statusCliente;
            this.limiteCredito = limiteCredito;                
        }
        public Cliente(string razaoSocial,
            string nomeFantasiaCliente, string nomeCompletoCliente,
            string rG, string cPF, DateTime dataNascimento,
            string cnpj, string email, bool statusCliente,
            double limiteCredito, int codigoPedido,
            int codigoEnderecoCliente, int codigoContatoCliente)
        {
            
                SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Winetech\Winetech\Winetech.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
                Conexao.Open();
                SqlCommand Comando = new SqlCommand("insert into enderecoCliente values(1,'PR','Colombo','Paloma','87654321','Rua das Camélias','79','Casa')");
                Conexao.Close();
            /*
            this.razaoSocial = razaoSocial;
            this.nomeFantasiaCliente = nomeFantasiaCliente;
            this.nomeCompletoCliente = nomeCompletoCliente;
            this.rG = rG;
            this.cPF = cPF;
            this.dataNascimento = dataNascimento;
            this.cnpj = cnpj;
            this.email = email;
            this.statusCliente = statusCliente;
            this.limiteCredito = limiteCredito;*/

        }

        
    }
       
}
