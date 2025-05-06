using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkPos
{
    public partial class InformeFactura : Form
    {
        public InformeFactura(List<DetalleVenta> detallesVenta)
        {
            InitializeComponent();
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.DataSource = detallesVenta;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void InformeFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
