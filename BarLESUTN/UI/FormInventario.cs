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
    public partial class FormInventario : Form
    {
        public enum EFiltro
        {
            Todos,Comida,Bebida
        }

        private Usuario usuarioLogueado;

        private FormInventario()
        {
            InitializeComponent();
        }

        public FormInventario(Usuario usuarioLogueado) :this()
        {
            this.usuarioLogueado = usuarioLogueado;
        }

        private void FormInventario_Load(object sender, EventArgs e)
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

                btnAgregarComida.Visible = usuarioLogueado.EsAdmin;
                btnAgregarBebida.Visible = usuarioLogueado.EsAdmin;
                btnQuitarProducto.Visible = usuarioLogueado.EsAdmin;
                btnModificarCantidad.Visible = usuarioLogueado.EsAdmin;
            }

            cmbFiltro.DataSource = Enum.GetValues(typeof(EFiltro));
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosDeTabla();
        }

        private void ActualizarDatosDeTabla()
        {
            dtgvProductos.Rows.Clear();
            FiltrarDatosParaMostrar((EFiltro)cmbFiltro.SelectedItem);
        }

        private void FiltrarDatosParaMostrar(EFiltro filtro)
        {
            Dictionary<Producto, int> listaProducto = Bar.ObtenerListaProductos();

            if(listaProducto is not null)
            {
                foreach (KeyValuePair<Producto, int> item in listaProducto)
                {
                    int i = dtgvProductos.Rows.Add();
                    switch (filtro)
                    {
                        case EFiltro.Comida:
                            if(item.Key is Comida)
                            {
                                dtgvProductos.Rows[i].Cells[0].Value = item.Key.Id;
                                dtgvProductos.Rows[i].Cells[1].Value = item.Key.Descripcion;
                                dtgvProductos.Rows[i].Cells[2].Value = item.Key.Formato;
                                dtgvProductos.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                                dtgvProductos.Rows[i].Cells[4].Value = item.Value;
                            }
                            break;
                        case EFiltro.Bebida:
                            if (item.Key is Bebida)
                            {
                                dtgvProductos.Rows[i].Cells[0].Value = item.Key.Id;
                                dtgvProductos.Rows[i].Cells[1].Value = item.Key.Descripcion;
                                dtgvProductos.Rows[i].Cells[2].Value = item.Key.Formato;
                                dtgvProductos.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                                dtgvProductos.Rows[i].Cells[4].Value = item.Value;
                            }
                            break;
                        default:
                            dtgvProductos.Rows[i].Cells[0].Value = item.Key.Id;
                            dtgvProductos.Rows[i].Cells[1].Value = item.Key.Descripcion;
                            dtgvProductos.Rows[i].Cells[2].Value = item.Key.Formato;
                            dtgvProductos.Rows[i].Cells[3].Value = item.Key.PrecioUnitario;
                            dtgvProductos.Rows[i].Cells[4].Value = item.Value;
                            break;
                    }
                }

            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado;
            int idProducto;

            if (dtgvProductos.Rows.Count > 0)
            {
                indiceSeleccionado = dtgvProductos.CurrentCell.RowIndex;
                if(indiceSeleccionado > -1)
                {
                    if(int.TryParse(dtgvProductos.Rows[indiceSeleccionado].Cells[0].Value.ToString(),out idProducto))
                    {
                        Bar.QuitarProductoDeLista(idProducto);
                        dtgvProductos.Rows.RemoveAt(indiceSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            FormProductoEnInventario frmAgregarComida = new FormProductoEnInventario(EFiltro.Comida);
            DialogResult resultado = frmAgregarComida.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                ActualizarDatosDeTabla();
            }
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            FormProductoEnInventario frmAgregarBebida = new FormProductoEnInventario(EFiltro.Bebida);
            DialogResult resultado = frmAgregarBebida.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ActualizarDatosDeTabla();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarCantidad_Click(object sender, EventArgs e)
        {
            FormProductoEnInventario frmProducto;
            DialogResult resultado;
            int indiceSeleccionado;
            int idProducto;

            if (dtgvProductos.Rows.Count > 0)
            {
                indiceSeleccionado  = dtgvProductos.CurrentCell.RowIndex;
                if (indiceSeleccionado > -1)
                {
                    if (int.TryParse(dtgvProductos.Rows[indiceSeleccionado].Cells[0].Value.ToString(), out idProducto))
                    {
                        frmProducto = new FormProductoEnInventario(idProducto);
                        resultado = frmProducto.ShowDialog();
                        if(resultado == DialogResult.OK)
                        {
                            ActualizarDatosDeTabla();
                        }
                    }
                }
            }
        }
    }
}
