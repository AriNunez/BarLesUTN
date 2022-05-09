using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMenuPrincipal : Form
    {
        private FormLogin frmLogin;
        private FormMenuPrincipal()
        {
            InitializeComponent();
        }        
        public FormMenuPrincipal(FormLogin form):this()
        {
            if(form is not null)
            {
                frmLogin = form;
                frmLogin.SetValoresVacios();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que queres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                frmLogin.Show();
            }
        }
    }
}
