using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosiChange.Classes;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    public class Paciente
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public bool Ferida { get; set; }
        public string Descricao { get; set; }
        public string Situacao { get; set; }

        public Paciente()
        {

        }

        public Paciente(int cod, string nome, bool ferida, string descricao, string situacao)
        {
            Cod = cod;
            Nome = nome;
            Ferida = ferida;
            Descricao = descricao;
            Situacao = situacao;
        }

        public Paciente(string nome, bool ferida, string descricao, string situacao)
        {
            Nome = nome;
            Ferida = ferida;
            Descricao = descricao;
            Situacao = situacao;
        }

        public void Insert()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_paciente";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_apr_fer", MySqlDbType.Bit).Value = Ferida;
            com.Parameters.Add("sp_des_fer", MySqlDbType.VarChar).Value = Descricao;
            com.Parameters.Add("sp_sit_pac", MySqlDbType.VarChar).Value = Situacao;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public bool Alterar()
        {
            bool alterado = false;
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_update_paciente";
            try
            {
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
                com.Parameters.Add("sp_apr_fer", MySqlDbType.Bit).Value = Ferida;
                com.Parameters.Add("sp_des_fer", MySqlDbType.VarChar).Value = Descricao;
                com.Parameters.Add("sp_sit_pac", MySqlDbType.VarChar).Value = Situacao;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception Ex)
            {
                
                throw;
            }
            return alterado;
        }
        
        public List<Paciente> ListaPaciente(string nome)
        {
            List<Paciente> pacientes = new List<Paciente>();
            var com = Banco.Abrir();
            com.CommandText = "select * from paciente where nome = '%" + nome + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Paciente pac = new Paciente();
                pac.Cod = dr.GetInt32(0);
                pac.Nome = dr.GetString(1);
                pac.Ferida = dr.GetBoolean(2);
                pac.Descricao = dr.GetString(3);
                pac.Situacao = dr.GetString(4);
                pacientes.Add(pac);
            }
            com.Connection.Close();
            return pacientes;
        }
    }
}