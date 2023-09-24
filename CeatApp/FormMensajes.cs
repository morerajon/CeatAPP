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
    public partial class FormMensajes : Form
    {
        public FormMensajes()
        {
            InitializeComponent();
            logica.RedondearBordes(this,40);
        }

        private void FormMensajes_Load(object sender, EventArgs e)
        {

        }
    }
}
