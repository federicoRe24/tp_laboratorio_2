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
            this.lblAfiliados = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarAfiliado = new System.Windows.Forms.Button();
            this.dgAfiliados = new System.Windows.Forms.DataGridView();
            this.btnExportarJSON = new System.Windows.Forms.Button();
            this.btnExportarXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAfiliados)).BeginInit();
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(565, 388);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarAfiliado
            // 
            this.btnAgregarAfiliado.Location = new System.Drawing.Point(455, 388);
            this.btnAgregarAfiliado.Name = "btnAgregarAfiliado";
            this.btnAgregarAfiliado.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarAfiliado.TabIndex = 4;
            this.btnAgregarAfiliado.Text = "Agregar";
            this.btnAgregarAfiliado.UseVisualStyleBackColor = true;
            this.btnAgregarAfiliado.Click += new System.EventHandler(this.btnAgregarAfiliado_Click);
            // 
            // dgAfiliados
            // 
            this.dgAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAfiliados.Location = new System.Drawing.Point(29, 53);
            this.dgAfiliados.Name = "dgAfiliados";
            this.dgAfiliados.ReadOnly = true;
            this.dgAfiliados.RowHeadersWidth = 51;
            this.dgAfiliados.RowTemplate.Height = 29;
            this.dgAfiliados.Size = new System.Drawing.Size(739, 310);
            this.dgAfiliados.TabIndex = 5;
            // 
            // btnExportarJSON
            // 
            this.btnExportarJSON.Location = new System.Drawing.Point(157, 388);
            this.btnExportarJSON.Name = "btnExportarJSON";
            this.btnExportarJSON.Size = new System.Drawing.Size(132, 29);
            this.btnExportarJSON.TabIndex = 6;
            this.btnExportarJSON.Text = "Exportar a JSON";
            this.btnExportarJSON.UseVisualStyleBackColor = true;
            this.btnExportarJSON.Click += new System.EventHandler(this.btnExportarJSON_Click);
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Location = new System.Drawing.Point(29, 388);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(122, 29);
            this.btnExportarXML.TabIndex = 7;
            this.btnExportarXML.Text = "Exportar a XML";
            this.btnExportarXML.UseVisualStyleBackColor = true;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // FormAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportarXML);
            this.Controls.Add(this.btnExportarJSON);
            this.Controls.Add(this.dgAfiliados);
            this.Controls.Add(this.btnAgregarAfiliado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblAfiliados);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado afiliados";
            this.Load += new System.EventHandler(this.FormAfiliados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblAfiliados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarAfiliado;
        private System.Windows.Forms.DataGridView dgAfiliados;
        private System.Windows.Forms.Button btnExportarJSON;
        private System.Windows.Forms.Button btnExportarXML;
    }
}