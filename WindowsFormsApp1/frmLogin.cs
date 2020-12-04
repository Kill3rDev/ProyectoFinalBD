using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Iconos diseñados por <a href="https://www.flaticon.es/autores/google" title="Google">Google</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>
namespace WindowsFormsApp1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "USUARIO")
            {
                txtusername.Text = "";
            }
            txtusername.ForeColor = Color.LightGray;
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "USUARIO";
            }
            txtusername.ForeColor = Color.DimGray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PASSWORD")
            {
                txtpassword.Text = "";
            }
            txtpassword.ForeColor = Color.LightGray;
            txtpassword.UseSystemPasswordChar = true;
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "PASSWORD";
            }
            txtpassword.ForeColor = Color.DimGray;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string pass = txtpassword.Text;
            string user = txtusername.Text;

            try
            {
                Control ctrl = new Control();
                string respuesta = ctrl.ctrlLogin(user,pass);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMenu frm = new frmMenu();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup frm1 = new frmsignup();
            frm1.Visible = true;
            this.Visible = false;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
