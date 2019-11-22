using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Monitoramento
    {
        public int Cod { get; set; }
        public string DescricaoAtual { get; set; }
        internal Paciente Patient { get; set; }

        public Monitoramento() { }

        public Monitoramento(int cod,string descricaoAtual, Paciente patient)
        {
            Cod = cod;
            DescricaoAtual = descricaoAtual;
            Patient = patient;
        }
        
        public Monitoramento(string descricaoAtual, Paciente patient)
        {
            DescricaoAtual = descricaoAtual;
            Patient = patient;
        }

        public void Insert(string descricaoAtual, Paciente patient)
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into monitoramento_paciente values(null, " + patient.Descricao + ", " + descricaoAtual + ", " + patient.Cod + ")";
            //Cod = Convert.ToInt32(com.ExecuteScalar());
            com.ExecuteNonQuery();
            com.Connection.Close();
        }

        public List<Monitoramento> ListaMonitoramento()
        {
            List<Monitoramento> Monitoramentos = new List<Monitoramento>();
            var com = Banco.Abrir();
            com.CommandText = "select * from Monitoramento_paciente";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Monitoramento mo = new Monitoramento();
                mo.Cod = dr.GetInt32(0);
                mo.Patient.Descricao = dr.GetString(1);
                mo.DescricaoAtual = dr.GetString(2);
                mo.Patient.Cod = dr.GetInt32(3);
                Monitoramentos.Add(mo);
                com.ExecuteNonQuery();
                com.Connection.Close();
            }
            com.Connection.Close();
            return Monitoramentos;
        }

    }
}
