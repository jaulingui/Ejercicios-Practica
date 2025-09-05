namespace PracticaWindowsForms2
{
    partial class Form3
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
            this.txtNumUno = new System.Windows.Forms.TextBox();
            this.txtNumDos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblExcepciones = new System.Windows.Forms.Label();
            this.lblExcepcionLanzada = new System.Windows.Forms.Label();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.txtValorDos = new System.Windows.Forms.TextBox();
            this.txtValorUno = new System.Windows.Forms.TextBox();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumUno
            // 
            this.txtNumUno.Location = new System.Drawing.Point(84, 140);
            this.txtNumUno.Name = "txtNumUno";
            this.txtNumUno.Size = new System.Drawing.Size(124, 20);
            this.txtNumUno.TabIndex = 0;
            // 
            // txtNumDos
            // 
            this.txtNumDos.Location = new System.Drawing.Point(84, 192);
            this.txtNumDos.Name = "txtNumDos";
            this.txtNumDos.Size = new System.Drawing.Size(124, 20);
            this.txtNumDos.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(107, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(107, 314);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblExcepciones
            // 
            this.lblExcepciones.AutoSize = true;
            this.lblExcepciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcepciones.Location = new System.Drawing.Point(84, 68);
            this.lblExcepciones.Name = "lblExcepciones";
            this.lblExcepciones.Size = new System.Drawing.Size(107, 22);
            this.lblExcepciones.TabIndex = 4;
            this.lblExcepciones.Text = "Excepciones";
            // 
            // lblExcepcionLanzada
            // 
            this.lblExcepcionLanzada.AutoSize = true;
            this.lblExcepcionLanzada.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcepcionLanzada.Location = new System.Drawing.Point(301, 68);
            this.lblExcepcionLanzada.Name = "lblExcepcionLanzada";
            this.lblExcepcionLanzada.Size = new System.Drawing.Size(181, 22);
            this.lblExcepcionLanzada.TabIndex = 8;
            this.lblExcepcionLanzada.Text = "Excepciones lanzadas";
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(324, 240);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular2.TabIndex = 7;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // txtValorDos
            // 
            this.txtValorDos.Location = new System.Drawing.Point(301, 192);
            this.txtValorDos.Name = "txtValorDos";
            this.txtValorDos.Size = new System.Drawing.Size(124, 20);
            this.txtValorDos.TabIndex = 6;
            // 
            // txtValorUno
            // 
            this.txtValorUno.Location = new System.Drawing.Point(301, 140);
            this.txtValorUno.Name = "txtValorUno";
            this.txtValorUno.Size = new System.Drawing.Size(124, 20);
            this.txtValorUno.TabIndex = 5;
            // 
            // lblResultado2
            // 
            this.lblResultado2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(324, 314);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultado2.Size = new System.Drawing.Size(0, 13);
            this.lblResultado2.TabIndex = 9;
            this.lblResultado2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 537);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblExcepcionLanzada);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.txtValorDos);
            this.Controls.Add(this.txtValorUno);
            this.Controls.Add(this.lblExcepciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumDos);
            this.Controls.Add(this.txtNumUno);
            this.MaximumSize = new System.Drawing.Size(562, 576);
            this.MinimumSize = new System.Drawing.Size(562, 576);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumUno;
        private System.Windows.Forms.TextBox txtNumDos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblExcepciones;
        private System.Windows.Forms.Label lblExcepcionLanzada;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.TextBox txtValorDos;
        private System.Windows.Forms.TextBox txtValorUno;
        private System.Windows.Forms.Label lblResultado2;
    }
}