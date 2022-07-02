
namespace EDChat.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboImagen = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lnkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pboCerrar = new System.Windows.Forms.PictureBox();
            this.pboMinimizar = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pboImagen);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 335);
            this.panel1.TabIndex = 0;
            // 
            // pboImagen
            // 
            this.pboImagen.Image = ((System.Drawing.Image)(resources.GetObject("pboImagen.Image")));
            this.pboImagen.Location = new System.Drawing.Point(39, 18);
            this.pboImagen.Name = "pboImagen";
            this.pboImagen.Size = new System.Drawing.Size(270, 298);
            this.pboImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboImagen.TabIndex = 0;
            this.pboImagen.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(518, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(94, 24);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "ED Chat";
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 406;
            this.lineShape5.X2 = 725;
            this.lineShape5.Y1 = 110;
            this.lineShape5.Y2 = 110;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape5});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 406;
            this.lineShape2.X2 = 725;
            this.lineShape2.Y1 = 190;
            this.lineShape2.Y2 = 190;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.LightGray;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnIniciarSesion.Location = new System.Drawing.Point(500, 240);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(158, 41);
            this.btnIniciarSesion.TabIndex = 11;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(456, 299);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(148, 17);
            this.lblRegistro.TabIndex = 12;
            this.lblRegistro.Text = "¿No estás registrado?";
            // 
            // lnkRegistrarse
            // 
            this.lnkRegistrarse.AutoSize = true;
            this.lnkRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistrarse.Location = new System.Drawing.Point(614, 299);
            this.lnkRegistrarse.Name = "lnkRegistrarse";
            this.lnkRegistrarse.Size = new System.Drawing.Size(76, 17);
            this.lnkRegistrarse.TabIndex = 13;
            this.lnkRegistrarse.TabStop = true;
            this.lnkRegistrarse.Text = "Registrarse";
            this.lnkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistrarse_LinkClicked);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(406, 82);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(320, 20);
            this.txtDni.TabIndex = 14;
            this.txtDni.Text = "DNI";
            this.txtDni.Enter += new System.EventHandler(this.txtDni_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(406, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pboCerrar
            // 
            this.pboCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboCerrar.Image")));
            this.pboCerrar.Location = new System.Drawing.Point(752, 3);
            this.pboCerrar.Name = "pboCerrar";
            this.pboCerrar.Size = new System.Drawing.Size(25, 18);
            this.pboCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCerrar.TabIndex = 16;
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
            this.pboMinimizar.TabIndex = 17;
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
            this.lblSubTitulo.TabIndex = 18;
            this.lblSubTitulo.Text = "- Alumno -";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.pboMinimizar);
            this.Controls.Add(this.pboCerrar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lnkRegistrarse);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboImagen;
        private System.Windows.Forms.Label LblTitulo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.LinkLabel lnkRegistrarse;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pboCerrar;
        private System.Windows.Forms.PictureBox pboMinimizar;
        private System.Windows.Forms.Label lblSubTitulo;
    }
}