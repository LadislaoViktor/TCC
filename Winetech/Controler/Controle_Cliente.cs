using System;
using Winetech.Model;

namespace Winetech.Controler
{
    class Controle_Cliente
    {
        private bool inserirCliente(string razaoSocial,
            string nomeFantasiaCliente, string nomeCompletoCliente,
            string rG, string cPF, DateTime dataNascimento,
            string cnpj, string email, bool statusCliente,
            double limiteCredito, int codigoPedido,
            int codigoEnderecoCliente, int codigoContatoCliente) {
            Cliente C = new Cliente(razaoSocial,nomeFantasiaCliente,nomeCompletoCliente,
                rG,cPF,dataNascimento,
                cnpj,email,statusCliente,
                limiteCredito,codigoPedido,
                codigoEnderecoCliente,codigoContatoCliente);
            

            return true;
        }
    }
}
0