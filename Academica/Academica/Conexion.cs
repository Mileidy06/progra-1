using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comando para trabjar con Bases de Datos.
using System.Data.SqlClient; //Esta libreria me permite trabajar con  SQL Server.


namespace Academica
{
    internal class Conexion {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection(); //conectarme a la Base de datos.
        SqlCommand objComando = new SqlCommand(); //Ejecutar  SQL en la BD, lectura, Actualizacion, eliminacion, insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); // un puente entre BD y la aplicacion 
        DataSet objDs = new DataSet(); // Es una representacion de la Arquitectura de la BD en memoria.

        public Conexion() { // constructor. inicializador de los atributos

            String cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
    }
}
