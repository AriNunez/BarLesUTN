using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(password))
            {
                Usuario usuarioLogueado = Bar.LoginUsuario(usuario, password);
                if (usuarioLogueado is not null)
                {
                    FormMenuPrincipal frmMenuPrincipal = new FormMenuPrincipal(this,usuarioLogueado);
                    frmMenuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o password incorrectos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    SetValoresVacios();
                }
            }
        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SetValoresVacios()
        {
            txtUsuario.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnAutocompletarEmpleado_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "arielnunez";
            txtPassword.Text = "123123";
        }

        private void btnAutocompletarAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
