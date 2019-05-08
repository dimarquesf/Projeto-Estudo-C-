using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPJ
{
    class Produto{

        public int id { get; set; }
        public String nome { get; set; }
        public int quantidade { get; set; }
        public int peso { get; set; }
        public bool ativo { get; set; }

        public Produto(int id, String nome, int quantidade, int peso)
        {
            this.id = id;
            this.nome = nome;
            this.quantidade = quantidade;
            this.peso = peso;
        }

        public Produto(String nome, int quantidade, int peso)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.peso = peso;
        }

        public Produto()
        {

        }

        public bool inserir(Produto objeto)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                objeto.ativo = true;
                sql = "INSERT INTO tbl_produto(nome, quantidade, peso, ativo) VALUES('" + objeto.nome + "','" + objeto.quantidade + "','" + objeto.peso + "','" + objeto.ativo + "')";

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

        public List<Produto> listar()
        {
            List<Produto> lstprodutos = new List<Produto>();
            //esses dados virão do banco de dados
            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_produto where ativo = true order by nome;";
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

                    lstprodutos.Add(objproduto);
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
            return lstprodutos;
        }



        public List<Produto> listar(string pesquisa)
        {
            List<Produto> lstprodutos = new List<Produto>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select id,nome,quantidade,peso from tbl_produto where (nome like ('%" + pesquisa + "%') and  ativo = true);";

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

                    lstprodutos.Add(objproduto);
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


            return lstprodutos;


        }

        public bool alterar( Produto objeto)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE tbl_produto set nome='" + objeto.nome + "', quantidade='" + objeto.quantidade + "', peso='" + objeto.peso + "' where id=" + objeto.id + ";";

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


        public bool excluir(int id )
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = string.Format("UPDATE tbl_produto set ativo = false where id={0}", id);

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