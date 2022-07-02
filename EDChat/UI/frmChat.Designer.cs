
namespace EDChat
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.LstChat = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LstContactos = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pboBuscar = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pboEnviar = new System.Windows.Forms.PictureBox();
            this.pboActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // LstChat
            // 
            this.LstChat.BackColor = System.Drawing.Color.LightGray;
            this.LstChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstChat.ForeColor = System.Drawing.Color.Black;
            this.LstChat.FormattingEnabled = true;
            this.LstChat.ItemHeight = 21;
            this.LstChat.Location = new System.Drawing.Point(639, 65);
            this.LstChat.Name = "LstChat";
            this.LstChat.Size = new System.Drawing.Size(331, 420);
            this.LstChat.TabIndex = 0;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(640, 505);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(226, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1059, 584);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 80;
            this.lineShape4.X2 = 306;
            this.lineShape4.Y1 = 140;
            this.lineShape4.Y2 = 140;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -4;
            this.lineShape3.X2 = 546;
            this.lineShape3.Y1 = 57;
            this.lineShape3.Y2 = 57;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 546;
            this.lineShape2.X2 = 546;
            this.lineShape2.Y1 = 1;
            this.lineShape2.Y2 = 584;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 639;
            this.lineShape1.X2 = 865;
            this.lineShape1.Y1 = 528;
            this.lineShape1.Y2 = 528;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 33);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Chats";
            // 
            // LstContactos
            // 
            this.LstContactos.BackColor = System.Drawing.Color.LightGray;
            this.LstContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstContactos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstContactos.FormattingEnabled = true;
            this.LstContactos.ItemHeight = 21;
            this.LstContactos.Location = new System.Drawing.Point(47, 159);
            this.LstContactos.Name = "LstContactos";
            this.LstContactos.Size = new System.Drawing.Size(409, 399);
            this.LstContactos.TabIndex = 5;
            this.LstContactos.SelectedIndexChanged += new System.EventHandler(this.LstContactos_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(635, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 21);
            this.lblNombre.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(82, 116);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // pboBuscar
            // 
            this.pboBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pboBuscar.Image")));
            this.pboBuscar.Location = new System.Drawing.Point(327, 111);
            this.pboBuscar.Name = "pboBuscar";
            this.pboBuscar.Size = new System.Drawing.Size(40, 27);
            this.pboBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboBuscar.TabIndex = 8;
            this.pboBuscar.TabStop = false;
            this.pboBuscar.Click += new System.EventHandler(this.pboBuscar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(635, 41);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblNombreUsuario.TabIndex = 9;
            // 
            // pboEnviar
            // 
            this.pboEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboEnviar.Image = ((System.Drawing.Image)(resources.GetObject("pboEnviar.Image")));
            this.pboEnviar.Location = new System.Drawing.Point(922, 500);
            this.pboEnviar.Name = "pboEnviar";
            this.pboEnviar.Size = new System.Drawing.Size(36, 29);
            this.pboEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEnviar.TabIndex = 10;
            this.pboEnviar.TabStop = false;
            this.pboEnviar.Click += new System.EventHandler(this.pboEnviar_Click);
            // 
            // pboActualizar
            // 
            this.pboActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pboActualizar.Image")));
            this.pboActualizar.Location = new System.Drawing.Point(938, 41);
            this.pboActualizar.Name = "pboActualizar";
            this.pboActualizar.Size = new System.Drawing.Size(32, 21);
            this.pboActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboActualizar.TabIndex = 11;
            this.pboActualizar.TabStop = false;
            this.pboActualizar.Click += new System.EventHandler(this.pboActualizar_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 584);
            this.Controls.Add(this.pboActualizar);
            this.Controls.Add(this.pboEnviar);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pboBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.LstContactos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.LstChat);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChat";
            this.Text = "frmChat";
            this.Load += new System.EventHandler(this.frmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstChat;
        private System.Windows.Forms.TextBox txtMensaje;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox LstContactos;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pboBuscar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pboEnviar;
        private System.Windows.Forms.PictureBox pboActualizar;
    }
}