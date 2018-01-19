using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMPrueba
{
    public partial class Login : Form
    {
        String pw = null;
        String usu;
        Boolean fu = false, fc = false;
        public Login()
        {
            InitializeComponent();
        }
        
        private void cambioIniC(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbContrasena.Text))
            {
                errorIniC.Text = "Ingrese contraseña.";
                fc = true;
            }
            else
            {
                fc = false;
                errorIniC.Text = null;
            }
        }

        private void cambioUsu(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbUsuario.Text))
            {
                errorIniU.Text = "Ingrese usuario.";
                fu = true;
            }
            else
            {
                fu = false;
                errorIniU.Text = null;
            }
        }

        private void iniciarSesion(object sender, EventArgs e)
        {
            usu = txtbUsuario.Text;
            pw = txtbContrasena.Text;
            //verificarCampos();
            if(!fu && !fc) {

                this.Hide();
                Menu menu = new ABMPrueba.Menu();
                
                //parece que solo se abre con Show Dialog.
                menu.ShowDialog();

                this.Close();

            }
        }

        private void verificarCampos()
        {
            if (String.IsNullOrEmpty(usu))
            {
                errorIniU.Text = "Ingrese usuario.";
                fu = true;
            }
            if (String.IsNullOrEmpty(pw))
            {
                errorIniC.Text = "Ingrese contraseña.";
                fc = true;
            }
        }
    }
}
