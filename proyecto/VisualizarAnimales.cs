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
    public partial class VisualizarAnimales : Form
    {
        ServicioAnimal servicioAnimal;
        public VisualizarAnimales()
        {
            InitializeComponent();
            servicioAnimal = new ServicioAnimal("server=localhost;user=root;database=bovinet;port=3306;password=MarioMendoza#02;");
            ConsultarAnimales();
        }

        public void ConsultarAnimales()
        {
            Respuesta respuesta = servicioAnimal.Consultar();
            LlenarDgv(respuesta.Animales);
        }

        public void LlenarDgv(List<Animal> animales)
        {
            dgvAnimales.AutoGenerateColumns = true;
            dgvAnimales.DataSource = animales;
        }

        private void btnAgregarAnimales_Click(object sender, EventArgs e)
        {
            new RegistrarAnimal().Show();
            this.Visible = false;
        }

        public string ObtenerDato()
        {
            return dgvAnimales.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new RegistrarProduccion(ObtenerDato()).Show();
        }
    }
}
