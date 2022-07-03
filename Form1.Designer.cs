namespace FormatoDeFuentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BotonFormControl = new System.Windows.Forms.Button();
            this.BotonFormVerde = new System.Windows.Forms.Button();
            this.BotonFormRojo = new System.Windows.Forms.Button();
            this.BotonFormAzul = new System.Windows.Forms.Button();
            this.BotonReducir = new System.Windows.Forms.Button();
            this.BotonAumentar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TamañoFuenteUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BotonTextoNegro = new System.Windows.Forms.Button();
            this.BotonTextoVerde = new System.Windows.Forms.Button();
            this.BotonTextoRojo = new System.Windows.Forms.Button();
            this.BotonTextoAzul = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckSubrayado = new System.Windows.Forms.CheckBox();
            this.CheckCursiva = new System.Windows.Forms.CheckBox();
            this.CheckNegrita = new System.Windows.Forms.CheckBox();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.BotonMostrar = new System.Windows.Forms.Button();
            this.BotonOcultar = new System.Windows.Forms.Button();
            this.ListaFuentes = new System.Windows.Forms.ListBox();
            this.Texto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamañoFuenteUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BotonReducir);
            this.panel1.Controls.Add(this.BotonAumentar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotonFormControl);
            this.groupBox1.Controls.Add(this.BotonFormVerde);
            this.groupBox1.Controls.Add(this.BotonFormRojo);
            this.groupBox1.Controls.Add(this.BotonFormAzul);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color de formulario";
            // 
            // BotonFormControl
            // 
            this.BotonFormControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonFormControl.Location = new System.Drawing.Point(194, 28);
            this.BotonFormControl.Name = "BotonFormControl";
            this.BotonFormControl.Size = new System.Drawing.Size(25, 25);
            this.BotonFormControl.TabIndex = 7;
            this.BotonFormControl.UseVisualStyleBackColor = false;
            this.BotonFormControl.Click += new System.EventHandler(this.BotonFormControl_Click);
            // 
            // BotonFormVerde
            // 
            this.BotonFormVerde.BackColor = System.Drawing.Color.Green;
            this.BotonFormVerde.Location = new System.Drawing.Point(6, 28);
            this.BotonFormVerde.Name = "BotonFormVerde";
            this.BotonFormVerde.Size = new System.Drawing.Size(25, 25);
            this.BotonFormVerde.TabIndex = 3;
            this.BotonFormVerde.UseVisualStyleBackColor = false;
            this.BotonFormVerde.Click += new System.EventHandler(this.BotonFormVerde_Click);
            // 
            // BotonFormRojo
            // 
            this.BotonFormRojo.BackColor = System.Drawing.Color.Red;
            this.BotonFormRojo.Location = new System.Drawing.Point(136, 28);
            this.BotonFormRojo.Name = "BotonFormRojo";
            this.BotonFormRojo.Size = new System.Drawing.Size(25, 25);
            this.BotonFormRojo.TabIndex = 5;
            this.BotonFormRojo.UseVisualStyleBackColor = false;
            this.BotonFormRojo.Click += new System.EventHandler(this.BotonFormRojo_Click);
            // 
            // BotonFormAzul
            // 
            this.BotonFormAzul.BackColor = System.Drawing.SystemColors.Desktop;
            this.BotonFormAzul.Location = new System.Drawing.Point(68, 28);
            this.BotonFormAzul.Name = "BotonFormAzul";
            this.BotonFormAzul.Size = new System.Drawing.Size(25, 25);
            this.BotonFormAzul.TabIndex = 4;
            this.BotonFormAzul.UseVisualStyleBackColor = false;
            this.BotonFormAzul.Click += new System.EventHandler(this.BotonFormAzul_Click);
            // 
            // BotonReducir
            // 
            this.BotonReducir.Location = new System.Drawing.Point(137, 44);
            this.BotonReducir.Name = "BotonReducir";
            this.BotonReducir.Size = new System.Drawing.Size(100, 25);
            this.BotonReducir.TabIndex = 2;
            this.BotonReducir.Text = "Reducir";
            this.BotonReducir.UseVisualStyleBackColor = true;
            this.BotonReducir.Click += new System.EventHandler(this.BotonReducir_Click);
            // 
            // BotonAumentar
            // 
            this.BotonAumentar.Location = new System.Drawing.Point(12, 44);
            this.BotonAumentar.Name = "BotonAumentar";
            this.BotonAumentar.Size = new System.Drawing.Size(100, 25);
            this.BotonAumentar.TabIndex = 1;
            this.BotonAumentar.Text = "Aumentar";
            this.BotonAumentar.UseVisualStyleBackColor = true;
            this.BotonAumentar.Click += new System.EventHandler(this.BotonAumentar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propiedades del FORM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TamañoFuenteUpDown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(26, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 150);
            this.panel2.TabIndex = 3;
            // 
            // TamañoFuenteUpDown
            // 
            this.TamañoFuenteUpDown.Location = new System.Drawing.Point(9, 39);
            this.TamañoFuenteUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.TamañoFuenteUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.TamañoFuenteUpDown.Name = "TamañoFuenteUpDown";
            this.TamañoFuenteUpDown.Size = new System.Drawing.Size(228, 22);
            this.TamañoFuenteUpDown.TabIndex = 7;
            this.TamañoFuenteUpDown.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.TamañoFuenteUpDown.ValueChanged += new System.EventHandler(this.TamañoFuenteUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tamaño del texto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BotonTextoNegro);
            this.groupBox2.Controls.Add(this.BotonTextoVerde);
            this.groupBox2.Controls.Add(this.BotonTextoRojo);
            this.groupBox2.Controls.Add(this.BotonTextoAzul);
            this.groupBox2.Location = new System.Drawing.Point(9, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color de texto";
            // 
            // BotonTextoNegro
            // 
            this.BotonTextoNegro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonTextoNegro.Location = new System.Drawing.Point(197, 28);
            this.BotonTextoNegro.Name = "BotonTextoNegro";
            this.BotonTextoNegro.Size = new System.Drawing.Size(25, 25);
            this.BotonTextoNegro.TabIndex = 8;
            this.BotonTextoNegro.UseVisualStyleBackColor = false;
            this.BotonTextoNegro.Click += new System.EventHandler(this.BotonTextoNegro_Click);
            // 
            // BotonTextoVerde
            // 
            this.BotonTextoVerde.BackColor = System.Drawing.Color.Green;
            this.BotonTextoVerde.Location = new System.Drawing.Point(6, 28);
            this.BotonTextoVerde.Name = "BotonTextoVerde";
            this.BotonTextoVerde.Size = new System.Drawing.Size(25, 25);
            this.BotonTextoVerde.TabIndex = 3;
            this.BotonTextoVerde.UseVisualStyleBackColor = false;
            this.BotonTextoVerde.Click += new System.EventHandler(this.BotonTextoVerde_Click);
            // 
            // BotonTextoRojo
            // 
            this.BotonTextoRojo.BackColor = System.Drawing.Color.Red;
            this.BotonTextoRojo.Location = new System.Drawing.Point(139, 28);
            this.BotonTextoRojo.Name = "BotonTextoRojo";
            this.BotonTextoRojo.Size = new System.Drawing.Size(25, 25);
            this.BotonTextoRojo.TabIndex = 5;
            this.BotonTextoRojo.UseVisualStyleBackColor = false;
            this.BotonTextoRojo.Click += new System.EventHandler(this.BotonTextoRojo_Click);
            // 
            // BotonTextoAzul
            // 
            this.BotonTextoAzul.BackColor = System.Drawing.SystemColors.Desktop;
            this.BotonTextoAzul.Location = new System.Drawing.Point(71, 28);
            this.BotonTextoAzul.Name = "BotonTextoAzul";
            this.BotonTextoAzul.Size = new System.Drawing.Size(25, 25);
            this.BotonTextoAzul.TabIndex = 4;
            this.BotonTextoAzul.UseVisualStyleBackColor = false;
            this.BotonTextoAzul.Click += new System.EventHandler(this.BotonTextoAzul_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CheckSubrayado);
            this.panel3.Controls.Add(this.CheckCursiva);
            this.panel3.Controls.Add(this.CheckNegrita);
            this.panel3.Controls.Add(this.BotonCerrar);
            this.panel3.Controls.Add(this.BotonMostrar);
            this.panel3.Controls.Add(this.BotonOcultar);
            this.panel3.Location = new System.Drawing.Point(26, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 150);
            this.panel3.TabIndex = 4;
            // 
            // CheckSubrayado
            // 
            this.CheckSubrayado.AutoSize = true;
            this.CheckSubrayado.Location = new System.Drawing.Point(377, 94);
            this.CheckSubrayado.Name = "CheckSubrayado";
            this.CheckSubrayado.Size = new System.Drawing.Size(96, 20);
            this.CheckSubrayado.TabIndex = 5;
            this.CheckSubrayado.Text = "Subrayado";
            this.CheckSubrayado.UseVisualStyleBackColor = true;
            this.CheckSubrayado.CheckedChanged += new System.EventHandler(this.CheckSubrayado_CheckedChanged);
            // 
            // CheckCursiva
            // 
            this.CheckCursiva.AutoSize = true;
            this.CheckCursiva.Location = new System.Drawing.Point(215, 94);
            this.CheckCursiva.Name = "CheckCursiva";
            this.CheckCursiva.Size = new System.Drawing.Size(74, 20);
            this.CheckCursiva.TabIndex = 4;
            this.CheckCursiva.Text = "Cursiva";
            this.CheckCursiva.UseVisualStyleBackColor = true;
            this.CheckCursiva.CheckedChanged += new System.EventHandler(this.CheckCursiva_CheckedChanged);
            // 
            // CheckNegrita
            // 
            this.CheckNegrita.AutoSize = true;
            this.CheckNegrita.Location = new System.Drawing.Point(30, 94);
            this.CheckNegrita.Name = "CheckNegrita";
            this.CheckNegrita.Size = new System.Drawing.Size(73, 20);
            this.CheckNegrita.TabIndex = 3;
            this.CheckNegrita.Text = "Negrita";
            this.CheckNegrita.UseVisualStyleBackColor = true;
            this.CheckNegrita.CheckedChanged += new System.EventHandler(this.CheckNegrita_CheckedChanged);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(366, 29);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(120, 30);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BotonMostrar
            // 
            this.BotonMostrar.Location = new System.Drawing.Point(191, 29);
            this.BotonMostrar.Name = "BotonMostrar";
            this.BotonMostrar.Size = new System.Drawing.Size(120, 30);
            this.BotonMostrar.TabIndex = 1;
            this.BotonMostrar.Text = "Mostrar texto";
            this.BotonMostrar.UseVisualStyleBackColor = true;
            this.BotonMostrar.Click += new System.EventHandler(this.BotonMostrar_Click);
            // 
            // BotonOcultar
            // 
            this.BotonOcultar.Location = new System.Drawing.Point(16, 29);
            this.BotonOcultar.Name = "BotonOcultar";
            this.BotonOcultar.Size = new System.Drawing.Size(120, 30);
            this.BotonOcultar.TabIndex = 0;
            this.BotonOcultar.Text = "Ocultar texto";
            this.BotonOcultar.UseVisualStyleBackColor = true;
            this.BotonOcultar.Click += new System.EventHandler(this.BotonOcultar_Click);
            // 
            // ListaFuentes
            // 
            this.ListaFuentes.FormattingEnabled = true;
            this.ListaFuentes.ItemHeight = 16;
            this.ListaFuentes.Location = new System.Drawing.Point(550, 24);
            this.ListaFuentes.Name = "ListaFuentes";
            this.ListaFuentes.Size = new System.Drawing.Size(220, 500);
            this.ListaFuentes.TabIndex = 5;
            this.ListaFuentes.SelectedIndexChanged += new System.EventHandler(this.ListaFuentes_SelectedIndexChanged);
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Texto.Location = new System.Drawing.Point(372, 252);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(41, 16);
            this.Texto.TabIndex = 6;
            this.Texto.Text = "Texto";
            this.Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.ListaFuentes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TamañoFuenteUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ListaFuentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BotonFormVerde;
        private System.Windows.Forms.Button BotonFormRojo;
        private System.Windows.Forms.Button BotonFormAzul;
        private System.Windows.Forms.Button BotonReducir;
        private System.Windows.Forms.Button BotonAumentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BotonTextoVerde;
        private System.Windows.Forms.Button BotonTextoRojo;
        private System.Windows.Forms.Button BotonTextoAzul;
        private System.Windows.Forms.CheckBox CheckSubrayado;
        private System.Windows.Forms.CheckBox CheckCursiva;
        private System.Windows.Forms.CheckBox CheckNegrita;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button BotonMostrar;
        private System.Windows.Forms.Button BotonOcultar;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Button BotonFormControl;
        private System.Windows.Forms.Button BotonTextoNegro;
        private System.Windows.Forms.NumericUpDown TamañoFuenteUpDown;
    }
}

