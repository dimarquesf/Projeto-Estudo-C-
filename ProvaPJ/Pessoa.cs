using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPJ
{
    class Pessoa
    {

        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string nascionalidade { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string foto { get; set; }
        public bool ativo { get; set; }


        public Pessoa(int id, string nome, int idade, string nascionalidade, string endereco,int numero, string telefone, string email, string foto)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.nascionalidade = nascionalidade;
            this.endereco = endereco;
            this.numero = numero;
            this.telefone = telefone;
            this.email = email;
            this.foto = foto;
        }

        public Pessoa(string nome, int idade, string nascionalidade, string endereco, int numero,string telefone, string email, string foto)
        {
            this.nome = nome;
            this.idade = idade;
            this.nascionalidade = nascionalidade;
            this.endereco = endereco;  
            this.numero = numero;
            this.telefone = telefone;
            this.email = email;
            this.foto = foto;
        }

        public Pessoa()
        {

        }

        public bool inserir(Pessoa objeto)
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
                sql = "INSERT INTO tbl_pessoa(nome, idade, nascionalidade, endereco, numero, telefone, email, foto, ativo) VALUES ('" + objeto.nome + "','" + objeto.idade + "','" + objeto.nascionalidade + "','" + objeto.endereco + "','" + objeto.numero + "','" + objeto.telefone + "','" + objeto.email + "','" + objeto.foto + "','" + objeto.ativo + "');";

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


        //LISTAR COMBOBOX
        public List<Pessoa> listar()
        {
            List<Pessoa> lstpessoa = new List<Pessoa>();
            //esses dados virão do banco de dados
            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select * from tbl_pessoa where ativo = true order by nome;";
                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);
                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Pessoa objpessoa = new Pessoa();
                    objpessoa.id = Convert.ToInt32(dr["id"]);
                    objpessoa.nome = dr["nome"].ToString();
                    objpessoa.idade = Convert.ToInt32(dr["idade"]);
                    objpessoa.nascionalidade = dr["nascionalidade"].ToString();
                    objpessoa.endereco = dr["endereco"].ToString();
                    objpessoa.numero = Convert.ToInt32(dr["numero"]);
                    objpessoa.telefone = dr["telefone"].ToString();
                    objpessoa.email = dr["email"].ToString();
                    objpessoa.foto = dr["foto"].ToString().Trim();

                    lstpessoa.Add(objpessoa);
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
            return lstpessoa;


        }


        // LISTAR DATAGRIDVIEW
        public List<Pessoa> listar(string pesquisa)
        {
            List<Pessoa> lstpessoas = new List<Pessoa>();

            //esses dados virão do banco de dados

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "select id,nome,idade,nascionalidade,endereco,numero,telefone,email,foto from tbl_pessoa where (nome like ('%" + pesquisa + "%') and ativo = true);";

                //atribui ao cmd o sql e a conexão a ser utilizada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                //exacuta-se o sql e declara um DataReader para receber a matriz de valores
                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {

                    Pessoa objpessoa = new Pessoa();
                    objpessoa.id = Convert.ToInt32(dr["id"]);
                    objpessoa.nome = dr["nome"].ToString();
                    objpessoa.idade = Convert.ToInt32(dr["idade"]);
                    objpessoa.nascionalidade = dr["nascionalidade"].ToString();
                    objpessoa.endereco = dr["endereco"].ToString();
                    objpessoa.numero = Convert.ToInt32(dr["numero"]);
                    objpessoa.telefone = dr["telefone"].ToString();
                    objpessoa.email = dr["email"].ToString();
                    objpessoa.foto = dr["foto"].ToString().Trim();

                    lstpessoas.Add(objpessoa);
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


            return lstpessoas;


        }


        public bool alterar(Pessoa objeto)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = "UPDATE tbl_pessoa set nome='" + objeto.nome + "',idade='" + objeto.idade + "', nascionalidade='" + objeto.nascionalidade + "',endereco='" + objeto.endereco + "',numero='" + objeto.numero + "',telefone='" + objeto.telefone + "',email='" + objeto.email + "' where id=" + objeto.id + ";";

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

        public bool excluir(int id)
        {

            NpgsqlConnection pgsqlConnection = null;
            try
            {

                Conexao objconexao = new Conexao();

                pgsqlConnection = objconexao.getConexao();

                pgsqlConnection.Open();

                string sql = "";
                //monta o comando sql
                sql = string.Format("UPDATE tbl_pessoa set ativo = false where id={0}", id);

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