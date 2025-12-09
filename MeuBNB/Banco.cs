using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MeuBNB
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strCon = ConfigurationManager.ConnectionStrings["ConexaoMeuBNB"].ConnectionString;
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            return cnn;
        }
    }
}
