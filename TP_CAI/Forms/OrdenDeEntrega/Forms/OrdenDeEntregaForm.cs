using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.PantallaPrincipal.Forms;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.OrdenDeEntrega.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Forms.OrdenDeEntrega.Forms
{
    public partial class OrdenDeEntregaForm : Form
    {
        private OrdenDeEntregaModel _ordenDeEntregaModel;

        public OrdenDeEntregaForm()
        {
            InitializeComponent();
            _ordenDeEntregaModel = new OrdenDeEntregaModel();
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró correctamente la órden de entrega ID 0003");
        }

        private void OrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
        }

        private void SeleccionarTransporistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tienes una Órden de Entrega en proceso. Si sales se perderá el progreso y la órden no será creada, ¿deseas salir?",
                "Advertencia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí"
            if (result == DialogResult.Yes)
            {
                // Crear una nueva instancia del formulario de menú principal
                PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();

                // Mostrar el formulario de menú principal
                pantallaPrincipalForm.Show();

                // Cerrar el formulario actual
                this.Close();
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
        }
    }
}
