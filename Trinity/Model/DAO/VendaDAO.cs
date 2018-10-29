using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Factory;
using Trinity.Model.Bean;

namespace Trinity.Model.DAO
{
    public class VendaDAO
    {
        SqlConnection connection;

        public VendaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public void AdicionaVenda(List<ItemVendido> listaItensVendidos)
        {
            string query = "EXECUTE SP_INSERE_VENDA " +
                           "@IdUsuario, @IdCliente, @DataVenda, @Desconto";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdUsuario", venda.Usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@IdCliente", venda.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O cargo foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este CARGO!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
