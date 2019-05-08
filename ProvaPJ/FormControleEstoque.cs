using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaPJ
{
    public partial class frm_estoque : Form
    {
        
        public frm_estoque()
        {
            InitializeComponent();
        }
        public void listar()
        {

            Produto objproduto = new Produto();

            dgvproduto.AutoGenerateColumns = false;

            var lista = new BindingList<Produto>(objproduto.listar(txtpesquisa.Text));
            dgvproduto.DataSource = lista;
            dgvproduto.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleEstoque estoqueDAO = new ControleEstoque();
            //int id = Convert.ToInt32(txt_id.Text);
            int idproduto = Convert.ToInt32(cmb_produto.SelectedValue);
            int quantidade = Convert.ToInt32(txt_quantidade.Text);

             

            ControleEstoque objestoque = new ControleEstoque(idproduto, new Produto(idproduto, "", '0', '0'),quantidade);
            if (estoqueDAO.Entrada(objestoque))
            {
                MessageBox.Show(" Entrada Cadastrado com sucesso!");



                txt_quantidade.Text = "";
                cmb_produto.Enabled = false;
                txt_quantidade.Enabled = false;


            }
            else
            {

                MessageBox.Show("ERRO !!!");

            }

        }

        private void FormControleEstoque_Load(object sender, EventArgs e)
        {
            List<Produto> arrprodutos = new List<Produto>();

            Produto objproduto = new Produto();

            arrprodutos = objproduto.listar();

            cmb_produto.DataSource = arrprodutos;

            cmb_produto.DisplayMember = "nome";
            cmb_produto.ValueMember = "id";

            List<Produto> arrprodutos2 = new List<Produto>();

            Produto objproduto2 = new Produto();

            arrprodutos = objproduto2.listar();

            cmb_produto2.DataSource = arrprodutos;

            cmb_produto2.DisplayMember = "nome";
            cmb_produto2.ValueMember = "id";


            listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_quantidade.Enabled = true;
            cmb_produto.Enabled = true;
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
             listar();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            ControleEstoque estoque2DAO = new ControleEstoque();
            int idproduto = Convert.ToInt32(cmb_produto2.SelectedValue);
            int quantidade = Convert.ToInt32(txt_quantidade2.Text);

            ControleEstoque objestoque2 = new ControleEstoque(new Produto(idproduto, "", '0', '0'), quantidade);
            if (estoque2DAO.Saida(objestoque2))
            {
                MessageBox.Show("Saída Cadastrado com sucesso!");



                txt_quantidade.Text = "";
                cmb_produto.Enabled = false;
                txt_quantidade.Enabled = false;


            }
            else
            {

                MessageBox.Show("ERRO !!!");

            }

        
    }
    }
}
