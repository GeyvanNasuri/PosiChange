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

        public void Insert(string andar, string room)
        {
            var com = Banco.Abrir();
            com.CommandText = "insert into quarto values(null, '" + andar + "', '" + room + "');";
            com.ExecuteNonQuery();
            com.Connection.Close();
        }

        public bool InserirPaciente(Paciente patient, int cod)
        {
            bool alterado = false;
            var com = Banco.Abrir();
            try
            {
                com.CommandText = "update quarto set _pac = " + patient.Cod + " where cod_quarto = " + cod;
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

        public List<Quarto> ListaQuarto(Paciente patient)
        {
            List<Quarto> quartos = new List<Quarto>();
            var com = Banco.Abrir();
            com.CommandText = "select * from quarto where _pac = " + patient.Cod;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Quarto qua = new Quarto();
                qua.Cod = dr.GetInt32(0);
                qua.Andar = dr.GetString(1);
                qua.Room = dr.GetString(2);
                qua.Patient.Cod = dr.GetInt32(3);
                com.ExecuteNonQuery();
                com.Connection.Close();
                quartos.Add(qua);
            }
            return quartos;
        }
    }
}
