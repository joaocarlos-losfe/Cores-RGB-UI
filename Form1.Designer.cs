namespace Definição_e_alteração_de_cores
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painelCor = new System.Windows.Forms.Panel();
            this.RGB = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.ct_vermelho = new System.Windows.Forms.TextBox();
            this.ct_verde = new System.Windows.Forms.TextBox();
            this.ct_azul = new System.Windows.Forms.TextBox();
            this.R0 = new System.Windows.Forms.Label();
            this.G1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.erro_texto_rgb = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numero_de_cores_salvas = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // painelCor
            // 
            this.painelCor.BackColor = System.Drawing.Color.Black;
            this.painelCor.Location = new System.Drawing.Point(12, 12);
            this.painelCor.Name = "painelCor";
            this.painelCor.Size = new System.Drawing.Size(333, 103);
            this.painelCor.TabIndex = 1;
            // 
            // RGB
            // 
            this.RGB.Location = new System.Drawing.Point(12, 121);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(35, 23);
            this.RGB.TabIndex = 2;
            this.RGB.Text = "RGB: ";
            this.RGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(58, 189);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(413, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TabStop = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vermelho";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(9, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verde";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(58, 240);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(413, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TabStop = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Azul";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(58, 291);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(413, 45);
            this.trackBar3.TabIndex = 7;
            this.trackBar3.TabStop = false;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // ct_vermelho
            // 
            this.ct_vermelho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_vermelho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_vermelho.Location = new System.Drawing.Point(477, 191);
            this.ct_vermelho.Name = "ct_vermelho";
            this.ct_vermelho.Size = new System.Drawing.Size(42, 23);
            this.ct_vermelho.TabIndex = 9;
            this.ct_vermelho.Text = "0";
            this.ct_vermelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_vermelho.TextChanged += new System.EventHandler(this.ct_vermelho_TextChanged);
            // 
            // ct_verde
            // 
            this.ct_verde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_verde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_verde.Location = new System.Drawing.Point(477, 242);
            this.ct_verde.Name = "ct_verde";
            this.ct_verde.Size = new System.Drawing.Size(42, 23);
            this.ct_verde.TabIndex = 10;
            this.ct_verde.Text = "0";
            this.ct_verde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_verde.TextChanged += new System.EventHandler(this.ct_verde_TextChanged);
            // 
            // ct_azul
            // 
            this.ct_azul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ct_azul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_azul.Location = new System.Drawing.Point(477, 293);
            this.ct_azul.Name = "ct_azul";
            this.ct_azul.Size = new System.Drawing.Size(42, 23);
            this.ct_azul.TabIndex = 11;
            this.ct_azul.Text = "0";
            this.ct_azul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_azul.TextChanged += new System.EventHandler(this.ct_azul_TextChanged);
            // 
            // R0
            // 
            this.R0.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R0.ForeColor = System.Drawing.Color.Red;
            this.R0.Location = new System.Drawing.Point(53, 121);
            this.R0.Margin = new System.Windows.Forms.Padding(3);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(35, 23);
            this.R0.TabIndex = 12;
            this.R0.Text = "0";
            this.R0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // G1
            // 
            this.G1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G1.ForeColor = System.Drawing.Color.Green;
            this.G1.Location = new System.Drawing.Point(94, 121);
            this.G1.Margin = new System.Windows.Forms.Padding(3);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(35, 23);
            this.G1.TabIndex = 13;
            this.G1.Text = "0";
            this.G1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.G1.Click += new System.EventHandler(this.label4_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.Blue;
            this.B2.Location = new System.Drawing.Point(135, 121);
            this.B2.Margin = new System.Windows.Forms.Padding(3);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(35, 23);
            this.B2.TabIndex = 14;
            this.B2.Text = "0";
            this.B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B2.Click += new System.EventHandler(this.label5_Click);
            // 
            // erro_texto_rgb
            // 
            this.erro_texto_rgb.AutoSize = true;
            this.erro_texto_rgb.ForeColor = System.Drawing.Color.OrangeRed;
            this.erro_texto_rgb.Location = new System.Drawing.Point(123, 161);
            this.erro_texto_rgb.Name = "erro_texto_rgb";
            this.erro_texto_rgb.Size = new System.Drawing.Size(294, 13);
            this.erro_texto_rgb.TabIndex = 15;
            this.erro_texto_rgb.Text = "Erro nos valores RGB. Defina um valor menor ou igual a 255.";
            this.erro_texto_rgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.erro_texto_rgb.Visible = false;
            // 
            // Salvar
            // 
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Location = new System.Drawing.Point(184, 369);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 16;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cores salvas: ";
            // 
            // numero_de_cores_salvas
            // 
            this.numero_de_cores_salvas.Location = new System.Drawing.Point(292, 336);
            this.numero_de_cores_salvas.Name = "numero_de_cores_salvas";
            this.numero_de_cores_salvas.Size = new System.Drawing.Size(31, 18);
            this.numero_de_cores_salvas.TabIndex = 19;
            this.numero_de_cores_salvas.Text = "0";
            this.numero_de_cores_salvas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numero_de_cores_salvas.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Location = new System.Drawing.Point(282, 369);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_exportar.TabIndex = 20;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(529, 404);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.numero_de_cores_salvas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.erro_texto_rgb);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.R0);
            this.Controls.Add(this.ct_azul);
            this.Controls.Add(this.ct_verde);
            this.Controls.Add(this.ct_vermelho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.painelCor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores RGBA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painelCor;
        private System.Windows.Forms.Label RGB;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox ct_vermelho;
        private System.Windows.Forms.TextBox ct_verde;
        private System.Windows.Forms.TextBox ct_azul;
        private System.Windows.Forms.Label R0;
        private System.Windows.Forms.Label G1;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label erro_texto_rgb;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numero_de_cores_salvas;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

