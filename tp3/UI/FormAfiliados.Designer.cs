namespace UI
{
    partial class FormAfiliados
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbAfiliados = new System.Windows.Forms.ListBox();
            this.lblAfiliados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(674, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbAfiliados
            // 
            this.lbAfiliados.FormattingEnabled = true;
            this.lbAfiliados.ItemHeight = 20;
            this.lbAfiliados.Location = new System.Drawing.Point(25, 51);
            this.lbAfiliados.Name = "lbAfiliados";
            this.lbAfiliados.Size = new System.Drawing.Size(743, 304);
            this.lbAfiliados.TabIndex = 1;
            // 
            // lblAfiliados
            // 
            this.lblAfiliados.AutoSize = true;
            this.lblAfiliados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAfiliados.Location = new System.Drawing.Point(344, 18);
            this.lblAfiliados.Name = "lblAfiliados";
            this.lblAfiliados.Size = new System.Drawing.Size(71, 20);
            this.lblAfiliados.TabIndex = 2;
            this.lblAfiliados.Text = "Afiliados";
            // 
            // FormAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblAfiliados);
            this.Controls.Add(this.lbAfiliados);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado afiliados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbAfiliados;
        private System.Windows.Forms.Label lblAfiliados;
    }
}