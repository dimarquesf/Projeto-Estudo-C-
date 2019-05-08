using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPJ
{
    class ControleEstoque
    {
        public int id { get; set; }
        public Produto produto { get; set; }
        public int quantidade { get; set; }
        public bool ativo { get; set; }


        public ControleEstoque(int id, Produto produto, int quantidade)
        {
            this.id = id;
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public ControleEstoque(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public ControleEstoque()
        { }


        public List<Produto> listar(string pesquisa)
        {
            List<Produto> lstestoques = new List<Produto>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_produto where (nome like ('%" + pesquisa + "%') and ativo = true);";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Produto objproduto = new Produto();
                    objproduto.id = Convert.ToInt32(dr["id"]);
                    objproduto.nome = dr["nome"].ToString();
                    objproduto.quantidade = Convert.ToInt32(dr["quantidade"]);
                    objproduto.peso = Convert.ToInt32(dr["peso"]);

                    lstestoques.Add(objproduto);
                }

            }
            catch (Exception ex)
            {

                //

            }
            finally
            {

                pgsqlConnection.Close();

            }


            return lstestoques;


        }



        public bool Entrada(ControleEstoque objeto)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE tbl_produto set quantidade = quantidade + '" + objeto.quantidade + "' where id=" + objeto.id + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;


            }
            catch (Exception ex)
            {

                return false;

            }
            finally
            {

                pgsqlConnection.Close();

            }


        }

        public bool Saida(ControleEstoque obj)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE tbl_produto set quantidade = quantidade - '" + obj.quantidade + "' where id=" + obj.id + ";";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                cmd.ExecuteNonQuery();//executa comando no banco de dados

                return true;


            }
            catch (Exception ex)
            {

                return false;
                
            }
            finally
            {

                pgsqlConnection.Close();

            }


        }

    }
}