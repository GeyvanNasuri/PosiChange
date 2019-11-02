using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosiChange.Classes;
using MySql.Data.MySqlClient;

namespace PosiChange.Classes
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {
            // RegEx
            string strConn = @"User Id=root;Host=localhost;Database=posichange;Persist Security Info=True";
            MySqlConnection cn = new MySqlConnection(strConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }
    }
}
