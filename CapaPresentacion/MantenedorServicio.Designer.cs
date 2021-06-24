
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
            this.dgVPrenda = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosServicio = new System.Windows.Forms.GroupBox();
            this.cbkEstadoAtencionServicio = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtPickerRegServicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaRegistroServicio = new System.Windows.Forms.Label();
            this.textBoxNroServicio = new System.Windows.Forms.TextBox();
            this.labelNroServicio = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelPrecioServicio = new System.Windows.Forms.Label();
            this.textBoxPrecioServicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPrenda)).BeginInit();
            this.groupBoxDatosServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVPrenda
            // 
            this.dgVPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVPrenda.Location = new System.Drawing.Point(1, 3);
            this.dgVPrenda.Name = "dgVPrenda";
            this.dgVPrenda.Size = new System.Drawing.Size(539, 242);
            this.dgVPrenda.TabIndex = 0;
            this.dgVPrenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVPrenda_CellDoubleClick);
            // 
            // groupBoxDatosServicio
            // 
            this.groupBoxDatosServicio.Controls.Add(this.cbkEstadoAtencionServicio);
            this.groupBoxDatosServicio.Controls.Add(this.btnModificar);
            this.groupBoxDatosServicio.Controls.Add(this.btnAgregar);
            this.groupBoxDatosServicio.Controls.Add(this.dtPickerRegServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelFechaRegistroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxNroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelNroServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxPrecioServicio);
            this.groupBoxDatosServicio.Controls.Add(this.labelPrecioServicio);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxDescripcion);
            this.groupBoxDatosServicio.Controls.Add(this.labelDescripcion);
            this.groupBoxDatosServicio.Controls.Add(this.textBoxIdCliente);
            this.groupBoxDatosServicio.Controls.Add(this.labelIdCliente);
            this.groupBoxDatosServicio.Location = new System.Drawing.Point(23, 251);
            this.groupBoxDatosServicio.Name = "groupBoxDatosServicio";
            this.groupBoxDatosServicio.Size = new System.Drawing.Size(638, 144);
            this.groupBoxDatosServicio.TabIndex = 1;
            this.groupBoxDatosServicio.TabStop = false;
            this.groupBoxDatosServicio.Text = "Datos del servicio";
            // 
            // cbkEstadoAtencionServicio
            // 
            this.cbkEstadoAtencionServicio.AutoSize = true;
            this.cbkEstadoAtencionServicio.Location = new System.Drawing.Point(266, 49);
            this.cbkEstadoAtencionServicio.Name = "cbkEstadoAtencionServicio";
            this.cbkEstadoAtencionServicio.Size = new System.Drawing.Size(175, 17);
            this.cbkEstadoAtencionServicio.TabIndex = 15;
            this.cbkEstadoAtencionServicio.Text = "Estado de Atencion del servicio";
            this.cbkEstadoAtencionServicio.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(523, 99);
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
            this.btnAgregar.Location = new System.Drawing.Point(523, 49);
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
            this.labelFechaRegistroServicio.Size = new System.Drawing.Size(149, 15);
            this.labelFechaRegistroServicio.TabIndex = 10;
            this.labelFechaRegistroServicio.Text = "Fecha registro del servicio";
            // 
            // textBoxNroServicio
            // 
            this.textBoxNroServicio.Location = new System.Drawing.Point(6, 52);
            this.textBoxNroServicio.Name = "textBoxNroServicio";
            this.textBoxNroServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroServicio.TabIndex = 7;
            // 
            // labelNroServicio
            // 
            this.labelNroServicio.AutoSize = true;
            this.labelNroServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroServicio.Location = new System.Drawing.Point(6, 35);
            this.labelNroServicio.Name = "labelNroServicio";
            this.labelNroServicio.Size = new System.Drawing.Size(88, 15);
            this.labelNroServicio.TabIndex = 6;
            this.labelNroServicio.Text = "Nro de servicio";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(130, 55);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(129, 35);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(72, 15);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(6, 101);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 1;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.Location = new System.Drawing.Point(6, 83);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(78, 15);
            this.labelIdCliente.TabIndex = 0;
            this.labelIdCliente.Text = "ID del cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(546, 31);
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
            this.btnEditar.Location = new System.Drawing.Point(546, 84);
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
            this.btnDeshabilitar.Location = new System.Drawing.Point(546, 138);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(86, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(546, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelPrecioServicio
            // 
            this.labelPrecioServicio.AutoSize = true;
            this.labelPrecioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioServicio.Location = new System.Drawing.Point(129, 84);
            this.labelPrecioServicio.Name = "labelPrecioServicio";
            this.labelPrecioServicio.Size = new System.Drawing.Size(108, 15);
            this.labelPrecioServicio.TabIndex = 4;
            this.labelPrecioServicio.Text = "Precio del Servicio";
            // 
            // textBoxPrecioServicio
            // 
            this.textBoxPrecioServicio.Location = new System.Drawing.Point(132, 102);
            this.textBoxPrecioServicio.Name = "textBoxPrecioServicio";
            this.textBoxPrecioServicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioServicio.TabIndex = 5;
            // 
            // MantenedorPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosServicio);
            this.Controls.Add(this.dgVPrenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorPrenda";
            this.Text = "FormServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgVPrenda)).EndInit();
            this.groupBoxDatosServicio.ResumeLayout(false);
            this.groupBoxDatosServicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVPrenda;
        private System.Windows.Forms.GroupBox groupBoxDatosServicio;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxNroServicio;
        private System.Windows.Forms.Label labelNroServicio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtPickerRegServicio;
        private System.Windows.Forms.Label labelFechaRegistroServicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox cbkEstadoAtencionServicio;
        private System.Windows.Forms.TextBox textBoxPrecioServicio;
        private System.Windows.Forms.Label labelPrecioServicio;
    }
}