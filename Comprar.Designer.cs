namespace Floricultura
{
    partial class Comprar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_nome_c = new System.Windows.Forms.TextBox();
            this.box_rg_c = new System.Windows.Forms.TextBox();
            this.box_rua = new System.Windows.Forms.TextBox();
            this.box_fone = new System.Windows.Forms.MaskedTextBox();
            this.btn_com = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.box_qtd_ven = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(335, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itens Disponiveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rua";
            // 
            // box_nome_c
            // 
            this.box_nome_c.Location = new System.Drawing.Point(166, 401);
            this.box_nome_c.Name = "box_nome_c";
            this.box_nome_c.Size = new System.Drawing.Size(223, 20);
            this.box_nome_c.TabIndex = 6;
            this.box_nome_c.TextChanged += new System.EventHandler(this.box_nome_c_TextChanged);
            // 
            // box_rg_c
            // 
            this.box_rg_c.Location = new System.Drawing.Point(166, 448);
            this.box_rg_c.Name = "box_rg_c";
            this.box_rg_c.Size = new System.Drawing.Size(223, 20);
            this.box_rg_c.TabIndex = 6;
            this.box_rg_c.TextChanged += new System.EventHandler(this.box_nome_c_TextChanged);
            // 
            // box_rua
            // 
            this.box_rua.Location = new System.Drawing.Point(166, 547);
            this.box_rua.Name = "box_rua";
            this.box_rua.Size = new System.Drawing.Size(223, 20);
            this.box_rua.TabIndex = 6;
            this.box_rua.TextChanged += new System.EventHandler(this.box_nome_c_TextChanged);
            // 
            // box_fone
            // 
            this.box_fone.Location = new System.Drawing.Point(166, 497);
            this.box_fone.Mask = "(00) 00000-0000";
            this.box_fone.Name = "box_fone";
            this.box_fone.Size = new System.Drawing.Size(223, 20);
            this.box_fone.TabIndex = 7;
            // 
            // btn_com
            // 
            this.btn_com.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_com.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_com.Location = new System.Drawing.Point(720, 517);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(204, 95);
            this.btn_com.TabIndex = 8;
            this.btn_com.Text = "Comprar";
            this.btn_com.UseVisualStyleBackColor = false;
            this.btn_com.Click += new System.EventHandler(this.btn_com_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.nome_produto,
            this.tipo_produto,
            this.preco,
            this.qtd_estoque});
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 280);
            this.dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade";
            // 
            // box_qtd_ven
            // 
            this.box_qtd_ven.Location = new System.Drawing.Point(166, 592);
            this.box_qtd_ven.Name = "box_qtd_ven";
            this.box_qtd_ven.Size = new System.Drawing.Size(54, 20);
            this.box_qtd_ven.TabIndex = 6;
            this.box_qtd_ven.TextChanged += new System.EventHandler(this.box_nome_c_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 99);
            this.panel1.TabIndex = 11;
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
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_com);
            this.Controls.Add(this.box_fone);
            this.Controls.Add(this.box_qtd_ven);
            this.Controls.Add(this.box_rua);
            this.Controls.Add(this.box_rg_c);
            this.Controls.Add(this.box_nome_c);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_nome_c;
        private System.Windows.Forms.TextBox box_rg_c;
        private System.Windows.Forms.TextBox box_rua;
        private System.Windows.Forms.MaskedTextBox box_fone;
        private System.Windows.Forms.Button btn_com;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_qtd_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_estoque;
        private System.Windows.Forms.Panel panel1;
    }
}