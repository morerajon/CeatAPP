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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
            BordesRedondeados.RedondearBordes(this, 40);
            BordesRedondeados.RedondearBordes(pnlUsuario, 40);
            BordesRedondeados.RedondearBordes(pBFoto,90);
            BordesRedondeados.RedondearBordes(pnlContacto, 40);
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {

        }

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
