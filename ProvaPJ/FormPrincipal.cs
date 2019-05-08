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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void pessoaNovo_menu_Click(object sender, EventArgs e)
        {
            frm_pessoa formpessoa = new frm_pessoa();

           // formpessoa.MdiParent = this;

            formpessoa.Show();
        }

        private void produtoNovo_menu_Click(object sender, EventArgs e)
        {
            frm_produto formproduto = new frm_produto();

            // formproduto.MdiParent = this;

            formproduto.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pessoa_Click(object sender, EventArgs e)
        {
            frm_pessoa formpessoa = new frm_pessoa();

            // formpessoa.MdiParent = this;

            formpessoa.Show();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            frm_produto formproduto = new frm_produto();

            // formproduto.MdiParent = this;

            formproduto.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendaP formvenda = new frm_vendaP();

            // formproduto.MdiParent = this;

            formvenda.Show();
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            frm_vendaP formvenda = new frm_vendaP();

            // formproduto.MdiParent = this;

            formvenda.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cadusuario formcadusuario = new frm_cadusuario();
            formcadusuario.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_estoque formestoque = new frm_estoque();
            formestoque.ShowDialog();
        }
    }

}