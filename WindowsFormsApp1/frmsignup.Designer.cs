namespace WindowsFormsApp1
{
    partial class frmsignup
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtconfirmcontraseña = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombre.Location = new System.Drawing.Point(51, 185);
            this.txtnombre.MaxLength = 45;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(246, 13);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Text = "PRIMER NOMBRE";
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtapellido.Location = new System.Drawing.Point(51, 231);
            this.txtapellido.MaxLength = 45;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(246, 13);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.Text = "APELLIDO";
            this.txtapellido.Enter += new System.EventHandler(this.txtapellido_Enter);
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(51, 277);
            this.txtemail.MaxLength = 45;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(246, 13);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "EMAIL";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.ForeColor = System.Drawing.Color.LightGray;
            this.btnregister.Location = new System.Drawing.Point(52, 427);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(244, 37);
            this.btnregister.TabIndex = 0;
            this.btnregister.Text = "Registrar";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtcontraseña.Location = new System.Drawing.Point(51, 323);
            this.txtcontraseña.MaxLength = 45;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(246, 13);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.Text = "PASSWORD";
            this.txtcontraseña.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontraseña.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // txtconfirmcontraseña
            // 
            this.txtconfirmcontraseña.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtconfirmcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconfirmcontraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtconfirmcontraseña.Location = new System.Drawing.Point(51, 369);
            this.txtconfirmcontraseña.MaxLength = 45;
            this.txtconfirmcontraseña.Name = "txtconfirmcontraseña";
            this.txtconfirmcontraseña.Size = new System.Drawing.Size(246, 13);
            this.txtconfirmcontraseña.TabIndex = 6;
            this.txtconfirmcontraseña.Text = "CONFIRMAR PASSWORD";
            this.txtconfirmcontraseña.Enter += new System.EventHandler(this.txtconfirmcontraseña_Enter);
            this.txtconfirmcontraseña.Leave += new System.EventHandler(this.txtconfirmcontraseña_Leave);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.ForeColor = System.Drawing.Color.DimGray;
            this.txtusername.Location = new System.Drawing.Point(51, 139);
            this.txtusername.MaxLength = 45;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(246, 13);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "USERNAME";
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.llave;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.LightGray;
            this.btnexit.Location = new System.Drawing.Point(335, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(19, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(357, 510);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 52;
            this.lineShape6.X2 = 296;
            this.lineShape6.Y1 = 391;
            this.lineShape6.Y2 = 391;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 51;
            this.lineShape5.X2 = 295;
            this.lineShape5.Y1 = 346;
            this.lineShape5.Y2 = 346;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 51;
            this.lineShape4.X2 = 295;
            this.lineShape4.Y1 = 298;
            this.lineShape4.Y2 = 298;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 51;
            this.lineShape3.X2 = 295;
            this.lineShape3.Y1 = 252;
            this.lineShape3.Y2 = 252;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 52;
            this.lineShape2.X2 = 296;
            this.lineShape2.Y1 = 207;
            this.lineShape2.Y2 = 207;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 52;
            this.lineShape1.X2 = 296;
            this.lineShape1.Y1 = 161;
            this.lineShape1.Y2 = 161;
            // 
            // frmsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(357, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtconfirmcontraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmsignup";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtconfirmcontraseña;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}