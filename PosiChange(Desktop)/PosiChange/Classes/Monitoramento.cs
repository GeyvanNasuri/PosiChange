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
        public string Razao { get; set; }
        internal Paciente Patient { get; set; }
        public DateTime Registro { get; set; }

        public Monitoramento() { }

        public Monitoramento(int cod, string razao, Paciente patient, DateTime registro)
        {
            Cod = cod;
            Razao = razao;
            Patient = patient;
            Registro = registro;
        }

        public Monitoramento(string razao, Paciente patient, DateTime registro)
        {
            Razao = razao;
            Patient = patient;
            Registro = registro;
        }

        public void Insert(string razao, Paciente patient)
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into Monitoramento_paciente values(null, " + razao + ", " + patient.Cod + ", now())";
            Cod = Convert.ToInt32(com.ExecuteScalar());
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
                Monitoramento his = new Monitoramento();
                his.Cod = dr.GetInt32(0);
                his.Razao = dr.GetString(1);
                his.Patient.Cod = dr.GetInt32(2);
                his.Registro = dr.GetDateTime(3);
                Monitoramentos.Add(his);
            }
            com.Connection.Close();
            return Monitoramentos;
        }

    }
}
