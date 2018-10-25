using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Factory;

namespace Trinity.Model.DAO
{
    public class VendaDAO
    {
        SqlConnection connection;

        public VendaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        /*public int GetUltimoIDVenda()
        {
            string query = "SELECT MAX(idVenda) as 'idVenda' FROM VENDA";
            try
            {
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                int idVenda = 1;

                if (dtr.Read())
                {
                    if (!dtr["idVenda"].ToString().Equals("NULL"))
                        idVenda = Convert.ToInt32(dtr["idVenda"].ToString());
                }
                return idVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }*/
    }
}
