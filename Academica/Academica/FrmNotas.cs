using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }
        Conexion objconexion = new Conexion();
        DataSet objNotas = new DataSet();
        private object periodosTableAdapter;
        private object materiaTableAdapter;
        private object db_academicaDataSet1;

        private void actualizarDs()
        {
            int idMateria = int.Parse(cboMateria.SelectedValue?.ToString() ?? "1");
            int idPeriodo = int.Parse(cboPeriodo.SelectedValue?.ToString() ?? "1");

            objNotas.Clear(); //Limpiar el DataSet

            objconexion.objAdaptador = new SqlDataAdapter("SELECT alumnos.nombre, dnotas.idDetalle, dnotas.idNota, dnotas.idMateria, " +
                 "dnotas.lab1, dnotas.lab2, dnotas.parcial, (dnotas.lab1*0.3 + dnotas.lab2*0.3 + dnotas.parcial*0.4) AS nf " +
                 "FROM dnotas INNER JOIN notas ON(notas.idNota=dnotas.idNota) INNER JOIN alumnos ON(alumnos.idAlumno=notas.idAlumno) " +
                 "WHERE notas.idPeriodo=" + idPeriodo + " AND dnotas.idMateria=" + idMateria, objconexion.objconexion);
            objconexion.objAdaptador.Fill(objNotas, "notasAlumnos");

        }
        private void actualizarGrid()
        {
            actualizarDs();
            dnotasDataGridView.DataSource = objNotas;
            dnotasDataGridView.DataMember = "notasAlumnos";
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet1.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicaDataSet1.periodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet1.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter.Fill(this.db_academicaDataSet1.Materia);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet1.dnotas' Puede moverla o quitarla según sea necesario.
            this.dnotasTableAdapter.Fill(this.db_academicaDataSet1.dnotas);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet1.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.db_academicaDataSet1.notas);


            actualizarGrid();

        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int nFilas = dnotasDataGridView.Rows.Count;
            for (int i = 0; i < nFilas; i++)
            {
                double lab1 = 0, lab2 = 0, parcial = 0;
                int idDetalle = int.Parse(dnotasDataGridView.Rows[i].Cells["idDetalle"]?.Value?.ToString() ?? "0");

                lab1 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab1"]?.Value?.ToString() ?? "0");
                lab2 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab2"]?.Value?.ToString() ?? "0");
                parcial = double.Parse(dnotasDataGridView.Rows[i].Cells["parcial"]?.Value?.ToString() ?? "0");

                string sql = "UPDATE dnotas SET lab1='" + lab1 + "', lab2='" + lab2 + "', parcial='" + parcial +
                    "' WHERE idDetalle='" + idDetalle + "'";
                String resp = objconexion.ejecutarSQL(sql);
                if (resp != "1")
                {
                    MessageBox.Show(resp, "Error al actualizar notas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarGrid();
            }
        }
    }
}

   