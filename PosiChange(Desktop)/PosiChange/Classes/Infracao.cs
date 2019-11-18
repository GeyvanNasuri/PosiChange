using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    class Infracao
    {
        public int Cod { get; set; }
        public string Infringement { get; set; }
        internal Paciente Patient { get; set; }
        internal Enfermeiro Nurse { get; set; }
        public DateTime Data { get; set; }
        public bool Nova { get; set; }

        public Infracao() { }

        public Infracao(int cod, string infringement, Paciente patient, Enfermeiro nurse, DateTime data, bool nova)
        {
            Cod = cod;
            Infringement = infringement;
            Patient = patient;
            Nurse = nurse;
            Data = data;
            Nova = nova;
        }

        public Infracao(string infringement, Paciente patient, Enfermeiro nurse, DateTime data, bool nova)
        {
            Infringement = infringement;
            Patient = patient;
            Nurse = nurse;
            Data = data;
            Nova = nova;
        }

        public List<Infracao> ListaOcorrencia()
        {
            List<Infracao> infracoes = new List<Infracao>();
            var com = Banco.Abrir();
            com.CommandText = "select * from infracao where nov_inf = 1";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Infracao inf = new Infracao();
                inf.Cod = dr.GetInt32(0);
                inf.Infringement = dr.GetString(1);
                inf.Patient.Cod = dr.GetInt32(2);
                inf.Nurse.Cod = dr.GetInt32(3);
                inf.Data = dr.GetDateTime(4);
                inf.Nova = dr.GetBoolean(4);
                infracoes.Add(inf);
            }
            com.Connection.Close();
            return infracoes;
        }

        public List<Infracao> ListaInfracao()
        {
            List<Infracao> infracoes = new List<Infracao>();
            var com = Banco.Abrir();
            com.CommandText = "select * from infracao";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Infracao inf = new Infracao();
                inf.Cod = dr.GetInt32(0);
                inf.Infringement = dr.GetString(1);
                inf.Patient.Cod = dr.GetInt32(2);
                inf.Nurse.Cod = dr.GetInt32(3);
                inf.Data = dr.GetDateTime(4);
                inf.Nova = dr.GetBoolean(4);
                infracoes.Add(inf);
            }
            com.Connection.Close();
            return infracoes;
        }

        public bool Verificar(int cod)
        {
            bool verificado = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update infracao set nov_inf = 0 where cod_inf =" + cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                verificado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return verificado;
        }
        /*
        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_infracao";
            com.Parameters.Add("sp_infracao", MySqlDbType.VarChar).Value = Infringement;
            com.Parameters.Add("sp_cod_pac", MySqlDbType.Int32).Value = Patient.Cod;
            com.Parameters.Add("sp_cod_enf", MySqlDbType.Int32).Value = Nurse.Cod;
            com.Parameters.Add("sp_data", MySqlDbType.DateTime).Value = Data;
            com.Parameters.Add("sp_nova", MySqlDbType.Bit).Value = Nova;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }
        */
    }
}
