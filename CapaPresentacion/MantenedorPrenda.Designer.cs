
namespace CapaPresentacion
{
    partial class MantenedorPrenda
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
            this.groupBoxDatosPrendas = new System.Windows.Forms.GroupBox();
            this.cbkEstadoAtencion = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtPickerRegPrenda = new System.Windows.Forms.DateTimePicker();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.textBoxColorPrenda = new System.Windows.Forms.TextBox();
            this.labelColorPrenda = new System.Windows.Forms.Label();
            this.textBoxNroPrenda = new System.Windows.Forms.TextBox();
            this.labelNroPrenda = new System.Windows.Forms.Label();
            this.textBoxEstadoPrenda = new System.Windows.Forms.TextBox();
            this.labelEstadoprenda = new System.Windows.Forms.Label();
            this.textBoxTipoPrenda = new System.Windows.Forms.TextBox();
            this.labelTipoPrenda = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPrenda)).BeginInit();
            this.groupBoxDatosPrendas.SuspendLayout();
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
            // groupBoxDatosPrendas
            // 
            this.groupBoxDatosPrendas.Controls.Add(this.cbkEstadoAtencion);
            this.groupBoxDatosPrendas.Controls.Add(this.btnModificar);
            this.groupBoxDatosPrendas.Controls.Add(this.btnAgregar);
            this.groupBoxDatosPrendas.Controls.Add(this.dtPickerRegPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelFechaRegistro);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxColorPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelColorPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxNroPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelNroPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxEstadoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelEstadoprenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxTipoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelTipoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxIdCliente);
            this.groupBoxDatosPrendas.Controls.Add(this.labelIdCliente);
            this.groupBoxDatosPrendas.Location = new System.Drawing.Point(23, 251);
            this.groupBoxDatosPrendas.Name = "groupBoxDatosPrendas";
            this.groupBoxDatosPrendas.Size = new System.Drawing.Size(638, 144);
            this.groupBoxDatosPrendas.TabIndex = 1;
            this.groupBoxDatosPrendas.TabStop = false;
            this.groupBoxDatosPrendas.Text = "Datos de prendas";
            // 
            // cbkEstadoAtencion
            // 
            this.cbkEstadoAtencion.AutoSize = true;
            this.cbkEstadoAtencion.Location = new System.Drawing.Point(386, 55);
            this.cbkEstadoAtencion.Name = "cbkEstadoAtencion";
            this.cbkEstadoAtencion.Size = new System.Drawing.Size(119, 17);
            this.cbkEstadoAtencion.TabIndex = 15;
            this.cbkEstadoAtencion.Text = "Estado de Atencion";
            this.cbkEstadoAtencion.UseVisualStyleBackColor = true;
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
            // dtPickerRegPrenda
            // 
            this.dtPickerRegPrenda.Location = new System.Drawing.Point(266, 102);
            this.dtPickerRegPrenda.Name = "dtPickerRegPrenda";
            this.dtPickerRegPrenda.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegPrenda.TabIndex = 11;
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.Location = new System.Drawing.Point(263, 84);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(90, 15);
            this.labelFechaRegistro.TabIndex = 10;
            this.labelFechaRegistro.Text = "Fecha Registro";
            // 
            // textBoxColorPrenda
            // 
            this.textBoxColorPrenda.Location = new System.Drawing.Point(266, 53);
            this.textBoxColorPrenda.Name = "textBoxColorPrenda";
            this.textBoxColorPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxColorPrenda.TabIndex = 9;
            // 
            // labelColorPrenda
            // 
            this.labelColorPrenda.AutoSize = true;
            this.labelColorPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorPrenda.Location = new System.Drawing.Point(263, 35);
            this.labelColorPrenda.Name = "labelColorPrenda";
            this.labelColorPrenda.Size = new System.Drawing.Size(95, 15);
            this.labelColorPrenda.TabIndex = 8;
            this.labelColorPrenda.Text = "Color de prenda";
            // 
            // textBoxNroPrenda
            // 
            this.textBoxNroPrenda.Location = new System.Drawing.Point(6, 60);
            this.textBoxNroPrenda.Name = "textBoxNroPrenda";
            this.textBoxNroPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroPrenda.TabIndex = 7;
            // 
            // labelNroPrenda
            // 
            this.labelNroPrenda.AutoSize = true;
            this.labelNroPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPrenda.Location = new System.Drawing.Point(6, 42);
            this.labelNroPrenda.Name = "labelNroPrenda";
            this.labelNroPrenda.Size = new System.Drawing.Size(86, 15);
            this.labelNroPrenda.TabIndex = 6;
            this.labelNroPrenda.Text = "Nro de prenda";
            // 
            // textBoxEstadoPrenda
            // 
            this.textBoxEstadoPrenda.Location = new System.Drawing.Point(132, 102);
            this.textBoxEstadoPrenda.Name = "textBoxEstadoPrenda";
            this.textBoxEstadoPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoPrenda.TabIndex = 5;
            // 
            // labelEstadoprenda
            // 
            this.labelEstadoprenda.AutoSize = true;
            this.labelEstadoprenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoprenda.Location = new System.Drawing.Point(129, 84);
            this.labelEstadoprenda.Name = "labelEstadoprenda";
            this.labelEstadoprenda.Size = new System.Drawing.Size(104, 15);
            this.labelEstadoprenda.TabIndex = 4;
            this.labelEstadoprenda.Text = "Estado de prenda";
            // 
            // textBoxTipoPrenda
            // 
            this.textBoxTipoPrenda.Location = new System.Drawing.Point(130, 55);
            this.textBoxTipoPrenda.Name = "textBoxTipoPrenda";
            this.textBoxTipoPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoPrenda.TabIndex = 3;
            // 
            // labelTipoPrenda
            // 
            this.labelTipoPrenda.AutoSize = true;
            this.labelTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPrenda.Location = new System.Drawing.Point(129, 35);
            this.labelTipoPrenda.Name = "labelTipoPrenda";
            this.labelTipoPrenda.Size = new System.Drawing.Size(90, 15);
            this.labelTipoPrenda.TabIndex = 2;
            this.labelTipoPrenda.Text = "Tipo de prenda";
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
            // MantenedorPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosPrendas);
            this.Controls.Add(this.dgVPrenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorPrenda";
            this.Text = "FormServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgVPrenda)).EndInit();
            this.groupBoxDatosPrendas.ResumeLayout(false);
            this.groupBoxDatosPrendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVPrenda;
        private System.Windows.Forms.GroupBox groupBoxDatosPrendas;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxColorPrenda;
        private System.Windows.Forms.Label labelColorPrenda;
        private System.Windows.Forms.TextBox textBoxNroPrenda;
        private System.Windows.Forms.Label labelNroPrenda;
        private System.Windows.Forms.TextBox textBoxEstadoPrenda;
        private System.Windows.Forms.Label labelEstadoprenda;
        private System.Windows.Forms.TextBox textBoxTipoPrenda;
        private System.Windows.Forms.Label labelTipoPrenda;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtPickerRegPrenda;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox cbkEstadoAtencion;
    }
}