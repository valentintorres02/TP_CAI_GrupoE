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
using TP_CAI.Forms.GestionOrdenSeleccion.Model;
using TP_CAI.Forms.OrdenDeSeleccion.Forms.Model;

namespace TP_CAI.Archivos.OrdenDeSeleccion.Forms
{
    public partial class OrdenDeSeleccionForm : Form
    {
        private OrdenDeSeleccionModel _ordenDeSeleccionModel;

        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
            _ordenDeSeleccionModel = new OrdenDeSeleccionModel();
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {

            List<OrdenPreparacion> ordenes = _ordenDeSeleccionModel.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                //OrdenesPreparacionListView.Add(false, orden.Id, orden.DocumentoCliente, orden.Prioridad, orden.Estado);
            }
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tienes una Órden de Selección en proceso. Si sales se perderá el progreso y la órden no será creada, ¿deseas salir?",
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

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            try
            {
                // todo: implementar logica
                string documentoCliente = "20-44444444-4"; // Esto debe ser obtenido del formulario

                string mensaje = _ordenDeSeleccionModel.CrearOrden(documentoCliente);

                // Mostrar el mensaje de éxito
                MessageBox.Show(mensaje);

               
            }
            catch (Exception ex)
            {
                // Manejar errores inesperados
                MessageBox.Show("La Orden de Selección no pudo ser creada correctamente. Por favor intente de nuevo o contacte al área de sistemas.\n" + ex.Message);
            }
            finally
            {
                LimpiarFormulario();
                EliminarOrdenesSeleccionadas();
            }
        }


        private void LimpiarFormulario()
        {
        }

        private void EliminarOrdenesSeleccionadas()
        {
           //
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
        }
    }
}
