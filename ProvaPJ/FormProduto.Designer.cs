namespace ProvaPJ
{
    partial class frm_produto
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
            this.tp_produto = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.tp_alterProduto = new System.Windows.Forms.TabPage();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tp_produto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_alterProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_produto);
            this.tabControl1.Controls.Add(this.tp_alterProduto);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_produto
            // 
            this.tp_produto.Controls.Add(this.lbl_id);
            this.tp_produto.Controls.Add(this.txt_id);
            this.tp_produto.Controls.Add(this.txt_peso);
            this.tp_produto.Controls.Add(this.lbl_nome);
            this.tp_produto.Controls.Add(this.txt_nome);
            this.tp_produto.Controls.Add(this.lbl_peso);
            this.tp_produto.Controls.Add(this.lbl_quantidade);
            this.tp_produto.Controls.Add(this.txt_quantidade);
            this.tp_produto.Controls.Add(this.groupBox1);
            this.tp_produto.Location = new System.Drawing.Point(4, 22);
            this.tp_produto.Name = "tp_produto";
            this.tp_produto.Padding = new System.Windows.Forms.Padding(3);
            this.tp_produto.Size = new System.Drawing.Size(591, 330);
            this.tp_produto.TabIndex = 0;
            this.tp_produto.Text = "Cadastrar";
            this.tp_produto.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(77, 71);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 78;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(165, 68);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 20);
            this.txt_id.TabIndex = 79;
            this.txt_id.Visible = false;
            // 
            // txt_peso
            // 
            this.txt_peso.Enabled = false;
            this.txt_peso.Location = new System.Drawing.Point(357, 129);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(84, 20);
            this.txt_peso.TabIndex = 4;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(77, 100);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 13);
            this.lbl_nome.TabIndex = 67;
            this.lbl_nome.Text = "Nome Produto";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(165, 97);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(276, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(320, 132);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 71;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(77, 132);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 69;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Enabled = false;
            this.txt_quantidade.Location = new System.Drawing.Point(165, 129);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(124, 20);
            this.txt_quantidade.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_novo);
            this.groupBox1.Controls.Add(this.btn_gravar);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 272);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para Cadastro";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Enabled = false;
            this.btn_excluir.Location = new System.Drawing.Point(284, 188);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(102, 50);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(158, 188);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(102, 50);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(410, 188);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 50);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(35, 188);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(102, 50);
            this.btn_novo.TabIndex = 1;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(158, 188);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(102, 50);
            this.btn_gravar.TabIndex = 5;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // tp_alterProduto
            // 
            this.tp_alterProduto.Controls.Add(this.btnpesquisa);
            this.tp_alterProduto.Controls.Add(this.txtpesquisa);
            this.tp_alterProduto.Controls.Add(this.dgvproduto);
            this.tp_alterProduto.Location = new System.Drawing.Point(4, 22);
            this.tp_alterProduto.Name = "tp_alterProduto";
            this.tp_alterProduto.Size = new System.Drawing.Size(591, 330);
            this.tp_alterProduto.TabIndex = 1;
            this.tp_alterProduto.Text = "Consultar";
            this.tp_alterProduto.UseVisualStyleBackColor = true;
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Location = new System.Drawing.Point(403, 51);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(98, 31);
            this.btnpesquisa.TabIndex = 5;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(129, 57);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(268, 20);
            this.txtpesquisa.TabIndex = 4;
            // 
            // dgvproduto
            // 
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.quantidade,
            this.peso});
            this.dgvproduto.Location = new System.Drawing.Point(34, 124);
            this.dgvproduto.MultiSelect = false;
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.ReadOnly = true;
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(522, 155);
            this.dgvproduto.TabIndex = 3;
            this.dgvproduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "nome";
            this.descricao.HeaderText = "Nome";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_produto";
            this.Text = "Produto";
            this.Activated += new System.EventHandler(this.frm_produto_Activated);
            this.Load += new System.EventHandler(this.frm_produto_Load);
            this.MdiChildActivate += new System.EventHandler(this.frm_produto_MdiChildActivate);
            this.tabControl1.ResumeLayout(false);
            this.tp_produto.ResumeLayout(false);
            this.tp_produto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tp_alterProduto.ResumeLayout(false);
            this.tp_alterProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_produto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TabPage tp_alterProduto;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
    }
}