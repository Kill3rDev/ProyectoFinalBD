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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagregaralumno cc = new frmagregaralumno();
            cc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTabla tabla = new frmTabla();
            tabla.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTablaReporte repo = new frmTablaReporte();
            repo.Show();

        }
    }
}
