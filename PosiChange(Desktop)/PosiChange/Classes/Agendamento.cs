using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosiChange.Classes;

namespace PosiChange.Classes
{
    class Agendamento
    {
        public int Cod { get; set; }
        internal Responsavel Responsible { get; set; }
        public DateTime Dia { get; set; }
        public bool Novo { get; set; }

        public Agendamento()
        {

        }

        public Agendamento(int cod, Responsavel responsible, DateTime dia, bool novo)
        {
            Cod = cod;
            Responsible = responsible;
            Dia = dia;
            Novo = novo;
        }

        public Agendamento(Responsavel responsible, DateTime dia, bool novo)
        {
            Responsible = responsible;
            Dia = dia;
            Novo = novo;
        }

        public bool Agenda()
        {
            bool agendou = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "select * from agendamento where nov_age = 1";
                com.ExecuteNonQuery();
                com.Connection.Close();
                agendou = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return agendou;
        }

        public List<Agendamento> NovaVisita()
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            var com = Banco.Abrir();
            com.CommandText = "select * from agendamento where nov_age = 1";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Agendamento age = new Agendamento();
                age.Cod = dr.GetInt32(0);
                age.Responsible.Cod = dr.GetInt32(1);
                age.Dia = dr.GetDateTime(2);
                age.Novo = dr.GetBoolean(3);
                com.ExecuteNonQuery();
                com.Connection.Close();
                agendamentos.Add(age);
            }
            
            return agendamentos;
        }

        public List<Agendamento> HistoricoVisita()
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            var com = Banco.Abrir();
            com.CommandText = "select * from agendamento";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Agendamento age = new Agendamento();
                age.Cod = dr.GetInt32(0);
                age.Responsible.Cod = dr.GetInt32(1);
                age.Dia = dr.GetDateTime(2);
                age.Novo = dr.GetBoolean(3);
                com.ExecuteNonQuery();
                com.Connection.Close();
                agendamentos.Add(age);
            }
            return agendamentos;
        }

        public bool VisitaFeita(int cod)
        {
            bool feita = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update agendamento set nov_age = 0 where cod_age =" + cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                feita = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return feita;
        }
    }
}
