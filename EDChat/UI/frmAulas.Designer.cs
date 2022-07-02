
namespace EDChat.UI
{
    partial class frmAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAulas));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.listChat = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pboEnviar = new System.Windows.Forms.PictureBox();
            this.pboActualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1043, 545);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 154;
            this.lineShape3.X2 = 709;
            this.lineShape3.Y1 = 452;
            this.lineShape3.Y2 = 452;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -4;
            this.lineShape2.X2 = 1059;
            this.lineShape2.Y1 = 57;
            this.lineShape2.Y2 = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aulas";
            // 
            // listChat
            // 
            this.listChat.BackColor = System.Drawing.Color.LightGray;
            this.listChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 21;
            this.listChat.Location = new System.Drawing.Point(155, 132);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(722, 294);
            this.listChat.TabIndex = 3;
            this.listChat.SelectedIndexChanged += new System.EventHandler(this.listMensajes_SelectedIndexChanged);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(155, 432);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(553, 20);
            this.txtMensaje.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(151, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(155, 21);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre de la sala:";
            // 
            // pboEnviar
            // 
            this.pboEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboEnviar.Image = ((System.Drawing.Image)(resources.GetObject("pboEnviar.Image")));
            this.pboEnviar.Location = new System.Drawing.Point(840, 432);
            this.pboEnviar.Name = "pboEnviar";
            this.pboEnviar.Size = new System.Drawing.Size(37, 33);
            this.pboEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEnviar.TabIndex = 10;
            this.pboEnviar.TabStop = false;
            this.pboEnviar.Click += new System.EventHandler(this.pboEnviar_Click);
            // 
            // pboActualizar
            // 
            this.pboActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pboActualizar.Image")));
            this.pboActualizar.Location = new System.Drawing.Point(852, 105);
            this.pboActualizar.Name = "pboActualizar";
            this.pboActualizar.Size = new System.Drawing.Size(25, 24);
            this.pboActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboActualizar.TabIndex = 11;
            this.pboActualizar.TabStop = false;
            this.pboActualizar.Click += new System.EventHandler(this.pboActualizar_Click);
            // 
            // frmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 545);
            this.Controls.Add(this.pboActualizar);
            this.Controls.Add(this.pboEnviar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.listChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAulas";
            ((System.ComponentModel.ISupportInitialize)(this.pboEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pboEnviar;
        private System.Windows.Forms.PictureBox pboActualizar;
    }
}