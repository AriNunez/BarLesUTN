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
    public partial class FormMenuPrincipal : Form
    {
        private FormLogin frmLogin;
        private Dictionary<int,Button> listaBotones;
        private Dictionary<int,bool> disponibilidadMesas;
        private Usuario usuarioLogueado;

        private FormMenuPrincipal()
        {
            InitializeComponent();
            listaBotones = new Dictionary<int,Button>();
            RelacionarMesasYBotones();
        }        
        public FormMenuPrincipal(FormLogin form,Usuario usuarioLogueado):this()
        {
            if(form is not null)
            {
                frmLogin = form;
                frmLogin.SetValoresVacios();
            }
            this.usuarioLogueado = usuarioLogueado;
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

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            Button botonAux = (Button)sender;

            foreach (KeyValuePair<int, Button> item in listaBotones)
            {
                if(item.Value == botonAux)
                {
                    MessageBox.Show($"Mesa: {item.Key}");
                }

            }
        }

        private void RelacionarMesasYBotones()
        {
            listaBotones.Add(1,btnMesa1);
            listaBotones.Add(2,btnMesa2);
            listaBotones.Add(3,btnMesa3);
            listaBotones.Add(4,btnMesa4);
            listaBotones.Add(5,btnMesa5);
            listaBotones.Add(6,btnMesa6);
            listaBotones.Add(7,btnMesa7);
            listaBotones.Add(8,btnMesa8);
            listaBotones.Add(9,btnMesa9);
            listaBotones.Add(10,btnMesa10);
            listaBotones.Add(11,btnMesa11);
            listaBotones.Add(12,btnMesa12);
            listaBotones.Add(13,btnMesa13);
            listaBotones.Add(14,btnMesa14);
            listaBotones.Add(15,btnMesa15);
            listaBotones.Add(16,btnBarra16);
            listaBotones.Add(17,btnBarra17);
            listaBotones.Add(18,btnBarra18);
            listaBotones.Add(19,btnBarra19);
            listaBotones.Add(20,btnBarra20);


        }

        private void ObtenerDisponibilidadMesas()
        {
            disponibilidadMesas = Bar.EstadoMesas();

            foreach (KeyValuePair<int,bool> item in disponibilidadMesas)
            {
                if(item.Value == true)
                {
                    listaBotones[item.Key].BackColor = Color.Red;
                }
                else
                {
                    listaBotones[item.Key].BackColor = Color.LightGreen;
                }
            }
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            SetBienvenidoUsuario();
            ObtenerDisponibilidadMesas();
            
            if(usuarioLogueado is not null)
            {
                btnEmpleados.Visible = usuarioLogueado.EsAdmin;
                btnSinAsignar.Visible = usuarioLogueado.EsAdmin;

                if(usuarioLogueado.EsAdmin)
                {
                    pnlOpciones.BackColor = Color.Goldenrod;
                }
                else
                {
                    pnlOpciones.BackColor = Color.DodgerBlue;
                }
            }

        }

        private void SetBienvenidoUsuario()
        {
            lblUsuarioLogueado.Text = String.Empty;
            lblUsuarioLogueado.Text = $"Bienvenido {usuarioLogueado.Nombre}...";
        }

    }
}
