using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == txtconfirmcontraseña.Text && txtcontraseña.Text!="PASSWORD")
            {
                Usuarios usuario = new Usuarios();
                usuario.Usuario = txtusername.Text;
                usuario.Password = txtcontraseña.Text;
                string ConPassword = txtconfirmcontraseña.Text;
                usuario.Nombre = txtnombre.Text;
                usuario.Apellido = txtapellido.Text;
                usuario.Email = txtemail.Text;

                try
                {

                    Control control = new Control();
                    string respuesta = control.ctrlRegistro(usuario);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                frmlogin frm2 = new frmlogin();
                frm2.Visible = true;
                this.Visible = false;
            }
            else { MessageBox.Show("La Contraseña no coincide", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
    }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "PASSWORD")
            {
                txtcontraseña.Text = "";
            }
            txtcontraseña.ForeColor = Color.LightGray;
            txtcontraseña.UseSystemPasswordChar = true;
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "PASSWORD";
            }
            txtcontraseña.ForeColor = Color.DimGray;
            txtcontraseña.UseSystemPasswordChar = true;
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "USERNAME")
            {
                txtusername.Text = "";
            }
            txtusername.ForeColor = Color.LightGray;
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "USERNAME";
            }
            txtusername.ForeColor = Color.DimGray;
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "PRIMER NOMBRE")
            {
                txtnombre.Text = "";
            }
            txtnombre.ForeColor = Color.LightGray;
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "PRIMER NOMBRE";
            }
            txtnombre.ForeColor = Color.DimGray;
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "APELLIDO")
            {
                txtapellido.Text = "";
            }
            txtapellido.ForeColor = Color.LightGray;
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "APELLIDO";
            }
            txtapellido.ForeColor = Color.DimGray;
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "EMAIL")
            {
                txtemail.Text = "";
            }
            txtemail.ForeColor = Color.LightGray;
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "EMAIL";
            }
            txtemail.ForeColor = Color.DimGray;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtconfirmcontraseña.Text == "CONFIRMAR PASSWORD")
            {
                txtconfirmcontraseña.Text = "";
            }
            txtconfirmcontraseña.ForeColor = Color.LightGray;
            txtconfirmcontraseña.UseSystemPasswordChar = true;
        }

        private void txtconfirmcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtconfirmcontraseña.Text == "")
            {
                txtconfirmcontraseña.Text = "CONFIRMAR PASSWORD";
            }
            txtconfirmcontraseña.ForeColor = Color.DimGray;
            txtconfirmcontraseña.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frm2 = new frmlogin();
            frm2.Visible = true;
            this.Visible = false;
        }
    }
}
