using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    class Infracao
    {
        public int Cod { get; set; }
        public string Infringement { get; set; }
        internal Paciente Patient { get; set; }
        internal Enfermeiro Nurse { get; set; }
        public bool Nova { get; set; }

        public Infracao()
        {

        }

        public Infracao(int cod, string infringement, Paciente patient, Enfermeiro nurse, bool nova)
        {
            Cod = cod;
            Infringement = infringement;
            Patient = patient;
            Nurse = nurse;
            Nova = nova;
        }

        public Infracao(string infringement, Paciente patient, Enfermeiro nurse, bool nova)
        {
            Infringement = infringement;
            Patient = patient;
            Nurse = nurse;
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
                inf.Nova = dr.GetBoolean(4);
                infracoes.Add(inf);
            }
            com.Connection.Close();
            return infracoes;
        }

        public bool Verificar(bool nova)
        {
            bool verificado = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update infracao set nov_inf = " + nova + " where cod_inf =" + Cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                verificado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return verificado;
        }
    }
}
