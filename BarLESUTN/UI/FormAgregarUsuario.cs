using Entidades;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormAgregarUsuario : Form
    {
        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim().ToUpper();
            string apellido = txtApellido.Text.Trim().ToUpper();
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool esAdmin = chkEsAdmin.Checked;

            if (!String.IsNullOrEmpty(txtDni.Text) && int.TryParse(txtDni.Text, out int dni))
            {
                if (Bar.CrearUsuario(nombre, apellido, dni, usuario, password, esAdmin))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No fue posible crear un nuevo usuario. Compruebe los datos a ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No fue posible crear un nuevo usuario. Compruebe los datos a ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
