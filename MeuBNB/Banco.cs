using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduar\OneDrive\Desktop\MeuBNB\MeuBNB\Database1.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            return cnn;
        }
    }
}
