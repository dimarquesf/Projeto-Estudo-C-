namespace ProvaPJ
{
    partial class frm_vendaP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_pessoa = new System.Windows.Forms.Label();
            this.cmbpessoa = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_precoT = new System.Windows.Forms.TextBox();
            this.txt_precoU = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_precoT = new System.Windows.Forms.Label();
            this.lbl_precoU = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.cmb_produto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_pessoa);
            this.tabPage1.Controls.Add(this.cmbpessoa);
            this.tabPage1.Controls.Add(this.txt_data);
            this.tabPage1.Controls.Add(this.lbl_data);
            this.tabPage1.Controls.Add(this.txt_precoT);
            this.tabPage1.Controls.Add(this.txt_precoU);
            this.tabPage1.Controls.Add(this.txt_quantidade);
            this.tabPage1.Controls.Add(this.lbl_precoT);
            this.tabPage1.Controls.Add(this.lbl_precoU);
            this.tabPage1.Controls.Add(this.lbl_quantidade);
            this.tabPage1.Controls.Add(this.lbl_produto);
            this.tabPage1.Controls.Add(this.cmb_produto);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venda de Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_pessoa
            // 
            this.lbl_pessoa.AutoSize = true;
            this.lbl_pessoa.Location = new System.Drawing.Point(92, 36);
            this.lbl_pessoa.Name = "lbl_pessoa";
            this.lbl_pessoa.Size = new System.Drawing.Size(101, 13);
            this.lbl_pessoa.TabIndex = 32;
            this.lbl_pessoa.Text = "Selecione a Pessoa";
            // 
            // cmbpessoa
            // 
            this.cmbpessoa.Enabled = false;
            this.cmbpessoa.FormattingEnabled = true;
            this.cmbpessoa.Location = new System.Drawing.Point(201, 33);
            this.cmbpessoa.Name = "cmbpessoa";
            this.cmbpessoa.Size = new System.Drawing.Size(283, 21);
            this.cmbpessoa.TabIndex = 31;
            // 
            // txt_data
            // 
            this.txt_data.Enabled = false;
            this.txt_data.Location = new System.Drawing.Point(363, 98);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(121, 20);
            this.txt_data.TabIndex = 30;
            this.txt_data.TextChanged += new System.EventHandler(this.txt_data_TextChanged);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(284, 101);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(79, 13);
            this.lbl_data.TabIndex = 29;
            this.lbl_data.Text = "Data da Venda";
            // 
            // txt_precoT
            // 
            this.txt_precoT.Enabled = false;
            this.txt_precoT.Location = new System.Drawing.Point(384, 131);
            this.txt_precoT.Name = "txt_precoT";
            this.txt_precoT.Size = new System.Drawing.Size(100, 20);
            this.txt_precoT.TabIndex = 27;
            this.txt_precoT.TextChanged += new System.EventHandler(this.txt_precoT_TextChanged);
            // 
            // txt_precoU
            // 
            this.txt_precoU.Enabled = false;
            this.txt_precoU.Location = new System.Drawing.Point(201, 131);
            this.txt_precoU.Name = "txt_precoU";
            this.txt_precoU.Size = new System.Drawing.Size(100, 20);
            this.txt_precoU.TabIndex = 26;
            this.txt_precoU.TextChanged += new System.EventHandler(this.txt_precoU_TextChanged);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Enabled = false;
            this.txt_quantidade.Location = new System.Drawing.Point(201, 98);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(77, 20);
            this.txt_quantidade.TabIndex = 25;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // lbl_precoT
            // 
            this.lbl_precoT.AutoSize = true;
            this.lbl_precoT.Location = new System.Drawing.Point(316, 134);
            this.lbl_precoT.Name = "lbl_precoT";
            this.lbl_precoT.Size = new System.Drawing.Size(62, 13);
            this.lbl_precoT.TabIndex = 24;
            this.lbl_precoT.Text = "Preço Total";
            // 
            // lbl_precoU
            // 
            this.lbl_precoU.AutoSize = true;
            this.lbl_precoU.Location = new System.Drawing.Point(92, 134);
            this.lbl_precoU.Name = "lbl_precoU";
            this.lbl_precoU.Size = new System.Drawing.Size(74, 13);
            this.lbl_precoU.TabIndex = 23;
            this.lbl_precoU.Text = "Preço Unitário";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(92, 101);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 22;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(92, 66);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(103, 13);
            this.lbl_produto.TabIndex = 21;
            this.lbl_produto.Text = "Selecione o Produto";
            // 
            // cmb_produto
            // 
            this.cmb_produto.Enabled = false;
            this.cmb_produto.FormattingEnabled = true;
            this.cmb_produto.Location = new System.Drawing.Point(201, 63);
            this.cmb_produto.Name = "cmb_produto";
            this.cmb_produto.Size = new System.Drawing.Size(283, 21);
            this.cmb_produto.TabIndex = 19;
            this.cmb_produto.SelectedIndexChanged += new System.EventHandler(this.cmb_produto_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_gravar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 301);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Venda";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(208, 245);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(120, 50);
            this.btn_gravar.TabIndex = 15;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(383, 245);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 50);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(41, 245);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(102, 50);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(594, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 119);
            this.button1.TabIndex = 19;
            this.button1.Text = "Gerar Listagem ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(24, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 301);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório de Venda";
            // 
            // frm_vendaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_vendaP";
            this.Text = "Venda de Produto";
            this.Load += new System.EventHandler(this.frm_vendaP_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_precoT;
        private System.Windows.Forms.TextBox txt_precoU;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_precoT;
        private System.Windows.Forms.Label lbl_precoU;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.ComboBox cmb_produto;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lbl_pessoa;
        private System.Windows.Forms.ComboBox cmbpessoa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}