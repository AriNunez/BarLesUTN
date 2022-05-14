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
        private Mesa mesaAsignada;

        private FormVenta()
        {
            InitializeComponent();
        }

        public FormVenta(Mesa mesa) :this()
        {
            mesaAsignada = mesa;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
