using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public Atendente()
        {

        }

        public Atendente(int codAtendente, string nome, string login, string senha, DateTime intervalo, string turno, string telefone)
        {
            CodAtendente = codAtendente;
            Nome = nome;
            Login = login;
            Senha = senha;
            Intervalo = intervalo;
            Turno = turno;
            Telefone = telefone;
        }

        public Atendente(string nome, string login, string senha, DateTime intervalo, string turno, string telefone)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Intervalo = intervalo;
            Turno = turno;
            Telefone = telefone;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_atendente";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_login", MySqlDbType.VarChar).Value = Login;
            com.Parameters.Add("sp_senha", MySqlDbType.VarChar).Value = GerarMd5(Senha);
            com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
            com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
            com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
        }

        public bool EfetuarLogin(string _login, string _senha)
        {
            //bool valido = false;
            var com = new Banco();
            string erro = String.Empty;
            var comm = com.TentarConexao(out erro);
            comm.CommandText = "select * from usuarios where login = '" + _login
                + "' and senha = '" + GerarMD5(_senha) + "'";
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Senha = dr.GetString(2);
                Nivel = dr.GetInt32(4);
                return /*valido =*/ true;
            }
            return false /*valido*/;
        }
    }
}
