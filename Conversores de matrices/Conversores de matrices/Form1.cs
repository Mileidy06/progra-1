using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores_de_matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e) {
            String[] m = new string[] { "5", "10", "15" };
            String[] serie = txtSerie.Text.Split(',');
            int suma = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                suma = suma + int.Parse(serie[i]);
            }
            lblSuma.Text = "suma: " + suma;
        }
        //lblSuma.Text = "suma: " + serie.Sum();
    }
}
