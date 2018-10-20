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
    public class ProdutoDAO
    {
        SqlConnection connection;

        public ProdutoDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public void AdicionaProduto(Produto produto)
        {
            string query = "EXECUTE SP_INSERE_PRODUTO " +
                "@Descricao, @IdUnidadeMedida, @IdGrupo, @QtdMinima, @QtdDisponivel, @ValorCompra, @ValorVenda, @IdMarca, @CodigoFabricante, @Observacoes, @DataCadastro";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@IdUnidadeMedida", produto.UnidadeMedida.IdUnidadeMedida);
                cmd.Parameters.AddWithValue("@IdGrupo", produto.Grupo.IdGrupo);
                cmd.Parameters.AddWithValue("@QtdMinima", produto.QtdMinima);
                cmd.Parameters.AddWithValue("@QtdDisponivel", produto.QtdDisponivel);
                cmd.Parameters.AddWithValue("@ValorCompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@IdMarca", produto.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@CodigoFabricante", produto.CodigoFabricante);
                cmd.Parameters.AddWithValue("@Observacoes", produto.Observacoes);
                cmd.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Produto foi cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta DESCRIÇÃO E MARCA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlteraProduto(Produto produto)
        {
            string query = "EXECUTE SP_ALTERA_PRODUTO " +
                "@IdProduto, @Descricao, @IdUnidadeMedida, @IdGrupo, @QtdMinima, @QtdDisponivel, @ValorCompra, @ValorVenda, @IdMarca, @CodigoFabricante, @Observacoes, @DataCadastro";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@IdUnidadeMedida", produto.UnidadeMedida.IdUnidadeMedida);
                cmd.Parameters.AddWithValue("@IdGrupo", produto.Grupo.IdGrupo);
                cmd.Parameters.AddWithValue("@QtdMinima", produto.QtdMinima);
                cmd.Parameters.AddWithValue("@QtdDisponivel", produto.QtdDisponivel);
                cmd.Parameters.AddWithValue("@ValorCompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@IdMarca", produto.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@CodigoFabricante", produto.CodigoFabricante);
                cmd.Parameters.AddWithValue("@Observacoes", produto.Observacoes);
                cmd.Parameters.AddWithValue("@DataCadastro", produto.DataCadastro);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Produto foi alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta DESCRIÇÃO E MARCA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Produto> GetListaProdutos()
        {
            string query = "SELECT * FROM VW_SELECIONA_PRODUTO";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Produto> listaProdutos = new List<Produto>();
                while (dtr.Read())
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(dtr["idProduto"].ToString());
                    produto.Descricao = dtr["descricao"].ToString();

                    UnidadeMedida unidadeMedida = new UnidadeMedida();
                    unidadeMedida.IdUnidadeMedida = Convert.ToInt32(dtr["idUnidadeMedida"].ToString());
                    unidadeMedida.Sigla = dtr["sigla"].ToString();
                    unidadeMedida.unidadeMedida = dtr["unidadeMedida"].ToString();

                    produto.UnidadeMedida = unidadeMedida;

                    Grupo grupo = new Grupo();
                    grupo.IdGrupo = Convert.ToInt32(dtr["idGrupo"].ToString());
                    grupo.grupo = dtr["grupo"].ToString();

                    produto.Grupo = grupo;

                    produto.QtdMinima = Convert.ToInt32(dtr["qtdMinima"].ToString());
                    produto.QtdDisponivel = Convert.ToInt32(dtr["qtdDisponivel"].ToString());
                    produto.ValorCompra = Convert.ToDouble(dtr["valorCompra"].ToString());
                    produto.ValorVenda = Convert.ToDouble(dtr["valorVenda"].ToString());

                    Marca marca = new Marca();
                    marca.IdMarca = Convert.ToInt32(dtr["idMarca"].ToString());
                    marca.marca = dtr["marca"].ToString();

                    produto.Marca = marca;

                    produto.CodigoFabricante = dtr["codigoFabricante"].ToString();
                    produto.Observacoes = dtr["observacoes"].ToString();
                    produto.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"].ToString());

                    listaProdutos.Add(produto);
                }
                dtr.Close();
                this.connection.Close();

                return listaProdutos;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public List<Produto> GetListaProdutosChave(String palavraChave)
        {
            string query = "EXECUTE SP_BUSCA_PRODUTO @palavraChave";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@palavraChave", palavraChave);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Produto> listaProdutos = new List<Produto>();
                while (dtr.Read())
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(dtr["idProduto"].ToString());
                    produto.Descricao = dtr["descricao"].ToString();

                    UnidadeMedida unidadeMedida = new UnidadeMedida();
                    unidadeMedida.IdUnidadeMedida = Convert.ToInt32(dtr["idUnidadeMedida"].ToString());
                    unidadeMedida.Sigla = dtr["sigla"].ToString();
                    unidadeMedida.unidadeMedida = dtr["unidadeMedida"].ToString();

                    produto.UnidadeMedida = unidadeMedida;

                    Grupo grupo = new Grupo();
                    grupo.IdGrupo = Convert.ToInt32(dtr["idGrupo"].ToString());
                    grupo.grupo = dtr["grupo"].ToString();

                    produto.Grupo = grupo;

                    produto.QtdMinima = Convert.ToInt32(dtr["qtdMinima"].ToString());
                    produto.QtdDisponivel = Convert.ToInt32(dtr["qtdDisponivel"].ToString());
                    produto.ValorCompra = Convert.ToDouble(dtr["valorCompra"].ToString());
                    produto.ValorVenda = Convert.ToDouble(dtr["valorVenda"].ToString());

                    Marca marca = new Marca();
                    marca.IdMarca = Convert.ToInt32(dtr["idMarca"].ToString());
                    marca.marca = dtr["marca"].ToString();

                    produto.Marca = marca;

                    produto.CodigoFabricante = dtr["codigoFabricante"].ToString();
                    produto.Observacoes = dtr["observacoes"].ToString();
                    produto.DataCadastro = Convert.ToDateTime(dtr["dataCadastro"].ToString());

                    listaProdutos.Add(produto);
                }
                dtr.Close();
                this.connection.Close();

                return listaProdutos;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public void DeletaProduto(int idProduto)
        {
            string query = "EXECUTE SP_DELETA_PRODUTO @IdProduto";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Produto foi excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Não foi possível realizar a operação.\nEste PRODUTO está sendo referenciado em alguma COMPRA ou VENDA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
