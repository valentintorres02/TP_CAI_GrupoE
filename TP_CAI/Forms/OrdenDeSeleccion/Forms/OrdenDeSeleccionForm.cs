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

namespace TP_CAI.Archivos.OrdenDeSeleccion.Forms
{
    public partial class OrdenDeSeleccionForm : Form
    {
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void OrdenDeSeleccionForm_Load(object sender, EventArgs e)
        {

            OrdenesPreparacionGridView.AllowUserToAddRows = false; // Deshabilitar agregar filas manualmente
            OrdenesPreparacionGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Agregar una columna de checkboxes para selección múltiple
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "Seleccionar";
            OrdenesPreparacionGridView.Columns.Add(chkCol);

            // Agregar otras columnas
            OrdenesPreparacionGridView.Columns.Add("Columna1", "ID Orden");
            OrdenesPreparacionGridView.Columns.Add("Columna2", "CUIT/CUIL Cliente");
            OrdenesPreparacionGridView.Columns.Add("Columna3", "Prioridad");
            OrdenesPreparacionGridView.Columns.Add("Columna4", "Estado");

            // Agregar algunas filas como ejemplo
            OrdenesPreparacionGridView.Rows.Add(false, "19", "20-44444444-4", "Media", "Pendiente");
            OrdenesPreparacionGridView.Rows.Add(false, "20", "20-55555555-4", "Media", "Pendiente");
            OrdenesPreparacionGridView.Rows.Add(false, "21", "20-66666666-4", "Alta", "Pendiente");
            OrdenesPreparacionGridView.Rows.Add(false, "22", "20-77777777-4", "Baja", "Pendiente");
            OrdenesPreparacionGridView.Rows.Add(false, "23", "20-88888888-4", "Alta", "Pendiente");
            OrdenesPreparacionGridView.Rows.Add(false, "23", "20-99999999-4", "Alta", "Pendiente");


            GenerarOrdenButton.Enabled = false; // El botón empieza deshabilitado
            LimpiarButton.Enabled = false;

            // Suscribirse al evento CellValueChanged para detectar cambios en el checkbox
            OrdenesPreparacionGridView.CellValueChanged += Dgv_CellValueChanged;

            // Suscribirse al evento CurrentCellDirtyStateChanged para hacer que el valor del checkbox
            // se detecte inmediatamente al hacer clic.
            OrdenesPreparacionGridView.CurrentCellDirtyStateChanged += Dgv_CurrentCellDirtyStateChanged;
        }

        // Evento para habilitar el botón si hay al menos un checkbox seleccionado
        private void Dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la columna es la de los checkboxes (columna 0 en este caso)
            if (e.ColumnIndex == 0)
            {
                VerificarSeleccion();
            }
        }

        // Este evento se asegura de que el valor del checkbox se registre inmediatamente después de un clic.
        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (OrdenesPreparacionGridView.IsCurrentCellDirty)
            {
                OrdenesPreparacionGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Método para verificar si hay al menos un checkbox seleccionado
        private void VerificarSeleccion()
        {
            bool alMenosUnoSeleccionado = false;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in OrdenesPreparacionGridView.Rows)
            {
                // Verificar si el checkbox de la primera columna está seleccionado
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    alMenosUnoSeleccionado = true;
                    break; // No necesitamos seguir recorriendo si ya encontramos uno
                }
            }

            // Habilitar o deshabilitar el botón en función de la selección
            GenerarOrdenButton.Enabled = alMenosUnoSeleccionado;
            LimpiarButton.Enabled = alMenosUnoSeleccionado;
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
            // des-comentar esto para mostrar la excepcion
            //MessageBox.Show("Ya existe una orden de selección para las órdenes de preparación seleccionadas.");
            MessageBox.Show("La orden de selección ID 0014 se generó correctamente.");
        }
    }
}
