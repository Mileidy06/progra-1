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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion ObjConexion = new Conexion();
            DataSet objDs = new DataSet();
            DataTable ObjDt = new DataTable();

        public int posicion = 0;
        public string accion = "Nuevo";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
