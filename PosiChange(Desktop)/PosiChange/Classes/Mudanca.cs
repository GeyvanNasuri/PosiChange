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
            com.CommandText = "insert into mudancas values(" + patient.Cod + ", '" + proxima + "', " + position.Cod + ", '" + tempo + ", " + ativo + "')";
            com.ExecuteNonQuery();
            com.Connection.Close();

        }

        public bool Alterar(Paciente patient, DateTime proxima, Posicao position, DateTime tempo, bool ativo)
        {
            bool alterado = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update mudancas set proxima = '" + proxima + "', _cod_posicao = " + position.Cod +
                    ", minimo = '" + tempo + "', ativo = " + ativo + " where _cod_pac = " + patient.Cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return alterado;
        }
    }
}
