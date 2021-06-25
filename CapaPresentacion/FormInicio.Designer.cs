
namespace CapaPresentacion
{
    partial class FormInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mantTipoHabitacionBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mantHabitacionBtn = new System.Windows.Forms.Button();
            this.mantenedorClienteBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salirBtn = new System.Windows.Forms.Button();
            this.containerForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.mantTipoHabitacionBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.mantHabitacionBtn);
            this.panel1.Controls.Add(this.mantenedorClienteBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            // 
            // mantTipoHabitacionBtn
            // 
            this.mantTipoHabitacionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantTipoHabitacionBtn.Location = new System.Drawing.Point(12, 314);
            this.mantTipoHabitacionBtn.Name = "mantTipoHabitacionBtn";
            this.mantTipoHabitacionBtn.Size = new System.Drawing.Size(120, 50);
            this.mantTipoHabitacionBtn.TabIndex = 2;
            this.mantTipoHabitacionBtn.Text = "Tipo Habitación";
            this.mantTipoHabitacionBtn.UseVisualStyleBackColor = true;
            this.mantTipoHabitacionBtn.Click += new System.EventHandler(this.mantTipoHabitacionBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Servicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 50);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Costa del Sol";
            // 
            // mantHabitacionBtn
            // 
            this.mantHabitacionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantHabitacionBtn.Location = new System.Drawing.Point(12, 202);
            this.mantHabitacionBtn.Name = "mantHabitacionBtn";
            this.mantHabitacionBtn.Size = new System.Drawing.Size(120, 50);
            this.mantHabitacionBtn.TabIndex = 2;
            this.mantHabitacionBtn.Text = "Habitaciones";
            this.mantHabitacionBtn.UseVisualStyleBackColor = true;
            this.mantHabitacionBtn.Click += new System.EventHandler(this.mantHabitacionBtn_Click);
            // 
            // mantenedorClienteBtn
            // 
            this.mantenedorClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenedorClienteBtn.Location = new System.Drawing.Point(12, 146);
            this.mantenedorClienteBtn.Name = "mantenedorClienteBtn";
            this.mantenedorClienteBtn.Size = new System.Drawing.Size(120, 50);
            this.mantenedorClienteBtn.TabIndex = 2;
            this.mantenedorClienteBtn.Text = "Clientes";
            this.mantenedorClienteBtn.UseVisualStyleBackColor = true;
            this.mantenedorClienteBtn.Click += new System.EventHandler(this.mantenedorClienteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.salirBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 50);
            this.panel2.TabIndex = 1;
            // 
            // salirBtn
            // 
            this.salirBtn.BackColor = System.Drawing.Color.Red;
            this.salirBtn.FlatAppearance.BorderSize = 0;
            this.salirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirBtn.ForeColor = System.Drawing.Color.White;
            this.salirBtn.Location = new System.Drawing.Point(558, 0);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(92, 50);
            this.salirBtn.TabIndex = 0;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = false;
            this.salirBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // containerForm
            // 
            this.containerForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.containerForm.Location = new System.Drawing.Point(150, 49);
            this.containerForm.Name = "containerForm";
            this.containerForm.Size = new System.Drawing.Size(650, 401);
            this.containerForm.TabIndex = 2;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mantHabitacionBtn;
        private System.Windows.Forms.Button mantenedorClienteBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mantTipoHabitacionBtn;
        private System.Windows.Forms.Panel containerForm;
        private System.Windows.Forms.Button salirBtn;
    }
}