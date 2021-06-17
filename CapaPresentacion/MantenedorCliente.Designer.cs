
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
            this.dgVCliente = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtPickerRegCliente = new System.Windows.Forms.DateTimePicker();
            this.labelFecRegCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxApellidoCliente = new System.Windows.Forms.TextBox();
            this.labelApellidoCliente = new System.Windows.Forms.Label();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.labelEmailCliente = new System.Windows.Forms.Label();
            this.textBoxDniCliente = new System.Windows.Forms.TextBox();
            this.labelDniCliente = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVCliente)).BeginInit();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVCliente
            // 
            this.dgVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVCliente.Location = new System.Drawing.Point(0, 12);
            this.dgVCliente.Name = "dgVCliente";
            this.dgVCliente.Size = new System.Drawing.Size(539, 238);
            this.dgVCliente.TabIndex = 0;
            this.dgVCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVCliente_CellDoubleClick_1);
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.btnModificar);
            this.groupBoxDatosCliente.Controls.Add(this.dtPickerRegCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelFecRegCliente);
            this.groupBoxDatosCliente.Controls.Add(this.btnAgregar);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosCliente.Controls.Add(this.labelTelefono);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxApellidoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelApellidoCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxEmailCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelEmailCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxDniCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelDniCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombreCliente);
            this.groupBoxDatosCliente.Controls.Add(this.labelIdCliente);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxIdCliente);
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(0, 265);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(649, 150);
            this.groupBoxDatosCliente.TabIndex = 1;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos de Cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(545, 67);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtPickerRegCliente
            // 
            this.dtPickerRegCliente.Location = new System.Drawing.Point(363, 109);
            this.dtPickerRegCliente.Name = "dtPickerRegCliente";
            this.dtPickerRegCliente.Size = new System.Drawing.Size(216, 20);
            this.dtPickerRegCliente.TabIndex = 14;
            // 
            // labelFecRegCliente
            // 
            this.labelFecRegCliente.AutoSize = true;
            this.labelFecRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecRegCliente.Location = new System.Drawing.Point(390, 91);
            this.labelFecRegCliente.Name = "labelFecRegCliente";
            this.labelFecRegCliente.Size = new System.Drawing.Size(85, 15);
            this.labelFecRegCliente.TabIndex = 13;
            this.labelFecRegCliente.Text = "Fecha registro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(545, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(235, 109);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(257, 91);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 15);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxApellidoCliente
            // 
            this.textBoxApellidoCliente.Location = new System.Drawing.Point(120, 109);
            this.textBoxApellidoCliente.Name = "textBoxApellidoCliente";
            this.textBoxApellidoCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoCliente.TabIndex = 9;
            // 
            // labelApellidoCliente
            // 
            this.labelApellidoCliente.AutoSize = true;
            this.labelApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoCliente.Location = new System.Drawing.Point(122, 91);
            this.labelApellidoCliente.Name = "labelApellidoCliente";
            this.labelApellidoCliente.Size = new System.Drawing.Size(98, 15);
            this.labelApellidoCliente.TabIndex = 8;
            this.labelApellidoCliente.Text = "Apellidos Cliente";
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.Location = new System.Drawing.Point(235, 51);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailCliente.TabIndex = 7;
            // 
            // labelEmailCliente
            // 
            this.labelEmailCliente.AutoSize = true;
            this.labelEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailCliente.Location = new System.Drawing.Point(257, 33);
            this.labelEmailCliente.Name = "labelEmailCliente";
            this.labelEmailCliente.Size = new System.Drawing.Size(39, 15);
            this.labelEmailCliente.TabIndex = 6;
            this.labelEmailCliente.Text = "Email";
            // 
            // textBoxDniCliente
            // 
            this.textBoxDniCliente.Location = new System.Drawing.Point(6, 110);
            this.textBoxDniCliente.Name = "textBoxDniCliente";
            this.textBoxDniCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxDniCliente.TabIndex = 5;
            // 
            // labelDniCliente
            // 
            this.labelDniCliente.AutoSize = true;
            this.labelDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniCliente.Location = new System.Drawing.Point(7, 91);
            this.labelDniCliente.Name = "labelDniCliente";
            this.labelDniCliente.Size = new System.Drawing.Size(69, 15);
            this.labelDniCliente.TabIndex = 4;
            this.labelDniCliente.Text = "DNI Cliente";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(120, 51);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCliente.TabIndex = 3;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(122, 33);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(99, 15);
            this.labelNombreCliente.TabIndex = 2;
            this.labelNombreCliente.Text = "Nombres Cliente";
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.Location = new System.Drawing.Point(7, 32);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(80, 15);
            this.labelIdCliente.TabIndex = 1;
            this.labelIdCliente.Text = "ID del Cliente";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCliente.Location = new System.Drawing.Point(6, 51);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 21);
            this.textBoxIdCliente.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(545, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(545, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(545, 153);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(83, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(543, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 427);
            this.Controls.Add(this.btnSalir);
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
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxApellidoCliente;
        private System.Windows.Forms.Label labelApellidoCliente;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.Label labelEmailCliente;
        private System.Windows.Forms.TextBox textBoxDniCliente;
        private System.Windows.Forms.Label labelDniCliente;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelFecRegCliente;
        private System.Windows.Forms.DateTimePicker dtPickerRegCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
    }
}