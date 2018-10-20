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
    public class FornecedorDAO
    {
        SqlConnection connection;

        public FornecedorDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            string query = "EXECUTE SP_INSERE_FORNECEDOR " +
                "@Logradouro, @Numero, @Complemento, @Bairro, @IdCidade, @Cep, @TelefoneFixo, @TelefoneCelular, @RazaoSocial, @NomeFantasia, @Cnpj, @Ie, @Im, @DataCadastro";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                cmd.Parameters.AddWithValue("@Complemento", fornecedor.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", fornecedor.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@TelefoneFixo", fornecedor.TelefoneFixo);
                cmd.Parameters.AddWithValue("@TelefoneCelular", fornecedor.TelefoneCelular);
                cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@Ie", fornecedor.Ie);
                cmd.Parameters.AddWithValue("@Im", fornecedor.Im);
                cmd.Parameters.AddWithValue("@DataCadastro", fornecedor.DataCadastro);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Fornecedor foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            } catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este CNPJ!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlteraFornecedor(Fornecedor fornecedor)
        {
            string query = "EXECUTE SP_ALTERA_FORNECEDOR " +
                "@IdFornecedor, @Logradouro, @Numero, @Complemento, @Bairro, @IdCidade, @Cep, @TelefoneFixo, @TelefoneCelular, @RazaoSocial, @NomeFantasia, @Cnpj, @Ie, @Im, @DataCadastro";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdFornecedor", fornecedor.IdFornecedor);
                cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                cmd.Parameters.AddWithValue("@Complemento", fornecedor.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", fornecedor.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", fornecedor.Cep);
                cmd.Parameters.AddWithValue("@TelefoneFixo", fornecedor.TelefoneFixo);
                cmd.Parameters.AddWithValue("@TelefoneCelular", fornecedor.TelefoneCelular);
                cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@Ie", fornecedor.Ie);
                cmd.Parameters.AddWithValue("@Im", fornecedor.Im);
                cmd.Parameters.AddWithValue("@DataCadastro", fornecedor.DataCadastro);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Fornecedor foi alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este CNPJ!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Fornecedor> GetListaFornecedores()
        {
            string query = "SELECT * FROM VW_SELECIONA_FORNECEDOR";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Fornecedor> listaFornecedores = new List<Fornecedor>();

                while (dtr.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.IdFornecedor = Convert.ToInt32(dtr["idFornecedor"].ToString());
                    fornecedor.Logradouro = dtr["logradouro"].ToString();
                    fornecedor.Numero = dtr["numero"].ToString();
                    fornecedor.Complemento = dtr["complemento"].ToString();
                    fornecedor.Bairro = dtr["bairro"].ToString();
                    fornecedor.Cep = dtr["cep"].ToString();
                    fornecedor.TelefoneFixo = dtr["telefoneFixo"].ToString();
                    fornecedor.TelefoneCelular = dtr["telefoneCelular"].ToString();
                    fornecedor.RazaoSocial = dtr["razaoSocial"].ToString();
                    fornecedor.NomeFantasia = dtr["nomeFantasia"].ToString();
                    fornecedor.Cnpj = dtr["cnpj"].ToString();
                    fornecedor.Ie = dtr["ie"].ToString();
                    fornecedor.Im = dtr["im"].ToString();
                    fornecedor.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"].ToString());

                    Estado estado = new Estado();
                    estado.IdEstado = Convert.ToInt32(dtr["idEstado"].ToString());
                    estado.estado = dtr["estado"].ToString();
                    estado.Uf = dtr["uf"].ToString();

                    Cidade cidade = new Cidade();
                    cidade.IdCidade = Convert.ToInt32(dtr["idCidade"].ToString());
                    cidade.cidade = dtr["cidade"].ToString();
                    cidade.Estado = estado;

                    fornecedor.Cidade = cidade;

                    listaFornecedores.Add(fornecedor);
                }

                dtr.Close();
                this.connection.Close();

                return listaFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public List<Fornecedor> GetListaFornecedoresChave(String palavraChave)
        {
            string query = "EXECUTE SP_BUSCA_FORNECEDOR @palavraChave";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@palavraChave", palavraChave);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Fornecedor> listaFornecedores = new List<Fornecedor>();

                while (dtr.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.IdFornecedor = Convert.ToInt32(dtr["idFornecedor"].ToString());
                    fornecedor.Logradouro = dtr["logradouro"].ToString();
                    fornecedor.Numero = dtr["numero"].ToString();
                    fornecedor.Complemento = dtr["complemento"].ToString();
                    fornecedor.Bairro = dtr["bairro"].ToString();
                    fornecedor.Cep = dtr["cep"].ToString();
                    fornecedor.TelefoneFixo = dtr["telefoneFixo"].ToString();
                    fornecedor.TelefoneCelular = dtr["telefoneCelular"].ToString();
                    fornecedor.RazaoSocial = dtr["razaoSocial"].ToString();
                    fornecedor.NomeFantasia = dtr["nomeFantasia"].ToString();
                    fornecedor.Cnpj = dtr["cnpj"].ToString();
                    fornecedor.Ie = dtr["ie"].ToString();
                    fornecedor.Im = dtr["im"].ToString();
                    fornecedor.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"].ToString());

                    Estado estado = new Estado();
                    estado.IdEstado = Convert.ToInt32(dtr["idEstado"].ToString());
                    estado.estado = dtr["estado"].ToString();
                    estado.Uf = dtr["uf"].ToString();

                    Cidade cidade = new Cidade();
                    cidade.IdCidade = Convert.ToInt32(dtr["idCidade"].ToString());
                    cidade.cidade = dtr["cidade"].ToString();
                    cidade.Estado = estado;

                    fornecedor.Cidade = cidade;

                    listaFornecedores.Add(fornecedor);
                }

                dtr.Close();
                this.connection.Close();

                return listaFornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public void DeletaFornecedor(int idFornecedor)
        {
            string query = "EXECUTE SP_DELETA_FORNECEDOR @IdFornecedor";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdFornecedor", idFornecedor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Fornecedor foi excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Não foi possível realizar a operação.\nEste FORNECEDOR está sendo referenciado em alguma COMPRA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
