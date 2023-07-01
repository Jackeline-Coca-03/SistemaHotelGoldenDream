using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHotel.Utilidades;

namespace CapaPresentacion.Modales
{
    public partial class mdHabitacion : Form
    {
        public Habitacion _Habitacion { get; set; }
        public mdHabitacion()
        {
            InitializeComponent();
        }

        private void mdHabitacion_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbmbuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbmbuscar.DisplayMember = "Texto";
            cbmbuscar.ValueMember = "Valor";
            cbmbuscar.SelectedIndex = 0;

            List<Habitacion> lista = new CN_Habitacion().listar();

            foreach (Habitacion item in lista)
            {
                if (item.estado)
                    dgvdata.Rows.Add(new object[] { item.codigohab, item.descripcion, item.precio });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                _Habitacion = new Habitacion()
                {
                    codigohab = Convert.ToInt32(dgvdata.Rows[iRow].Cells["codigo"].Value),
                    descripcion = dgvdata.Rows[iRow].Cells["numero"].Value.ToString(),
                    precio = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["precio"].Value),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbmbuscar.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
