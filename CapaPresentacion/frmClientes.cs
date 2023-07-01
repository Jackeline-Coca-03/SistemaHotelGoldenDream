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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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
            //Mostrar todos los clientes

            List<Cliente> listaCliente = new CN_Cliente().listar();

            foreach (Cliente item in listaCliente)
            {
                dgvdata.Rows.Add(new object[] { "", item.id_cliente,item.ci,item.nombreCompleto,item.celular,
                    item.estado == true ? 1 : 0,
                    item.estado == true ? "Activo" : "No Activo"
                });
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
                    txtidcliente.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtci.Text = dgvdata.Rows[indice].Cells["ci"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["nombre"].Value.ToString();
                    txtcelular.Text = dgvdata.Rows[indice].Cells["celular"].Value.ToString();

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

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtidcliente.Text = "0";
            txtnombre.Text = "";
            txtci.Text = "";
            txtcelular.Text = "";
            cbmestado.SelectedIndex = 0;

            txtci.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente objcliente = new Cliente()
            {
                id_cliente = Convert.ToInt32(txtidcliente.Text),
                ci = Convert.ToInt32(txtci.Text),
                nombreCompleto = txtnombre.Text,
                celular = Convert.ToInt32(txtcelular.Text),
                estado = Convert.ToInt32(((OpcionCombo)cbmestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objcliente.id_cliente == 0)
            {
                int id_clienteResultado = new CN_Cliente().Registrar(objcliente, out mensaje);

                if (id_clienteResultado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", id_clienteResultado,txtnombre.Text,txtci.Text,txtcelular.Text,
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
                bool resultado = new CN_Cliente().Editar(objcliente, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtidcliente.Text;
                    row.Cells["ci"].Value = txtci.Text;
                    row.Cells["nombre"].Value = txtnombre.Text;
                    row.Cells["celular"].Value = txtcelular.Text;
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidcliente.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objcliente = new Cliente()
                    {
                        id_cliente = Convert.ToInt32(txtidcliente.Text)
                    };
                    bool respuesta = new CN_Cliente().Eliminar(objcliente, out mensaje);

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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
