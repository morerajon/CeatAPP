using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CeatApp
{
    class logica

    {
        private static int vision = 0; // Suponiendo que 'vision' es para rastrear el estado de visibilidad


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );


        public static void RedondearBordes(Control control, int radio)
        {
            control.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radio, radio));
        }
        public static void verOcultar(PictureBox pBMostrarOcultar, ImageList iLVerOculartar, TextBox txtpassword, EventArgs e)
        {
            if (vision == 0)
            {
                pBMostrarOcultar.Image = iLVerOculartar.Images[1];
                vision = vision + 1;
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                pBMostrarOcultar.Image = iLVerOculartar.Images[0];
                vision = 0;
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
