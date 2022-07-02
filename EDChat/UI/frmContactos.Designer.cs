
namespace EDChat.UI
{
    partial class frmContactos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactos));
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.listViewContactos = new System.Windows.Forms.ListView();
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConexion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pboBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contactos";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1059, 584);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 67;
            this.lineShape2.X2 = 265;
            this.lineShape2.Y1 = 154;
            this.lineShape2.Y2 = 154;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 1059;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(68, 125);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 20);
            this.txtBuscar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtBuscar, "INGRESA NOMBRE");
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // listViewContactos
            // 
            this.listViewContactos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colApellido,
            this.colDni,
            this.colConexion});
            this.listViewContactos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewContactos.FullRowSelect = true;
            this.listViewContactos.GridLines = true;
            this.listViewContactos.HideSelection = false;
            this.listViewContactos.Location = new System.Drawing.Point(53, 182);
            this.listViewContactos.Name = "listViewContactos";
            this.listViewContactos.Size = new System.Drawing.Size(939, 352);
            this.listViewContactos.TabIndex = 5;
            this.listViewContactos.UseCompatibleStateImageBehavior = false;
            this.listViewContactos.View = System.Windows.Forms.View.Details;
            this.listViewContactos.SelectedIndexChanged += new System.EventHandler(this.listViewContactos_SelectedIndexChanged);
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 134;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 116;
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            this.colDni.Width = 120;
            // 
            // colConexion
            // 
            this.colConexion.Text = "Ultima conexion";
            this.colConexion.Width = 402;
            // 
            // pboBuscar
            // 
            this.pboBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pboBuscar.Image")));
            this.pboBuscar.Location = new System.Drawing.Point(273, 125);
            this.pboBuscar.Name = "pboBuscar";
            this.pboBuscar.Size = new System.Drawing.Size(36, 30);
            this.pboBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboBuscar.TabIndex = 6;
            this.pboBuscar.TabStop = false;
            this.pboBuscar.Click += new System.EventHandler(this.pboBuscar_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 584);
            this.Controls.Add(this.pboBuscar);
            this.Controls.Add(this.listViewContactos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContactos";
            this.Text = "frmContactos";
            ((System.ComponentModel.ISupportInitialize)(this.pboBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView listViewContactos;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pboBuscar;
        private System.Windows.Forms.ColumnHeader colConexion;
    }
}