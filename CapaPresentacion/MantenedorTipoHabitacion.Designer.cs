
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
            this.label1 = new System.Windows.Forms.Label();
            this.personalNombreTxt = new System.Windows.Forms.TextBox();
            this.personalApellidoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPersonalGBox = new System.Windows.Forms.GroupBox();
            this.listaPersonalGridView = new System.Windows.Forms.DataGridView();
            this.datosGBox = new System.Windows.Forms.GroupBox();
            this.controlesGBox = new System.Windows.Forms.GroupBox();
            this.registrarPersonalBtn = new System.Windows.Forms.Button();
            this.eliminarPersonalBtn = new System.Windows.Forms.Button();
            this.actualizarPersonalBtn = new System.Windows.Forms.Button();
            this.nuevoPersonalBtn = new System.Windows.Forms.Button();
            this.listaPersonalGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPersonalGridView)).BeginInit();
            this.datosGBox.SuspendLayout();
            this.controlesGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // personalNombreTxt
            // 
            this.personalNombreTxt.Location = new System.Drawing.Point(6, 34);
            this.personalNombreTxt.Name = "personalNombreTxt";
            this.personalNombreTxt.Size = new System.Drawing.Size(100, 20);
            this.personalNombreTxt.TabIndex = 1;
            // 
            // personalApellidoTxt
            // 
            this.personalApellidoTxt.Location = new System.Drawing.Point(6, 77);
            this.personalApellidoTxt.Name = "personalApellidoTxt";
            this.personalApellidoTxt.Size = new System.Drawing.Size(100, 20);
            this.personalApellidoTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // listaPersonalGBox
            // 
            this.listaPersonalGBox.Controls.Add(this.listaPersonalGridView);
            this.listaPersonalGBox.Location = new System.Drawing.Point(12, 12);
            this.listaPersonalGBox.Name = "listaPersonalGBox";
            this.listaPersonalGBox.Size = new System.Drawing.Size(626, 248);
            this.listaPersonalGBox.TabIndex = 2;
            this.listaPersonalGBox.TabStop = false;
            this.listaPersonalGBox.Text = "Tipos de Habitación";
            this.listaPersonalGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listaPersonalGridView
            // 
            this.listaPersonalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPersonalGridView.Location = new System.Drawing.Point(3, 19);
            this.listaPersonalGridView.Name = "listaPersonalGridView";
            this.listaPersonalGridView.Size = new System.Drawing.Size(623, 229);
            this.listaPersonalGridView.TabIndex = 0;
            this.listaPersonalGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaPersonalGridView_CellContentClick);
            // 
            // datosGBox
            // 
            this.datosGBox.Controls.Add(this.label1);
            this.datosGBox.Controls.Add(this.personalNombreTxt);
            this.datosGBox.Controls.Add(this.personalApellidoTxt);
            this.datosGBox.Controls.Add(this.label2);
            this.datosGBox.Location = new System.Drawing.Point(12, 277);
            this.datosGBox.Name = "datosGBox";
            this.datosGBox.Size = new System.Drawing.Size(369, 112);
            this.datosGBox.TabIndex = 2;
            this.datosGBox.TabStop = false;
            this.datosGBox.Text = "Datos";
            this.datosGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // controlesGBox
            // 
            this.controlesGBox.Controls.Add(this.registrarPersonalBtn);
            this.controlesGBox.Controls.Add(this.eliminarPersonalBtn);
            this.controlesGBox.Controls.Add(this.actualizarPersonalBtn);
            this.controlesGBox.Controls.Add(this.nuevoPersonalBtn);
            this.controlesGBox.Location = new System.Drawing.Point(387, 277);
            this.controlesGBox.Name = "controlesGBox";
            this.controlesGBox.Size = new System.Drawing.Size(251, 112);
            this.controlesGBox.TabIndex = 3;
            this.controlesGBox.TabStop = false;
            this.controlesGBox.Text = "Controles";
            this.controlesGBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // registrarPersonalBtn
            // 
            this.registrarPersonalBtn.Location = new System.Drawing.Point(6, 72);
            this.registrarPersonalBtn.Name = "registrarPersonalBtn";
            this.registrarPersonalBtn.Size = new System.Drawing.Size(100, 25);
            this.registrarPersonalBtn.TabIndex = 0;
            this.registrarPersonalBtn.Text = "Registrar";
            this.registrarPersonalBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarPersonalBtn
            // 
            this.eliminarPersonalBtn.Location = new System.Drawing.Point(145, 72);
            this.eliminarPersonalBtn.Name = "eliminarPersonalBtn";
            this.eliminarPersonalBtn.Size = new System.Drawing.Size(100, 25);
            this.eliminarPersonalBtn.TabIndex = 0;
            this.eliminarPersonalBtn.Text = "Eliminar";
            this.eliminarPersonalBtn.UseVisualStyleBackColor = true;
            // 
            // actualizarPersonalBtn
            // 
            this.actualizarPersonalBtn.Location = new System.Drawing.Point(145, 19);
            this.actualizarPersonalBtn.Name = "actualizarPersonalBtn";
            this.actualizarPersonalBtn.Size = new System.Drawing.Size(100, 25);
            this.actualizarPersonalBtn.TabIndex = 0;
            this.actualizarPersonalBtn.Text = "Actualizar";
            this.actualizarPersonalBtn.UseVisualStyleBackColor = true;
            // 
            // nuevoPersonalBtn
            // 
            this.nuevoPersonalBtn.Location = new System.Drawing.Point(6, 19);
            this.nuevoPersonalBtn.Name = "nuevoPersonalBtn";
            this.nuevoPersonalBtn.Size = new System.Drawing.Size(100, 25);
            this.nuevoPersonalBtn.TabIndex = 0;
            this.nuevoPersonalBtn.Text = "Nuevo";
            this.nuevoPersonalBtn.UseVisualStyleBackColor = true;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.controlesGBox);
            this.Controls.Add(this.datosGBox);
            this.Controls.Add(this.listaPersonalGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersonal";
            this.Text = "FormPersonal";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            this.listaPersonalGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaPersonalGridView)).EndInit();
            this.datosGBox.ResumeLayout(false);
            this.datosGBox.PerformLayout();
            this.controlesGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personalNombreTxt;
        private System.Windows.Forms.TextBox personalApellidoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox listaPersonalGBox;
        private System.Windows.Forms.GroupBox datosGBox;
        private System.Windows.Forms.GroupBox controlesGBox;
        private System.Windows.Forms.Button nuevoPersonalBtn;
        private System.Windows.Forms.Button registrarPersonalBtn;
        private System.Windows.Forms.Button eliminarPersonalBtn;
        private System.Windows.Forms.Button actualizarPersonalBtn;
        private System.Windows.Forms.DataGridView listaPersonalGridView;
    }
}