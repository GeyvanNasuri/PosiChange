using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_mudanca";
            com.Parameters.Add("sp_cod_pac", MySqlDbType.Int32).Value = Patient.Cod;
            com.Parameters.Add("sp_proxima", MySqlDbType.Timestamp).Value = Proxima;
            com.Parameters.Add("sp_cod_pos", MySqlDbType.Int32).Value = Position.Cod;
            com.Parameters.Add("sp_tempo", MySqlDbType.Timestamp).Value = Tempo;
	    com.Parameters.Add("sp_ativo", MySqlDbType.Bit).Value = Ativo;
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
