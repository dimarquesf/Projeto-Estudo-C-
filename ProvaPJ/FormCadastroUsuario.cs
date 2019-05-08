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
    public partial class frm_cadusuario : Form
    {
        public frm_cadusuario()
        {
            InitializeComponent();
        }
        public bool validaForm()
        {
            if (txt_username.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome de Usuário vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_username.Focus();
            }
            else if (txt_senha.Text == string.Empty)
            {
                MessageBox.Show("Campo Senha Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_senha.Focus();
            }
            else
            {
                return true;
            }
            return false;
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_username.Enabled = true;
            txt_senha.Enabled = true;
            btn_gravar.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                Usuario usuarioDAO = new Usuario();

                //coletar dados da interace
                String username = txt_username.Text;
                String senha = txt_senha.Text;

                //declarar e instaciar o objeto estado
                Usuario objusuario = new Usuario(username,senha);

                //chamar o metodo inserir da classe estado
                if (usuarioDAO.inserir(objusuario))
                {

                    MessageBox.Show("Registro Cadastro com Sucesso!");
                }
                else {

                    MessageBox.Show("ops! Algo de Errado aconteceu!");
                }

                txt_username.Text = "";
                txt_senha.Text = "";
                btn_gravar.Enabled = false;
                btn_novo.Enabled = true;

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
