using CapaEntidad;
using FontAwesome.Sharp;
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
using CapaHotel;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioactual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioactual = objusuario;
            InitializeComponent();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().listar(usuarioactual.id_usuario);
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.nombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            lblusuario.Text = usuarioactual.cuenta;
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkRed;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());
        }

        private void submenuhabitacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmHabitacion());
        }

        private void submenuhotel_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmHotel());
        }

        private void submenuregistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmRegistrar());
        }

        private void submenudetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmDetalle());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }
    }
}
