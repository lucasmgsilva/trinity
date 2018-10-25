using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Factory
{
    public class ConnectionFactory
    {
        public SqlConnection getConnection()
        {
            try
            {
                //return new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-TVLFH4O\\SQLEXPRESS;Catalog=TRINITY;Integrated Security=True;"].ToString());
                //return new SqlConnection("Data Source=HIT\\DADOS;Initial Catalog=TRINITY;User ID=sa;Password=root");
                return new SqlConnection("Data Source=Lucas-PC\\SQLExpress;Initial Catalog=TRINITY;User ID=sa;Password=root");
            } catch (SqlException e)
            {
                throw e;
            }
        }

    }
}
