namespace PracticaWindowsForms2
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.rbtRojo = new System.Windows.Forms.RadioButton();
            this.rbtVerde = new System.Windows.Forms.RadioButton();
            this.rbtAzul = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.lblDatosGenerales = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(55, 229);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(100, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // lvElementos
            // 
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(55, 264);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(230, 97);
            this.lvElementos.TabIndex = 1;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(55, 406);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // rbtRojo
            // 
            this.rbtRojo.AutoSize = true;
            this.rbtRojo.Checked = true;
            this.rbtRojo.Location = new System.Drawing.Point(10, 19);
            this.rbtRojo.Name = "rbtRojo";
            this.rbtRojo.Size = new System.Drawing.Size(47, 17);
            this.rbtRojo.TabIndex = 3;
            this.rbtRojo.TabStop = true;
            this.rbtRojo.Text = "Rojo";
            this.rbtRojo.UseVisualStyleBackColor = true;
            // 
            // rbtVerde
            // 
            this.rbtVerde.AutoSize = true;
            this.rbtVerde.Location = new System.Drawing.Point(102, 19);
            this.rbtVerde.Name = "rbtVerde";
            this.rbtVerde.Size = new System.Drawing.Size(53, 17);
            this.rbtVerde.TabIndex = 4;
            this.rbtVerde.Text = "Verde";
            this.rbtVerde.UseVisualStyleBackColor = true;
            // 
            // rbtAzul
            // 
            this.rbtAzul.AutoSize = true;
            this.rbtAzul.Location = new System.Drawing.Point(194, 19);
            this.rbtAzul.Name = "rbtAzul";
            this.rbtAzul.Size = new System.Drawing.Size(45, 17);
            this.rbtAzul.TabIndex = 5;
            this.rbtAzul.Text = "Azul";
            this.rbtAzul.UseVisualStyleBackColor = true;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.rbtAzul);
            this.grbColor.Controls.Add(this.rbtRojo);
            this.grbColor.Controls.Add(this.rbtVerde);
            this.grbColor.Location = new System.Drawing.Point(55, 150);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(254, 53);
            this.grbColor.TabIndex = 6;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // lblDatosGenerales
            // 
            this.lblDatosGenerales.AutoSize = true;
            this.lblDatosGenerales.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosGenerales.Location = new System.Drawing.Point(55, 35);
            this.lblDatosGenerales.Name = "lblDatosGenerales";
            this.lblDatosGenerales.Size = new System.Drawing.Size(165, 26);
            this.lblDatosGenerales.TabIndex = 7;
            this.lblDatosGenerales.Text = "Datos generales";
            // 
            // dtmFecha
            // 
            this.dtmFecha.Location = new System.Drawing.Point(55, 114);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(200, 20);
            this.dtmFecha.TabIndex = 8;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(323, 229);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(208, 21);
            this.cmbPais.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 537);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.lblDatosGenerales);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.txtTexto);
            this.MaximumSize = new System.Drawing.Size(562, 576);
            this.MinimumSize = new System.Drawing.Size(562, 576);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana de primeros datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.RadioButton rbtRojo;
        private System.Windows.Forms.RadioButton rbtVerde;
        private System.Windows.Forms.RadioButton rbtAzul;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.Label lblDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.ComboBox cmbPais;
    }
}

