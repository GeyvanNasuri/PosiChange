using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    class Historico
    {
        public int Cod { get; set; }
        public string Razao { get; set; }
        internal Paciente Patient { get; set; }
        public DateTime Registro { get; set; }

        public Historico()
        {

        }

        public Historico(int cod, string razao, Paciente patient, DateTime registro)
        {
            Cod = cod;
            Razao = razao;
            Patient = patient;
            Registro = registro;
        }

        public Historico(string razao, Paciente patient, DateTime registro)
        {
            Razao = razao;
            Patient = patient;
            Registro = registro;
        }

        public void Insert()
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into historico_paciente values(null, " + Razao + ", " + Patient.Cod + ", now())";
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }
    }
}