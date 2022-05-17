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
    public partial class FormProductoEnInventario : Form
    {
        
        private FormInventario.EFiltro filtro;
        private int idProducto;
        private Producto producto;

        private FormProductoEnInventario()
        {
            InitializeComponent();
            idProducto = 0;
            producto = null;
        }

        public FormProductoEnInventario(int idProducto):this()
        {
            if(idProducto > 0)
            {
                this.idProducto = idProducto;
            }
        }
        public FormProductoEnInventario(FormInventario.EFiltro filtro):this()
        {
            this.filtro = filtro;
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            if(idProducto == 0)
            {
                if (filtro == FormInventario.EFiltro.Comida )
                {
                    cmbFormato.DataSource = Enum.GetValues(typeof(Comida.EFormato));
                    btnModificar.Visible = false;
                }
                else
                {
                    if(filtro == FormInventario.EFiltro.Bebida)
                    {
                        cmbFormato.DataSource = Enum.GetValues(typeof(Bebida.EFormato));
                        btnModificar.Visible = false;
                    }
                }
            }

            if(idProducto > 0)
            {
                btnAgregar.Visible = false;
                txtDescripcion.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                producto = Bar.BuscarProductoPorID(idProducto);
                if(producto is not null)
                {
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.PrecioUnitario.ToString();
                    cmbFormato.Text = producto.Formato;
                    numCantidad.Value = Bar.ObtenerCantidadDeProducto(idProducto);
                }

            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text.Trim();
            if(decimal.TryParse(txtPrecio.Text.Trim(),out decimal precio))
            {
                int cantidad = (int)numCantidad.Value;
                if(cmbFormato.Items.Contains(Bebida.EFormato.Lata))
                {
                    Bebida.EFormato formato = (Bebida.EFormato)cmbFormato.SelectedItem;
                    Bar.AgregarBebidaEnLista(descripcion, precio, formato, cantidad);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if(cmbFormato.Items.Contains(Comida.EFormato.Individual))
                    {
                        Comida.EFormato formato = (Comida.EFormato)cmbFormato.SelectedItem;
                        Bar.AgregarComidaEnLista(descripcion, precio, formato, cantidad);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;
            Bar.ModificarCantidadDeProducto(idProducto, cantidad);
            this.DialogResult= DialogResult.OK;
        }
    }
}
