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
            //string strConn = @"User Id=root;password=usbw;Host=localhost;Database=posichange;Persist Security Info=True";
            string strConn = @"server=softkleen.com.br;user id=softklee_posichange;password=senac@posic19;persistsecurityinfo=True;database=softklee_posichange";
            MySqlConnection cn = new MySqlConnection(strConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }
    }
}
