namespace UI
{
    partial class FormCargarAtencion
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
            this.cmbAfiliado = new System.Windows.Forms.ComboBox();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.lblFranjaHoraria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarAtencion
            // 
            this.btnCargarAtencion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarAtencion.Location = new System.Drawing.Point(338, 129);
            this.btnCargarAtencion.Name = "btnCargarAtencion";
            this.btnCargarAtencion.Size = new System.Drawing.Size(144, 29);
            this.btnCargarAtencion.TabIndex = 3;
            this.btnCargarAtencion.Text = "Cargar Atención";
            this.btnCargarAtencion.UseVisualStyleBackColor = true;
            this.btnCargarAtencion.Click += new System.EventHandler(this.btnCargarAtencion_Click);
            // 
            // cmbAfiliado
            // 
            this.cmbAfiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAfiliado.FormattingEnabled = true;
            this.cmbAfiliado.Location = new System.Drawing.Point(57, 66);
            this.cmbAfiliado.Name = "cmbAfiliado";
            this.cmbAfiliado.Size = new System.Drawing.Size(151, 28);
            this.cmbAfiliado.TabIndex = 4;
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(101, 28);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(62, 20);
            this.lblAfiliado.TabIndex = 6;
            this.lblAfiliado.Text = "Afiliado";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(278, 28);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(83, 20);
            this.lblProfesional.TabIndex = 7;
            this.lblProfesional.Text = "Profesional";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(247, 66);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(151, 28);
            this.cmbProfesional.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(505, 129);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranjaHoraria
            // 
            this.cmbFranjaHoraria.FormattingEnabled = true;
            this.cmbFranjaHoraria.Location = new System.Drawing.Point(439, 66);
            this.cmbFranjaHoraria.Name = "cmbFranjaHoraria";
            this.cmbFranjaHoraria.Size = new System.Drawing.Size(151, 28);
            this.cmbFranjaHoraria.TabIndex = 12;
            // 
            // lblFranjaHoraria
            // 
            this.lblFranjaHoraria.AutoSize = true;
            this.lblFranjaHoraria.Location = new System.Drawing.Point(460, 28);
            this.lblFranjaHoraria.Name = "lblFranjaHoraria";
            this.lblFranjaHoraria.Size = new System.Drawing.Size(103, 20);
            this.lblFranjaHoraria.TabIndex = 13;
            this.lblFranjaHoraria.Text = "Franja Horaria";
            // 
            // FormCargarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 182);
            this.ControlBox = false;
            this.Controls.Add(this.lblFranjaHoraria);
            this.Controls.Add(this.cmbFranjaHoraria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.cmbAfiliado);
            this.Controls.Add(this.btnCargarAtencion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargarAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Atención";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargarAtencion;
        private System.Windows.Forms.ComboBox cmbAfiliado;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranjaHoraria;
        private System.Windows.Forms.Label lblFranjaHoraria;
    }
}