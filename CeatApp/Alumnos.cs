using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CeatApp
{
    public partial class Alumnos : Form
    {
        //creamos una instancia de la clase para acceder a los métodos creados
        ConexionConBD claseConexion = new ConexionConBD();
        //creamos un objeto con la estructura de una tabla para recibir los datos
        DataTable Tabla = new DataTable();

        //int id;
        public Alumnos()
        {
            InitializeComponent();
            logica.RedondearBordes(this, 40);
           
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            Tabla.Clear();

            //ejecutamos el método Leer de la clase ConexionConBD y el objeto
            //DataTable asigna el resultado a su estructura

            Tabla.Load(claseConexion.Leer("SELECT Alumno_Nombres as Nombre,Alumno_Apellidos as Apellido, Alumno_Dni as DNI, Alumno_Nacimiento as Nacimiento, Alumno_Sexo as Sexo, Alumno_Nacionalidad as Nacionalidad, Alumno_AñoAdmision as Ingreso, Alumno_Seccion as Seccion, Alumno_FechaRetiro as Retiro, Alumno_CausaRetiro as Causa FROM Alumno "));

            //Asignamos el orígen de los datos de la grilla

            dgvAlumnos.DataSource = Tabla;

            //Cerramos la conexión. Siempre desconectamos al terminar!

            claseConexion.Desconectar();
        }
    //    private void dataElectro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    //    {
    //        if (e.RowIndex >= 0 && e.RowIndex < dataElectro.Rows.Count)
    //        {
    //            DataGridViewRow row = dataElectro.Rows[e.RowIndex];
    //            if (row.Cells["Id"].Value != null)
    //            {
    //                id = Convert.ToInt32(dataElectro.CurrentRow.Cells["ID"].Value.ToString());


    //                txtNombre.Text = dataElectro.Rows[e.RowIndex].Cells[1].Value.ToString();
    //                txtMarca.Text = dataElectro.Rows[e.RowIndex].Cells[2].Value.ToString();
    //                txtColor.Text = dataElectro.Rows[e.RowIndex].Cells[3].Value.ToString();
    //                txtStock.Text = dataElectro.Rows[e.RowIndex].Cells[4].Value.ToString();
    //                txtPrecio.Text = dataElectro.Rows[e.RowIndex].Cells[5].Value.ToString();

    //                int a = Convert.ToInt32(dataElectro.Rows[e.RowIndex].Cells[6].Value);
    //                bool valor = Convert.ToBoolean(a);
    //                ChBSi.Checked = valor;


    //                btnEliminar.Enabled = true;
    //                btnModificar.Enabled = true;
    //                btnAgregar.Enabled = false;

    //            }
    //        }
    //    }

    //    private void btnModificar_Click(object sender, EventArgs e)
    //    {
    //        DialogResult ModExitoso = MessageBox.Show("¿Está seguro de realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    //        // Llamamos al método y enviamos la consulta de actualización


    //        if (ModExitoso == DialogResult.Yes)
    //        {
    //            claseConexion.ABM("UPDATE Electrodomesticos SET nombre = '" + txtNombre.Text +
    //          "', marca = '" + txtMarca.Text +
    //          "', color = '" + txtColor.Text +
    //          "', stock = '" + txtStock.Text +
    //          "', precio = '" + txtPrecio.Text +
    //          "', conEnvio = '" + (ChBSi.Checked ? "-1" : "0") + "' WHERE id = " + id);
    //            MessageBox.Show("Se Modifico correctamente el registro", "Proceso finalizado");
    //            Form1_Load(null, null); // Llamamos al evento Load para la actualización de datos

    //        }
    //        else
    //        {
    //            MessageBox.Show(" la operación fue cancelada");

    //        }
    //        textboxClean();


    //        btnEliminar.Enabled = false;
    //        btnModificar.Enabled = false;
    //        btnAgregar.Enabled = true;
    //    }



    //    private void textboxClean()
    //    {
    //        txtPrecio.Clear();
    //        txtNombre.Clear();
    //        txtMarca.Clear();
    //        txtStock.Clear();
    //        txtColor.Clear();
    //        ChBSi.Checked = false;
    //    }

    //    private void btnEliminar_Click(object sender, EventArgs e)
    //    {
    //        DialogResult EliExitoso = MessageBox.Show("¿Está seguro de realizar la Eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    //        // Llamamos al método y enviamos la consulta de actualización


    //        if (EliExitoso == DialogResult.Yes)
    //        {

    //            claseConexion.ABM("DELETE FROM  Electrodomesticos WHERE ID  = " + id);
    //            MessageBox.Show("Se elimino correctamente el registro", "Proceso finalizado");
    //            Form1_Load(null, null); // Llamamos al evento Load para la actualización de datos

    //        }
    //        else
    //        {
    //            MessageBox.Show(" la operación fue cancelada");

    //        }
    //        textboxClean();


    //        btnEliminar.Enabled = false;
    //        btnModificar.Enabled = false;
    //        btnAgregar.Enabled = true;
    //    }
    }
}
