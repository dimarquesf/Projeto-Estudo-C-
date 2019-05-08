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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario();

            objusuario.username = txt_username.Text;
            objusuario.senha = txt_senha.Text;

            Usuario objusuario_aux = new Usuario();
            objusuario_aux = objusuario.login();


            if ((objusuario.username == objusuario_aux.username) && (objusuario.senha == objusuario_aux.senha))
            {

                frm_principal formprincipal = new frm_principal();
                formprincipal.ShowDialog();

            }
            else {

                MessageBox.Show("Usuário e Senha Inválidos");

            }
        }
    }
}