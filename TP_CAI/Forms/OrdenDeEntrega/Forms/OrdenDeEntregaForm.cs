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
            _ordenDeEntregaModel.CrearOrdenEntrega();
            ActualizarTabla();
        }

        private void OrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            List<OrdenPreparacion> ordenesPreparacion = _ordenDeEntregaModel.OrdenesDePreparacion;

            OrdenesPreparacionListView.Items.Clear();

            if(ordenesPreparacion.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparacion preparadas para agregar a la orden de entrega");
            }

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                        orden.FechaEntrega.ToString(),
                    });

                // Agregar el item al ListView
                OrdenesPreparacionListView.Items.Add(item);
            }
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();

                // Mostrar el formulario de menú principal
                pantallaPrincipalForm.Show();

                // Cerrar el formulario actual
                this.Close();
        }
    }
}
