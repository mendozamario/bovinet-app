using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace proyecto
{
    public partial class CrearPropietario : Form
    {
        ServicioPropietario servicioPropietario;
        ServicioCredenciales servicioCredenciales;
        public CrearPropietario()
        {
            InitializeComponent();
            servicioPropietario = new ServicioPropietario("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            servicioCredenciales = new ServicioCredenciales("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
        }
        public void Guardar()
        {
            string response2 = servicioPropietario.Guardar(Mapear().Propietario);
            string response = servicioCredenciales.Guardar(Mapear());
            DialogResult dialog = MessageBox.Show(response, "Guardar Produccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                LimpiarVista();
            }
        }
        public Credenciales Mapear()
        {
            Propietario propietario = new Propietario()
            {
                Identificacion = txtIdentificacion.Text,
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
            };
            Credenciales credenciales = new Credenciales()
            {
                NombreUsuario = txtNombreUsuario.Text,
                Contraseña = txtContraseña.Text,
                Tipo = 0,
                Propietario = propietario
            };

            return credenciales;
        }
        public void LimpiarVista()
        {
            txtIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
