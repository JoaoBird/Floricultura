namespace Floricultura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_historico_c = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Administrador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_estoque
            // 
            this.btn_estoque.FlatAppearance.BorderSize = 0;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_estoque.Location = new System.Drawing.Point(35, 249);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(243, 55);
            this.btn_estoque.TabIndex = 0;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.UseVisualStyleBackColor = true;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.FlatAppearance.BorderSize = 0;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_comprar.Location = new System.Drawing.Point(77, 285);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(136, 54);
            this.btn_comprar.TabIndex = 1;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_historico_c
            // 
            this.btn_historico_c.FlatAppearance.BorderSize = 0;
            this.btn_historico_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historico_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historico_c.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_historico_c.Location = new System.Drawing.Point(26, 378);
            this.btn_historico_c.Name = "btn_historico_c";
            this.btn_historico_c.Size = new System.Drawing.Size(252, 55);
            this.btn_historico_c.TabIndex = 2;
            this.btn_historico_c.Text = "Historico do Cliente";
            this.btn_historico_c.UseVisualStyleBackColor = true;
            this.btn_historico_c.Click += new System.EventHandler(this.btn_historico_c_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.Administrador);
            this.panel1.Controls.Add(this.btn_estoque);
            this.panel1.Controls.Add(this.btn_historico_c);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 625);
            this.panel1.TabIndex = 3;
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = true;
            this.Administrador.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Administrador.Location = new System.Drawing.Point(42, 46);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(199, 37);
            this.Administrador.TabIndex = 3;
            this.Administrador.Text = "Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.Cliente);
            this.panel2.Controls.Add(this.btn_comprar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 625);
            this.panel2.TabIndex = 4;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cliente.Location = new System.Drawing.Point(96, 46);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(105, 37);
            this.Cliente.TabIndex = 3;
            this.Cliente.Text = "Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_historico_c;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Administrador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

