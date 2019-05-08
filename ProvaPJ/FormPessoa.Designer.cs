namespace ProvaPJ
{
    partial class frm_pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tc_pessoa = new System.Windows.Forms.TabControl();
            this.tp_pessoa = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nascionalidade = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nascionalidade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tp_alterpessoa = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tc_pessoa.SuspendLayout();
            this.tp_pessoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tp_alterpessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_pessoa
            // 
            this.tc_pessoa.Controls.Add(this.tp_pessoa);
            this.tc_pessoa.Controls.Add(this.tp_alterpessoa);
            this.tc_pessoa.Location = new System.Drawing.Point(2, 2);
            this.tc_pessoa.Name = "tc_pessoa";
            this.tc_pessoa.SelectedIndex = 0;
            this.tc_pessoa.Size = new System.Drawing.Size(799, 358);
            this.tc_pessoa.TabIndex = 0;
            // 
            // tp_pessoa
            // 
            this.tp_pessoa.Controls.Add(this.lbl_id);
            this.tp_pessoa.Controls.Add(this.txt_id);
            this.tp_pessoa.Controls.Add(this.txt_nascionalidade);
            this.tp_pessoa.Controls.Add(this.txt_email);
            this.tp_pessoa.Controls.Add(this.lbl_email);
            this.tp_pessoa.Controls.Add(this.txt_telefone);
            this.tp_pessoa.Controls.Add(this.lbl_telefone);
            this.tp_pessoa.Controls.Add(this.lbl_nascionalidade);
            this.tp_pessoa.Controls.Add(this.txt_idade);
            this.tp_pessoa.Controls.Add(this.lbl_idade);
            this.tp_pessoa.Controls.Add(this.txt_numero);
            this.tp_pessoa.Controls.Add(this.lbl_numero);
            this.tp_pessoa.Controls.Add(this.txt_endereco);
            this.tp_pessoa.Controls.Add(this.lbl_endereco);
            this.tp_pessoa.Controls.Add(this.txt_nome);
            this.tp_pessoa.Controls.Add(this.lbl_nome);
            this.tp_pessoa.Controls.Add(this.groupBox1);
            this.tp_pessoa.Location = new System.Drawing.Point(4, 22);
            this.tp_pessoa.Name = "tp_pessoa";
            this.tp_pessoa.Padding = new System.Windows.Forms.Padding(3);
            this.tp_pessoa.Size = new System.Drawing.Size(791, 332);
            this.tp_pessoa.TabIndex = 0;
            this.tp_pessoa.Text = "Cadastrar";
            this.tp_pessoa.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(49, 41);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 80;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(137, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 20);
            this.txt_id.TabIndex = 81;
            this.txt_id.Visible = false;
            // 
            // txt_nascionalidade
            // 
            this.txt_nascionalidade.Enabled = false;
            this.txt_nascionalidade.Location = new System.Drawing.Point(314, 97);
            this.txt_nascionalidade.Name = "txt_nascionalidade";
            this.txt_nascionalidade.Size = new System.Drawing.Size(190, 20);
            this.txt_nascionalidade.TabIndex = 53;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(323, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(181, 20);
            this.txt_email.TabIndex = 57;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(278, 205);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 66;
            this.lbl_email.Text = "E-mail";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Location = new System.Drawing.Point(137, 198);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(124, 20);
            this.txt_telefone.TabIndex = 56;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(49, 201);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 65;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_nascionalidade
            // 
            this.lbl_nascionalidade.AutoSize = true;
            this.lbl_nascionalidade.Location = new System.Drawing.Point(228, 104);
            this.lbl_nascionalidade.Name = "lbl_nascionalidade";
            this.lbl_nascionalidade.Size = new System.Drawing.Size(80, 13);
            this.lbl_nascionalidade.TabIndex = 64;
            this.lbl_nascionalidade.Text = "Nascionalidade";
            // 
            // txt_idade
            // 
            this.txt_idade.Enabled = false;
            this.txt_idade.Location = new System.Drawing.Point(137, 101);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(61, 20);
            this.txt_idade.TabIndex = 52;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(49, 104);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_idade.TabIndex = 63;
            this.lbl_idade.Text = "Idade";
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(434, 136);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(70, 20);
            this.txt_numero.TabIndex = 55;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(384, 139);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 62;
            this.lbl_numero.Text = "Número";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Location = new System.Drawing.Point(137, 136);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(236, 20);
            this.txt_endereco.TabIndex = 54;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(49, 139);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 61;
            this.lbl_endereco.Text = "Endereço";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(137, 69);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(367, 20);
            this.txt_nome.TabIndex = 51;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(49, 72);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(82, 13);
            this.lbl_nome.TabIndex = 60;
            this.lbl_nome.Text = "Nome Completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_foto);
            this.groupBox1.Controls.Add(this.btn_iniciar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_gravar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 297);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para Cadastro";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Enabled = false;
            this.btn_excluir.Location = new System.Drawing.Point(253, 219);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(102, 50);
            this.btn_excluir.TabIndex = 64;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(133, 219);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(102, 50);
            this.btn_alterar.TabIndex = 63;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Enabled = false;
            this.btn_foto.Location = new System.Drawing.Point(614, 219);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(102, 28);
            this.btn_foto.TabIndex = 62;
            this.btn_foto.Text = "Tirar Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.Location = new System.Drawing.Point(506, 219);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(102, 28);
            this.btn_iniciar.TabIndex = 61;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(506, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 187);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(133, 219);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(102, 50);
            this.btn_gravar.TabIndex = 59;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(11, 219);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(102, 50);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(369, 219);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 50);
            this.btn_cancelar.TabIndex = 58;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tp_alterpessoa
            // 
            this.tp_alterpessoa.Controls.Add(this.listView1);
            this.tp_alterpessoa.Controls.Add(this.btnpesquisa);
            this.tp_alterpessoa.Controls.Add(this.txtpesquisa);
            this.tp_alterpessoa.Location = new System.Drawing.Point(4, 22);
            this.tp_alterpessoa.Name = "tp_alterpessoa";
            this.tp_alterpessoa.Size = new System.Drawing.Size(791, 332);
            this.tp_alterpessoa.TabIndex = 1;
            this.tp_alterpessoa.Text = "Consultar";
            this.tp_alterpessoa.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(100, 114);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 188);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Idade";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nascionalidade";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Endereço";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Número";
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 7;
            this.columnHeader8.Text = "E-mail";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 6;
            this.columnHeader3.Text = "Telefone";
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Location = new System.Drawing.Point(401, 51);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(98, 31);
            this.btnpesquisa.TabIndex = 8;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(110, 57);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(268, 20);
            this.txtpesquisa.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.tc_pessoa);
            this.Name = "frm_pessoa";
            this.Text = "Pessoa";
            this.Activated += new System.EventHandler(this.frm_pessoa_Activated);
            this.Load += new System.EventHandler(this.frm_pessoa_Load);
            this.MdiChildActivate += new System.EventHandler(this.frm_pessoa_MdiChildActivate);
            this.Enter += new System.EventHandler(this.frm_pessoa_Enter);
            this.tc_pessoa.ResumeLayout(false);
            this.tp_pessoa.ResumeLayout(false);
            this.tp_pessoa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tp_alterpessoa.ResumeLayout(false);
            this.tp_alterpessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_pessoa;
        private System.Windows.Forms.TabPage tp_pessoa;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nascionalidade;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nascionalidade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TabPage tp_alterpessoa;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_excluir;
    }
}