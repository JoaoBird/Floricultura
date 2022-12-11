namespace Floricultura
{
    partial class Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.la_nome_p = new System.Windows.Forms.Label();
            this.la_tp = new System.Windows.Forms.Label();
            this.la_preco = new System.Windows.Forms.Label();
            this.la_qtd_p = new System.Windows.Forms.Label();
            this.box_nome_p = new System.Windows.Forms.TextBox();
            this.cb_tp = new System.Windows.Forms.ComboBox();
            this.box_qtd = new System.Windows.Forms.TextBox();
            this.box_preco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.nome_produto,
            this.tipo_produto,
            this.preco,
            this.qtd_estoque});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(976, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(451, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Itens Disponiveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(997, 109);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(118, 65);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar Item";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editar.Location = new System.Drawing.Point(997, 307);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(118, 65);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar Item";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_excluir.Location = new System.Drawing.Point(997, 209);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(118, 65);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir Item";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // la_nome_p
            // 
            this.la_nome_p.AutoSize = true;
            this.la_nome_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_nome_p.Location = new System.Drawing.Point(8, 400);
            this.la_nome_p.Name = "la_nome_p";
            this.la_nome_p.Size = new System.Drawing.Size(160, 24);
            this.la_nome_p.TabIndex = 5;
            this.la_nome_p.Text = "Nome do Produto";
            // 
            // la_tp
            // 
            this.la_tp.AutoSize = true;
            this.la_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_tp.Location = new System.Drawing.Point(438, 402);
            this.la_tp.Name = "la_tp";
            this.la_tp.Size = new System.Drawing.Size(119, 24);
            this.la_tp.TabIndex = 6;
            this.la_tp.Text = "Tipo Produto";
            // 
            // la_preco
            // 
            this.la_preco.AutoSize = true;
            this.la_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_preco.Location = new System.Drawing.Point(8, 445);
            this.la_preco.Name = "la_preco";
            this.la_preco.Size = new System.Drawing.Size(60, 24);
            this.la_preco.TabIndex = 7;
            this.la_preco.Text = "Preço";
            // 
            // la_qtd_p
            // 
            this.la_qtd_p.AutoSize = true;
            this.la_qtd_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la_qtd_p.Location = new System.Drawing.Point(438, 449);
            this.la_qtd_p.Name = "la_qtd_p";
            this.la_qtd_p.Size = new System.Drawing.Size(108, 24);
            this.la_qtd_p.TabIndex = 8;
            this.la_qtd_p.Text = "Quantidade";
            // 
            // box_nome_p
            // 
            this.box_nome_p.Location = new System.Drawing.Point(177, 404);
            this.box_nome_p.Name = "box_nome_p";
            this.box_nome_p.Size = new System.Drawing.Size(244, 20);
            this.box_nome_p.TabIndex = 9;
            // 
            // cb_tp
            // 
            this.cb_tp.FormattingEnabled = true;
            this.cb_tp.Location = new System.Drawing.Point(607, 405);
            this.cb_tp.Name = "cb_tp";
            this.cb_tp.Size = new System.Drawing.Size(119, 21);
            this.cb_tp.TabIndex = 10;
            // 
            // box_qtd
            // 
            this.box_qtd.Location = new System.Drawing.Point(607, 453);
            this.box_qtd.Name = "box_qtd";
            this.box_qtd.Size = new System.Drawing.Size(50, 20);
            this.box_qtd.TabIndex = 12;
            // 
            // box_preco
            // 
            this.box_preco.Location = new System.Drawing.Point(177, 449);
            this.box_preco.Name = "box_preco";
            this.box_preco.Size = new System.Drawing.Size(119, 20);
            this.box_preco.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 100);
            this.panel1.TabIndex = 13;
            // 
            // id_produto
            // 
            this.id_produto.DataPropertyName = "id_produto";
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_produto.DataPropertyName = "nome_produto";
            this.nome_produto.HeaderText = "nome_produto";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            // 
            // tipo_produto
            // 
            this.tipo_produto.DataPropertyName = "tipo_produto";
            this.tipo_produto.HeaderText = "tipo_produto";
            this.tipo_produto.Name = "tipo_produto";
            this.tipo_produto.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "preco";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.DataPropertyName = "qtd_estoque";
            this.qtd_estoque.HeaderText = "qtd_estoque";
            this.qtd_estoque.Name = "qtd_estoque";
            this.qtd_estoque.ReadOnly = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 484);
            this.Controls.Add(this.box_preco);
            this.Controls.Add(this.box_qtd);
            this.Controls.Add(this.cb_tp);
            this.Controls.Add(this.box_nome_p);
            this.Controls.Add(this.la_qtd_p);
            this.Controls.Add(this.la_preco);
            this.Controls.Add(this.la_tp);
            this.Controls.Add(this.la_nome_p);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label la_nome_p;
        private System.Windows.Forms.Label la_tp;
        private System.Windows.Forms.Label la_preco;
        private System.Windows.Forms.Label la_qtd_p;
        private System.Windows.Forms.TextBox box_nome_p;
        private System.Windows.Forms.ComboBox cb_tp;
        private System.Windows.Forms.TextBox box_qtd;
        private System.Windows.Forms.TextBox box_preco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_estoque;
    }
}