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
    public partial class Menu : Form
    {
        
        private Form formActivo = null;
        
        public Menu()
        {
            InitializeComponent();
            logica.RedondearBordes(panel1, 20);
            logica.RedondearBordes(pnlSecundario,30);
        }


        private void FormHijo(Form formhijo)
        {
            if (formActivo != null) formActivo.Close();
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(formhijo);
            pnlCentral.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }
        string path="C:\\CeatApp\\CeatApp\\Imagenes\\";

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // Cierra por completo la app
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            logica.RedondearBordes(boton, 0);
            boton.ForeColor = Color.White;
            boton.Image = Image.FromFile(path + boton.Name + "A.png");
            boton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;
            logica.RedondearBordes(boton, 70);
            if (boton.Name != "btnCerrarSesion1") boton.ForeColor = Color.Cyan;
            boton.Image = Image.FromFile(path + boton.Name + "B.png");
            boton.ImageAlign = ContentAlignment.MiddleCenter;

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormHijo(new Alumnos());
        }

       

        
    }
}
