
namespace CapaPresentacion
{
    partial class MantenedorTipoCliente
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
            this.dgVTipoCliente = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxDescripcionTipoCliente = new System.Windows.Forms.TextBox();
            this.textBoxTipoCliente = new System.Windows.Forms.TextBox();
            this.textBoxIdTipoCliente = new System.Windows.Forms.TextBox();
            this.checkBoxEstadoTipoCliente = new System.Windows.Forms.CheckBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelTipoCliente = new System.Windows.Forms.Label();
            this.labelIdTipoCliente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVTipoCliente)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVTipoCliente
            // 
            this.dgVTipoCliente.AllowUserToAddRows = false;
            this.dgVTipoCliente.AllowUserToDeleteRows = false;
            this.dgVTipoCliente.AllowUserToResizeColumns = false;
            this.dgVTipoCliente.AllowUserToResizeRows = false;
            this.dgVTipoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVTipoCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgVTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVTipoCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVTipoCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVTipoCliente.ColumnHeadersHeight = 30;
            this.dgVTipoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgVTipoCliente.EnableHeadersVisualStyles = false;
            this.dgVTipoCliente.Location = new System.Drawing.Point(12, 12);
            this.dgVTipoCliente.MultiSelect = false;
            this.dgVTipoCliente.Name = "dgVTipoCliente";
            this.dgVTipoCliente.ReadOnly = true;
            this.dgVTipoCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgVTipoCliente.RowHeadersVisible = false;
            this.dgVTipoCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgVTipoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVTipoCliente.Size = new System.Drawing.Size(511, 201);
            this.dgVTipoCliente.TabIndex = 0;
            this.dgVTipoCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVTipoCliente_CellDoubleClick);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.textBoxDescripcionTipoCliente);
            this.groupBoxDatos.Controls.Add(this.textBoxTipoCliente);
            this.groupBoxDatos.Controls.Add(this.textBoxIdTipoCliente);
            this.groupBoxDatos.Controls.Add(this.checkBoxEstadoTipoCliente);
            this.groupBoxDatos.Controls.Add(this.labelDescripcion);
            this.groupBoxDatos.Controls.Add(this.labelTipoCliente);
            this.groupBoxDatos.Controls.Add(this.labelIdTipoCliente);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 230);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(614, 145);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(504, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(411, 93);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(411, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textBoxDescripcionTipoCliente
            // 
            this.textBoxDescripcionTipoCliente.Location = new System.Drawing.Point(173, 59);
            this.textBoxDescripcionTipoCliente.Name = "textBoxDescripcionTipoCliente";
            this.textBoxDescripcionTipoCliente.Size = new System.Drawing.Size(130, 20);
            this.textBoxDescripcionTipoCliente.TabIndex = 6;
            // 
            // textBoxTipoCliente
            // 
            this.textBoxTipoCliente.Location = new System.Drawing.Point(45, 111);
            this.textBoxTipoCliente.Name = "textBoxTipoCliente";
            this.textBoxTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoCliente.TabIndex = 5;
            // 
            // textBoxIdTipoCliente
            // 
            this.textBoxIdTipoCliente.Location = new System.Drawing.Point(45, 59);
            this.textBoxIdTipoCliente.Name = "textBoxIdTipoCliente";
            this.textBoxIdTipoCliente.Size = new System.Drawing.Size(49, 20);
            this.textBoxIdTipoCliente.TabIndex = 4;
            // 
            // checkBoxEstadoTipoCliente
            // 
            this.checkBoxEstadoTipoCliente.AutoSize = true;
            this.checkBoxEstadoTipoCliente.Location = new System.Drawing.Point(183, 113);
            this.checkBoxEstadoTipoCliente.Name = "checkBoxEstadoTipoCliente";
            this.checkBoxEstadoTipoCliente.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEstadoTipoCliente.TabIndex = 3;
            this.checkBoxEstadoTipoCliente.Text = "Estado";
            this.checkBoxEstadoTipoCliente.UseVisualStyleBackColor = true;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(170, 41);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(72, 15);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelTipoCliente
            // 
            this.labelTipoCliente.AutoSize = true;
            this.labelTipoCliente.Location = new System.Drawing.Point(42, 93);
            this.labelTipoCliente.Name = "labelTipoCliente";
            this.labelTipoCliente.Size = new System.Drawing.Size(63, 13);
            this.labelTipoCliente.TabIndex = 1;
            this.labelTipoCliente.Text = "Tipo Cliente";
            // 
            // labelIdTipoCliente
            // 
            this.labelIdTipoCliente.AutoSize = true;
            this.labelIdTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdTipoCliente.Location = new System.Drawing.Point(42, 42);
            this.labelIdTipoCliente.Name = "labelIdTipoCliente";
            this.labelIdTipoCliente.Size = new System.Drawing.Size(22, 15);
            this.labelIdTipoCliente.TabIndex = 0;
            this.labelIdTipoCliente.Text = "ID ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(529, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(529, 93);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(529, 160);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(82, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // MantenedorTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 391);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.dgVTipoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorTipoCliente";
            this.Text = "MantenedorTipoCliente";
            this.Load += new System.EventHandler(this.MantenedorTipoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVTipoCliente)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVTipoCliente;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelIdTipoCliente;
        private System.Windows.Forms.Label labelTipoCliente;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.CheckBox checkBoxEstadoTipoCliente;
        private System.Windows.Forms.TextBox textBoxIdTipoCliente;
        private System.Windows.Forms.TextBox textBoxTipoCliente;
        private System.Windows.Forms.TextBox textBoxDescripcionTipoCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}