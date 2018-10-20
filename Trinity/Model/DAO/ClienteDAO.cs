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
    public class ClienteDAO
    {
        SqlConnection connection;

        public ClienteDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        #region Adicionar
        public void AdicionaClientePF(ClientePF clientepf)
        {
            string query = "EXECUTE SP_INSERE_CLIENTEPF " +
                "@Logradouro, @Numero, @Complemento, @Bairro, @IdCidade, @Cep, @TelefoneFixo, @TelefoneCelular, @Observacoes, @DataCadastro, @Nome, @Apelido, @Sexo, @Cpf, @Rg, @DataNascimento";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Logradouro", clientepf.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", clientepf.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clientepf.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", clientepf.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", clientepf.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", clientepf.Cep);
                cmd.Parameters.AddWithValue("@TelefoneFixo", clientepf.TelefoneFixo);
                cmd.Parameters.AddWithValue("@TelefoneCelular", clientepf.TelefoneCelular);
                cmd.Parameters.AddWithValue("@Observacoes", clientepf.Observacoes);
                cmd.Parameters.AddWithValue("@DataCadastro", clientepf.DataCadastro);
                cmd.Parameters.AddWithValue("@Nome", clientepf.Nome);
                cmd.Parameters.AddWithValue("@Apelido", clientepf.Apelido);
                cmd.Parameters.AddWithValue("@Sexo", clientepf.Sexo);
                cmd.Parameters.AddWithValue("@Cpf", clientepf.Cpf);
                cmd.Parameters.AddWithValue("@Rg", clientepf.Rg);
                cmd.Parameters.AddWithValue("@DataNascimento", clientepf.DataNascimento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Cliente foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com este CNPJ!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int AdicionaClientePJ(ClientePJ clientePj)
        {
            string query = "EXECUTE SP_INSERE_CLIENTEPJ " +
               "@Logradouro, @Numero, @Complemento, @Bairro, @IdCidade, @Cep, @TelefoneFixo, @TelefoneCelular, @Observacoes, " +
               "@DataCadastro, @Razao, @Fant, @Cnpj, @Ie, @Im, @DataAbertura";

            int res = 0;

            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Logradouro", clientePj.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", clientePj.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clientePj.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", clientePj.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", clientePj.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", clientePj.Cep);
                cmd.Parameters.AddWithValue("@TelefoneFixo", clientePj.TelefoneFixo);
                cmd.Parameters.AddWithValue("@TelefoneCelular", clientePj.TelefoneCelular);
                cmd.Parameters.AddWithValue("@Observacoes", clientePj.Observacoes);
                cmd.Parameters.AddWithValue("@DataCadastro", clientePj.DataCadastro);
                cmd.Parameters.AddWithValue("@Razao", clientePj.RazaoSocial);
                cmd.Parameters.AddWithValue("@Fant", clientePj.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cnpj", clientePj.Cnpj);
                cmd.Parameters.AddWithValue("@Ie", clientePj.Ie);
                cmd.Parameters.AddWithValue("@Im", clientePj.Im);
                cmd.Parameters.AddWithValue("@DataAbertura", clientePj.DataAbertura);

                res = cmd.ExecuteNonQuery();
                MessageBox.Show("O Cliente foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }
        #endregion

        #region Alterar
        public int AlterarClientePF(ClientePF Cliente)
        {
            string Query = "EXECUTE SP_ALTERA_CLIENTE 0, @idCliente, @Nome, @Apelido, @Sexo, @CPF, @RG, 0, @Data, @Logradouro, " +
                "@Numero, @Complemento, @Bairro, @IdCidade, @Cep, @Fixo, @Celular, @Observacoes, @DataNascimento";

            int res = 0;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@idCliente", Cliente.IdClientePF);
                cmd.Parameters.AddWithValue("@Nome", Cliente.Nome);
                cmd.Parameters.AddWithValue("@Apelido", Cliente.Apelido);
                cmd.Parameters.AddWithValue("@Sexo", Cliente.Sexo);
                cmd.Parameters.AddWithValue("@CPF", Cliente.Cpf);
                cmd.Parameters.AddWithValue("@RG", Cliente.Rg);
                cmd.Parameters.AddWithValue("@Data", Cliente.DataCadastro);
                cmd.Parameters.AddWithValue("@Logradouro", Cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Cliente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Cliente.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Cliente.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", Cliente.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", Cliente.Cep);
                cmd.Parameters.AddWithValue("@Fixo", Cliente.TelefoneFixo);
                cmd.Parameters.AddWithValue("@Celular", Cliente.TelefoneCelular);
                cmd.Parameters.AddWithValue("@Observacoes", Cliente.Observacoes);
                cmd.Parameters.AddWithValue("@DataNascimento", Cliente.DataNascimento);

                res = cmd.ExecuteNonQuery();
                MessageBox.Show("Alterações concluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um problema durante a alteração dos dados do cliente.\nErro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return res;
        }

        public int AlterarClientePJ(ClientePJ Cliente)
        {
            string Query = "EXECUTE SP_ALTERA_CLIENTE 1, @idCliente, @Razao, @Fant, 0, @CNPJ, @IE, @IM, @Data, @Logradouro, " +
                "@Numero, @Complemento, @Bairro, @IdCidade, @Cep, @Fixo, @Celular, @Observacoes, @DataCadastro";
            int res = 0;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@idCliente", Cliente.IdClientePJ);
                cmd.Parameters.AddWithValue("@Razao", Cliente.RazaoSocial);
                cmd.Parameters.AddWithValue("@Fant", Cliente.NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", Cliente.Cnpj);
                cmd.Parameters.AddWithValue("@IE", Cliente.Ie);
                cmd.Parameters.AddWithValue("@IM", Cliente.Im);
                cmd.Parameters.AddWithValue("@Data", Cliente.DataCadastro);
                cmd.Parameters.AddWithValue("@Logradouro", Cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Cliente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", Cliente.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Cliente.Bairro);
                cmd.Parameters.AddWithValue("@IdCidade", Cliente.Cidade.IdCidade);
                cmd.Parameters.AddWithValue("@Cep", Cliente.Cep);
                cmd.Parameters.AddWithValue("@Fixo", Cliente.TelefoneFixo);
                cmd.Parameters.AddWithValue("@Celular", Cliente.TelefoneCelular);
                cmd.Parameters.AddWithValue("@Observacoes", Cliente.Observacoes);
                cmd.Parameters.AddWithValue("@DataCadastro", Cliente.DataAbertura);

                res = cmd.ExecuteNonQuery();
                MessageBox.Show("Alterações concluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Ocorreu um erro durante a alteração do Cliente.\nErro: " + sqlEx.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return res;
        }

        #endregion

        #region ListarCliente
        public List<Cliente> GetListaClientes()
        {
            string query = "SELECT * FROM VW_SELECIONA_CLIENTES";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<Cliente> listaClientes = new List<Cliente>();

                while (dtr.Read())
                {
                    Cliente cliente;

                    if (dtr["idClientePF"].ToString() != String.Empty)
                    {
                        ClientePF clientePF = new ClientePF();
                        clientePF.IdClientePF = Convert.ToInt32(dtr["idClientePF"]);
                        clientePF.Nome = dtr["nome"].ToString();
                        clientePF.Apelido = dtr["apelido"].ToString();
                        clientePF.Sexo = Convert.ToChar(dtr["sexo"]);
                        clientePF.Cpf = dtr["cpf"].ToString();
                        clientePF.Rg = dtr["rg"].ToString();
                        clientePF.DataNascimento = Convert.ToDateTime(dtr["dataNascimento"]);
                        cliente = clientePF;
                    } else
                    {
                        ClientePJ clientePJ = new ClientePJ();
                        clientePJ.IdClientePJ = Convert.ToInt32(dtr["idClientePJ"]);
                        clientePJ.RazaoSocial = dtr["razaoSocial"].ToString();
                        clientePJ.NomeFantasia = dtr["nomeFantasia"].ToString();
                        clientePJ.Cnpj = dtr["cnpj"].ToString();
                        clientePJ.Ie = dtr["ie"].ToString();
                        clientePJ.Im = dtr["im"].ToString();
                        clientePJ.DataAbertura = Convert.ToDateTime(dtr["dataAbertura"]);
                        cliente = clientePJ;
                    }

                    cliente.IdCliente = Convert.ToInt32(dtr["idCliente"]);
                    cliente.Logradouro = dtr["logradouro"].ToString();
                    cliente.Numero = dtr["numero"].ToString();
                    cliente.Complemento = dtr["complemento"].ToString();
                    cliente.Bairro = dtr["bairro"].ToString();
                    cliente.Cep = dtr["cep"].ToString();
                    cliente.TelefoneFixo = dtr["telefoneFixo"].ToString();
                    cliente.TelefoneCelular = dtr["telefoneCelular"].ToString();
                    cliente.Observacoes = dtr["observacoes"].ToString();
                    cliente.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"]);

                    Estado estado = new Estado();
                    estado.IdEstado = Convert.ToInt32(dtr["idEstado"].ToString());
                    estado.estado = dtr["estado"].ToString();
                    estado.Uf = dtr["uf"].ToString();

                    Cidade cidade = new Cidade();
                    cidade.IdCidade = Convert.ToInt32(dtr["idCidade"].ToString());
                    cidade.cidade = dtr["cidade"].ToString();
                    cidade.Estado = estado;

                    cliente.Cidade = cidade;

                    listaClientes.Add(cliente);
                }

                dtr.Close();
                this.connection.Close();

                return listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }
        #endregion 

        #region ListarClienteChave
        public List<Cliente> GetListaClientesChave(String palavraChave)
        {
            string query = "EXECUTE SP_BUSCA_CLIENTE @palavraChave";

            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@palavraChave", palavraChave);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<Cliente> listaClientes = new List<Cliente>();

                while (dtr.Read())
                {
                    Cliente cliente;

                    if (dtr["idClientePF"].ToString() != String.Empty)
                    {
                        ClientePF clientePF = new ClientePF();
                        clientePF.IdClientePF = Convert.ToInt32(dtr["idClientePF"]);
                        clientePF.Nome = dtr["nome"].ToString();
                        clientePF.Apelido = dtr["apelido"].ToString();
                        clientePF.Sexo = Convert.ToChar(dtr["sexo"]);
                        clientePF.Cpf = dtr["cpf"].ToString();
                        clientePF.Rg = dtr["rg"].ToString();
                        clientePF.DataNascimento = Convert.ToDateTime(dtr["dataNascimento"]);
                        cliente = clientePF;
                    }
                    else
                    {
                        ClientePJ clientePJ = new ClientePJ();
                        clientePJ.IdClientePJ = Convert.ToInt32(dtr["idClientePJ"]);
                        clientePJ.RazaoSocial = dtr["razaoSocial"].ToString();
                        clientePJ.NomeFantasia = dtr["nomeFantasia"].ToString();
                        clientePJ.Cnpj = dtr["cnpj"].ToString();
                        clientePJ.Ie = dtr["ie"].ToString();
                        clientePJ.Im = dtr["im"].ToString();
                        clientePJ.DataAbertura = Convert.ToDateTime(dtr["dataAbertura"]);
                        cliente = clientePJ;
                    }

                    cliente.IdCliente = Convert.ToInt32(dtr["idCliente"]);
                    cliente.Logradouro = dtr["logradouro"].ToString();
                    cliente.Numero = dtr["numero"].ToString();
                    cliente.Complemento = dtr["complemento"].ToString();
                    cliente.Bairro = dtr["bairro"].ToString();
                    cliente.Cep = dtr["cep"].ToString();
                    cliente.TelefoneFixo = dtr["telefoneFixo"].ToString();
                    cliente.TelefoneCelular = dtr["telefoneCelular"].ToString();
                    cliente.Observacoes = dtr["observacoes"].ToString();
                    cliente.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"]);

                    Estado estado = new Estado();
                    estado.IdEstado = Convert.ToInt32(dtr["idEstado"].ToString());
                    estado.estado = dtr["estado"].ToString();
                    estado.Uf = dtr["uf"].ToString();

                    Cidade cidade = new Cidade();
                    cidade.IdCidade = Convert.ToInt32(dtr["idCidade"].ToString());
                    cidade.cidade = dtr["cidade"].ToString();
                    cidade.Estado = estado;

                    cliente.Cidade = cidade;

                    listaClientes.Add(cliente);
                }

                dtr.Close();
                this.connection.Close();

                return listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }
        #endregion 

    }
}
