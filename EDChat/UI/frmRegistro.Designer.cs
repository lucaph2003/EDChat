
namespace EDChat.UI
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboEdchat = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lnkIniciarSesion = new System.Windows.Forms.LinkLabel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.pboCerrar = new System.Windows.Forms.PictureBox();
            this.pboMinimizar = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEdchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pboEdchat);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 335);
            this.panel1.TabIndex = 0;
            // 
            // pboEdchat
            // 
            this.pboEdchat.Image = ((System.Drawing.Image)(resources.GetObject("pboEdchat.Image")));
            this.pboEdchat.Location = new System.Drawing.Point(39, 18);
            this.pboEdchat.Name = "pboEdchat";
            this.pboEdchat.Size = new System.Drawing.Size(270, 298);
            this.pboEdchat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEdchat.TabIndex = 0;
            this.pboEdchat.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(518, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(94, 24);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "ED Chat";
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto1.Location = new System.Drawing.Point(456, 299);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(145, 17);
            this.lblTexto1.TabIndex = 2;
            this.lblTexto1.Text = "¿Ya estás registrado?";
            // 
            // lnkIniciarSesion
            // 
            this.lnkIniciarSesion.AutoSize = true;
            this.lnkIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIniciarSesion.Location = new System.Drawing.Point(620, 300);
            this.lnkIniciarSesion.Name = "lnkIniciarSesion";
            this.lnkIniciarSesion.Size = new System.Drawing.Size(89, 17);
            this.lnkIniciarSesion.TabIndex = 3;
            this.lnkIniciarSesion.TabStop = true;
            this.lnkIniciarSesion.Text = "Iniciar Sesión";
            this.lnkIniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIniciarSesion_LinkClicked);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnRegistrar.Location = new System.Drawing.Point(500, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(158, 41);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 406;
            this.lineShape5.X2 = 725;
            this.lineShape5.Y1 = 70;
            this.lineShape5.Y2 = 70;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 406;
            this.lineShape4.X2 = 725;
            this.lineShape4.Y1 = 110;
            this.lineShape4.Y2 = 110;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 406;
            this.lineShape3.X2 = 725;
            this.lineShape3.Y1 = 150;
            this.lineShape3.Y2 = 150;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 406;
            this.lineShape2.X2 = 725;
            this.lineShape2.Y1 = 190;
            this.lineShape2.Y2 = 190;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 406;
            this.lineShape1.X2 = 725;
            this.lineShape1.Y1 = 230;
            this.lineShape1.Y2 = 230;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(406, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(320, 20);
            this.txtDni.TabIndex = 6;
            this.txtDni.Text = "DNI";
            this.txtDni.Enter += new System.EventHandler(this.txtDni_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(406, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(406, 124);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(320, 20);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(406, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(406, 204);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(320, 20);
            this.txtConPassword.TabIndex = 10;
            this.txtConPassword.Text = "Confirmar Contraseña";
            this.txtConPassword.TextChanged += new System.EventHandler(this.txtConPassword_TextChanged);
            this.txtConPassword.Enter += new System.EventHandler(this.txtConPassword_Enter);
            this.txtConPassword.Leave += new System.EventHandler(this.txtConPassword_Leave);
            // 
            // pboCerrar
            // 
            this.pboCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboCerrar.Image")));
            this.pboCerrar.Location = new System.Drawing.Point(752, 3);
            this.pboCerrar.Name = "pboCerrar";
            this.pboCerrar.Size = new System.Drawing.Size(25, 18);
            this.pboCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCerrar.TabIndex = 11;
            this.pboCerrar.TabStop = false;
            this.pboCerrar.Click += new System.EventHandler(this.pboCerrar_Click);
            // 
            // pboMinimizar
            // 
            this.pboMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pboMinimizar.Image")));
            this.pboMinimizar.Location = new System.Drawing.Point(725, 3);
            this.pboMinimizar.Name = "pboMinimizar";
            this.pboMinimizar.Size = new System.Drawing.Size(25, 18);
            this.pboMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboMinimizar.TabIndex = 12;
            this.pboMinimizar.TabStop = false;
            this.pboMinimizar.Click += new System.EventHandler(this.pboMinimizar_Click);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(532, 33);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(50, 13);
            this.lblSubTitulo.TabIndex = 13;
            this.lblSubTitulo.Text = "- Alumno -";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.pboMinimizar);
            this.Controls.Add(this.pboCerrar);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lnkIniciarSesion);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboEdchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboEdchat;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.LinkLabel lnkIniciarSesion;
        private System.Windows.Forms.Button btnRegistrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.PictureBox pboCerrar;
        private System.Windows.Forms.PictureBox pboMinimizar;
        private System.Windows.Forms.Label lblSubTitulo;
    }
}

