using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosiChange.Classes;

namespace PosiChange.Classes
{
    public class Enfermeiro
    {


        public int Cod { get; set; }
        public string Nome { get; set; }
        public int Coren { get; set; }
        public string Turno { get; set; }
        public DateTime Intervalo { get; set; }
        public string Telefone { get; set; }
        internal Nivel Level { get; set; }
        
        public Enfermeiro()
        {
            
        }

        public Enfermeiro(int codEnfermeiro, string nome, int coren, string turno, DateTime intervalo, string telefone, Nivel level)
        {
            Cod = codEnfermeiro;
            Nome = nome;
            Coren = coren;
            Turno = turno;
            Intervalo = intervalo;
            Telefone = telefone;
            Level = level;
        }

        public Enfermeiro(string nome, int coren, string turno, DateTime intervalo, string telefone, Nivel level)
        {
            Nome = nome;
            Coren = coren;
            Turno = turno;
            Intervalo = intervalo;
            Telefone = telefone;
            Level = level;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_enfermeiro";
            com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
            com.Parameters.Add("sp_coren", MySqlDbType.Int32).Value = Coren;
            com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
            com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
            com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
            com.Parameters.Add("sp_cod_nivel", MySqlDbType.Int32).Value = Level;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public bool Alterar()
        {
            var com = Banco.Abrir();
            bool alterado = false;
            try
            {
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = "sp_update_enfermeiro";
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_nome", MySqlDbType.VarChar).Value = Nome;
                com.Parameters.Add("sp_coren", MySqlDbType.Int32).Value = Coren;
                com.Parameters.Add("sp_intervalo", MySqlDbType.Time).Value = Intervalo;
                com.Parameters.Add("sp_turno", MySqlDbType.VarChar).Value = Turno;
                com.Parameters.Add("sp_telefone", MySqlDbType.VarChar).Value = Telefone;
                com.Parameters.Add("sp_cod_nivel", MySqlDbType.Int32).Value = Level.Cod;
                com.ExecuteNonQuery();
                com.Connection.Close();
                alterado = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return alterado;
        }
        public List<Enfermeiro> ListaEnfermeiro(string nome)
        {
            List<Enfermeiro> enfermeiros = new List<Enfermeiro>();
            
            var com = Banco.Abrir();
            com.CommandText = "select * from enfermeiro where nome = '%" + nome + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Enfermeiro enf = new Enfermeiro();
                enf.Cod = dr.GetInt32(0);
                enf.Nome = dr.GetString(1);
                enf.Coren = dr.GetInt32(2);
                enf.Intervalo = dr.GetDateTime(3);
                enf.Turno = dr.GetString(4);
                enf.Telefone = dr.GetString(5);
                enf.Level.Cod = dr.GetInt32(6);
                enfermeiros.Add(enf);
            }
            com.Connection.Close();
            return enfermeiros;
        }
    }
}
