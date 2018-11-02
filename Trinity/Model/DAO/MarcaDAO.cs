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
    public class MarcaDAO
    {
        SqlConnection connection;

        public MarcaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public Marca Pesquisar(int id = 0)
        {
            Marca marca = null;

            try
            {
                StringBuilder sb = new StringBuilder();

                if (id > 0)
                    sb.Append("SELECT * FROM MARCA WHERE idMarca = " + id);
                else
                    sb.Append("SELECT TOP 1 * FROM MARCA ORDER BY idMarca DESC");

                this.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), this.connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    marca = new Marca();

                    if (dr["idMarca"] != DBNull.Value)
                        marca.IdMarca = Convert.ToInt32(dr["idMarca"]);

                    if (dr["marca"] != DBNull.Value)
                        marca.marca = dr["marca"].ToString();
                }
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um erro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.connection.Close();
            }
            return marca;
        }

        public bool AdicionaMarca (Marca marca)
        {
            string query = "EXECUTE SP_INSERE_MARCA "
                           + "@Marca";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Marca", marca.marca);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Marca foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            } catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta MARCA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool AlteraMarca(Marca marca)
        {
            string query = "EXECUTE SP_ALTERA_MARCA @Id, @Marca";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Id", marca.IdMarca);
                cmd.Parameters.AddWithValue("@Marca", marca.marca);
                cmd.ExecuteNonQuery();

                MessageBox.Show("A Marca foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta MARCA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<Marca> GetListaMarcas()
        {
            string query = "SELECT * FROM VW_SELECIONA_MARCA";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<Marca> listaMarcas = new List<Marca>();

                while (dtr.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = Convert.ToInt32(dtr["idMarca"].ToString());
                    marca.marca = dtr["marca"].ToString();
                    listaMarcas.Add(marca);
                }

                dtr.Close();
                this.connection.Close();

                return listaMarcas;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public bool DeletaMarca(int id)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM MARCA WHERE idMarca = @id", this.connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                    MessageBox.Show("Não é possível deletar esta marca pois ela está sendo usada em algum produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Ocorreu um erro na deleção.\nErro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na deleção.\nErro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
