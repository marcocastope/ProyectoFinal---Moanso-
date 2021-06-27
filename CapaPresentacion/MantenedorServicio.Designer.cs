
namespace CapaPresentacion
{
    partial class MantenedorServicio
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
            this.dgVServicio = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosServicio = new System.Windows.Forms.GroupBox();
            this.cbkestAtencionServicio = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtPickerRegServicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaRegistroServicio = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxPrecioServicio = new System.Windows.Forms.TextBox();
            this.labelPrecioServicio = new System.Windows.Forms.Label();
            this.textBoxNroServicio = new System.Windows.Forms.TextBox();
            this.labelNroServicio = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVServicio)).BeginInit();
            this.groupBoxDatosServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVServicio
            // 
            this.dgVServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVServicio.Location = new System.Drawing.Point(1, 3);
            this.dgVServicio.Name = "dgVServicio";
            this.dgVServicio.Size = new System.Drawing.Size(568, 242);
            this.dgVServicio.TabIndex = 0;
            this.dgVServicio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVServicio_CellDoubleClick);
            // 
            // groupBoxDatosServicio
            // 
            this.groupBoxDatosServicio.Controls.Add(this.cbkestAtencionServicio);
            this.groupBoxDatosServicio.Controls.Add(this.btnCancelar);
            this.groupBoxDatosServicio.Controls.Add(this.btnModificar);
            this.groupBoxDatosServicio.Controls.Add(this.btnAgregar);
            this.groupBoxDatosServicio.Controls.Add(this.dtPickerRegServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelFechaRegistroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxDescripcion);
            this.groupBoxDatosServicio.Controls.Add(this.labelDescripcion);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxPrecioServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelPrecioServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxNroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelNroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxIdCliente);
            this.groupBoxDatosServicio.Controls.Add(this.labelIdCliente);
            this.groupBoxDatosServicio.Location = new System.Drawing.Point(23, 251);
            this.groupBoxDatosServicio.Name = "groupBoxDatosServicio";
            this.groupBoxDatosServicio.Size = new System.Drawing.Size(638, 144);
            this.groupBoxDatosServicio.TabIndex = 1;
            this.groupBoxDatosServicio.TabStop = false;
            this.groupBoxDatosServicio.Text = "Datos de Servicios";
            // 
            // cbkestAtencionServicio
            // 
            this.cbkestAtencionServicio.AutoSize = true;
            this.cbkestAtencionServicio.Location = new System.Drawing.Point(266, 53);
            this.cbkestAtencionServicio.Name = "cbkestAtencionServicio";
            this.cbkestAtencionServicio.Size = new System.Drawing.Size(119, 17);
            this.cbkestAtencionServicio.TabIndex = 15;
            this.cbkestAtencionServicio.Text = "Estado de Atencion";
            this.cbkestAtencionServicio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(523, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(523, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(523, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtPickerRegServicio
            // 
            this.dtPickerRegServicio.Location = new System.Drawing.Point(266, 102);
            this.dtPickerRegServicio.Name = "dtPickerRegServicio";
            this.dtPickerRegServicio.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegServicio.TabIndex = 11;
            // 
            // labelFechaRegistroServicio
            // 
            this.labelFechaRegistroServicio.AutoSize = true;
            this.labelFechaRegistroServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistroServicio.Location = new System.Drawing.Point(263, 84);
            this.labelFechaRegistroServicio.Name = "labelFechaRegistroServicio";
            this.labelFechaRegistroServicio.Size = new System.Drawing.Size(90, 15);
            this.labelFechaRegistroServicio.TabIndex = 10;
            this.labelFechaRegistroServicio.Text = "Fecha Registro";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(147, 53);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(144, 35);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(72, 15);
            this.labelDescripcion.TabIndex = 6;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxPrecioServicio
            // 
            this.textBoxPrecioServicio.Location = new System.Drawing.Point(148, 102);
            this.textBoxPrecioServicio.Name = "textBoxPrecioServicio";
            this.textBoxPrecioServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioServicio.TabIndex = 5;
            // 
            // labelPrecioServicio
            // 
            this.labelPrecioServicio.AutoSize = true;
            this.labelPrecioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioServicio.Location = new System.Drawing.Point(144, 84);
            this.labelPrecioServicio.Name = "labelPrecioServicio";
            this.labelPrecioServicio.Size = new System.Drawing.Size(88, 15);
            this.labelPrecioServicio.TabIndex = 4;
            this.labelPrecioServicio.Text = "Precio Servicio";
            // 
            // textBoxNroServicio
            // 
            this.textBoxNroServicio.Location = new System.Drawing.Point(9, 53);
            this.textBoxNroServicio.Name = "textBoxNroServicio";
            this.textBoxNroServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroServicio.TabIndex = 3;
            // 
            // labelNroServicio
            // 
            this.labelNroServicio.AutoSize = true;
            this.labelNroServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroServicio.Location = new System.Drawing.Point(6, 29);
            this.labelNroServicio.Name = "labelNroServicio";
            this.labelNroServicio.Size = new System.Drawing.Size(73, 15);
            this.labelNroServicio.TabIndex = 2;
            this.labelNroServicio.Text = "Nro Servicio";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(6, 106);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 1;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.Location = new System.Drawing.Point(6, 84);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(78, 15);
            this.labelIdCliente.TabIndex = 0;
            this.labelIdCliente.Text = "ID del cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(575, 33);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(575, 86);
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
            this.btnDeshabilitar.Location = new System.Drawing.Point(575, 138);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(86, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // MantenedorServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 398);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosServicio);
            this.Controls.Add(this.dgVServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorServicio";
            this.Text = "FormServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgVServicio)).EndInit();
            this.groupBoxDatosServicio.ResumeLayout(false);
            this.groupBoxDatosServicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVServicio;
        private System.Windows.Forms.GroupBox groupBoxDatosServicio;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecioServicio;
        private System.Windows.Forms.Label labelPrecioServicio;
        private System.Windows.Forms.TextBox textBoxNroServicio;
        private System.Windows.Forms.Label labelNroServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtPickerRegServicio;
        private System.Windows.Forms.Label labelFechaRegistroServicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.CheckBox cbkestAtencionServicio;
    }
}