namespace UI
{
    partial class FormPrincipal
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
            this.btnCargarAtencion = new System.Windows.Forms.Button();
            this.btnAfiliados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarAtencion
            // 
            this.btnCargarAtencion.Location = new System.Drawing.Point(186, 206);
            this.btnCargarAtencion.Name = "btnCargarAtencion";
            this.btnCargarAtencion.Size = new System.Drawing.Size(94, 56);
            this.btnCargarAtencion.TabIndex = 0;
            this.btnCargarAtencion.Text = "Cargar Atención";
            this.btnCargarAtencion.UseVisualStyleBackColor = true;
            this.btnCargarAtencion.Click += new System.EventHandler(this.btnCargarAtencion_Click);
            // 
            // btnAfiliados
            // 
            this.btnAfiliados.Location = new System.Drawing.Point(476, 206);
            this.btnAfiliados.Name = "btnAfiliados";
            this.btnAfiliados.Size = new System.Drawing.Size(94, 56);
            this.btnAfiliados.TabIndex = 1;
            this.btnAfiliados.Text = "Afiliados";
            this.btnAfiliados.UseVisualStyleBackColor = true;
            this.btnAfiliados.Click += new System.EventHandler(this.btnAfiliados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAfiliados);
            this.Controls.Add(this.btnCargarAtencion);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarAtencion;
        private System.Windows.Forms.Button btnAfiliados;
        private System.Windows.Forms.Button btnSalir;
    }
}