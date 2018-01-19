using System;

namespace ABMPrueba
{
    partial class Login
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
            this.botonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbContrasena = new System.Windows.Forms.TextBox();
            this.errorIniU = new System.Windows.Forms.Label();
            this.errorIniC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(86, 235);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(220, 50);
            this.botonLogin.TabIndex = 0;
            this.botonLogin.Text = "Iniciar sesión";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.iniciarSesion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(68, 73);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(249, 20);
            this.txtbUsuario.TabIndex = 3;
            this.txtbUsuario.TextChanged += new System.EventHandler(this.cambioUsu);
            // 
            // txtbContrasena
            // 
            this.txtbContrasena.Location = new System.Drawing.Point(68, 174);
            this.txtbContrasena.Name = "txtbContrasena";
            this.txtbContrasena.Size = new System.Drawing.Size(249, 20);
            this.txtbContrasena.TabIndex = 4;
            this.txtbContrasena.TextChanged += new System.EventHandler(this.cambioIniC);
            // 
            // errorIniU
            // 
            this.errorIniU.AutoSize = true;
            this.errorIniU.ForeColor = System.Drawing.Color.Red;
            this.errorIniU.Location = new System.Drawing.Point(171, 96);
            this.errorIniU.Name = "errorIniU";
            this.errorIniU.Size = new System.Drawing.Size(0, 13);
            this.errorIniU.TabIndex = 5;
            // 
            // errorIniC
            // 
            this.errorIniC.AutoSize = true;
            this.errorIniC.ForeColor = System.Drawing.Color.Red;
            this.errorIniC.Location = new System.Drawing.Point(171, 197);
            this.errorIniC.Name = "errorIniC";
            this.errorIniC.Size = new System.Drawing.Size(0, 13);
            this.errorIniC.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 336);
            this.Controls.Add(this.errorIniC);
            this.Controls.Add(this.errorIniU);
            this.Controls.Add(this.txtbContrasena);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.TextBox txtbContrasena;
        private System.Windows.Forms.Label errorIniU;
        private System.Windows.Forms.Label errorIniC;
    }
}


