using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica
{
    public partial class Frmprincipal : Form
    {

        public Frmprincipal()
        {
            InitializeComponent();  
        }  


        private void alumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMateria objMateria = new FrmMateria();
            objMateria.MdiParent = this;
            objMateria.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
    