using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPJ
{
    class Usuario
    {

        public int id { get; set; }
        public String username { get; set; }
        public String senha { get; set; }


        public Usuario(int id, String username, String senha)
        {
            this.id = id;
            this.username = username;
            this.senha = senha;
        }

        public Usuario(String username, String senha)
        {
            this.username = username;
            this.senha = senha;
        }

        public Usuario()
        {

        }

        public bool inserir(Usuario objeto)
        {
            NpgsqlConnection pgsqlConnection = null;
            try
            {
                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql

                sql = "INSERT INTO tbl_usuario (username,senha) VALUES('" + objeto.username + "','" + objeto.senha + "')";

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

        public Usuario login()
        {
            //Dadis que virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;

            Usuario objusuario = new Usuario();
            try
            {
                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                // Montar o comando sql para buscar dados do banco
                sql = "select * from tbl_usuario where username ='" + this.username + "' and senha='" + this.senha + "';";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                dr.Read();



                objusuario.id = Convert.ToInt32(dr["id"]);
                objusuario.username = dr["username"].ToString();
                objusuario.senha = dr["senha"].ToString();



            }
            catch (Exception ex)
            {

                //

            }
            finally
            {

                pgsqlConnection.Close();

            }


            return objusuario;


        }



    }
}