using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Quarto
    {
        public int Cod { get; set; }
        public string Andar { get; set; }
        public string Room { get; set; }
        internal Paciente Patient { get; set; }

        public Quarto()
        {

        }

        public Quarto(string andar, string room, Paciente patient)
        {
            Andar = andar;
            Room = room;
            Patient = patient;
        }

        public void Insert()
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into quarto values(null, '" + Andar + "', '" + Room + "');";
            com.Connection.Close();
        }

        public bool InserirPaciente()
        {
            bool alterado = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update quarto set _pac = " + Patient.Cod + " where cod_quarto = " + Cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return alterado;
        }
    }
}
