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

        public bool AdicionaUnidadeMedida(UnidadeMedida unidadeMedida)
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
                return true;
            }
            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta SIGLA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
        }

        public bool AlterarUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("EXECUTE SP_ALTERA_UNIDADEMEDIDA @Id, @Sigla, @UnidadeMedida", this.connection);
                cmd.Parameters.AddWithValue("@Id", unidadeMedida.IdUnidadeMedida);
                cmd.Parameters.AddWithValue("@Sigla", unidadeMedida.Sigla);
                cmd.Parameters.AddWithValue("@UnidadeMedida", unidadeMedida.unidadeMedida);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta SIGLA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Ocorreu um erro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
            }
        }

        public UnidadeMedida Pesquisar(string sigla = "")
        {
            UnidadeMedida un = null;
            try
            {
                StringBuilder sb = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(sigla))
                    sb.Append("SELECT * FROM UNIDADEMEDIDA WHERE sigla = '" + sigla + "'");
                else
                    sb.Append("SELECT TOP 1 * FROM UNIDADEMEDIDA ORDER BY idUnidadeMedida DESC");

                this.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), this.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    un = new UnidadeMedida();

                    if (dr["idUnidadeMedida"] != DBNull.Value)
                        un.IdUnidadeMedida = Convert.ToInt32(dr["idUnidadeMedida"]);

                    if (dr["sigla"] != DBNull.Value)
                        un.Sigla = dr["sigla"].ToString();

                    if (dr["unidadeMedida"] != DBNull.Value)
                        un.unidadeMedida = dr["unidadeMedida"].ToString();
                    
                }
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um erro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.connection.Close();
            }

            return un;
        }

        public bool DeletaUnidadeMedida(int Id)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UNIDADEMEDIDA WHERE idUnidadeMedida = @Id", this.connection);
                cmd.Parameters.AddWithValue("@Id", Id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                    MessageBox.Show("Não foi possível excluir esta unidade de medida pois ela está sendo usada em algum produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Ocorreu um erro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool verificaSigla(string sigla)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT CASE WHEN sigla = @sigla THEN 1 ELSE 0 END AS State FROM UNIDADEMEDIDA", this.connection);
                cmd.Parameters.AddWithValue("@sigla", sigla);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["State"] != DBNull.Value && Convert.ToInt32(dr["State"]) == 1)
                        return true;
                    return false;
                        
                }
                return false;
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a sigla.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a sigla.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
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
