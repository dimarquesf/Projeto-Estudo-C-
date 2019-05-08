namespace ProvaPJ
{
    partial class frm_estoque
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
            this.tp_pesquisa = new System.Windows.Forms.TabPage();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_entrada = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_produto = new System.Windows.Forms.ComboBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.tp_saida = new System.Windows.Forms.TabPage();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cmb_produto2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantidade2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id2 = new System.Windows.Forms.TextBox();
            this.tp_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_entrada.SuspendLayout();
            this.tp_saida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_pesquisa
            // 
            this.tp_pesquisa.Controls.Add(this.btnpesquisa);
            this.tp_pesquisa.Controls.Add(this.txtpesquisa);
            this.tp_pesquisa.Controls.Add(this.dgvproduto);
            this.tp_pesquisa.Location = new System.Drawing.Point(4, 22);
            this.tp_pesquisa.Name = "tp_pesquisa";
            this.tp_pesquisa.Size = new System.Drawing.Size(591, 330);
            this.tp_pesquisa.TabIndex = 1;
            this.tp_pesquisa.Text = "Consultar";
            this.tp_pesquisa.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_pesquisa);
            this.tabControl1.Controls.Add(this.tp_entrada);
            this.tabControl1.Controls.Add(this.tp_saida);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 356);
            this.tabControl1.TabIndex = 1;
            // 
            // tp_entrada
            // 
            this.tp_entrada.Controls.Add(this.lbl_id);
            this.tp_entrada.Controls.Add(this.txt_id);
            this.tp_entrada.Controls.Add(this.button1);
            this.tp_entrada.Controls.Add(this.button2);
            this.tp_entrada.Controls.Add(this.button3);
            this.tp_entrada.Controls.Add(this.cmb_produto);
            this.tp_entrada.Controls.Add(this.lbl_nome);
            this.tp_entrada.Controls.Add(this.lbl_quantidade);
            this.tp_entrada.Controls.Add(this.txt_quantidade);
            this.tp_entrada.Location = new System.Drawing.Point(4, 22);
            this.tp_entrada.Name = "tp_entrada";
            this.tp_entrada.Size = new System.Drawing.Size(591, 330);
            this.tp_entrada.TabIndex = 2;
            this.tp_entrada.Text = "Entrada";
            this.tp_entrada.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(109, 59);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 80;
            this.lbl_id.Text = "ID";
            this.lbl_id.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(197, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 20);
            this.txt_id.TabIndex = 81;
            this.txt_id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 75;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 76;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 50);
            this.button3.TabIndex = 77;
            this.button3.Text = "NOVO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_produto
            // 
            this.cmb_produto.FormattingEnabled = true;
            this.cmb_produto.Location = new System.Drawing.Point(197, 88);
            this.cmb_produto.Name = "cmb_produto";
            this.cmb_produto.Size = new System.Drawing.Size(172, 21);
            this.cmb_produto.TabIndex = 74;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(109, 88);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 13);
            this.lbl_nome.TabIndex = 72;
            this.lbl_nome.Text = "Nome Produto";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(109, 120);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 73;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(197, 117);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(110, 20);
            this.txt_quantidade.TabIndex = 71;
            // 
            // tp_saida
            // 
            this.tp_saida.Controls.Add(this.label3);
            this.tp_saida.Controls.Add(this.txt_id2);
            this.tp_saida.Controls.Add(this.btn_gravar);
            this.tp_saida.Controls.Add(this.btn_cancelar);
            this.tp_saida.Controls.Add(this.btn_novo);
            this.tp_saida.Controls.Add(this.cmb_produto2);
            this.tp_saida.Controls.Add(this.label1);
            this.tp_saida.Controls.Add(this.label2);
            this.tp_saida.Controls.Add(this.txt_quantidade2);
            this.tp_saida.Location = new System.Drawing.Point(4, 22);
            this.tp_saida.Name = "tp_saida";
            this.tp_saida.Size = new System.Drawing.Size(591, 330);
            this.tp_saida.TabIndex = 3;
            this.tp_saida.Text = "Saída";
            this.tp_saida.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(239, 221);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(120, 50);
            this.btn_gravar.TabIndex = 76;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(412, 221);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 50);
            this.btn_cancelar.TabIndex = 77;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(77, 221);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(102, 50);
            this.btn_novo.TabIndex = 78;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // cmb_produto2
            // 
            this.cmb_produto2.FormattingEnabled = true;
            this.cmb_produto2.Location = new System.Drawing.Point(177, 64);
            this.cmb_produto2.Name = "cmb_produto2";
            this.cmb_produto2.Size = new System.Drawing.Size(172, 21);
            this.cmb_produto2.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nome Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Quantidade";
            // 
            // txt_quantidade2
            // 
            this.txt_quantidade2.Location = new System.Drawing.Point(177, 101);
            this.txt_quantidade2.Name = "txt_quantidade2";
            this.txt_quantidade2.Size = new System.Drawing.Size(124, 20);
            this.txt_quantidade2.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // txt_id2
            // 
            this.txt_id2.Enabled = false;
            this.txt_id2.Location = new System.Drawing.Point(177, 30);
            this.txt_id2.Name = "txt_id2";
            this.txt_id2.Size = new System.Drawing.Size(56, 20);
            this.txt_id2.TabIndex = 83;
            this.txt_id2.Visible = false;
            // 
            // frm_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_estoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormControleEstoque_Load);
            this.tp_pesquisa.ResumeLayout(false);
            this.tp_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_entrada.ResumeLayout(false);
            this.tp_entrada.PerformLayout();
            this.tp_saida.ResumeLayout(false);
            this.tp_saida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_pesquisa;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_entrada;
        private System.Windows.Forms.TabPage tp_saida;
        private System.Windows.Forms.ComboBox cmb_produto;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.ComboBox cmb_produto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantidade2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id2;
    }
}