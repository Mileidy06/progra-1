using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Uso_de_conversores
{
    internal class Conexion_base_datos
    {
        
        SqlConnection objConexion = new SqlConnection();
        SqlCommand objComando = new SqlCommand();
        SqlDataAdapter objAdaptador = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        public object ObjComando { get; private set; }

        public Conexion_base_datos()
        {
            String cadenaConexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory | \usuarios.mdf; Integrated Security = True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();
        }

        public DataSet ObtenerDatos()
        {
            objDs.Clear();
            objComando.Connection = objConexion;

            objAdaptador.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM Usuarios";
            objAdaptador.Fill(objDs, "Usuarios");

            return objDs;

        }


    }
}