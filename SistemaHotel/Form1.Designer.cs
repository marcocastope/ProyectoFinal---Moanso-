
namespace SistemaHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloDelSistema = new System.Windows.Forms.Label();
            this.loginUsuarioLbl = new System.Windows.Forms.Label();
            this.loginContraseñaLbl = new System.Windows.Forms.Label();
            this.loginUsuarioTxt = new System.Windows.Forms.TextBox();
            this.loginContraseñaTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloDelSistema
            // 
            this.TituloDelSistema.AutoSize = true;
            this.TituloDelSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloDelSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TituloDelSistema.Location = new System.Drawing.Point(62, 105);
            this.TituloDelSistema.Name = "TituloDelSistema";
            this.TituloDelSistema.Size = new System.Drawing.Size(229, 39);
            this.TituloDelSistema.TabIndex = 0;
            this.TituloDelSistema.Text = "Sistema Hotel";
            // 
            // loginUsuarioLbl
            // 
            this.loginUsuarioLbl.AutoSize = true;
            this.loginUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsuarioLbl.Location = new System.Drawing.Point(478, 156);
            this.loginUsuarioLbl.Name = "loginUsuarioLbl";
            this.loginUsuarioLbl.Size = new System.Drawing.Size(57, 17);
            this.loginUsuarioLbl.TabIndex = 1;
            this.loginUsuarioLbl.Text = "Usuario";
            // 
            // loginContraseñaLbl
            // 
            this.loginContraseñaLbl.AutoSize = true;
            this.loginContraseñaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginContraseñaLbl.Location = new System.Drawing.Point(478, 215);
            this.loginContraseñaLbl.Name = "loginContraseñaLbl";
            this.loginContraseñaLbl.Size = new System.Drawing.Size(81, 17);
            this.loginContraseñaLbl.TabIndex = 1;
            this.loginContraseñaLbl.Text = "Contraseña";
            // 
            // loginUsuarioTxt
            // 
            this.loginUsuarioTxt.Location = new System.Drawing.Point(481, 176);
            this.loginUsuarioTxt.Name = "loginUsuarioTxt";
            this.loginUsuarioTxt.Size = new System.Drawing.Size(200, 20);
            this.loginUsuarioTxt.TabIndex = 2;
            // 
            // loginContraseñaTxt
            // 
            this.loginContraseñaTxt.Location = new System.Drawing.Point(481, 235);
            this.loginContraseñaTxt.Name = "loginContraseñaTxt";
            this.loginContraseñaTxt.Size = new System.Drawing.Size(200, 20);
            this.loginContraseñaTxt.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBtn.Location = new System.Drawing.Point(481, 276);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(200, 40);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Ingresar";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.TituloDelSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginContraseñaTxt);
            this.Controls.Add(this.loginUsuarioTxt);
            this.Controls.Add(this.loginContraseñaLbl);
            this.Controls.Add(this.loginUsuarioLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloDelSistema;
        private System.Windows.Forms.Label loginUsuarioLbl;
        private System.Windows.Forms.Label loginContraseñaLbl;
        private System.Windows.Forms.TextBox loginUsuarioTxt;
        private System.Windows.Forms.TextBox loginContraseñaTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

