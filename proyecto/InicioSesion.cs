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
using proyecto;

namespace proyecto
{
    public partial class InicioSesion : Form
    {
        ServicioCredenciales servicioCredenciales;
        public InicioSesion()
        {
            InitializeComponent();
            servicioCredenciales = new ServicioCredenciales("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            Iniciar();            
        }
        public void Mapear()
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
        }
        public void Iniciar()
        {
            txtContraseña.PasswordChar = '*';
        }

        private void llRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CrearPropietario().Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            new VisualizarAnimales().Show();
        }
    }
}
