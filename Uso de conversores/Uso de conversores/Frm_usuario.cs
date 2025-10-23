using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_de_conversores
{
    public partial class Frm_usuario : Form
    {
        public Frm_usuario()

        {
            InitializeComponent();
        }

        Conexion_base_datos objConexion = new Conexion_base_datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.ObtenerDatos();
            objDt = objDs.Tables["Materia"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };

            grbUsuario.DataSource = objDt.DefaultView;
            mostrarDatos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el usuario " + txtUsuario.Text,
                "Eliminando Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosUsuario(  // 🔹 corregido
                    new String[] { idUsuario.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Nuevo")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                string[] materias = {
    idUsuario.Text,txtUsuario.Text,txtClave.Text,txtNombre.Text,txtDireccion.Text,txtTelefono.Text };
                String respuesta = objConexion.administrarDatosUsuarios(Usuario, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregar.Text = "Nuevo";
                    btnModificar.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnPrimerUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
            cboBuscar.SelectedIndex = 1;

        }
    }
}


