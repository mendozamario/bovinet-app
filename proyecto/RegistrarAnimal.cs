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
    public partial class RegistrarAnimal : Form
    {
        ServicioPropietario servicioPropietario;
        ServicioAnimal servicioAnimal;
        public RegistrarAnimal()
        {
            InitializeComponent();
            servicioPropietario = new ServicioPropietario("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            servicioAnimal = new ServicioAnimal("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            LlenarPropietarios();
        }

        public void Guardar()
        {
            string response = servicioAnimal.Guardar(Mapear());
            DialogResult dialog = MessageBox.Show(response, "Guardar Animal", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                LimpiarVista();
            }
        }

        public Animal Mapear()
        {
            int estado = 0;
            if (cmbEstado.Equals("Preñada")) estado = 1;

            Animal animal = new Animal()
            {
                Codigo = txtCodigo.Text,
                Raza = cmbRaza.Text,
                Peso = int.Parse(txtPeso.Text),
                Estado = estado,
                FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"),
                Tipo = cmbTipo.Text,
                Propietario = ConsultarPropietario(cmbPropietario.Text)
            };
            return animal;  
        }

        public Propietario ConsultarPropietario(string identificacion)
        {
            Respuesta respuesta = servicioPropietario.Consultar();
            Propietario propietario = null;
            foreach (var item in respuesta.Propietarios)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    propietario = item;
                    break;
                }
            }
            return propietario;
        }

        public void LlenarPropietarios()
        {
            Respuesta respuesta = servicioPropietario.Consultar();
            foreach (var item in respuesta.Propietarios)
            {
                cmbPropietario.Items.Add(item.Identificacion);
            }
        }

        public void LimpiarVista()
        {
            txtCodigo.Text = string.Empty;
            cmbRaza.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cmbEstado.Text = string.Empty;
            cmbTipo.Text = string.Empty;
            cmbPropietario.Text = string.Empty;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
