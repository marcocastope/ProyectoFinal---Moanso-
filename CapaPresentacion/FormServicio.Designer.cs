﻿
namespace CapaPresentacion
{
    partial class FormServicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosPrendas = new System.Windows.Forms.GroupBox();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.labelTipoPrenda = new System.Windows.Forms.Label();
            this.textBoxTipoPrenda = new System.Windows.Forms.TextBox();
            this.labelEstadoprenda = new System.Windows.Forms.Label();
            this.textBoxEstadoPrenda = new System.Windows.Forms.TextBox();
            this.labelNroPrenda = new System.Windows.Forms.Label();
            this.textBoxNroPrenda = new System.Windows.Forms.TextBox();
            this.labelColorPrenda = new System.Windows.Forms.Label();
            this.textBoxColorPrenda = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDatosPrendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxDatosPrendas
            // 
            this.groupBoxDatosPrendas.Controls.Add(this.btnCancelar);
            this.groupBoxDatosPrendas.Controls.Add(this.btnModificar);
            this.groupBoxDatosPrendas.Controls.Add(this.btnAgregar);
            this.groupBoxDatosPrendas.Controls.Add(this.dateTimePicker1);
            this.groupBoxDatosPrendas.Controls.Add(this.labelFechaRegistro);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxColorPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelColorPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxNroPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelNroPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxEstadoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelEstadoprenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxTipoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.labelTipoPrenda);
            this.groupBoxDatosPrendas.Controls.Add(this.textBoxCodigoCliente);
            this.groupBoxDatosPrendas.Controls.Add(this.labelCodigoCliente);
            this.groupBoxDatosPrendas.Location = new System.Drawing.Point(23, 251);
            this.groupBoxDatosPrendas.Name = "groupBoxDatosPrendas";
            this.groupBoxDatosPrendas.Size = new System.Drawing.Size(638, 144);
            this.groupBoxDatosPrendas.TabIndex = 1;
            this.groupBoxDatosPrendas.TabStop = false;
            this.groupBoxDatosPrendas.Text = "Datos de prendas";
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.Location = new System.Drawing.Point(3, 35);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(105, 15);
            this.labelCodigoCliente.TabIndex = 0;
            this.labelCodigoCliente.Text = "Código del cliente";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(6, 53);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCliente.TabIndex = 1;
            // 
            // labelTipoPrenda
            // 
            this.labelTipoPrenda.AutoSize = true;
            this.labelTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPrenda.Location = new System.Drawing.Point(3, 84);
            this.labelTipoPrenda.Name = "labelTipoPrenda";
            this.labelTipoPrenda.Size = new System.Drawing.Size(90, 15);
            this.labelTipoPrenda.TabIndex = 2;
            this.labelTipoPrenda.Text = "Tipo de prenda";
            // 
            // textBoxTipoPrenda
            // 
            this.textBoxTipoPrenda.Location = new System.Drawing.Point(6, 102);
            this.textBoxTipoPrenda.Name = "textBoxTipoPrenda";
            this.textBoxTipoPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoPrenda.TabIndex = 3;
            // 
            // labelEstadoprenda
            // 
            this.labelEstadoprenda.AutoSize = true;
            this.labelEstadoprenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoprenda.Location = new System.Drawing.Point(144, 84);
            this.labelEstadoprenda.Name = "labelEstadoprenda";
            this.labelEstadoprenda.Size = new System.Drawing.Size(104, 15);
            this.labelEstadoprenda.TabIndex = 4;
            this.labelEstadoprenda.Text = "Estado de prenda";
            // 
            // textBoxEstadoPrenda
            // 
            this.textBoxEstadoPrenda.Location = new System.Drawing.Point(148, 102);
            this.textBoxEstadoPrenda.Name = "textBoxEstadoPrenda";
            this.textBoxEstadoPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoPrenda.TabIndex = 5;
            // 
            // labelNroPrenda
            // 
            this.labelNroPrenda.AutoSize = true;
            this.labelNroPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPrenda.Location = new System.Drawing.Point(144, 35);
            this.labelNroPrenda.Name = "labelNroPrenda";
            this.labelNroPrenda.Size = new System.Drawing.Size(86, 15);
            this.labelNroPrenda.TabIndex = 6;
            this.labelNroPrenda.Text = "Nro de prenda";
            // 
            // textBoxNroPrenda
            // 
            this.textBoxNroPrenda.Location = new System.Drawing.Point(147, 53);
            this.textBoxNroPrenda.Name = "textBoxNroPrenda";
            this.textBoxNroPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroPrenda.TabIndex = 7;
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
            // textBoxColorPrenda
            // 
            this.textBoxColorPrenda.Location = new System.Drawing.Point(266, 53);
            this.textBoxColorPrenda.Name = "textBoxColorPrenda";
            this.textBoxColorPrenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxColorPrenda.TabIndex = 9;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(586, 30);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(586, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(586, 132);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(86, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(586, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(551, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(551, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(551, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 423);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosPrendas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicio";
            this.Text = "FormServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDatosPrendas.ResumeLayout(false);
            this.groupBoxDatosPrendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxDatosPrendas;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.TextBox textBoxColorPrenda;
        private System.Windows.Forms.Label labelColorPrenda;
        private System.Windows.Forms.TextBox textBoxNroPrenda;
        private System.Windows.Forms.Label labelNroPrenda;
        private System.Windows.Forms.TextBox textBoxEstadoPrenda;
        private System.Windows.Forms.Label labelEstadoprenda;
        private System.Windows.Forms.TextBox textBoxTipoPrenda;
        private System.Windows.Forms.Label labelTipoPrenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
    }
}