using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProvaPJ
{
    public partial class frm_vendaP : Form
    {

        void OpenWithArguments()
        {
            Process.Start("IExplore.exe", "file:///C:/Users/Diego/Documents/relatorio1.html");
        }

        public frm_vendaP()
        {
            InitializeComponent();
        }

      
        private void btn_novo_Click(object sender, EventArgs e)
        {
            
            txt_quantidade.Text = "";
            txt_data.Text = "";
            txt_precoU.Text = "";
            txt_precoT.Text = "";
            cmb_produto.Enabled = true;
            cmbpessoa.Enabled = true;
            txt_quantidade.Enabled = true;
            txt_data.Enabled = true;
            txt_precoU.Enabled = true;
            txt_precoT.Enabled = true;
            btn_gravar.Enabled = true;
            cmb_produto.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Venda vendaDAO = new Venda();

            int idproduto= Convert.ToInt32(cmb_produto.SelectedValue);
            int idpessoa = Convert.ToInt32(cmbpessoa.SelectedValue);
            int quantidade = Convert.ToInt32(txt_quantidade.Text);
            DateTime datavenda = Convert.ToDateTime(txt_data.Text);
            double preco = Convert.ToDouble(txt_precoU.Text);
            double total = Convert.ToDouble(txt_precoT.Text);
            
            Venda objvenda = new Venda(new Produto(idproduto,"",'0','0'),new Pessoa(idpessoa,"",0,"","",0,"","",""),quantidade,datavenda,preco,total);

            if (vendaDAO.inserir(objvenda))
            {
                MessageBox.Show("Cadastrado com sucesso!");


               
                txt_quantidade.Text = "";
                txt_data.Text = "";
                txt_precoU.Text = "";
                txt_precoT.Text = "";
                cmbpessoa.Enabled = false;
                cmb_produto.Enabled = false;
                txt_quantidade.Enabled = false;
                txt_data.Enabled = false;
                txt_precoU.Enabled = false;
                txt_precoT.Enabled = false;


           

            }
            else
            {

                MessageBox.Show("ERRO !!!");

            }
        }

        private void frm_vendaP_Load(object sender, EventArgs e)
        {

            List<Produto> arrprodutos = new List<Produto>();

            Produto objproduto = new Produto();

            arrprodutos = objproduto.listar();

            cmb_produto.DataSource = arrprodutos;

            cmb_produto.DisplayMember = "nome";
            cmb_produto.ValueMember = "id";

            List<Pessoa> arrpessoas = new List<Pessoa>();

            Pessoa objpessoa = new Pessoa();

            arrpessoas = objpessoa.listar();

            cmbpessoa.DataSource = arrpessoas;
            cmbpessoa.DisplayMember = "nome";
            cmbpessoa.ValueMember = "id";
        }

        private void txt_precoT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precoU_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            Relatorio oRelatorio = new Relatorio();
            oRelatorio.relatorio();

            OpenWithArguments();
          


        }

    }
}
