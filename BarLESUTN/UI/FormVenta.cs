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
    public partial class FormVenta : Form
    {

        private int numeroMesa;
        private Usuario usuarioLogueado;
        private FormMenuPrincipal frmMenuPrincipal;

        private FormVenta()
        {
            InitializeComponent();
        }

        public FormVenta(Usuario usuarioLogueado,int numeroMesa,FormMenuPrincipal frmMenuPrincipal) :this()
        {
            this.usuarioLogueado = usuarioLogueado;
            this.numeroMesa = numeroMesa;
            this.frmMenuPrincipal = frmMenuPrincipal;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado is not null)
            {
                if (usuarioLogueado.EsAdmin)
                {
                    pnlOpciones.BackColor = Color.Goldenrod;
                }
                else
                {
                    pnlOpciones.BackColor = Color.DodgerBlue;
                }
            }

            ActualizarOpciones();
        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            Bar.AsignarClienteAMesa(numeroMesa, usuarioLogueado.Nombre);
            this.ActualizarOpciones();
        }

        private void ActualizarOpciones()
        {
            if (Bar.MesaEstaOcupada(numeroMesa) == false)
            {
                btnAgregarComida.Visible = false;
                btnAgregarBebida.Visible = false;
                btnQuitarProducto.Visible = false;
                btnContinuar.Visible = false;
                btnModificarCantidad.Visible = false;
                pnlDatosCiente.Visible = false;
                btnAsignarCliente.Visible = true;
            }
            else
            {
                btnAgregarComida.Visible = true;
                btnAgregarBebida.Visible = true;
                btnQuitarProducto.Visible = true;
                btnContinuar.Visible = true;
                btnModificarCantidad.Visible = true;
                pnlDatosCiente.Visible = true;
                btnAsignarCliente.Visible = false;

                if (Bar.MesaEsBarra(numeroMesa))
                {
                    btnAgregarComida.Visible = false;
                    lblNumeroMesa.Text = $"Barra {numeroMesa}";
                }
                else
                {
                    lblNumeroMesa.Text = $"Mesa {numeroMesa}";
                }

                cmbMedioDePago.DataSource = Enum.GetValues(typeof(Cliente.EMedioDePago));
                ActualizarDatosDeTabla();
            }
        }

        private void ActualizarDatosDeTabla()
        {
            Dictionary<Producto, int> pedido = Bar.ObtenerPedidoDeMesa(numeroMesa);
            decimal costoPedido = Bar.ObtenerCostoTotalDeMesa(numeroMesa);
            dtgvPedido.Rows.Clear();

            foreach (KeyValuePair<Producto, int> item in pedido)
            {
                int i = dtgvPedido.Rows.Add();

                dtgvPedido.Rows[i].Cells[0].Value = item.Key.Id;
                dtgvPedido.Rows[i].Cells[1].Value = item.Key.Descripcion;
                dtgvPedido.Rows[i].Cells[2].Value = item.Key.Formato;
                dtgvPedido.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                dtgvPedido.Rows[i].Cells[4].Value = item.Value;
            }

            if (cmbMedioDePago.SelectedItem.ToString() == Cliente.EMedioDePago.Credito.ToString())
            {
                costoPedido = costoPedido * 1.10M;
            }

            if(chkEstacionamiento.Checked == true)
            {
                costoPedido += 100;
            }
            lblCostoTotal.Text = $"Costo total {costoPedido.ToString("C")}";
            
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal.SetDisponibilidadMesas();
        }

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            FormProductoEnVenta frmAgregarComida = new FormProductoEnVenta(FormInventario.EFiltro.Comida,numeroMesa);
            DialogResult resultado = frmAgregarComida.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ActualizarDatosDeTabla();
            }
        }
        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            FormProductoEnVenta frmAgregarBebida = new FormProductoEnVenta(FormInventario.EFiltro.Bebida,numeroMesa);
            DialogResult resultado = frmAgregarBebida.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ActualizarDatosDeTabla();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            if(pnlDatosCiente.Visible == false)
            {
                this.Close();
            }
            else
            {
                Bar.CerrarMesa(numeroMesa);
                this.Close();
            }


        }

        private void cmbMedioDePago_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizarDatosDeTabla();
        }

        private void chkEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDatosDeTabla();
        }
    }
}
