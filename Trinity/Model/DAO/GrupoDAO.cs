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
    public class GrupoDAO
    {
        SqlConnection connection;

        public GrupoDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public bool AdicionaGrupo(Grupo grupo)
        {
            string query = "EXECUTE SP_INSERE_GRUPO "
                           + "@Grupo";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Grupo", grupo.grupo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Grupo foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            } catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este GRUPO!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool Alterar(Grupo grupo)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("EXECUTE SP_ALTERA_GRUPO @Id, @Grupo", this.connection);
                cmd.Parameters.AddWithValue("@Id", grupo.IdGrupo);
                cmd.Parameters.AddWithValue("@Grupo", grupo.grupo);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um erro.\nErro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro.\nErro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Grupo Pesquisar(int id = 0)
        {
            Grupo grupo = null;
            try
            {
                StringBuilder sb = new StringBuilder();
                if (id > 0)
                    sb.Append("SELECT * FROM GRUPO WHERE idGrupo = " + id);
                else
                    sb.Append("SELECT TOP 1 * FROM GRUPO ORDER BY idGrupo DESC");

                this.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), this.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    grupo = new Grupo();

                    if (dr["idGrupo"] != DBNull.Value)
                        grupo.IdGrupo = Convert.ToInt32(dr["idGrupo"]);

                    if (dr["grupo"] != DBNull.Value)
                        grupo.grupo = dr["grupo"].ToString();
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
            return grupo;
        }

        public List<Grupo> GetListaGrupos()
        {
            string query = "SELECT * FROM VW_SELECIONA_GRUPO";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<Grupo> listaGrupo = new List<Grupo>();

                while (dtr.Read())
                {
                    Grupo grupo = new Grupo();
                    grupo.IdGrupo = Convert.ToInt32(dtr["idGrupo"].ToString());
                    grupo.grupo = dtr["grupo"].ToString();
                    listaGrupo.Add(grupo);
                }

                dtr.Close();
                this.connection.Close();

                return listaGrupo;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM GRUPO WHERE idGrupo = @id", this.connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                return true;

            }
            catch(SqlException sqlEx)
            {
                if(sqlEx.Number == 547)
                    MessageBox.Show("Não é possível deletar este gupo pois ele está sendo usado em algum produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
