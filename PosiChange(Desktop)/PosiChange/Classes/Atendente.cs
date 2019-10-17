using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Atendente
    {
        public int CodAtendente { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime Intervalo { get; set; }
        public string Turno { get; set; }
        public string Telefone { get; set; }
        private string GerarMd5(string senha)
        {
            var md5hash = MD5.Create();
            byte[] chave = md5hash.ComputeHash(Encoding.UTF32.GetBytes(senha));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < chave.Length; i++)
            {
                builder.Append(chave[i].ToString("X2"));
            }
            return builder.ToString();
        }




    }
}
