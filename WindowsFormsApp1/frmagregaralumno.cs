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
    public partial class frmagregaralumno : Form
    {
        public frmagregaralumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txnom.Text !="Nombre"  && txnum.Text != "Matricula")
                { 
            Alumno alum = new Alumno();
            alum.Nombre = txnom.Text;
            alum.Apellido = txape.Text;
            alum.Control = txnum.Text;
            alum.Carrera = txcare.Text;
            alum.Semestre = txsem.Text;
            alum.NoOficio = txtNoOficio.Text;
            alum.Programa = txtPrograma.Text;
            alum.Telefono = txtTelefono.Text;
            alum.Telefono2 = txtTelefono2.Text;
            alum.Correo = txtCorreo.Text;
            try
            {

                Control control = new Control();
                string respuesta = control.ctrlAlumno(alum);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alumno registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
            else { MessageBox.Show("Falta llenar Campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }

} 

        private void txnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
