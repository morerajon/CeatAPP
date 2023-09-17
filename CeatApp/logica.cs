using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CeatApp
{
    class logica
    {
        private static int vision = 0; // Suponiendo que 'vision' es para rastrear el estado de visibilidad

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
