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

        public void AdicionaVenda(Venda venda)
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
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    int idVenda = Convert.ToInt32(dtr["idVenda"].ToString());

                    query = "EXECUTE SP_INSERE_ITEMVENDIDO @IdVenda, @IdProduto, @QtdVendida, @ValorVenda";
                    cmd = new SqlCommand(query, this.connection);
                    cmd.Parameters.AddWithValue("@IdVenda", idVenda);

                    foreach (var ItemVendido in venda.ListaItemVendidos)
                    {
                        cmd.Parameters.AddWithValue("@IdProduto", ItemVendido.Produto.IdProduto);
                        cmd.Parameters.AddWithValue("@QtdVendida", ItemVendido.QtdVendida);
                        cmd.Parameters.AddWithValue("@ValorVenda", ItemVendido.ValorVenda);
                        cmd.ExecuteNonQuery();
                    }
                }

                dtr.Close();
                this.connection.Close();
                MessageBox.Show("A venda foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
