using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistrar : Form
    {
        private Usuario _Usuario;
        public frmRegistrar(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtcicliente.Text = Convert.ToString(modal._Cliente.ci);
                    txtnombrecliente.Text = modal._Cliente.nombreCompleto;
                    txtcodigo.Select();
                }
                else
                {
                    txtcicliente.Select();
                }
            }
        }

        private void btnbuscarhab_Click(object sender, EventArgs e)
        {
            using (var modal = new mdHabitacion())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidhab.Text = modal._Habitacion.id_hab.ToString();
                    txtcodigo.Text = modal._Habitacion.codigohab.ToString();
                    txtnumhab.Text = modal._Habitacion.descripcion;
                    txtprecio.Text = modal._Habitacion.precio.ToString();
                    numericUpDown3.Select();
                }
                else
                {
                    txtcodigo.Select();
                }
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            txtfechar.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidhab.Text = "0";

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";
            
        }

        private void dtmsalida_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaIngreso = dtmingreso.Value;
            DateTime fechaSalida = dtmsalida.Value;
            TimeSpan tSpan = fechaSalida - fechaIngreso;
            txtdia.Text = (tSpan.Days).ToString();
            txtnoche.Text = ((tSpan.Days) - 1).ToString();
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Habitacion oHabitacion = new CN_Habitacion().listar().Where(p => p.codigohab.ToString() == txtcodigo.Text && p.estado == true).FirstOrDefault();
                if(oHabitacion != null)
                {
                    txtcodigo.BackColor = Color.Honeydew;
                    txtidhab.Text = oHabitacion.id_hab.ToString();
                    txtcodigo.Text = oHabitacion.codigohab.ToString();
                    txtnumhab.Text = oHabitacion.descripcion;
                    txtprecio.Text = oHabitacion.precio.ToString("0.00");
                    numericUpDown3.Select();
                }
                else
                {
                    txtcodigo.BackColor = Color.MistyRose;
                    txtidhab.Text = "0";
                    txtcodigo.Text = "";
                    txtnumhab.Text = "";
                    txtprecio.Text = "";
                    numericUpDown3.Value = 1;
                }
            }
        }
    }
}
