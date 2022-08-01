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
            this.btnAtenciones = new System.Windows.Forms.Button();
            this.btnAfiliados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProfesionales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtenciones
            // 
            this.btnAtenciones.Location = new System.Drawing.Point(610, 202);
            this.btnAtenciones.Name = "btnAtenciones";
            this.btnAtenciones.Size = new System.Drawing.Size(94, 56);
            this.btnAtenciones.TabIndex = 0;
            this.btnAtenciones.Text = "Atenciones";
            this.btnAtenciones.UseVisualStyleBackColor = true;
            this.btnAtenciones.Click += new System.EventHandler(this.btnAtenciones_Click);
            // 
            // btnAfiliados
            // 
            this.btnAfiliados.Location = new System.Drawing.Point(123, 202);
            this.btnAfiliados.Name = "btnAfiliados";
            this.btnAfiliados.Size = new System.Drawing.Size(94, 56);
            this.btnAfiliados.TabIndex = 1;
            this.btnAfiliados.Text = "Afiliados";
            this.btnAfiliados.UseVisualStyleBackColor = true;
            this.btnAfiliados.Click += new System.EventHandler(this.btnAfiliados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(773, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProfesionales
            // 
            this.btnProfesionales.Location = new System.Drawing.Point(358, 202);
            this.btnProfesionales.Name = "btnProfesionales";
            this.btnProfesionales.Size = new System.Drawing.Size(108, 56);
            this.btnProfesionales.TabIndex = 3;
            this.btnProfesionales.Text = "Profesionales";
            this.btnProfesionales.UseVisualStyleBackColor = true;
            this.btnProfesionales.Click += new System.EventHandler(this.btnProfesionales_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnProfesionales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAfiliados);
            this.Controls.Add(this.btnAtenciones);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtenciones;
        private System.Windows.Forms.Button btnAfiliados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProfesionales;
    }
}