
namespace CapaPresentacion
{
    partial class MantenedorCiudad
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
            this.dgVCiudad = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosCiudad = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxIdCiudad = new System.Windows.Forms.TextBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelIdCiudad = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVCiudad)).BeginInit();
            this.groupBoxDatosCiudad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVCiudad
            // 
            this.dgVCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVCiudad.Location = new System.Drawing.Point(1, 3);
            this.dgVCiudad.Name = "dgVCiudad";
            this.dgVCiudad.Size = new System.Drawing.Size(498, 201);
            this.dgVCiudad.TabIndex = 0;
            this.dgVCiudad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVCiudad_CellDoubleClick);
            // 
            // groupBoxDatosCiudad
            // 
            this.groupBoxDatosCiudad.Controls.Add(this.btnCancelar);
            this.groupBoxDatosCiudad.Controls.Add(this.btnModificar);
            this.groupBoxDatosCiudad.Controls.Add(this.btnAgregar);
            this.groupBoxDatosCiudad.Controls.Add(this.textBoxCiudad);
            this.groupBoxDatosCiudad.Controls.Add(this.textBoxIdCiudad);
            this.groupBoxDatosCiudad.Controls.Add(this.checkBoxEstado);
            this.groupBoxDatosCiudad.Controls.Add(this.labelCiudad);
            this.groupBoxDatosCiudad.Controls.Add(this.labelIdCiudad);
            this.groupBoxDatosCiudad.Location = new System.Drawing.Point(9, 223);
            this.groupBoxDatosCiudad.Name = "groupBoxDatosCiudad";
            this.groupBoxDatosCiudad.Size = new System.Drawing.Size(620, 169);
            this.groupBoxDatosCiudad.TabIndex = 1;
            this.groupBoxDatosCiudad.TabStop = false;
            this.groupBoxDatosCiudad.Text = "Datos Ciudad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(521, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(415, 95);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(415, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(22, 121);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 4;
            // 
            // textBoxIdCiudad
            // 
            this.textBoxIdCiudad.Location = new System.Drawing.Point(22, 55);
            this.textBoxIdCiudad.Name = "textBoxIdCiudad";
            this.textBoxIdCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCiudad.TabIndex = 3;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(187, 82);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEstado.TabIndex = 2;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(19, 103);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(46, 15);
            this.labelCiudad.TabIndex = 1;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelIdCiudad
            // 
            this.labelIdCiudad.AutoSize = true;
            this.labelIdCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCiudad.Location = new System.Drawing.Point(19, 37);
            this.labelIdCiudad.Name = "labelIdCiudad";
            this.labelIdCiudad.Size = new System.Drawing.Size(56, 15);
            this.labelIdCiudad.TabIndex = 0;
            this.labelIdCiudad.Text = "IdCiudad";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(521, 38);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(521, 87);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(521, 139);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(84, 23);
            this.btnDeshabilitar.TabIndex = 4;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // MantenedorCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 412);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosCiudad);
            this.Controls.Add(this.dgVCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorCiudad";
            this.Text = "MantenedorCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.dgVCiudad)).EndInit();
            this.groupBoxDatosCiudad.ResumeLayout(false);
            this.groupBoxDatosCiudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVCiudad;
        private System.Windows.Forms.GroupBox groupBoxDatosCiudad;
        private System.Windows.Forms.Label labelIdCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxIdCiudad;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}