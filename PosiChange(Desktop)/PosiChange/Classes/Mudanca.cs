using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Mudanca
    {
        internal Paciente Patient { get; set; }
        public DateTime Proxima { get; set; }
        internal Posicao Position { get; set; }
        public DateTime Tempo { get; set; }
        public bool Ativo { get; set; }

        public Mudanca() { }

        public Mudanca(Paciente patient, DateTime proxima, Posicao position, DateTime tempo, bool ativo)
        {
            Patient = patient;
            Proxima = proxima;
            Position = position;
            Tempo = tempo;
            Ativo = ativo;
        }

        public void Inserir(Paciente patient, DateTime proxima, Posicao position, DateTime tempo, bool ativo)
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into mudancas values(null, " + patient.Cod + ", '" + proxima + "', " + position.Cod + ", '" + tempo + ", " + ativo + "')";
            com.ExecuteNonQuery();
            com.Connection.Close();

        }
    }
}
