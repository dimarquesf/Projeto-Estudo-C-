using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProvaPJ
{
    class Venda {

    


        public int id { get; set; }
        public Produto produto { get; set; }
        public Pessoa pessoa { get; set; }
        public int quantidade { get; set; }
        public DateTime datavenda { get; set; }
        public double preco { get; set; }
        public double total { get; set; }

        public Venda( int id, Produto produto, Pessoa pessoa, int quantidade, DateTime datavenda, double preco, double total)
        {
            this.id = id;
            this.produto = produto;
            this.pessoa = pessoa;
            this.quantidade = quantidade;
            this.datavenda = datavenda;
            this.preco = preco;
            this.total = total;
        }

        public Venda(Produto produto, Pessoa pessoa, int quantidade, DateTime datavenda, double preco, double total)
        {
            this.produto = produto;
            this.pessoa = pessoa;
            this.quantidade = quantidade;
            this.datavenda = datavenda;
            this.preco = preco;
            this.total = total;
        }

        public Venda()
        {
        }


        public bool inserir(Venda objeto)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_venda(idproduto, idpessoa, quantidade, datavenda, preco, total) VALUES('" + objeto.produto.id + "','" + objeto.pessoa.id + "','" + objeto.quantidade + "','" + objeto.datavenda + "','" + objeto.preco + "','" + objeto.total + "')";

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
