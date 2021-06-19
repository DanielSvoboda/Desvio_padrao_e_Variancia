namespace desvio_padrao
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
            this.osNumeros = new System.Windows.Forms.TextBox();
            this.label_numeros = new System.Windows.Forms.Label();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.aMEDIA = new System.Windows.Forms.Label();
            this.oTAMANHO = new System.Windows.Forms.Label();
            this.aSOMA = new System.Windows.Forms.Label();
            this.label_SOMA = new System.Windows.Forms.Label();
            this.label_TAMANHO = new System.Windows.Forms.Label();
            this.label_MEDIA = new System.Windows.Forms.Label();
            this.oDESVIO = new System.Windows.Forms.Label();
            this.group_CALCULOS = new System.Windows.Forms.GroupBox();
            this.label_MEDIANA = new System.Windows.Forms.Label();
            this.aMEDIANA = new System.Windows.Forms.Label();
            this.group_DESVIO = new System.Windows.Forms.GroupBox();
            this.group_VARIÂNCIA = new System.Windows.Forms.GroupBox();
            this.aVARIANCIA_C = new System.Windows.Forms.Label();
            this.aVARIANCIA_B = new System.Windows.Forms.Label();
            this.aVARIANCIA_A = new System.Windows.Forms.Label();
            this.group_DESVIO_PADRÃO_POPULACIONAL = new System.Windows.Forms.GroupBox();
            this.oDESVIOpADRAO_p = new System.Windows.Forms.Label();
            this.group_DESVIO_PADRÃO_AMOSTRAL = new System.Windows.Forms.GroupBox();
            this.oDESVIOpADRAO_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUMEROS_ORDENADO = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.group_CALCULOS.SuspendLayout();
            this.group_DESVIO.SuspendLayout();
            this.group_VARIÂNCIA.SuspendLayout();
            this.group_DESVIO_PADRÃO_POPULACIONAL.SuspendLayout();
            this.group_DESVIO_PADRÃO_AMOSTRAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // osNumeros
            // 
            this.osNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osNumeros.Location = new System.Drawing.Point(108, 36);
            this.osNumeros.Name = "osNumeros";
            this.osNumeros.Size = new System.Drawing.Size(549, 24);
            this.osNumeros.TabIndex = 0;
            // 
            // label_numeros
            // 
            this.label_numeros.AutoSize = true;
            this.label_numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeros.Location = new System.Drawing.Point(12, 39);
            this.label_numeros.Name = "label_numeros";
            this.label_numeros.Size = new System.Drawing.Size(90, 18);
            this.label_numeros.TabIndex = 1;
            this.label_numeros.Text = "NUMEROS:";
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(663, 36);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(94, 24);
            this.CALCULAR.TabIndex = 2;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // aMEDIA
            // 
            this.aMEDIA.AutoSize = true;
            this.aMEDIA.Location = new System.Drawing.Point(100, 55);
            this.aMEDIA.Name = "aMEDIA";
            this.aMEDIA.Size = new System.Drawing.Size(16, 18);
            this.aMEDIA.TabIndex = 3;
            this.aMEDIA.Text = "0";
            this.aMEDIA.UseWaitCursor = true;
            // 
            // oTAMANHO
            // 
            this.oTAMANHO.AutoSize = true;
            this.oTAMANHO.Location = new System.Drawing.Point(100, 19);
            this.oTAMANHO.Name = "oTAMANHO";
            this.oTAMANHO.Size = new System.Drawing.Size(16, 18);
            this.oTAMANHO.TabIndex = 4;
            this.oTAMANHO.Text = "0";
            this.oTAMANHO.UseWaitCursor = true;
            // 
            // aSOMA
            // 
            this.aSOMA.AutoSize = true;
            this.aSOMA.Location = new System.Drawing.Point(100, 37);
            this.aSOMA.Name = "aSOMA";
            this.aSOMA.Size = new System.Drawing.Size(16, 18);
            this.aSOMA.TabIndex = 5;
            this.aSOMA.Text = "0";
            this.aSOMA.UseWaitCursor = true;
            // 
            // label_SOMA
            // 
            this.label_SOMA.AutoSize = true;
            this.label_SOMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SOMA.Location = new System.Drawing.Point(7, 37);
            this.label_SOMA.Name = "label_SOMA";
            this.label_SOMA.Size = new System.Drawing.Size(84, 18);
            this.label_SOMA.TabIndex = 6;
            this.label_SOMA.Text = "SOMA       :";
            this.label_SOMA.UseWaitCursor = true;
            // 
            // label_TAMANHO
            // 
            this.label_TAMANHO.AutoSize = true;
            this.label_TAMANHO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TAMANHO.Location = new System.Drawing.Point(6, 19);
            this.label_TAMANHO.Name = "label_TAMANHO";
            this.label_TAMANHO.Size = new System.Drawing.Size(86, 18);
            this.label_TAMANHO.TabIndex = 7;
            this.label_TAMANHO.Text = "TAMANHO:";
            this.label_TAMANHO.UseWaitCursor = true;
            // 
            // label_MEDIA
            // 
            this.label_MEDIA.AutoSize = true;
            this.label_MEDIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MEDIA.Location = new System.Drawing.Point(7, 55);
            this.label_MEDIA.Name = "label_MEDIA";
            this.label_MEDIA.Size = new System.Drawing.Size(82, 18);
            this.label_MEDIA.TabIndex = 8;
            this.label_MEDIA.Text = "MÉDIA      :";
            this.label_MEDIA.UseWaitCursor = true;
            // 
            // oDESVIO
            // 
            this.oDESVIO.AutoSize = true;
            this.oDESVIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oDESVIO.Location = new System.Drawing.Point(6, 16);
            this.oDESVIO.Name = "oDESVIO";
            this.oDESVIO.Size = new System.Drawing.Size(18, 20);
            this.oDESVIO.TabIndex = 10;
            this.oDESVIO.Text = "0";
            // 
            // group_CALCULOS
            // 
            this.group_CALCULOS.Controls.Add(this.label_MEDIANA);
            this.group_CALCULOS.Controls.Add(this.aMEDIANA);
            this.group_CALCULOS.Controls.Add(this.label_TAMANHO);
            this.group_CALCULOS.Controls.Add(this.label_MEDIA);
            this.group_CALCULOS.Controls.Add(this.label_SOMA);
            this.group_CALCULOS.Controls.Add(this.aMEDIA);
            this.group_CALCULOS.Controls.Add(this.aSOMA);
            this.group_CALCULOS.Controls.Add(this.oTAMANHO);
            this.group_CALCULOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_CALCULOS.Location = new System.Drawing.Point(10, 69);
            this.group_CALCULOS.Name = "group_CALCULOS";
            this.group_CALCULOS.Size = new System.Drawing.Size(167, 105);
            this.group_CALCULOS.TabIndex = 11;
            this.group_CALCULOS.TabStop = false;
            this.group_CALCULOS.Text = "CALCULOS";
            this.group_CALCULOS.UseWaitCursor = true;
            // 
            // label_MEDIANA
            // 
            this.label_MEDIANA.AutoSize = true;
            this.label_MEDIANA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MEDIANA.Location = new System.Drawing.Point(7, 73);
            this.label_MEDIANA.Name = "label_MEDIANA";
            this.label_MEDIANA.Size = new System.Drawing.Size(82, 18);
            this.label_MEDIANA.TabIndex = 10;
            this.label_MEDIANA.Text = "MEDIANA :";
            this.label_MEDIANA.UseWaitCursor = true;
            // 
            // aMEDIANA
            // 
            this.aMEDIANA.AutoSize = true;
            this.aMEDIANA.Location = new System.Drawing.Point(100, 73);
            this.aMEDIANA.Name = "aMEDIANA";
            this.aMEDIANA.Size = new System.Drawing.Size(16, 18);
            this.aMEDIANA.TabIndex = 9;
            this.aMEDIANA.Text = "0";
            this.aMEDIANA.UseWaitCursor = true;
            // 
            // group_DESVIO
            // 
            this.group_DESVIO.Controls.Add(this.oDESVIO);
            this.group_DESVIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_DESVIO.Location = new System.Drawing.Point(10, 180);
            this.group_DESVIO.Name = "group_DESVIO";
            this.group_DESVIO.Size = new System.Drawing.Size(167, 388);
            this.group_DESVIO.TabIndex = 12;
            this.group_DESVIO.TabStop = false;
            this.group_DESVIO.Text = "DESVIO";
            // 
            // group_VARIÂNCIA
            // 
            this.group_VARIÂNCIA.Controls.Add(this.aVARIANCIA_C);
            this.group_VARIÂNCIA.Controls.Add(this.aVARIANCIA_B);
            this.group_VARIÂNCIA.Controls.Add(this.aVARIANCIA_A);
            this.group_VARIÂNCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_VARIÂNCIA.Location = new System.Drawing.Point(183, 69);
            this.group_VARIÂNCIA.Name = "group_VARIÂNCIA";
            this.group_VARIÂNCIA.Size = new System.Drawing.Size(574, 273);
            this.group_VARIÂNCIA.TabIndex = 13;
            this.group_VARIÂNCIA.TabStop = false;
            this.group_VARIÂNCIA.Text = "VARIÂNCIA (V)";
            // 
            // aVARIANCIA_C
            // 
            this.aVARIANCIA_C.AutoSize = true;
            this.aVARIANCIA_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVARIANCIA_C.Location = new System.Drawing.Point(6, 186);
            this.aVARIANCIA_C.Name = "aVARIANCIA_C";
            this.aVARIANCIA_C.Size = new System.Drawing.Size(18, 20);
            this.aVARIANCIA_C.TabIndex = 13;
            this.aVARIANCIA_C.Text = "0";
            // 
            // aVARIANCIA_B
            // 
            this.aVARIANCIA_B.AutoSize = true;
            this.aVARIANCIA_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVARIANCIA_B.Location = new System.Drawing.Point(6, 105);
            this.aVARIANCIA_B.Name = "aVARIANCIA_B";
            this.aVARIANCIA_B.Size = new System.Drawing.Size(18, 20);
            this.aVARIANCIA_B.TabIndex = 12;
            this.aVARIANCIA_B.Text = "0";
            // 
            // aVARIANCIA_A
            // 
            this.aVARIANCIA_A.AutoSize = true;
            this.aVARIANCIA_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVARIANCIA_A.Location = new System.Drawing.Point(6, 35);
            this.aVARIANCIA_A.Name = "aVARIANCIA_A";
            this.aVARIANCIA_A.Size = new System.Drawing.Size(18, 20);
            this.aVARIANCIA_A.TabIndex = 11;
            this.aVARIANCIA_A.Text = "0";
            // 
            // group_DESVIO_PADRÃO_POPULACIONAL
            // 
            this.group_DESVIO_PADRÃO_POPULACIONAL.Controls.Add(this.oDESVIOpADRAO_p);
            this.group_DESVIO_PADRÃO_POPULACIONAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_DESVIO_PADRÃO_POPULACIONAL.Location = new System.Drawing.Point(183, 348);
            this.group_DESVIO_PADRÃO_POPULACIONAL.Name = "group_DESVIO_PADRÃO_POPULACIONAL";
            this.group_DESVIO_PADRÃO_POPULACIONAL.Size = new System.Drawing.Size(574, 108);
            this.group_DESVIO_PADRÃO_POPULACIONAL.TabIndex = 14;
            this.group_DESVIO_PADRÃO_POPULACIONAL.TabStop = false;
            this.group_DESVIO_PADRÃO_POPULACIONAL.Text = "DESVIO PADRÃO POPULACIONAL (σ)";
            // 
            // oDESVIOpADRAO_p
            // 
            this.oDESVIOpADRAO_p.AutoSize = true;
            this.oDESVIOpADRAO_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oDESVIOpADRAO_p.Location = new System.Drawing.Point(6, 34);
            this.oDESVIOpADRAO_p.Name = "oDESVIOpADRAO_p";
            this.oDESVIOpADRAO_p.Size = new System.Drawing.Size(18, 20);
            this.oDESVIOpADRAO_p.TabIndex = 14;
            this.oDESVIOpADRAO_p.Text = "0";
            // 
            // group_DESVIO_PADRÃO_AMOSTRAL
            // 
            this.group_DESVIO_PADRÃO_AMOSTRAL.Controls.Add(this.oDESVIOpADRAO_a);
            this.group_DESVIO_PADRÃO_AMOSTRAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_DESVIO_PADRÃO_AMOSTRAL.Location = new System.Drawing.Point(183, 462);
            this.group_DESVIO_PADRÃO_AMOSTRAL.Name = "group_DESVIO_PADRÃO_AMOSTRAL";
            this.group_DESVIO_PADRÃO_AMOSTRAL.Size = new System.Drawing.Size(574, 108);
            this.group_DESVIO_PADRÃO_AMOSTRAL.TabIndex = 15;
            this.group_DESVIO_PADRÃO_AMOSTRAL.TabStop = false;
            this.group_DESVIO_PADRÃO_AMOSTRAL.Text = "DESVIO PADRÃO AMOSTRAL (Sx)";
            // 
            // oDESVIOpADRAO_a
            // 
            this.oDESVIOpADRAO_a.AutoSize = true;
            this.oDESVIOpADRAO_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oDESVIOpADRAO_a.Location = new System.Drawing.Point(6, 34);
            this.oDESVIOpADRAO_a.Name = "oDESVIOpADRAO_a";
            this.oDESVIOpADRAO_a.Size = new System.Drawing.Size(18, 20);
            this.oDESVIOpADRAO_a.TabIndex = 14;
            this.oDESVIOpADRAO_a.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "ORDENADO(ROL):";
            // 
            // NUMEROS_ORDENADO
            // 
            this.NUMEROS_ORDENADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMEROS_ORDENADO.Location = new System.Drawing.Point(158, 574);
            this.NUMEROS_ORDENADO.Name = "NUMEROS_ORDENADO";
            this.NUMEROS_ORDENADO.Size = new System.Drawing.Size(599, 24);
            this.NUMEROS_ORDENADO.TabIndex = 16;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(740, 18);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "ESCREVA OS NÚMEROS, SEPARANDO COM ALGUNS DESSES CARACTERES:   \'   \'     \' , \'    " +
    " \' : \'    \' ; \'    \' . \'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 610);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUMEROS_ORDENADO);
            this.Controls.Add(this.group_DESVIO_PADRÃO_AMOSTRAL);
            this.Controls.Add(this.group_DESVIO_PADRÃO_POPULACIONAL);
            this.Controls.Add(this.group_VARIÂNCIA);
            this.Controls.Add(this.group_DESVIO);
            this.Controls.Add(this.group_CALCULOS);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.label_numeros);
            this.Controls.Add(this.osNumeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DESVIO PADRÃO";
            this.group_CALCULOS.ResumeLayout(false);
            this.group_CALCULOS.PerformLayout();
            this.group_DESVIO.ResumeLayout(false);
            this.group_DESVIO.PerformLayout();
            this.group_VARIÂNCIA.ResumeLayout(false);
            this.group_VARIÂNCIA.PerformLayout();
            this.group_DESVIO_PADRÃO_POPULACIONAL.ResumeLayout(false);
            this.group_DESVIO_PADRÃO_POPULACIONAL.PerformLayout();
            this.group_DESVIO_PADRÃO_AMOSTRAL.ResumeLayout(false);
            this.group_DESVIO_PADRÃO_AMOSTRAL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox osNumeros;
        private System.Windows.Forms.Label label_numeros;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Label aMEDIA;
        private System.Windows.Forms.Label oTAMANHO;
        private System.Windows.Forms.Label aSOMA;
        private System.Windows.Forms.Label label_SOMA;
        private System.Windows.Forms.Label label_TAMANHO;
        private System.Windows.Forms.Label label_MEDIA;
        private System.Windows.Forms.Label oDESVIO;
        private System.Windows.Forms.GroupBox group_CALCULOS;
        private System.Windows.Forms.GroupBox group_DESVIO;
        private System.Windows.Forms.GroupBox group_VARIÂNCIA;
        private System.Windows.Forms.Label aVARIANCIA_A;
        private System.Windows.Forms.Label aVARIANCIA_B;
        private System.Windows.Forms.Label aVARIANCIA_C;
        private System.Windows.Forms.GroupBox group_DESVIO_PADRÃO_POPULACIONAL;
        private System.Windows.Forms.Label oDESVIOpADRAO_p;
        private System.Windows.Forms.GroupBox group_DESVIO_PADRÃO_AMOSTRAL;
        private System.Windows.Forms.Label oDESVIOpADRAO_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NUMEROS_ORDENADO;
        private System.Windows.Forms.Label label_MEDIANA;
        private System.Windows.Forms.Label aMEDIANA;
        private System.Windows.Forms.Label label_titulo;
    }
}

