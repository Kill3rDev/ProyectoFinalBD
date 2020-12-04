
namespace WindowsFormsApp1
{
    partial class frmagregaralumno
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
            this.txnom = new System.Windows.Forms.TextBox();
            this.txcare = new System.Windows.Forms.TextBox();
            this.txnum = new System.Windows.Forms.TextBox();
            this.txape = new System.Windows.Forms.TextBox();
            this.txsem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtNoOficio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txnom
            // 
            this.txnom.Location = new System.Drawing.Point(16, 13);
            this.txnom.Name = "txnom";
            this.txnom.Size = new System.Drawing.Size(272, 20);
            this.txnom.TabIndex = 0;
            this.txnom.Text = "Nombre";
            this.txnom.TextChanged += new System.EventHandler(this.txnom_TextChanged);
            // 
            // txcare
            // 
            this.txcare.Location = new System.Drawing.Point(16, 126);
            this.txcare.Name = "txcare";
            this.txcare.Size = new System.Drawing.Size(272, 20);
            this.txcare.TabIndex = 1;
            this.txcare.Text = "Carrera";
            // 
            // txnum
            // 
            this.txnum.Location = new System.Drawing.Point(16, 91);
            this.txnum.Name = "txnum";
            this.txnum.Size = new System.Drawing.Size(272, 20);
            this.txnum.TabIndex = 2;
            this.txnum.Text = "Matricula";
            this.txnum.TextChanged += new System.EventHandler(this.txnum_TextChanged);
            // 
            // txape
            // 
            this.txape.Location = new System.Drawing.Point(16, 54);
            this.txape.Name = "txape";
            this.txape.Size = new System.Drawing.Size(272, 20);
            this.txape.TabIndex = 4;
            this.txape.Text = "Apellidos";
            // 
            // txsem
            // 
            this.txsem.Location = new System.Drawing.Point(16, 162);
            this.txsem.Name = "txsem";
            this.txsem.Size = new System.Drawing.Size(272, 20);
            this.txsem.TabIndex = 5;
            this.txsem.Text = "Semestre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrograma
            // 
            this.txtPrograma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrograma.Location = new System.Drawing.Point(315, 13);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(272, 20);
            this.txtPrograma.TabIndex = 7;
            this.txtPrograma.Text = "Programa";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(315, 48);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Text = "Telefono*";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(315, 86);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(272, 20);
            this.txtTelefono2.TabIndex = 9;
            this.txtTelefono2.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(315, 122);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 20);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(315, 162);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(272, 20);
            this.txtHoras.TabIndex = 11;
            this.txtHoras.Text = "Horas por dia";
            // 
            // txtNoOficio
            // 
            this.txtNoOficio.Location = new System.Drawing.Point(16, 198);
            this.txtNoOficio.Name = "txtNoOficio";
            this.txtNoOficio.Size = new System.Drawing.Size(272, 20);
            this.txtNoOficio.TabIndex = 12;
            this.txtNoOficio.Text = "No Oficio";
            this.txtNoOficio.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // frmagregaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 248);
            this.Controls.Add(this.txtNoOficio);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txsem);
            this.Controls.Add(this.txape);
            this.Controls.Add(this.txnum);
            this.Controls.Add(this.txcare);
            this.Controls.Add(this.txnom);
            this.Name = "frmagregaralumno";
            this.Text = "Agregar alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txnom;
        private System.Windows.Forms.TextBox txcare;
        private System.Windows.Forms.TextBox txnum;
        private System.Windows.Forms.TextBox txape;
        private System.Windows.Forms.TextBox txsem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtNoOficio;
    }
}