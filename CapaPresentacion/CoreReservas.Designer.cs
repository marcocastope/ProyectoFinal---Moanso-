
namespace CapaPresentacion
{
    partial class CoreReservas
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
            this.reservasGBox = new System.Windows.Forms.GroupBox();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.nuevoReservaBtn = new System.Windows.Forms.Button();
            this.datosReservaGBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHabitacion = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.controlesGBox = new System.Windows.Forms.GroupBox();
            this.anularReservaBtn = new System.Windows.Forms.Button();
            this.registrarReservaBtn = new System.Windows.Forms.Button();
            this.checkBoxEstadoReserva = new System.Windows.Forms.CheckBox();
            this.reservasGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.datosReservaGBox.SuspendLayout();
            this.controlesGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservasGBox
            // 
            this.reservasGBox.Controls.Add(this.dataGridViewReservas);
            this.reservasGBox.Location = new System.Drawing.Point(12, 12);
            this.reservasGBox.Name = "reservasGBox";
            this.reservasGBox.Size = new System.Drawing.Size(610, 178);
            this.reservasGBox.TabIndex = 0;
            this.reservasGBox.TabStop = false;
            this.reservasGBox.Text = "Reservas";
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(598, 150);
            this.dataGridViewReservas.TabIndex = 0;
            // 
            // nuevoReservaBtn
            // 
            this.nuevoReservaBtn.Location = new System.Drawing.Point(33, 16);
            this.nuevoReservaBtn.Name = "nuevoReservaBtn";
            this.nuevoReservaBtn.Size = new System.Drawing.Size(100, 40);
            this.nuevoReservaBtn.TabIndex = 1;
            this.nuevoReservaBtn.Text = "Nuevo";
            this.nuevoReservaBtn.UseVisualStyleBackColor = true;
            // 
            // datosReservaGBox
            // 
            this.datosReservaGBox.Controls.Add(this.checkBoxEstadoReserva);
            this.datosReservaGBox.Controls.Add(this.label4);
            this.datosReservaGBox.Controls.Add(this.dateTimePickerCheckOut);
            this.datosReservaGBox.Controls.Add(this.label3);
            this.datosReservaGBox.Controls.Add(this.dateTimePickerCheckIn);
            this.datosReservaGBox.Controls.Add(this.label2);
            this.datosReservaGBox.Controls.Add(this.label1);
            this.datosReservaGBox.Controls.Add(this.comboBoxHabitacion);
            this.datosReservaGBox.Controls.Add(this.comboBoxCliente);
            this.datosReservaGBox.Location = new System.Drawing.Point(12, 196);
            this.datosReservaGBox.Name = "datosReservaGBox";
            this.datosReservaGBox.Size = new System.Drawing.Size(438, 154);
            this.datosReservaGBox.TabIndex = 2;
            this.datosReservaGBox.TabStop = false;
            this.datosReservaGBox.Text = "Datos Reserva";
            this.datosReservaGBox.Enter += new System.EventHandler(this.datosReservaGBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check Out";
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(208, 84);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckOut.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Check In";
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(208, 38);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCheckIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habitación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // comboBoxHabitacion
            // 
            this.comboBoxHabitacion.FormattingEnabled = true;
            this.comboBoxHabitacion.Location = new System.Drawing.Point(6, 84);
            this.comboBoxHabitacion.Name = "comboBoxHabitacion";
            this.comboBoxHabitacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHabitacion.TabIndex = 0;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(6, 38);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // controlesGBox
            // 
            this.controlesGBox.Controls.Add(this.anularReservaBtn);
            this.controlesGBox.Controls.Add(this.registrarReservaBtn);
            this.controlesGBox.Controls.Add(this.nuevoReservaBtn);
            this.controlesGBox.Location = new System.Drawing.Point(456, 196);
            this.controlesGBox.Name = "controlesGBox";
            this.controlesGBox.Size = new System.Drawing.Size(160, 154);
            this.controlesGBox.TabIndex = 2;
            this.controlesGBox.TabStop = false;
            this.controlesGBox.Text = "Controles";
            // 
            // anularReservaBtn
            // 
            this.anularReservaBtn.Location = new System.Drawing.Point(33, 108);
            this.anularReservaBtn.Name = "anularReservaBtn";
            this.anularReservaBtn.Size = new System.Drawing.Size(100, 40);
            this.anularReservaBtn.TabIndex = 1;
            this.anularReservaBtn.Text = "Anular";
            this.anularReservaBtn.UseVisualStyleBackColor = true;
            // 
            // registrarReservaBtn
            // 
            this.registrarReservaBtn.Location = new System.Drawing.Point(33, 62);
            this.registrarReservaBtn.Name = "registrarReservaBtn";
            this.registrarReservaBtn.Size = new System.Drawing.Size(100, 40);
            this.registrarReservaBtn.TabIndex = 1;
            this.registrarReservaBtn.Text = "Registrar";
            this.registrarReservaBtn.UseVisualStyleBackColor = true;
            this.registrarReservaBtn.Click += new System.EventHandler(this.registrarReservaBtn_Click);
            // 
            // checkBoxEstadoReserva
            // 
            this.checkBoxEstadoReserva.AutoSize = true;
            this.checkBoxEstadoReserva.Location = new System.Drawing.Point(6, 131);
            this.checkBoxEstadoReserva.Name = "checkBoxEstadoReserva";
            this.checkBoxEstadoReserva.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEstadoReserva.TabIndex = 4;
            this.checkBoxEstadoReserva.Text = "Estado";
            this.checkBoxEstadoReserva.UseVisualStyleBackColor = true;
            // 
            // CoreReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.controlesGBox);
            this.Controls.Add(this.datosReservaGBox);
            this.Controls.Add(this.reservasGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoreReservas";
            this.Text = "CoreReservas";
            this.Load += new System.EventHandler(this.CoreReservas_Load);
            this.reservasGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.datosReservaGBox.ResumeLayout(false);
            this.datosReservaGBox.PerformLayout();
            this.controlesGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox reservasGBox;
        private System.Windows.Forms.Button nuevoReservaBtn;
        private System.Windows.Forms.GroupBox datosReservaGBox;
        private System.Windows.Forms.GroupBox controlesGBox;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Button anularReservaBtn;
        private System.Windows.Forms.Button registrarReservaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHabitacion;
        private System.Windows.Forms.CheckBox checkBoxEstadoReserva;
    }
}