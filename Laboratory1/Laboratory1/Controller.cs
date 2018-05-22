using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    class Controller
    {
        public Controller()
        {
            sqlConnection = new SqlConnection("Data Source=VLANGA-LPT\\SQLEXPRESS;Initial Catalog=OutdoorGear;Integrated Security=True");
        }

        private SqlConnection sqlConnection;

    }
}
