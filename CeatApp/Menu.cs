﻿using System;
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
        string path = "C:\\CeatApp\\CeatApp\\Imagenes\\";
        
        public Menu()
        {
            InitializeComponent();
            BordesRedondeados.RedondearBordes(panel1, 20);
            BordesRedondeados.RedondearBordes(pnlSecundario, 20);
            
        }


        private void FormHijo(Form formhijo)
        {
            pnlSecundario.BackgroundImage = null;
            if (formActivo != null) formActivo.Close();
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            pnlSecundario.Controls.Add(formhijo);
            pnlSecundario.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }
        

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // Cierra por completo la app
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            BordesRedondeados.RedondearBordes(boton, 0);
            boton.ForeColor = Color.White;
            boton.Image = Image.FromFile(path + boton.Name + "A.png");
            boton.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;
            BordesRedondeados.RedondearBordes(boton, 70);
            if (boton.Name != "btnCerrarSesion1") boton.ForeColor = Color.Cyan;
            boton.Image = Image.FromFile(path + boton.Name + "B.png");
            boton.ImageAlign = ContentAlignment.MiddleCenter;

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormHijo(new Alumnos());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                
                if (form != this)
                {
                    form.Hide();
                }
            }
            pnlSecundario.BackgroundImage = Image.FromFile(path+"manosfondo.jpg");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FormHijo(new FormPerfil());
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            FormHijo(new FormMensajes());
        }

        private void btnClaves_Click(object sender, EventArgs e)
        {
            FormHijo(new FormSeguridad());
        }

        private void btnCerrarSesion1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

       

        
    }
}
