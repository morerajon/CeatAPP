using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CeatApp
{
    public partial class Menu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        public static void RedondearBordes(Control control, int radio)
        {
            control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radio, radio));
        }
        public Menu()
        {
            InitializeComponent();
            RedondearBordes(panel1, 20);
            RedondearBordes(pnlSecundario,30);
        }
        string path="C:\\CeatApp\\CeatApp\\Imagenes\\";

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            RedondearBordes(boton, 0);
            boton.ForeColor = Color.White;
            boton.Image = Image.FromFile(path + boton.Name + "A.png");
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;
            RedondearBordes(boton, 70);
            if (boton.Name != "btnCerrarSesion1") boton.ForeColor = Color.Cyan;
            boton.Image = Image.FromFile(path + boton.Name + "B.png");

        }
    }
}
