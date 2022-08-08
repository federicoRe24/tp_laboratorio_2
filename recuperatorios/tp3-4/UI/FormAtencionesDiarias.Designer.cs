namespace UI
{
    partial class FormAtencionesDiarias
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
            this.dgAtenciones = new System.Windows.Forms.DataGridView();
            this.lblAtenciones = new System.Windows.Forms.Label();
            this.btnCargarAtencion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(361, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAtenciones
            // 
            this.dgAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtenciones.Location = new System.Drawing.Point(29, 53);
            this.dgAtenciones.Name = "dgAtenciones";
            this.dgAtenciones.ReadOnly = true;
            this.dgAtenciones.RowHeadersWidth = 51;
            this.dgAtenciones.RowTemplate.Height = 29;
            this.dgAtenciones.Size = new System.Drawing.Size(426, 276);
            this.dgAtenciones.TabIndex = 5;
            // 
            // lblAtenciones
            // 
            this.lblAtenciones.AutoSize = true;
            this.lblAtenciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAtenciones.Location = new System.Drawing.Point(155, 9);
            this.lblAtenciones.Name = "lblAtenciones";
            this.lblAtenciones.Size = new System.Drawing.Size(139, 20);
            this.lblAtenciones.TabIndex = 2;
            this.lblAtenciones.Text = "Atenciones Diarias";
            // 
            // btnCargarAtencion
            // 
            this.btnCargarAtencion.Location = new System.Drawing.Point(29, 347);
            this.btnCargarAtencion.Name = "btnCargarAtencion";
            this.btnCargarAtencion.Size = new System.Drawing.Size(94, 49);
            this.btnCargarAtencion.TabIndex = 6;
            this.btnCargarAtencion.Text = "Cargar atención";
            this.btnCargarAtencion.UseVisualStyleBackColor = true;
            this.btnCargarAtencion.Click += new System.EventHandler(this.btnCargarAtencion_Click);
            // 
            // FormAtencionesDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 408);
            this.ControlBox = false;
            this.Controls.Add(this.btnCargarAtencion);
            this.Controls.Add(this.dgAtenciones);
            this.Controls.Add(this.lblAtenciones);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAtencionesDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAtenciones;
        private System.Windows.Forms.Label lblAtenciones;
        private System.Windows.Forms.Button btnCargarAtencion;
    }
}