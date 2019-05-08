namespace ProvaPJ
{
    partial class frm_principal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaNovo_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoNovo_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pessoa = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_venda = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(604, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaNovo_menu});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // pessoaNovo_menu
            // 
            this.pessoaNovo_menu.Name = "pessoaNovo_menu";
            this.pessoaNovo_menu.Size = new System.Drawing.Size(103, 22);
            this.pessoaNovo_menu.Text = "Novo";
            this.pessoaNovo_menu.Click += new System.EventHandler(this.pessoaNovo_menu_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoNovo_menu});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // produtoNovo_menu
            // 
            this.produtoNovo_menu.Name = "produtoNovo_menu";
            this.produtoNovo_menu.Size = new System.Drawing.Size(103, 22);
            this.produtoNovo_menu.Text = "Novo";
            this.produtoNovo_menu.Click += new System.EventHandler(this.produtoNovo_menu_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sairToolStripMenuItem.Text = "Programa";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2});
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem2.Text = "Novo";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click);
            // 
            // btn_pessoa
            // 
            this.btn_pessoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pessoa.Location = new System.Drawing.Point(38, 74);
            this.btn_pessoa.Name = "btn_pessoa";
            this.btn_pessoa.Size = new System.Drawing.Size(105, 77);
            this.btn_pessoa.TabIndex = 1;
            this.btn_pessoa.Text = "Pessoa";
            this.btn_pessoa.UseVisualStyleBackColor = false;
            this.btn_pessoa.Click += new System.EventHandler(this.btn_pessoa_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.Location = new System.Drawing.Point(149, 74);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(105, 77);
            this.btn_produto.TabIndex = 2;
            this.btn_produto.Text = "Produto";
            this.btn_produto.UseVisualStyleBackColor = false;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_venda
            // 
            this.btn_venda.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venda.Location = new System.Drawing.Point(260, 74);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(105, 77);
            this.btn_venda.TabIndex = 4;
            this.btn_venda.Text = "Venda";
            this.btn_venda.UseVisualStyleBackColor = false;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_produto);
            this.Controls.Add(this.btn_pessoa);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frm_principal";
            this.Text = "Cadastramento";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem pessoaNovo_menu;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoNovo_menu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Button btn_pessoa;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
    }
}

