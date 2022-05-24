using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormEmpleados : Form
    {
        private Usuario usuarioLogueado;
        private FormEmpleados()
        {
            InitializeComponent();
        }

        public FormEmpleados(Usuario usuarioLogueado) : this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            ActualizarDatosDeTabla();
        }
        private void ActualizarDatosDeTabla()
        {
            dtgvEmpleados.Rows.Clear();
            List<Usuario> listaUsuarios = Bar.ObtenerListaUsuarios();

            if (listaUsuarios is not null)
            {
                foreach (Usuario item in listaUsuarios)
                {
                    int i = dtgvEmpleados.Rows.Add();
                    dtgvEmpleados.Rows[i].Cells[0].Value = item.Nombre;
                    dtgvEmpleados.Rows[i].Cells[1].Value = item.Apellido;
                    dtgvEmpleados.Rows[i].Cells[2].Value = item.Dni;
                    dtgvEmpleados.Rows[i].Cells[3].Value = item.NombreUsuario;
                    dtgvEmpleados.Rows[i].Cells[4].Value = item.EsAdmin;
                }
            }
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario frmAgregarUsuario = new FormAgregarUsuario();
            DialogResult resultado = frmAgregarUsuario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ActualizarDatosDeTabla();
            }
            else
            {
                MessageBox.Show("Creacion de usuario cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarUsuario_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado;
            int dniUsuario;

            if (dtgvEmpleados.Rows.Count > 0)
            {
                indiceSeleccionado = dtgvEmpleados.CurrentCell.RowIndex;
                if (indiceSeleccionado > -1)
                {
                    if (int.TryParse(dtgvEmpleados.Rows[indiceSeleccionado].Cells[2].Value.ToString(), out dniUsuario))
                    {
                        if (dniUsuario != usuarioLogueado.Dni)
                        {
                            Bar.QuitarUsuario(dniUsuario);
                            dtgvEmpleados.Rows.RemoveAt(indiceSeleccionado);
                            ActualizarDatosDeTabla();
                        }
                        else
                        {
                            MessageBox.Show("No es posible eliminar el usuario con el que se encuentra logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
