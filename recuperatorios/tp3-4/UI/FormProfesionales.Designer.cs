namespace UI
{
    partial class FormProfesionales
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
            this.lblProfesionales = new System.Windows.Forms.Label();
            this.dgProfesionales = new System.Windows.Forms.DataGridView();
            this.btnComenzarCarga = new System.Windows.Forms.Button();
            this.btnCancelarCarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesionales)).BeginInit();
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
            // lblProfesionales
            // 
            this.lblProfesionales.AutoSize = true;
            this.lblProfesionales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfesionales.Location = new System.Drawing.Point(344, 18);
            this.lblProfesionales.Name = "lblProfesionales";
            this.lblProfesionales.Size = new System.Drawing.Size(103, 20);
            this.lblProfesionales.TabIndex = 2;
            this.lblProfesionales.Text = "Profesionales";
            // 
            // dgProfesionales
            // 
            this.dgProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesionales.Location = new System.Drawing.Point(29, 53);
            this.dgProfesionales.Name = "dgProfesionales";
            this.dgProfesionales.ReadOnly = true;
            this.dgProfesionales.RowHeadersWidth = 51;
            this.dgProfesionales.RowTemplate.Height = 29;
            this.dgProfesionales.Size = new System.Drawing.Size(739, 310);
            this.dgProfesionales.TabIndex = 5;
            // 
            // btnComenzarCarga
            // 
            this.btnComenzarCarga.Location = new System.Drawing.Point(29, 388);
            this.btnComenzarCarga.Name = "btnComenzarCarga";
            this.btnComenzarCarga.Size = new System.Drawing.Size(143, 50);
            this.btnComenzarCarga.TabIndex = 6;
            this.btnComenzarCarga.Text = "Comenzar carga profesionales";
            this.btnComenzarCarga.UseVisualStyleBackColor = true;
            this.btnComenzarCarga.Click += new System.EventHandler(this.btnComenzarCarga_Click);
            // 
            // btnCancelarCarga
            // 
            this.btnCancelarCarga.Location = new System.Drawing.Point(178, 388);
            this.btnCancelarCarga.Name = "btnCancelarCarga";
            this.btnCancelarCarga.Size = new System.Drawing.Size(143, 50);
            this.btnCancelarCarga.TabIndex = 7;
            this.btnCancelarCarga.Text = "Cancelar carga profesionales";
            this.btnCancelarCarga.UseVisualStyleBackColor = true;
            this.btnCancelarCarga.Click += new System.EventHandler(this.btnCancelarCarga_Click);
            // 
            // FormProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 454);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarCarga);
            this.Controls.Add(this.btnComenzarCarga);
            this.Controls.Add(this.dgProfesionales);
            this.Controls.Add(this.lblProfesionales);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado profesionales";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProfesionales;
        private System.Windows.Forms.DataGridView dgProfesionales;
        private System.Windows.Forms.Button btnComenzarCarga;
        private System.Windows.Forms.Button btnCancelarCarga;
    }
}