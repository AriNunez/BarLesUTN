using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormProductoEnVenta : Form
    {
        private FormInventario.EFiltro filtro;
        private int id;
        private int numeroMesa;
        private FormProductoEnVenta()
        {
            InitializeComponent();
            id = 0;
        }

        public FormProductoEnVenta(FormInventario.EFiltro filtro, int numeroMesa) : this()
        {
            this.filtro = filtro;
            this.numeroMesa = numeroMesa;
        }

        private void FormProductoEnVenta_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                FiltrarDatosParaMostrar(filtro);
                btnModificar.Visible = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text) && numCantidad.Value > 0)
            {
                Bar.AgregarProductoAPedido(numeroMesa, id, (int)numCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se agregar producto a pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FiltrarDatosParaMostrar(FormInventario.EFiltro filtro)
        {
            Dictionary<Producto, int> listaProducto = Bar.ObtenerListaProductos();

            foreach (KeyValuePair<Producto, int> item in listaProducto)
            {
                int i = dtgvProductos.Rows.Add();
                switch (filtro)
                {
                    case FormInventario.EFiltro.Comida:
                        if (item.Key is Comida)
                        {
                            dtgvProductos.Rows[i].Cells[0].Value = item.Key.Id;
                            dtgvProductos.Rows[i].Cells[1].Value = item.Key.Descripcion;
                            dtgvProductos.Rows[i].Cells[2].Value = item.Key.Formato;
                            dtgvProductos.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                        }
                        break;
                    case FormInventario.EFiltro.Bebida:
                        if (item.Key is Bebida)
                        {
                            dtgvProductos.Rows[i].Cells[0].Value = item.Key.Id;
                            dtgvProductos.Rows[i].Cells[1].Value = item.Key.Descripcion;
                            dtgvProductos.Rows[i].Cells[2].Value = item.Key.Formato;
                            dtgvProductos.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                        }
                        break;
                }
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceSeleccionado;
            int idProducto;
            Producto producto;
            Dictionary<Producto, int> listaProducto = Bar.ObtenerListaProductos();

            if (dtgvProductos.Rows.Count > 0 && listaProducto is not null)
            {
                indiceSeleccionado = dtgvProductos.CurrentCell.RowIndex;
                if (indiceSeleccionado > -1 && dtgvProductos.Rows[indiceSeleccionado].Cells[0].Value is not null) // lo que contiene la celda es un objeto
                {
                    if (int.TryParse(dtgvProductos.Rows[indiceSeleccionado].Cells[0].Value.ToString(), out idProducto))
                    {
                        producto = Bar.BuscarProductoPorID(idProducto);

                        if (producto is not null)
                        {
                            txtDescripcion.Text = producto.Descripcion;
                            txtPrecio.Text = producto.PrecioUnitario.ToString();
                            txtFormato.Text = producto.Formato;
                            foreach (KeyValuePair<Producto, int> item in listaProducto)
                            {
                                if (item.Key == producto)
                                {
                                    numCantidad.Maximum = item.Value;
                                    this.id = idProducto;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
