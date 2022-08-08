namespace UI
{
    partial class FormAtencionesFuturas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarAtencion = new System.Windows.Forms.Button();
            this.dgAtenciones = new System.Windows.Forms.DataGridView();
            this.lblAtenciones = new System.Windows.Forms.Label();
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(261, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarAtencion
            // 
            this.btnAgregarAtencion.Location = new System.Drawing.Point(161, 357);
            this.btnAgregarAtencion.Name = "btnAgregarAtencion";
            this.btnAgregarAtencion.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarAtencion.TabIndex = 4;
            this.btnAgregarAtencion.Text = "Agregar";
            this.btnAgregarAtencion.UseVisualStyleBackColor = true;
            this.btnAgregarAtencion.Click += new System.EventHandler(this.btnAgregarAtencion_Click);
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
            this.lblAtenciones.Location = new System.Drawing.Point(138, 9);
            this.lblAtenciones.Name = "lblAtenciones";
            this.lblAtenciones.Size = new System.Drawing.Size(169, 20);
            this.lblAtenciones.TabIndex = 2;
            this.lblAtenciones.Text = "Atenciones Agendadas";
            // 
            // FormAtencionesFuturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 408);
            this.ControlBox = false;
            this.Controls.Add(this.dgAtenciones);
            this.Controls.Add(this.btnAgregarAtencion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblAtenciones);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAtencionesFuturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado atenciones futuras";
            this.Load += new System.EventHandler(this.FormAtenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarAtencion;
        private System.Windows.Forms.DataGridView dgAtenciones;
        private System.Windows.Forms.Label lblAtenciones;
    }
}