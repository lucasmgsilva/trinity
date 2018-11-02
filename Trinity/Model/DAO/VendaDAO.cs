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
                    dtr.Close();
                    query = "EXECUTE SP_INSERE_ITEMVENDIDO @IdVenda, @IdProduto, @QtdVendida, @ValorVenda";
                    foreach (var ItemVendido in venda.ListaItemVendidos)
                    {
                        cmd = new SqlCommand(query, this.connection);
                        cmd.Parameters.AddWithValue("@IdVenda", idVenda);
                        cmd.Parameters.AddWithValue("@IdProduto", ItemVendido.Produto.IdProduto);
                        cmd.Parameters.AddWithValue("@QtdVendida", ItemVendido.QtdVendida);
                        cmd.Parameters.AddWithValue("@ValorVenda", ItemVendido.ValorVenda);
                        cmd.ExecuteNonQuery();
                    }
                }

                this.connection.Close();
                MessageBox.Show("A venda foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public void AlteraVenda(Venda venda, List<ItemVendido> listaItemVendidoNovo, List<ItemVendido> listaItemVendidoAlterado, List<ItemVendido> listaItemVendidoDeletado)
        {
            string query = "EXECUTE SP_ALTERA_VENDA " +
                           "@IdVenda, @IdUsuario, @IdCliente, @DataVenda, @Desconto";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdVenda", venda.IdVenda);
                cmd.Parameters.AddWithValue("@IdUsuario", venda.Usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@IdCliente", venda.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                cmd.Parameters.AddWithValue("@Desconto", venda.Desconto);
                cmd.ExecuteNonQuery();

                foreach (ItemVendido item in listaItemVendidoNovo)
                {
                    //MessageBox.Show("Item Vendido NOVO");
                    query = "EXECUTE SP_INSERE_ITEMVENDIDO @IdVenda, @IdProduto, @QtdVendida, @ValorVenda";
                        cmd = new SqlCommand(query, this.connection);
                        cmd.Parameters.AddWithValue("@IdVenda", venda.IdVenda);
                        cmd.Parameters.AddWithValue("@IdProduto", item.Produto.IdProduto);
                        cmd.Parameters.AddWithValue("@QtdVendida", item.QtdVendida);
                        cmd.Parameters.AddWithValue("@ValorVenda", item.ValorVenda);
                        cmd.ExecuteNonQuery();
                }

                foreach (ItemVendido item in listaItemVendidoAlterado)
                {
                    //MessageBox.Show("Item Vendido ALTERADO");
                    query = "EXECUTE SP_ALTERA_ITEMVENDIDO @IdVenda, @IdProduto, @QtdVendida, @ValorVenda";
                        cmd = new SqlCommand(query, this.connection);
                        cmd.Parameters.AddWithValue("@IdVenda", venda.IdVenda);
                        cmd.Parameters.AddWithValue("@IdProduto", item.Produto.IdProduto);
                        cmd.Parameters.AddWithValue("@QtdVendida", item.QtdVendida);
                        cmd.Parameters.AddWithValue("@ValorVenda", item.ValorVenda);
                        cmd.ExecuteNonQuery();
                }

                foreach (ItemVendido item in listaItemVendidoDeletado)
                {
                    //MessageBox.Show("Item Vendido DELETADO");
                    query = "EXECUTE SP_DELETA_ITEMVENDIDO @IdVenda, @IdProduto";
                        cmd = new SqlCommand(query, this.connection);
                        cmd.Parameters.AddWithValue("@IdVenda", venda.IdVenda);
                        cmd.Parameters.AddWithValue("@IdProduto", item.Produto.IdProduto);
                        cmd.ExecuteNonQuery();
                }

                this.connection.Close();
                MessageBox.Show("A VENDA foi alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }



        public List<Venda> GetListaVendas()
        {
            string query = "SELECT * FROM VW_SELECIONA_VENDAS";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Venda> listaVendas = new List<Venda>();

                while (dtr.Read())
                {
                    //Venda
                    Venda venda = new Venda()
                    {
                        IdVenda = Convert.ToInt32(dtr["idVenda"].ToString()),
                        DataVenda = Convert.ToDateTime(dtr["dataVenda"].ToString()),
                        Desconto = Convert.ToDouble(dtr["desconto"].ToString()),
                        Usuario = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(dtr["idUsuario"].ToString()),
                            usuario = dtr["usuario"].ToString()
                        },
                        ValorTotal = Convert.ToDouble(dtr["valorTotal"].ToString())
                    };

                    if (!String.IsNullOrWhiteSpace(dtr["nome"].ToString()))
                    { //É cliente PF
                        ClientePF clientepf = new ClientePF()
                        {
                            IdCliente = Convert.ToInt32(dtr["idCliente"].ToString()),
                            Nome = dtr["nome"].ToString()
                        };
                        venda.Cliente = clientepf;
                    } else
                    { //É cliente PJ
                        ClientePJ clientepj = new ClientePJ()
                        {
                            IdCliente = Convert.ToInt32(dtr["idCliente"].ToString()),
                            RazaoSocial = dtr["razaoSocial"].ToString()
                        };
                        venda.Cliente = clientepj;
                    }

                    listaVendas.Add(venda);
                }

                dtr.Close();
                this.connection.Close();

                return listaVendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public List<Venda> GetListaVendasChave(String palavraChave)
        {
            string query = "EXECUTE SP_BUSCA_VENDA_CHAVE @palavraChave";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@palavraChave", palavraChave);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<Venda> listaVendas = new List<Venda>();

                while (dtr.Read())
                {
                    //Venda
                    Venda venda = new Venda()
                    {
                        IdVenda = Convert.ToInt32(dtr["idVenda"].ToString()),
                        DataVenda = Convert.ToDateTime(dtr["dataVenda"].ToString()),
                        Desconto = Convert.ToDouble(dtr["desconto"].ToString()),
                        Usuario = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(dtr["idUsuario"].ToString()),
                            usuario = dtr["usuario"].ToString()
                        },
                        ValorTotal = Convert.ToDouble(dtr["valorTotal"].ToString())
                    };

                    if (!String.IsNullOrWhiteSpace(dtr["nome"].ToString()))
                    { //É cliente PF
                        ClientePF clientepf = new ClientePF()
                        {
                            IdCliente = Convert.ToInt32(dtr["idCliente"].ToString()),
                            Nome = dtr["nome"].ToString()
                        };
                        venda.Cliente = clientepf;
                    }
                    else
                    { //É cliente PJ
                        ClientePJ clientepj = new ClientePJ()
                        {
                            IdCliente = Convert.ToInt32(dtr["idCliente"].ToString()),
                            RazaoSocial = dtr["razaoSocial"].ToString()
                        };
                        venda.Cliente = clientepj;
                    }

                    listaVendas.Add(venda);
                }

                dtr.Close();
                this.connection.Close();

                return listaVendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public List<ItemVendido> GetListaItensVendidos(int idVenda)
        {
            string query = "EXECUTE SP_OBTEM_ITENSVENDIDOS @IdVenda";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdVenda", idVenda);
                SqlDataReader dtr = cmd.ExecuteReader();
                List<ItemVendido> listaItensVendidos = new List<ItemVendido>();

                while (dtr.Read())
                {
                    ItemVendido itemVendido = new ItemVendido()
                    {
                        QtdVendida = float.Parse(dtr["qtdVendida"].ToString()),
                        ValorVenda = Convert.ToDouble(dtr["valorVenda"].ToString()),
                        IdProduto = Convert.ToInt32(dtr["idProduto"].ToString()),
                        Produto = new Produto()
                        {
                            IdProduto = Convert.ToInt32(dtr["idProduto"].ToString()),
                            Descricao = dtr["descricao"].ToString()
                        }
                    };
                    itemVendido.ValorTotal = itemVendido.QtdVendida * itemVendido.ValorVenda;

                    listaItensVendidos.Add(itemVendido);
                }

                dtr.Close();
                this.connection.Close();

                return listaItensVendidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }

        public void DeletaVenda(int idVenda)
        {
            string query = "EXECUTE SP_DELETA_VENDA @IdVenda";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@IdVenda", idVenda);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Venda foi excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Não foi possível realizar a operação.\nEsta VENDA está sendo referenciada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
