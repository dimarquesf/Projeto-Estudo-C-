using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPJ
{
    class Relatorio
    {

        public void relatorio()
        {

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

        pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
        //monta o comando sql
        sql = "SELECT tbl_venda.id,tbl_produto.nome as produto,tbl_pessoa.nome as cliente,tbl_venda.quantidade,tbl_venda.datavenda,tbl_venda.preco,tbl_venda.total FROM tbl_venda INNER JOIN tbl_produto ON tbl_produto.id = tbl_venda.idproduto INNER JOIN tbl_pessoa ON tbl_pessoa.id = tbl_venda.idpessoa";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

        //exacuta-se o sql e declara um DataReader para receber a matriz de valores
        NpgsqlDataReader dr = cmd.ExecuteReader();

                //criar o arquivo
                string lines = "<html><head><title>RELATÓRIO DE VENDAS</title><meta charset='UTF-8'/></head><body><table><thead> <tr><th><b><FONT COLOR = red >#</th><th>Nome do Comprador</th><th>Nome do Produto</th><th>Quantidade</th><th>Preço Unitario</th><th>Preço Total</th><th>Data da Compra</th></tr></b></thead><tbody>";

                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Diego\\Documents\\relatorio1.html");

                while (dr.Read())
                {

                    lines += "<tr><td>" + dr["id"].ToString() + "</td><td>" + dr["cliente"].ToString() + "</td><td>" + dr["produto"].ToString() + "</td><td>" + dr["quantidade"].ToString() + "</td><td>" + dr["preco"].ToString() + "</td><td>" + dr["total"].ToString() + "</td><td>" + dr["datavenda"].ToString() + "</td></tr>";

                }


                lines += "</tbody><tfoot></tfoot></table></body></html>";


                file.WriteLine(lines);

                file.Close();

            }
            catch (Exception ex)
            {

                //

            }
            finally
            {

                pgsqlConnection.Close();

            }


        }
    }
}
