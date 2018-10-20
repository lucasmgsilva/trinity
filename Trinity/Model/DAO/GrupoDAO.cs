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

        public void AdicionaGrupo(Grupo grupo)
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
                this.connection.Close();

            } catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este GRUPO!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
