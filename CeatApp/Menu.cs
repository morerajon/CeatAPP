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
        public Menu()
        {
            InitializeComponent();
        }
        string path="C:\\CeatApp\\CeatApp\\Imagenes\\";
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.White;
            boton.Image = Image.FromFile(path + boton.Name + "A.png");
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.ForeColor = Color.Cyan;
            boton.Image = Image.FromFile(path + boton.Name + "B.png");

        }
    }
}
