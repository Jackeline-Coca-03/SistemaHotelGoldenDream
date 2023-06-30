using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmbuscarCliente bc = new frmbuscarCliente();
            bc.ShowDialog();
        }

        private void btnbuscarhab_Click(object sender, EventArgs e)
        {
            frmbuscarHabitacion bh = new frmbuscarHabitacion();
            bh.ShowDialog();
        }
    }
}
