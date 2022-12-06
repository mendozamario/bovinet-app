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
    public partial class RegistrarProduccion : Form
    {
        ServicioProduccion servicioProduccion;
        ServicioAnimal servicioAnimal;
        public RegistrarProduccion(string codigo)
        {
            InitializeComponent();
            servicioProduccion = new ServicioProduccion("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            servicioAnimal = new ServicioAnimal("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            txtAnimal.Enabled = false;
            txtAnimal.Text = codigo;
        }

        public void Guardar()
        {
            string response = servicioProduccion.Guardar(Mapear());
            DialogResult dialog = MessageBox.Show(response, "Guardar Produccion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                LimpiarVista();
            }
        }
        public Produccion Mapear()
        {
            Produccion produccion = new Produccion()
            {
                Cantidad = int.Parse(txtCantidad.Text),
                CostoDia = float.Parse(txtCostoDia.Text),
                Fehca = DateTime.Now.ToString("yyyy-MM-dd"),
                Animal = ConsultarAnimal(txtAnimal.Text)
            };

            return produccion;
        }
        public Animal ConsultarAnimal(string codigo)
        {
            Respuesta respuesta = servicioAnimal.Consultar();
            Animal animal = null;
            foreach (var item in respuesta.Animales)
            {
                if (item.Codigo.Equals(codigo))
                {
                    animal = item;
                    break;
                }
            }
            return animal;
        }
        public void LimpiarVista()
        {
            txtAnimal.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCostoDia.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
