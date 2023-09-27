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
    public partial class Login : Form
    {
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        
        private void pBMostrarOcultar_Click(object sender, EventArgs e)
        {
            //logica.verOcultar(pBMostrarOcultar, iLVerOculartar, txtContrasenia, e);
            
        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextBox Txtbx= (TextBox)sender;
            
            if (Txtbx.Text==Txtbx.Tag.ToString())
            {
                if (Txtbx.Text == "Contraseña") Txtbx.PasswordChar = '*';
          
                Txtbx.ForeColor = Color.Black;
                Txtbx.Clear();
            }
        }

      
      

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if ( txtUsuario.Text== string.Empty)
            {
                txtUsuario.ForeColor = Color.Silver;
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == string.Empty)
            {
                txtContrasenia.ForeColor = Color.Silver;
                txtContrasenia.PasswordChar = '\0';
                txtContrasenia.Text = "Contraseña";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();

            this.Hide();// escondes esta ventana Login

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
        

       
        

       
    }
}
