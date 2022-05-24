using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormTicket : Form
    {
        private DataGridView pedido;
        private decimal costoTotal;
        private bool conEstacionamiento;
        private bool conRecargo;

        private FormTicket()
        {
            InitializeComponent();
        }
        public FormTicket(DataGridView pedido, decimal costoTotal, bool conEstacionamiento, bool conRecargo) : this()
        {
            this.pedido = pedido;
            this.costoTotal = costoTotal;
            this.conEstacionamiento = conEstacionamiento;
            this.conRecargo = conRecargo;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            decimal costoProducto = 0;
            int cantidad = 0;

            foreach (DataGridViewRow item in pedido.Rows)
            {
                if (item.Cells[0] != null)
                {
                    rtbResumenPedido.AppendText($"{item.Cells[4].Value.ToString()}  {item.Cells[1].Value.ToString()}\n");

                    costoProducto = decimal.Parse(item.Cells[3].Value.ToString());
                    cantidad = int.Parse(item.Cells[4].Value.ToString());

                    rtbCostos.AppendText($"${(cantidad * costoProducto).ToString()}\n");
                }
            }
            if (conEstacionamiento)
            {
                rtbResumenPedido.AppendText($"Con Estacionamiento\n");
                rtbCostos.AppendText($"$100,00\n");
            }
            if (conRecargo)
            {
                rtbResumenPedido.AppendText($"Pago con Tarjeta de Credito\n");
                rtbCostos.AppendText($"%10\n");
            }
            rtbResumenPedido.AppendText($"Costo total\n");
            rtbCostos.AppendText($"${costoTotal}\n");
        }

        private void FormTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
