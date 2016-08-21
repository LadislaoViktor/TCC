using System;
using CryptSharp;

namespace Winetech.Ajuda
{
    public static class Criptografia
    {
        public static string Codificacao(string senha) {
            return Crypter.MD5.Crypt(senha);
        }
        public static bool Compara(string senha,string hash) {
            return Crypter.CheckPassword(senha, hash);
        }        
    }
}
