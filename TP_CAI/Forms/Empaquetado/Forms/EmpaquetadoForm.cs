using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_CAI.Archivos.PantallaPrincipal.Forms;
using TP_CAI.Forms.Empaquetado.Model;
using TP_CAI.Forms.OrdenDePreparacion.Model;

namespace TP_CAI.Archivos.Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        private EmpaquetadoModel _empaquetadoModel;
        private OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar;

        public EmpaquetadoForm()
        {
            InitializeComponent();
            _empaquetadoModel = new EmpaquetadoModel();
        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            PasarALaSiguienteOrden();
        }

        private void PasarALaSiguienteOrden()
        {
            List<OrdenDePreparacionAEmpaquetar> ordenes = _empaquetadoModel.OrdenesDePreparacionAEmpaquetar;
            ordenDePreparacionAEmpaquetar = ordenes.FirstOrDefault();

            if (ordenDePreparacionAEmpaquetar == null)
            {
                MessageBox.Show("No hay ordenes de preparacion para empaquetar");
                OrdenesPreparacionListView.Items.Clear();
                NroOrdenLabel.Text = "N/A";
                return;
            }

            NroOrdenLabel.Text = ordenDePreparacionAEmpaquetar.Id;

            List<Producto> productosOrden = ordenDePreparacionAEmpaquetar.Productos;

            OrdenesPreparacionListView.Items.Clear();
            foreach (var producto in productosOrden)
            {
                var item = new ListViewItem(new[]
                  {
                        producto.Id.ToString(),
                        producto.Descripcion,
                        producto.Cantidad.ToString(),
                    });

                // Agregar el item al ListView
                OrdenesPreparacionListView.Items.Add(item);
            }
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            _empaquetadoModel.MarcarOrdenComoEmpaquetada(ordenDePreparacionAEmpaquetar);
            //MessageBox.Show("Se registró correctamente el empaquetado de la orden de preparación ID " + orden.Id);
            PasarALaSiguienteOrden();
        }

        private void VolverAlMenu()
        {
            // Solo oculta el formulario actual
            this.Hide();

            // Mostrar el formulario de menú principal
            // Verifica si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaPrincipalForm)
                {
                    form.Show(); // Muestra el formulario si está oculto
                    return;
                }
            }

            // Si no está abierto, crea una nueva instancia (solo si es necesario)
            PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();
            pantallaPrincipalForm.Show();
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {

            VolverAlMenu();
        }



        private void EmpaquetadoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenu();
        }
    }
}
