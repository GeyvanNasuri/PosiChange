using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    public class Atendente
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime Intervalo { get; set; }
        public string Turno { get; set; }
        public string Telefone { get; set; }
        public bool Acesso { get; set; }
        internal Nivel Level { get; set; }
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

        public Atendente(int cod, string nome, string rg, string cpf, string login, string senha, DateTime intervalo, string turno, string telefone, bool acesso, Nivel level)
        {
            Cod = cod;
            Nome = nome;
            RG = rg;
            CPF = cpf;
            Login = login;
            Senha = senha;
            Intervalo = intervalo;
            Turno = turno;
            Telefone = telefone;
            Acesso = acesso;
            Level = level;
        }

        public Atendente(string nome, string login, string rg, string cpf, string senha, DateTime intervalo, string turno, string telefone, bool acesso, Nivel level)
        {
            Nome = nome;
            RG = rg;
            CPF = cpf;
            Login = login;
            Senha = senha;
            Intervalo = intervalo;
            Turno = turno;
            Telefone = telefone;
            Acesso = acesso;
            Level = level;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_atendente";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_rg", MySqlDbType.VarChar).Value = RG;
            com.Parameters.Add("sp_cpf", MySqlDbType.VarChar).Value = CPF;
            com.Parameters.Add("sp_login", MySqlDbType.VarChar).Value = Login;
            com.Parameters.Add("sp_senha", MySqlDbType.VarChar).Value = GerarMd5(Senha);
            com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
            com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
            com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
            com.Parameters.Add("sp_acesso", MySqlDbType.Bit).Value = Acesso;
            com.Parameters.Add("sp_cod_nivel", MySqlDbType.Int32).Value = Level.Cod;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public bool EfetuarLogin(string login, string senha)
        {
            var com = Banco.Abrir();
            com.CommandText = "select * from atendimento where login = '" + login + "' and senha = '" + GerarMd5(senha) + "'";
            var dr = com.ExecuteReader();
            bool logado = false;
            try
            {
                while (dr.Read())
                {
                    Cod = dr.GetInt32(0);
                    Nome = dr.GetString(1);
                    RG = dr.GetString(2);
                    CPF = dr.GetString(3);
                    Login = dr.GetString(4);
                    Senha = dr.GetString(5);
                    Intervalo = dr.GetDateTime(6);
                    Turno = dr.GetString(7);
                    Telefone = dr.GetString(8);
                    com.Connection.Close();
                    logado = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return logado;
        }
        public bool Alterar()
        {
            var com = Banco.Abrir();
            bool alterado = false;
            try
            {
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = "sp_update_atendente";
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
                com.Parameters.Add("sp_senha", MySqlDbType.VarChar).Value = GerarMd5(Senha);
                com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
                com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
                com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
                com.Parameters.Add("sp_acesso", MySqlDbType.Bit).Value = Acesso;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return alterado;
        }
        public List<Atendente> ListaAtendente(string nome)
        {
            List<Atendente> atendentes = new List<Atendente>();

            var com = Banco.Abrir();
            com.CommandText = "select * from atendente where nome = '%" + nome + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Atendente ate = new Atendente();
                ate.Cod = dr.GetInt32(0);
                ate.Nome = dr.GetString(1);
                ate.RG = dr.GetString(2);
                ate.CPF = dr.GetString(3);
                ate.Login = dr.GetString(4);
                ate.Senha = dr.GetString(5);
                ate.Intervalo = dr.GetDateTime(6);
                ate.Turno = dr.GetString(7);
                ate.Telefone = dr.GetString(8);
                ate.Acesso = dr.GetBoolean(9);
                atendentes.Add(ate);
            }
            com.Connection.Close();
            return atendentes;
        }
    }
}