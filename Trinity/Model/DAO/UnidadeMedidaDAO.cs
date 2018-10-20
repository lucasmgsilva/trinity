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
    public class UnidadeMedidaDAO
    {
        SqlConnection connection;

        public UnidadeMedidaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public void AdicionaUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            string query = "EXECUTE SP_INSERE_UNIDADEMEDIDA "
                           + "@Sigla, @UnidadeMedida";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Sigla", unidadeMedida.Sigla);
                cmd.Parameters.AddWithValue("@UnidadeMedida", unidadeMedida.unidadeMedida);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Unidade de Medida foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta SIGLA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<UnidadeMedida> GetListaUnidadesMedida()
        {
            string query = "SELECT * FROM VW_SELECIONA_UNIDADEMEDIDA ";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<UnidadeMedida> listaUnidadesMedida = new List<UnidadeMedida>();

                while (dtr.Read())
                {
                    UnidadeMedida unidadeMedda = new UnidadeMedida();
                    unidadeMedda.IdUnidadeMedida = Convert.ToInt32(dtr["idUnidadeMedida"].ToString());
                    unidadeMedda.Sigla = dtr["sigla"].ToString();
                    unidadeMedda.unidadeMedida = dtr["unidadeMedida"].ToString();
                    listaUnidadesMedida.Add(unidadeMedda);
                }

                dtr.Close();
                this.connection.Close();

                return listaUnidadesMedida;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }
    }
}
