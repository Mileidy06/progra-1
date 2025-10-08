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
    public partial class FrmPeriodo : Form
    {
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void periodosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.periodosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dboalumnosDataSet);

        }

        private void FrmPeriodo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dboalumnosDataSet.Periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.dboalumnosDataSet.Periodos);

        }
    }
}
