using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Responsavel
    {
        public int CodResponsavel { get; set; }
        internal List<Paciente> Paciente { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime Agendamento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        private string GerarMD5(string senha)
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
