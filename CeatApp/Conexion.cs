using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Datos
{
     public class Conexion
    {
            //creamos los objetos y variables a nivel clase
            static private OleDbConnection Conecta;
            static private OleDbCommand Orden;
            //Indicamos el nombre de la base de datos dentro de cadena de conexion
            static string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; " +
            "Data Source = C:\\CeatApp\\CeatApp\\bin\\Debug\\ceat.mdb;";

            //método para leer datos de Access
            public OleDbDataReader Leer(string Consulta)
            {
                //creamos la conexión con la base de datos
                Conecta = new OleDbConnection(strConexion);
                //establecemos la consulta dentro de la conexión
                Orden = new OleDbCommand(Consulta, Conecta);
                try
                {
                    Conecta.Open();//abrimos la conexion

                    //ejecutamos la consulta y retornamos el resultado de tipo OleDbDataReader

                    return Orden.ExecuteReader();
                }
                catch
                {
                    //ante cualquier error en la conexión, se devuelve un valor nulo al DataTable (Tabla)

                    OleDbDataReader error = null;

                    return error;

                }
            }

            public void Desconectar()
            {
                if (Conecta.State == ConnectionState.Open)
                    Conecta.Close();
            }

            public bool ABM(string Consulta)
            {
                //variable de control
                bool Resultado = false;
                //creamos la conexión con la base de datos
                Conecta = new OleDbConnection(strConexion);
                //establecemos la consulta dentro de la conexión
                Orden = new OleDbCommand(Consulta, Conecta);
                try
                {
                    Conecta.Open();//abrimos la conexion
                    //ejecutamos la consulta
                    Orden.ExecuteNonQuery();

                    //indicamos que todo se realizó de forma correcta

                    Resultado = true;

                }
                catch
                {
                    //caso contrario, indicamos que hubo un error
                    Resultado = false;
                }
                Desconectar();//deconectamos
                //devolvemos el valor asignado en la variable de control
                return Resultado;



        }
    }
}
