using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using SystemHotel.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cbmestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbmestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbmestado.DisplayMember = "Texto";
            cbmestado.ValueMember = "Valor";
            cbmestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().listar();

            foreach (Rol item in listaRol)
            {
                cbmrol.Items.Add(new OpcionCombo() { Valor = item.id_rol, Texto = item.descripcion });
            }
            cbmrol.DisplayMember = "Texto";
            cbmrol.ValueMember = "Valor";
            cbmrol.SelectedIndex = 0;

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
            //Mostrar todos los usuarios

            List<Usuario> listaUsuario = new CN_Usuario().listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvdata.Rows.Add(new object[] { "", item.id_usuario,item.nombreCompleto,item.ci,item.cuenta,item.pasword,
                    item.oRol.id_rol,
                    item.oRol.descripcion,
                    item.estado == true ? 1 : 0,
                    item.estado == true ? "Activo" : "No Activo"
                });
            }
            cbmrol.DisplayMember = "Texto";
            cbmrol.ValueMember = "Valor";
            cbmrol.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(new object[] { "", txtidusuario.Text,txtnombre.Text,txtci.Text,txtcuenta.Text,txtpassword.Text,
                ((OpcionCombo)cbmrol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbmrol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cbmestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbmestado.SelectedItem).Texto.ToString()
            });
            limpiar();
        }

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtidusuario.Text = "0";
            txtnombre.Text = "";
            txtci.Text = "";
            txtcuenta.Text = "";
            txtpassword.Text = "";
            txtconfirmarpassword.Text = "";
            cbmrol.SelectedIndex = 0;
            cbmestado.SelectedIndex = 0;
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "Btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtidusuario.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtci.Text = dgvdata.Rows[indice].Cells["ci"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["nombre"].Value.ToString();
                    txtcuenta.Text = dgvdata.Rows[indice].Cells["cuenta"].Value.ToString();
                    txtpassword.Text = dgvdata.Rows[indice].Cells["password"].Value.ToString();
                    txtconfirmarpassword.Text = dgvdata.Rows[indice].Cells["password"].Value.ToString();

                    foreach (OpcionCombo oc in cbmrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["id_rol"].Value.ToString()))
                        {
                            int indice_combo = cbmrol.Items.IndexOf(oc);
                            cbmrol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
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
    }
}
