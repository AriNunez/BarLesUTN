using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormHistorialClientes : Form
    {
        public FormHistorialClientes()
        {
            InitializeComponent();
        }

        private void FormHistorialClientes_Load(object sender, EventArgs e)
        {
            ActualizarDatosDeTabla();
        }

        private void ActualizarDatosDeTabla()
        {
            List<Cliente> listaClientes = Bar.ObtenerListaClientes();

            if (listaClientes is not null)
            {
                foreach (Cliente item in listaClientes)
                {
                    int i = dtgvClientes.Rows.Add();

                    dtgvClientes.Rows[i].Cells[0].Value = item.NombreEmpleadoACargo;
                    dtgvClientes.Rows[i].Cells[1].Value = item.HoraIngreso;
                    dtgvClientes.Rows[i].Cells[2].Value = item.HoraEgreso;
                    dtgvClientes.Rows[i].Cells[3].Value = item.MedioDePago;
                    dtgvClientes.Rows[i].Cells[4].Value = item.ConEstacionamineto;
                    dtgvClientes.Rows[i].Cells[5].Value = item.CostoTotal;
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
