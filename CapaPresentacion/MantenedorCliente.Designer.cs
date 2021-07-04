namespace CapaPresentacion
{
    partial class MantenedorCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVCliente = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.cbkestAtencionCliente = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.dtPickerRegCliente = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoCliente = new System.Windows.Forms.ComboBox();
            this.labelTipoCliente = new System.Windows.Forms.Label();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.textBoxProfesion = new System.Windows.Forms.TextBox();
            this.labelProfesion = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVCliente)).BeginInit();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVCliente
            // 
            this.dgVCliente.AllowUserToAddRows = false;
            this.dgVCliente.AllowUserToDeleteRows = false;
            this.dgVCliente.AllowUserToResizeColumns = false;
            this.dgVCliente.AllowUserToResizeRows = false;
            this.dgVCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgVCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVCliente.ColumnHeadersHeight = 30;
            this.dgVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgVCliente.EnableHeadersVisualStyles = false;
            this.dgVCliente.Location = new System.Drawing.Point(12, 12);
            this.dgVCliente.MultiSelect = false;
            this.dgVCliente.Name = "dgVCliente";
            this.dgVCliente.ReadOnly = true;
            this.dgVCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgVCliente.RowHeadersVisible = false;
            this.dgVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVCliente.Size = new System.Drawing.Size(537, 244);
            this.dgVCliente.TabIndex = 0;
            this.dgVCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVCliente_CellContentClick);
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.cbkestAtencionCliente);
            this.groupBoxDatosCliente.Controls.Add(this.btnCancelar);
            this.groupBoxDatosCliente.Controls.Add(this.btnModificar);
            this.groupBoxDatosCliente.Controls.Add(this.btnAgregar);
            this.groupBoxDatosCliente.Controls.Add(this.labelFechaRegistro);
            this.groupBoxDatosCliente.Controls.Add(this.dtPickerRegCliente);
            this.groupBoxDatosCliente.Controls.Add(this.comboBoxTipoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelTipoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.comboBoxCiudad);
            this.groupBoxDatosCliente.Controls.Add(this.labelCiudad);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxProfesion);
            this.groupBoxDatosCliente.Controls.Add(this.labelProfesion);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxDni);
            this.groupBoxDatosCliente.Controls.Add(this.labelDni);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxIdCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelIdCliente);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(12, 262);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(626, 127);
            this.groupBoxDatosCliente.TabIndex = 1;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de Cliente";
            this.groupBoxDatosCliente.Enter += new System.EventHandler(this.groupBoxDatosCliente_Enter);
            // 
            // cbkestAtencionCliente
            // 
            this.cbkestAtencionCliente.AutoSize = true;
            this.cbkestAtencionCliente.Location = new System.Drawing.Point(358, 37);
            this.cbkestAtencionCliente.Name = "cbkestAtencionCliente";
            this.cbkestAtencionCliente.Size = new System.Drawing.Size(111, 19);
            this.cbkestAtencionCliente.TabIndex = 20;
            this.cbkestAtencionCliente.Text = "Esado Atencion";
            this.cbkestAtencionCliente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(543, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(543, 51);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(543, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.Location = new System.Drawing.Point(355, 75);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(90, 15);
            this.labelFechaRegistro.TabIndex = 16;
            this.labelFechaRegistro.Text = "Fecha Registro";
            // 
            // dtPickerRegCliente
            // 
            this.dtPickerRegCliente.Location = new System.Drawing.Point(344, 94);
            this.dtPickerRegCliente.Name = "dtPickerRegCliente";
            this.dtPickerRegCliente.Size = new System.Drawing.Size(162, 21);
            this.dtPickerRegCliente.TabIndex = 15;
            // 
            // comboBoxTipoCliente
            // 
            this.comboBoxTipoCliente.FormattingEnabled = true;
            this.comboBoxTipoCliente.Location = new System.Drawing.Point(223, 37);
            this.comboBoxTipoCliente.Name = "comboBoxTipoCliente";
            this.comboBoxTipoCliente.Size = new System.Drawing.Size(115, 23);
            this.comboBoxTipoCliente.TabIndex = 14;
            // 
            // labelTipoCliente
            // 
            this.labelTipoCliente.AutoSize = true;
            this.labelTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoCliente.Location = new System.Drawing.Point(220, 22);
            this.labelTipoCliente.Name = "labelTipoCliente";
            this.labelTipoCliente.Size = new System.Drawing.Size(89, 15);
            this.labelTipoCliente.TabIndex = 13;
            this.labelTipoCliente.Text = "Tipo de Cliente";
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(223, 92);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(115, 23);
            this.comboBoxCiudad.TabIndex = 10;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(220, 75);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(46, 15);
            this.labelCiudad.TabIndex = 8;
            this.labelCiudad.Text = "Ciudad";
            // 
            // textBoxProfesion
            // 
            this.textBoxProfesion.Location = new System.Drawing.Point(98, 95);
            this.textBoxProfesion.Name = "textBoxProfesion";
            this.textBoxProfesion.Size = new System.Drawing.Size(117, 21);
            this.textBoxProfesion.TabIndex = 7;
            // 
            // labelProfesion
            // 
            this.labelProfesion.AutoSize = true;
            this.labelProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesion.Location = new System.Drawing.Point(95, 76);
            this.labelProfesion.Name = "labelProfesion";
            this.labelProfesion.Size = new System.Drawing.Size(59, 15);
            this.labelProfesion.TabIndex = 6;
            this.labelProfesion.Text = "Profesion";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(10, 95);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(82, 21);
            this.textBoxDni.TabIndex = 5;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(10, 76);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 15);
            this.labelDni.TabIndex = 4;
            this.labelDni.Text = "Dni";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(98, 38);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(116, 21);
            this.textBoxNombreCliente.TabIndex = 3;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(95, 22);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(119, 15);
            this.labelNombreCliente.TabIndex = 2;
            this.labelNombreCliente.Text = "Nombres y Apellidos";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(10, 39);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(60, 21);
            this.textBoxIdCliente.TabIndex = 1;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.Location = new System.Drawing.Point(7, 20);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(55, 15);
            this.labelIdCliente.TabIndex = 0;
            this.labelIdCliente.Text = "IdCliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(555, 50);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(555, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(555, 179);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(85, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosCliente);
            this.Controls.Add(this.dgVCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgVCliente)).EndInit();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVCliente;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox textBoxProfesion;
        private System.Windows.Forms.Label labelProfesion;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtPickerRegCliente;
        private System.Windows.Forms.ComboBox comboBoxTipoCliente;
        private System.Windows.Forms.Label labelTipoCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox cbkestAtencionCliente;
    }
}