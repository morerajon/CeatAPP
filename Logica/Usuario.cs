﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Datos;


namespace Logica
{
     public class Usuario
    {
        Datos.Conexion conecta = new Datos.Conexion();
        public int IdUsuario;
        public string Nombre;
        public string Apellido;
        public string Permisos;

        //public bool TraeDatos(string usu, string pass)
        //{
        //    OleDbDataReader reader = conecta.Leer("SELECT * FROM Usuario where Usuario_Alias = '" + usu + "' and Usuario_Password = '" + pass + "'");
        //    if (reader.HasRows)
        //    {
        //        if (reader.HasRows)
        //        {
        //            //while (reader.Read())
        //            //{
        //            //    IdUsuario = reader.GetInt32(0);
        //            //    Nombre = reader.GetString(1);
        //            //    Apellido = reader.GetString(2);
        //            //    Permisos = reader.GetString(3);

        //            //}
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    //public bool funciona(){if (conecta.suma(2, 3) == 5){ return true; } else{return false;}}

        //}
    }
}
