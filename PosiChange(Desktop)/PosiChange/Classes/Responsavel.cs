using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    public class Responsavel
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Acesso { get; set; }
        internal Paciente Patient { get; set; }
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

        public Responsavel()
        {

        }

        public Responsavel(int cod, string nome, string rG, string cPF, string senha, string telefone, string email, bool acesso, Paciente patient)
        {
            Cod = cod;
            Nome = nome;
            RG = rG;
            CPF = cPF;
            Senha = senha;
            Telefone = telefone;
            Email = email;
            Acesso = acesso;
            Patient = patient;
        }

        public Responsavel(string nome, string rG, string cPF, string senha, string telefone, string email, bool acesso, Paciente patient)
        {
            Nome = nome;
            RG = rG;
            CPF = cPF;
            Senha = senha;
            Telefone = telefone;
            Email = email;
            Acesso = acesso;
            Patient = patient;
        }

        public void Insert()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_paciente";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_rg", MySqlDbType.VarChar).Value = RG;
            com.Parameters.Add("sp_cpf", MySqlDbType.VarChar).Value = CPF;
            com.Parameters.Add("sp_senha", MySqlDbType.VarChar).Value = GerarMD5(Senha);
            com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
            com.Parameters.Add("sp_email", MySqlDbType.VarChar).Value = Email;
            com.Parameters.Add("sp_acesso", MySqlDbType.Bit).Value = Acesso;
            com.Parameters.Add("sp_cod_pac", MySqlDbType.Int32).Value = Patient.Cod;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public List<Responsavel> ListaResponsavel(string nome)
        {
            List<Responsavel> responsaveis = new List<Responsavel>();
            var com = Banco.Abrir();
            com.CommandText = "select * from resposavel where nome = '%" + nome + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Responsavel res = new Responsavel();
                res.Cod = dr.GetInt32(0);
                res.Nome = dr.GetString(1);
                res.RG = dr.GetString(2);
                res.CPF = dr.GetString(3);
                res.Senha = dr.GetString(4);
                res.Telefone = dr.GetString(5);
                res.Email = dr.GetString(6);
                res.Acesso = dr.GetBoolean(7);
                responsaveis.Add(res);
            }
            return responsaveis;
        }

        public bool Alterar()
        {
            bool alterado = false;
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_update_responsavel";
            try
            {
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
                com.Parameters.Add("sp_rg", MySqlDbType.VarChar).Value = RG;
                com.Parameters.Add("sp_cpf", MySqlDbType.VarChar).Value = CPF;
                com.Parameters.Add("sp_senha", MySqlDbType.VarChar).Value = GerarMD5(Senha);
                com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
                com.Parameters.Add("sp_email", MySqlDbType.VarChar).Value = Email;
                com.Parameters.Add("sp_acesso", MySqlDbType.Bit).Value = Acesso;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return alterado;
        }
    }
}
