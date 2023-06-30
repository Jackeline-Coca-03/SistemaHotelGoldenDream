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

namespace CapaPresentacion
{
    public partial class frmHabitacion : Form
    {
        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            cbmestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbmestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbmestado.DisplayMember = "Texto";
            cbmestado.ValueMember = "Valor";
            cbmestado.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "Btnseleccionar")
                {
                    cbmbuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

                }
            }
            cbmbuscar.DisplayMember = "Texto";
            cbmbuscar.ValueMember = "Valor";
            cbmbuscar.SelectedIndex = 0;
            //Mostrar todos los habitaciones

            List<Habitacion> listaHabitacion = new CN_Habitacion().listar();

            foreach (Habitacion item in listaHabitacion)
            {
                dgvdata.Rows.Add(new object[] { "", item.id_hab,item.codigohab,item.descripcion,item.cantCamas,item.num_personas, item.precio,
                    item.estado == true ? 1 : 0,
                    item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "Btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtidhab.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["codigo"].Value.ToString();
                    txtnumero.Text = dgvdata.Rows[indice].Cells["numero"].Value.ToString();
                    txtcantidad.Text = dgvdata.Rows[indice].Cells["cantidad"].Value.ToString();
                    txtpersona.Text = dgvdata.Rows[indice].Cells["numeropersonas"].Value.ToString();
                    txtprecio.Text = dgvdata.Rows[indice].Cells["precio"].Value.ToString();

              
                    foreach (OpcionCombo oc in cbmestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["estadovalor"].Value.ToString()))
                        {
                            int indice_combo = cbmestado.Items.IndexOf(oc);
                            cbmestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
