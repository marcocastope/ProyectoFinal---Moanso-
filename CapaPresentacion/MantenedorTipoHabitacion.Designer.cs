
namespace CapaPresentacion
{
    partial class MantenedorTipoHabitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tipolHabitacionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPersonalGBox = new System.Windows.Forms.GroupBox();
            this.listaTiposHabitacionGridView = new System.Windows.Forms.DataGridView();
            this.datosTipoHabitacionGBox = new System.Windows.Forms.GroupBox();
            this.tipoHabitacionDescripcionTxt = new System.Windows.Forms.TextBox();
            this.estadoTipoHabitacionCheck = new System.Windows.Forms.CheckBox();
            this.controlesGBox = new System.Windows.Forms.GroupBox();
            this.registrarTipolBtn = new System.Windows.Forms.Button();
            this.deshablitarTipoHabitacionBtn = new System.Windows.Forms.Button();
            this.modificarTipoBtn = new System.Windows.Forms.Button();
            this.nuevoTipoBtn = new System.Windows.Forms.Button();
            this.idTipoHabitacionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaPersonalGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposHabitacionGridView)).BeginInit();
            this.datosTipoHabitacionGBox.SuspendLayout();
            this.controlesGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // tipolHabitacionTxt
            // 
            this.tipolHabitacionTxt.Location = new System.Drawing.Point(6, 80);
            this.tipolHabitacionTxt.Name = "tipolHabitacionTxt";
            this.tipolHabitacionTxt.Size = new System.Drawing.Size(100, 20);
            this.tipolHabitacionTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // listaPersonalGBox
            // 
            this.listaPersonalGBox.Controls.Add(this.listaTiposHabitacionGridView);
            this.listaPersonalGBox.Location = new System.Drawing.Point(12, 12);
            this.listaPersonalGBox.Name = "listaPersonalGBox";
            this.listaPersonalGBox.Size = new System.Drawing.Size(626, 197);
            this.listaPersonalGBox.TabIndex = 2;
            this.listaPersonalGBox.TabStop = false;
            this.listaPersonalGBox.Text = "Tipos de Habitación";
            this.listaPersonalGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listaTiposHabitacionGridView
            // 
            this.listaTiposHabitacionGridView.AllowUserToAddRows = false;
            this.listaTiposHabitacionGridView.AllowUserToDeleteRows = false;
            this.listaTiposHabitacionGridView.AllowUserToResizeColumns = false;
            this.listaTiposHabitacionGridView.AllowUserToResizeRows = false;
            this.listaTiposHabitacionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaTiposHabitacionGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaTiposHabitacionGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaTiposHabitacionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaTiposHabitacionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaTiposHabitacionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.listaTiposHabitacionGridView.ColumnHeadersHeight = 30;
            this.listaTiposHabitacionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaTiposHabitacionGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.listaTiposHabitacionGridView.EnableHeadersVisualStyles = false;
            this.listaTiposHabitacionGridView.Location = new System.Drawing.Point(3, 19);
            this.listaTiposHabitacionGridView.MultiSelect = false;
            this.listaTiposHabitacionGridView.Name = "listaTiposHabitacionGridView";
            this.listaTiposHabitacionGridView.ReadOnly = true;
            this.listaTiposHabitacionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listaTiposHabitacionGridView.RowHeadersVisible = false;
            this.listaTiposHabitacionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaTiposHabitacionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaTiposHabitacionGridView.ShowEditingIcon = false;
            this.listaTiposHabitacionGridView.Size = new System.Drawing.Size(623, 172);
            this.listaTiposHabitacionGridView.TabIndex = 0;
            this.listaTiposHabitacionGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaTiposHabitacionGridViewOnClick);
            // 
            // datosTipoHabitacionGBox
            // 
            this.datosTipoHabitacionGBox.Controls.Add(this.tipoHabitacionDescripcionTxt);
            this.datosTipoHabitacionGBox.Controls.Add(this.estadoTipoHabitacionCheck);
            this.datosTipoHabitacionGBox.Controls.Add(this.label3);
            this.datosTipoHabitacionGBox.Controls.Add(this.idTipoHabitacionTxt);
            this.datosTipoHabitacionGBox.Controls.Add(this.label1);
            this.datosTipoHabitacionGBox.Controls.Add(this.tipolHabitacionTxt);
            this.datosTipoHabitacionGBox.Controls.Add(this.label2);
            this.datosTipoHabitacionGBox.Location = new System.Drawing.Point(12, 215);
            this.datosTipoHabitacionGBox.Name = "datosTipoHabitacionGBox";
            this.datosTipoHabitacionGBox.Size = new System.Drawing.Size(369, 174);
            this.datosTipoHabitacionGBox.TabIndex = 2;
            this.datosTipoHabitacionGBox.TabStop = false;
            this.datosTipoHabitacionGBox.Text = "Datos";
            this.datosTipoHabitacionGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tipoHabitacionDescripcionTxt
            // 
            this.tipoHabitacionDescripcionTxt.Location = new System.Drawing.Point(6, 121);
            this.tipoHabitacionDescripcionTxt.Name = "tipoHabitacionDescripcionTxt";
            this.tipoHabitacionDescripcionTxt.Size = new System.Drawing.Size(100, 20);
            this.tipoHabitacionDescripcionTxt.TabIndex = 3;
            // 
            // estadoTipoHabitacionCheck
            // 
            this.estadoTipoHabitacionCheck.AutoSize = true;
            this.estadoTipoHabitacionCheck.Location = new System.Drawing.Point(167, 83);
            this.estadoTipoHabitacionCheck.Name = "estadoTipoHabitacionCheck";
            this.estadoTipoHabitacionCheck.Size = new System.Drawing.Size(59, 17);
            this.estadoTipoHabitacionCheck.TabIndex = 2;
            this.estadoTipoHabitacionCheck.Text = "Estado";
            this.estadoTipoHabitacionCheck.UseVisualStyleBackColor = true;
            // 
            // controlesGBox
            // 
            this.controlesGBox.Controls.Add(this.registrarTipolBtn);
            this.controlesGBox.Controls.Add(this.deshablitarTipoHabitacionBtn);
            this.controlesGBox.Controls.Add(this.modificarTipoBtn);
            this.controlesGBox.Controls.Add(this.nuevoTipoBtn);
            this.controlesGBox.Location = new System.Drawing.Point(387, 215);
            this.controlesGBox.Name = "controlesGBox";
            this.controlesGBox.Size = new System.Drawing.Size(251, 174);
            this.controlesGBox.TabIndex = 3;
            this.controlesGBox.TabStop = false;
            this.controlesGBox.Text = "Controles";
            this.controlesGBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // registrarTipolBtn
            // 
            this.registrarTipolBtn.Location = new System.Drawing.Point(6, 72);
            this.registrarTipolBtn.Name = "registrarTipolBtn";
            this.registrarTipolBtn.Size = new System.Drawing.Size(100, 40);
            this.registrarTipolBtn.TabIndex = 0;
            this.registrarTipolBtn.Text = "Registrar";
            this.registrarTipolBtn.UseVisualStyleBackColor = true;
            this.registrarTipolBtn.Click += new System.EventHandler(this.registrarTipolBtn_Click);
            // 
            // deshablitarTipoHabitacionBtn
            // 
            this.deshablitarTipoHabitacionBtn.Location = new System.Drawing.Point(145, 72);
            this.deshablitarTipoHabitacionBtn.Name = "deshablitarTipoHabitacionBtn";
            this.deshablitarTipoHabitacionBtn.Size = new System.Drawing.Size(100, 40);
            this.deshablitarTipoHabitacionBtn.TabIndex = 0;
            this.deshablitarTipoHabitacionBtn.Text = "Deshabilitar";
            this.deshablitarTipoHabitacionBtn.UseVisualStyleBackColor = true;
            this.deshablitarTipoHabitacionBtn.Click += new System.EventHandler(this.deshablitarTipoHabitacionBtn_Click);
            // 
            // modificarTipoBtn
            // 
            this.modificarTipoBtn.Location = new System.Drawing.Point(6, 121);
            this.modificarTipoBtn.Name = "modificarTipoBtn";
            this.modificarTipoBtn.Size = new System.Drawing.Size(100, 40);
            this.modificarTipoBtn.TabIndex = 0;
            this.modificarTipoBtn.Text = "Modificar";
            this.modificarTipoBtn.UseVisualStyleBackColor = true;
            this.modificarTipoBtn.Click += new System.EventHandler(this.modificarTipoBtn_Click);
            // 
            // nuevoTipoBtn
            // 
            this.nuevoTipoBtn.Location = new System.Drawing.Point(6, 19);
            this.nuevoTipoBtn.Name = "nuevoTipoBtn";
            this.nuevoTipoBtn.Size = new System.Drawing.Size(100, 40);
            this.nuevoTipoBtn.TabIndex = 0;
            this.nuevoTipoBtn.Text = "Nuevo";
            this.nuevoTipoBtn.UseVisualStyleBackColor = true;
            this.nuevoTipoBtn.Click += new System.EventHandler(this.nuevoTipoBtn_Click);
            // 
            // idTipoHabitacionTxt
            // 
            this.idTipoHabitacionTxt.Enabled = false;
            this.idTipoHabitacionTxt.Location = new System.Drawing.Point(6, 34);
            this.idTipoHabitacionTxt.Name = "idTipoHabitacionTxt";
            this.idTipoHabitacionTxt.ReadOnly = true;
            this.idTipoHabitacionTxt.Size = new System.Drawing.Size(19, 20);
            this.idTipoHabitacionTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // MantenedorTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.controlesGBox);
            this.Controls.Add(this.datosTipoHabitacionGBox);
            this.Controls.Add(this.listaPersonalGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorTipoHabitacion";
            this.Text = "FormPersonal";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            this.listaPersonalGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposHabitacionGridView)).EndInit();
            this.datosTipoHabitacionGBox.ResumeLayout(false);
            this.datosTipoHabitacionGBox.PerformLayout();
            this.controlesGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipolHabitacionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox listaPersonalGBox;
        private System.Windows.Forms.GroupBox datosTipoHabitacionGBox;
        private System.Windows.Forms.GroupBox controlesGBox;
        private System.Windows.Forms.Button nuevoTipoBtn;
        private System.Windows.Forms.Button registrarTipolBtn;
        private System.Windows.Forms.Button deshablitarTipoHabitacionBtn;
        private System.Windows.Forms.Button modificarTipoBtn;
        private System.Windows.Forms.DataGridView listaTiposHabitacionGridView;
        private System.Windows.Forms.CheckBox estadoTipoHabitacionCheck;
        private System.Windows.Forms.TextBox tipoHabitacionDescripcionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTipoHabitacionTxt;
    }
}