using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace PosiChange.Classes
{
    public class Posicao
    {
        public int Cod { get; set; }
        public string Position { get; set; }
        public byte[] Imagem { get; set; }

        public Posicao() { }

        public Posicao(int cod, string position, byte[] imagem)
        {
            Cod = cod;
            Position = position;
            Imagem = imagem;
        }

        public Posicao(string position, byte[] imagem)
        {
            Position = position;
            Imagem = imagem;
        }

        public void Inserir()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_insert_posicao";
            com.Parameters.Add("sp_posicao", MySqlDbType.VarChar).Value = Position;
            com.Parameters.Add("sp_img", MySqlDbType.LongBlob).Value = Imagem;
            Cod = Convert.ToInt32(com.ExecuteScalar());
            com.Connection.Close();
        }

        public List<Posicao> ListaPosicao(string position)
        {
            List<Posicao> posicoes = new List<Posicao>();
            var com = Banco.Abrir();
            com.CommandText = "select * from posicao where posicao = '%" + position + "%'";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Posicao pos = new Posicao();
                pos.Cod = dr.GetInt32(0);
                pos.Position = dr.GetString(1);
                //pos.Imagem = dr.GetByte(3);
                com.ExecuteNonQuery();
                com.Connection.Close();
                posicoes.Add(pos);
            }
            return posicoes;
        }

        public List<Posicao> TodasPosicoes()
        {
            List<Posicao> posicoes = new List<Posicao>();
            var com = Banco.Abrir();
            com.CommandText = "select * from posicao";
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                Posicao pos = new Posicao();
                pos.Cod = dr.GetInt32(0);
                pos.Position = dr.GetString(1);
                //pos.Imagem = dr.GetByte(3);
                com.ExecuteNonQuery();
                com.Connection.Close();
                posicoes.Add(pos);
            }
            return posicoes;
        }

        public bool Alterar(string posicao)
        {
            bool alterado = false;
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_update_posicao";
            try
            {
                com.Parameters.Add("sp_cod", MySqlDbType.Int32).Value = Cod;
                com.Parameters.Add("sp_posicao", MySqlDbType.VarChar).Value = Position;
                com.Parameters.Add("sp_img", MySqlDbType.LongBlob).Value = Imagem;
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