using System;
using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class frm_pessoa : Form
    {
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;
        Graphics g;
        int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
        int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        List<Pessoa> lista = new List<Pessoa>();

        int aux;
        public frm_pessoa()
        {
            InitializeComponent();
    }

        
        public void listar()
        {
            listView1.Items.Clear();
            Pessoa objpessoa = new Pessoa();
            lista = objpessoa.listar(txtpesquisa.Text);
            foreach (Pessoa p in lista)
            {
                ListViewItem item = new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.nome);
                item.SubItems.Add(Convert.ToInt32(p.idade).ToString());
                item.SubItems.Add(p.nascionalidade);
                item.SubItems.Add(p.endereco);
                item.SubItems.Add(Convert.ToInt32(p.numero).ToString());
                item.SubItems.Add(p.telefone);
                item.SubItems.Add(p.email);
                listView1.Items.Add(item);
            }

        }

        public bool validaForm()
        {
            if (txt_nome.Text == string.Empty)
            {
                MessageBox.Show("Campo Nome vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nome.Focus();
            }
            else if (txt_idade.Text == string.Empty)
            {
                MessageBox.Show("Campo Idade Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_idade.Focus();
            }
            else if (txt_nascionalidade.Text == string.Empty)
            {
                MessageBox.Show("Campo Nascionalidade Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_endereco.Text == string.Empty)
            {
                MessageBox.Show("Campo Endereço Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_numero.Text == string.Empty)
            {
                MessageBox.Show("Campo Número Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_telefone.Text == string.Empty)
            {
                MessageBox.Show("Campo Telefone Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_email.Text == string.Empty)
            {
                MessageBox.Show("Campo E-mail Vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return true;
            }
            return false;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                Pessoa pessoaDAO = new Pessoa();

                //coletar dados da interace
                string nome = txt_nome.Text;
                int idade = Convert.ToInt32(txt_idade.Text);
                string nascionalidade = txt_nascionalidade.Text;
                string endereco = txt_endereco.Text;
                int numero = Convert.ToInt32(txt_numero.Text);
                string telefone = txt_telefone.Text;
                string email = txt_email.Text;
                string foto = txt_nome.Text;

                //declarar e instaciar o objeto estado
                Pessoa objpessoa = new Pessoa(nome, idade, nascionalidade, endereco, numero,telefone, email, foto);

                //chamar o metodo inserir da classe estado
                if (pessoaDAO.inserir(objpessoa))
                {

                    MessageBox.Show("Registro Cadastro com Sucesso!");

                    txt_nome.Text = "";
                    txt_idade.Text = "";
                    txt_nascionalidade.Text = "";
                    txt_endereco.Text = "";
                    txt_numero.Text = "";
                    txt_telefone.Text = "";
                    txt_email.Text = "";
                    txt_nome.Enabled = false;
                    txt_idade.Enabled = false;
                    txt_nascionalidade.Enabled = false;
                    txt_endereco.Enabled = false;
                    txt_numero.Enabled = false;
                    txt_telefone.Enabled = false;
                    txt_email.Enabled = false;
                    btn_gravar.Enabled = false;
                    btn_novo.Enabled = true;
                    btn_iniciar.Enabled = false;
                    btn_foto.Enabled = false;
                    pictureBox1.Image = null;
                }
                else {

                    MessageBox.Show("ops! Algo de Errado aconteceu!");
                }

                
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_idade.Text = "";
            txt_nascionalidade.Text = "";
            txt_endereco.Text = "";
            txt_numero.Text = "";
            txt_telefone.Text = "";
            txt_email.Text = "";
            txt_nome.Enabled = true;
            txt_idade.Enabled = true;
            txt_nascionalidade.Enabled = true;
            txt_endereco.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefone.Enabled = true;
            txt_email.Enabled = true;
            btn_gravar.Enabled = true;
            btn_novo.Enabled = false;
            btn_foto.Enabled = true;
            btn_iniciar.Enabled = true;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);

            if (videosources != null)
            {
                videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosources[0].MonikerString);
                videoSource.NewFrame += (s, f) => pictureBox1.Image = (Bitmap)f.Frame.Clone();
                videoSource.Start();
            }
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            txt_nome.Text.Replace("  ", " ");
            pictureBox1.Image.Save(txt_nome.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            videoSource.SimulateTrigger();

            base.OnClosed(e);

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //armazena a imagem no bitmap
            Bitmap b = new Bitmap(TelaLargura, TelaAltura);
            //copia  a tela no bitmap
            g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            //atribui a imagem ao picturebox exibindo-a
            pictureBox1.Image = b;
            this.Show();
            //encerra o timer
            timer1.Stop();
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_pessoa_Load(object sender, EventArgs e)
        {
           
            listar();
        }

        private void frm_pessoa_Enter(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_pessoa_Activated(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_pessoa_MdiChildActivate(object sender, EventArgs e)
        {
            listar();
        }


        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           // Pessoa objpessoa = (Pessoa)listView1.SelectedItems;
        }



        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaDAO = new Pessoa();

            //coletar dados da interace

            int id = Convert.ToInt32(txt_id.Text);
            string nome = txt_nome.Text;
            int idade = Convert.ToInt32(txt_idade.Text);
            string nascionalidade = txt_nascionalidade.Text;
            string endereco = txt_endereco.Text;
            int numero = Convert.ToInt32(txt_numero.Text);
            string telefone = txt_telefone.Text;
            string email = txt_email.Text;



            //declarar e instaciar o objeto 
            Pessoa objpessoa = new Pessoa(id, nome, idade, nascionalidade,endereco,numero,telefone,email,"");

            //chamar o metodo inserir da classe 
            if (pessoaDAO.alterar(objpessoa))
            {

                MessageBox.Show("Registro Alterado com Sucesso!");

                txt_id.Visible = false;
                lbl_id.Visible = false;
                txt_nome.Enabled = false;
                txt_idade.Enabled = false;
                txt_nascionalidade.Enabled = false;
                txt_endereco.Enabled = false;
                txt_numero.Enabled = false;
                txt_telefone.Enabled = false;
                txt_email.Enabled = false;
                txt_nome.Text = "";
                txt_idade.Text = "";
                txt_nascionalidade.Text = "";
                txt_endereco.Text = "";
                txt_numero.Text = "";
                txt_telefone.Text = "";
                txt_email.Text = "";
                pictureBox1.Image = null;
                btn_alterar.Visible = false;
                btn_excluir.Enabled = false;
                btn_novo.Enabled = true;
                btn_gravar.Visible = true;
                listView1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Ops. Algo de Errado aconteceu!");

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa objpessoa = lista[listView1.FocusedItem.Index];
            /*txt_id.Text = dgvpessoa.CurrentRow.Cells[0].Value.ToString();
           txt_nome.Text = dgvpessoa.CurrentRow.Cells[1].Value.ToString();
           txt_idade.Text = dgvpessoa.CurrentRow.Cells[2].Value.ToString();
           txt_nascionalidade.Text = dgvpessoa.CurrentRow.Cells[3].Value.ToString();
           txt_endereco.Text = dgvpessoa.CurrentRow.Cells[4].Value.ToString();
           txt_numero.Text = dgvpessoa.CurrentRow.Cells[5].Value.ToString();
           txt_telefone.Text = dgvpessoa.CurrentRow.Cells[6].Value.ToString();
           txt_email.Text = dgvpessoa.CurrentRow.Cells[7].Value.ToString();
           */

            try {
                pictureBox1.Image = Image.FromFile(
                   Application.StartupPath + "\\" + objpessoa.foto + ".jpg"); ;
            }
            catch(Exception ex)
            {
                pictureBox1.Image = null;
            }
            txt_id.Text = objpessoa.id.ToString();
            aux = Convert.ToInt32(txt_id.Text);
            txt_nome.Text = objpessoa.nome;
            txt_idade.Text = objpessoa.idade.ToString();
            txt_nascionalidade.Text = objpessoa.nascionalidade;
            txt_endereco.Text = objpessoa.endereco;
            txt_numero.Text = objpessoa.numero.ToString();
            txt_telefone.Text = objpessoa.telefone;
            txt_email.Text = objpessoa.email;

            listView1.Enabled = false;
            tp_pessoa.Show();
            lbl_id.Visible = true;
            txt_id.Visible = true;
            txt_id.Enabled = false;
            btn_gravar.Visible = false;
            btn_alterar.Visible = true;
            btn_excluir.Enabled = true;
            btn_novo.Enabled = false;
            txt_nome.Enabled = true;
            txt_idade.Enabled = true;
            txt_nascionalidade.Enabled = true;
            txt_endereco.Enabled = true;
            txt_numero.Enabled = true;
            txt_telefone.Enabled = true;
            txt_email.Enabled = true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Excluir?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Pessoa aPessoa = new Pessoa();
                aPessoa.excluir(aux);

                txt_id.Visible = false;
                lbl_id.Visible = false;
                txt_nome.Enabled = false;
                txt_idade.Enabled = false;
                txt_nascionalidade.Enabled = false;
                txt_endereco.Enabled = false;
                txt_numero.Enabled = false;
                txt_telefone.Enabled = false;
                txt_email.Enabled = false;
                txt_nome.Text = "";
                txt_idade.Text = "";
                txt_nascionalidade.Text = "";
                txt_endereco.Text = "";
                txt_numero.Text = "";
                txt_telefone.Text = "";
                txt_email.Text = "";
                btn_alterar.Visible = false;
                btn_novo.Enabled = true;
                btn_gravar.Visible = true;
                btn_excluir.Enabled = false;
                pictureBox1.Image = null;
                listView1.Enabled = true;

            }
        }

        
    }
}

