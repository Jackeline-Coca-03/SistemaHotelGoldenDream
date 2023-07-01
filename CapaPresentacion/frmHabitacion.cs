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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Habitacion objhabitacion = new Habitacion()
            {
                id_hab = Convert.ToInt32(txtidhab.Text),
                codigohab = Convert.ToInt32(txtcodigo.Text),
                descripcion = txtnumero.Text,
                cantCamas = Convert.ToInt32(txtcantidad.Text),
                num_personas = Convert.ToInt32(txtpersona.Text),
                precio = Convert.ToDecimal(txtprecio.Text),
                estado = Convert.ToInt32(((OpcionCombo)cbmestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objhabitacion.id_hab == 0)
            {
                int id_habitacionResultado = new CN_Habitacion().Registrar(objhabitacion, out mensaje);

                if (id_habitacionResultado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", id_habitacionResultado,txtcodigo.Text,txtnumero.Text,txtcantidad.Text,txtpersona.Text, txtprecio.Text,              
                    ((OpcionCombo)cbmestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbmestado.SelectedItem).Texto.ToString()
                    });
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Habitacion().Editar(objhabitacion, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtidhab.Text;
                    row.Cells["codigo"].Value = txtcodigo.Text;
                    row.Cells["numero"].Value = txtnumero.Text;
                    row.Cells["cantidad"].Value = txtcantidad.Text;
                    row.Cells["numeropersonas"].Value = txtpersona.Text;
                    row.Cells["precio"].Value = txtprecio.Text;
                    row.Cells["estadovalor"].Value = ((OpcionCombo)cbmestado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionCombo)cbmestado.SelectedItem).Texto.ToString();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        private void limpiar()
        {
            txtindice.Text = "-1";
            txtidhab.Text = "0";
            txtcodigo.Text = "";
            txtnumero.Text = "";
            txtcantidad.Text = "";
            txtpersona.Text = "";
            txtprecio.Text = "";
            cbmestado.SelectedIndex = 0;

            txtcodigo.Select();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidhab.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar la habitacion", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Habitacion objhabitacion = new Habitacion()
                    {
                        id_hab = Convert.ToInt32(txtidhab.Text)
                    };
                    bool respuesta = new CN_Habitacion().Eliminar(objhabitacion, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
