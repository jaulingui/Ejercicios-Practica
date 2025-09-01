namespace PracticaWindowsForms
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
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMostrarApellido = new System.Windows.Forms.Label();
            this.checkNombre = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton1.Location = new System.Drawing.Point(70, 93);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(89, 33);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Saludar";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton2.Location = new System.Drawing.Point(17, 306);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(116, 52);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "BOTON 2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(224, 21);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(70, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(89, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblMostrarApellido
            // 
            this.lblMostrarApellido.AutoSize = true;
            this.lblMostrarApellido.Location = new System.Drawing.Point(224, 50);
            this.lblMostrarApellido.Name = "lblMostrarApellido";
            this.lblMostrarApellido.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarApellido.TabIndex = 7;
            // 
            // checkNombre
            // 
            this.checkNombre.AutoSize = true;
            this.checkNombre.Location = new System.Drawing.Point(165, 17);
            this.checkNombre.Name = "checkNombre";
            this.checkNombre.Size = new System.Drawing.Size(15, 14);
            this.checkNombre.TabIndex = 8;
            this.checkNombre.UseVisualStyleBackColor = true;
            this.checkNombre.CheckedChanged += new System.EventHandler(this.chekNombre_CheckedChanged);
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Location = new System.Drawing.Point(166, 49);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(15, 14);
            this.checkApellido.TabIndex = 9;
            this.checkApellido.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 370);
            this.Controls.Add(this.checkApellido);
            this.Controls.Add(this.checkNombre);
            this.Controls.Add(this.lblMostrarApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMostrarApellido;
        private System.Windows.Forms.CheckBox checkNombre;
        private System.Windows.Forms.CheckBox checkApellido;
    }
}

