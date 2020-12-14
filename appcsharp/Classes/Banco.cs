using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace appcsharp.Classes
{
    public static class Banco
    {
        public static MySqlCommand Abrir() 
        {
            MySqlCommand cmd = new MySqlCommand();
            string strCon = @"server=softkleen.com.br;database=wellington_fcinco;user id =fcincoon; passoword=bm*5rN60 ";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            cmd.Connection = cn;
            return cmd;
        }
    }
}
