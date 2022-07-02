
namespace EDChat.UI
{
    partial class frmChats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChats));
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.listChat = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.listContactos = new System.Windows.Forms.ListBox();
            this.pboEnviar = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pboBuscar = new System.Windows.Forms.PictureBox();
            this.pboActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chats";
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
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 80;
            this.lineShape4.X2 = 306;
            this.lineShape4.Y1 = 139;
            this.lineShape4.Y2 = 139;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 655;
            this.lineShape3.X2 = 881;
            this.lineShape3.Y1 = 520;
            this.lineShape3.Y2 = 520;
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
            this.lineShape1.X1 = -4;
            this.lineShape1.X2 = 546;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // listChat
            // 
            this.listChat.BackColor = System.Drawing.Color.LightGray;
            this.listChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listChat.Enabled = false;
            this.listChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChat.ForeColor = System.Drawing.Color.Black;
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 21;
            this.listChat.Location = new System.Drawing.Point(638, 95);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(331, 378);
            this.listChat.TabIndex = 2;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(658, 500);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(228, 20);
            this.txtMensaje.TabIndex = 3;
            // 
            // listContactos
            // 
            this.listContactos.BackColor = System.Drawing.Color.LightGray;
            this.listContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listContactos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContactos.FormattingEnabled = true;
            this.listContactos.ItemHeight = 21;
            this.listContactos.Location = new System.Drawing.Point(61, 156);
            this.listContactos.Name = "listContactos";
            this.listContactos.Size = new System.Drawing.Size(408, 399);
            this.listContactos.TabIndex = 5;
            this.listContactos.SelectedIndexChanged += new System.EventHandler(this.LstContactos_SelectedIndexChanged);
            // 
            // pboEnviar
            // 
            this.pboEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboEnviar.Image = ((System.Drawing.Image)(resources.GetObject("pboEnviar.Image")));
            this.pboEnviar.Location = new System.Drawing.Point(928, 498);
            this.pboEnviar.Name = "pboEnviar";
            this.pboEnviar.Size = new System.Drawing.Size(41, 31);
            this.pboEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEnviar.TabIndex = 7;
            this.pboEnviar.TabStop = false;
            this.pboEnviar.Click += new System.EventHandler(this.pboEnviar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(635, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 21);
            this.lblNombre.TabIndex = 8;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(82, 118);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // pboBuscar
            // 
            this.pboBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pboBuscar.Image")));
            this.pboBuscar.Location = new System.Drawing.Point(341, 108);
            this.pboBuscar.Name = "pboBuscar";
            this.pboBuscar.Size = new System.Drawing.Size(41, 31);
            this.pboBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboBuscar.TabIndex = 10;
            this.pboBuscar.TabStop = false;
            this.pboBuscar.Click += new System.EventHandler(this.pboBuscar_Click);
            // 
            // pboActualizar
            // 
            this.pboActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pboActualizar.Image")));
            this.pboActualizar.Location = new System.Drawing.Point(928, 58);
            this.pboActualizar.Name = "pboActualizar";
            this.pboActualizar.Size = new System.Drawing.Size(41, 31);
            this.pboActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboActualizar.TabIndex = 11;
            this.pboActualizar.TabStop = false;
            this.pboActualizar.Click += new System.EventHandler(this.pboActualizar_Click);
            // 
            // frmChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 584);
            this.Controls.Add(this.pboActualizar);
            this.Controls.Add(this.pboBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pboEnviar);
            this.Controls.Add(this.listContactos);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.listChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChats";
            this.Text = "frmChats";
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ListBox listContactos;
        private System.Windows.Forms.PictureBox pboEnviar;
        private System.Windows.Forms.Label lblNombre;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pboBuscar;
        private System.Windows.Forms.PictureBox pboActualizar;
    }
}