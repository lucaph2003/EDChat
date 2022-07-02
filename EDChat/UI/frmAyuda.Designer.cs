
namespace EDChat.UI
{
    partial class frmAyuda
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
            this.label2 = new System.Windows.Forms.Label();
            this.lkLblPregunta1 = new System.Windows.Forms.LinkLabel();
            this.lkLblPregunta2 = new System.Windows.Forms.LinkLabel();
            this.lkLblPregunta3 = new System.Windows.Forms.LinkLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ayuda y Soporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preguntas Frecuentes";
            // 
            // lkLblPregunta1
            // 
            this.lkLblPregunta1.AutoSize = true;
            this.lkLblPregunta1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLblPregunta1.Location = new System.Drawing.Point(136, 172);
            this.lkLblPregunta1.Name = "lkLblPregunta1";
            this.lkLblPregunta1.Size = new System.Drawing.Size(216, 21);
            this.lkLblPregunta1.TabIndex = 2;
            this.lkLblPregunta1.TabStop = true;
            this.lkLblPregunta1.Text = "¿Cómo envio un mensaje?";
            this.lkLblPregunta1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLblPregunta1_LinkClicked);
            // 
            // lkLblPregunta2
            // 
            this.lkLblPregunta2.AutoSize = true;
            this.lkLblPregunta2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLblPregunta2.Location = new System.Drawing.Point(136, 238);
            this.lkLblPregunta2.Name = "lkLblPregunta2";
            this.lkLblPregunta2.Size = new System.Drawing.Size(301, 21);
            this.lkLblPregunta2.TabIndex = 3;
            this.lkLblPregunta2.TabStop = true;
            this.lkLblPregunta2.Text = "¿Cómo cambio mis datos de usuario?";
            this.lkLblPregunta2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLblPregunta2_LinkClicked);
            // 
            // lkLblPregunta3
            // 
            this.lkLblPregunta3.AutoSize = true;
            this.lkLblPregunta3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLblPregunta3.Location = new System.Drawing.Point(136, 301);
            this.lkLblPregunta3.Name = "lkLblPregunta3";
            this.lkLblPregunta3.Size = new System.Drawing.Size(264, 21);
            this.lkLblPregunta3.TabIndex = 4;
            this.lkLblPregunta3.TabStop = true;
            this.lkLblPregunta3.Text = "¿Cómo cambio mi foto de perfil?";
            this.lkLblPregunta3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLblPregunta3_LinkClicked);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1075, 623);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 1059;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 623);
            this.Controls.Add(this.lkLblPregunta3);
            this.Controls.Add(this.lkLblPregunta2);
            this.Controls.Add(this.lkLblPregunta1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyuda";
            this.Opacity = 0.95D;
            this.Text = "Interfaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lkLblPregunta1;
        private System.Windows.Forms.LinkLabel lkLblPregunta2;
        private System.Windows.Forms.LinkLabel lkLblPregunta3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}