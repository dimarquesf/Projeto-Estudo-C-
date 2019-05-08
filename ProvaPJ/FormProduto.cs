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
    public partial class frm_produto : Form
    {
        int aux;

        public frm_produto()
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

        public bool validaForm()
        {
            if (txt_nome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nome.Focus();
            }
            else if (txt_quantidade.Text == string.Empty)
            {
                MessageBox.Show("Campo Quantidade Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_quantidade.Focus();
            }
            else if (txt_peso.Text == string.Empty)
            {
                MessageBox.Show("Campo Peso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_peso.Focus();
            }
            else
            { return true; }
            return false;
        }



        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                Produto produtoDAO = new Produto();

                //coletar dados da interace
                string nome = txt_nome.Text;
                int quantidade = Convert.ToInt32(txt_quantidade.Text);
                int peso = Convert.ToInt32(txt_peso.Text);



                //declarar e instaciar o objeto estado
                Produto objproduto = new Produto(nome, quantidade, peso);

                //chamar o metodo inserir da classe estado
                if (produtoDAO.inserir(objproduto))
                {

                    MessageBox.Show("Registro Cadastro com Sucesso!");
                }
                else {

                    MessageBox.Show("ops! Algo de Errado aconteceu!");
                }

                txt_nome.Text = "";
                txt_quantidade.Text = "";
                txt_peso.Text = "";
                txt_nome.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_peso.Enabled = false;
                btn_gravar.Enabled = false;
                btn_novo.Enabled = true;

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_peso.Text = "";
            txt_nome.Enabled = true;
            txt_quantidade.Enabled = true;
            txt_peso.Enabled = true;
            btn_gravar.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_produto_Activated(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_produto_MdiChildActivate(object sender, EventArgs e)
        {
            listar();
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            listar();
        }



      

        private void btn_alterar_Click(object sender, EventArgs e)
        {
                Produto produtoDAO = new Produto();

            //coletar dados da interace

                int id = Convert.ToInt32(txt_id.Text);
                string nome = txt_nome.Text;
                int quantidade = Convert.ToInt32(txt_quantidade.Text);
                int peso = Convert.ToInt32(txt_peso.Text);
         
                


                //declarar e instaciar o objeto estado
                Produto objproduto = new Produto(id,nome, quantidade, peso);

                //chamar o metodo inserir da classe estado
                if (produtoDAO.alterar(objproduto))
                {

                    MessageBox.Show("Registro Alterado com Sucesso!");

                    txt_id.Visible = false;
                    lbl_id.Visible = false;
                    txt_nome.Enabled = false;
                    txt_peso.Enabled = false;
                    txt_quantidade.Enabled = false;
                    txt_nome.Text = "";
                    txt_quantidade.Text = "";
                    txt_peso.Text = "";
                    btn_alterar.Visible = false;
                    btn_excluir.Enabled = false;
                    btn_novo.Enabled = true;
                    btn_gravar.Visible = true;
                    dgvproduto.Enabled = true;

                }else
                {
                    MessageBox.Show("Ops. Algo de Errado aconteceu!");

                }

            }

        private void dgvproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgvproduto.CurrentRow.Cells[0].Value.ToString();
            aux = Convert.ToInt32(txt_id.Text);
            txt_nome.Text = dgvproduto.CurrentRow.Cells[1].Value.ToString();
            txt_quantidade.Text = dgvproduto.CurrentRow.Cells[2].Value.ToString();
            txt_peso.Text = dgvproduto.CurrentRow.Cells[3].Value.ToString();
            dgvproduto.Enabled = false;
            tp_produto.Show();
            lbl_id.Visible = true;
            txt_id.Visible = true;
            txt_id.Enabled = false;
            btn_gravar.Visible = false;
            btn_alterar.Visible = true;
            btn_excluir.Enabled = true;
            btn_novo.Enabled = false;
            txt_nome.Enabled = true;
            txt_quantidade.Enabled = true;
            txt_peso.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?","Excluir?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Produto oProduto = new Produto();
                oProduto.excluir(aux);
            }

            txt_id.Visible = false;
            lbl_id.Visible = false;
            txt_nome.Enabled = false;
            txt_peso.Enabled = false;
            txt_quantidade.Enabled = false;
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_peso.Text = "";
            btn_alterar.Visible = false;
            btn_novo.Enabled = true;
            btn_gravar.Visible = true;
            btn_excluir.Enabled = false;
            dgvproduto.Enabled = true;
        }
    }
    }
