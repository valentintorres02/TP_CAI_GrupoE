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

namespace TP_CAI.Archivos.Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        public EmpaquetadoForm()
        {
            InitializeComponent();
        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            OrdenesPreparacionGridView.AllowUserToAddRows = false; // Deshabilitar agregar filas manualmente
            OrdenesPreparacionGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdenesPreparacionGridView.MultiSelect = false;

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
            OrdenesPreparacionGridView.Rows.Add(false, "19", "20-44444444-4", "Media", "En Preparación");
            OrdenesPreparacionGridView.Rows.Add(false, "20", "20-55555555-4", "Media", "En Preparación");
            OrdenesPreparacionGridView.Rows.Add(false, "21", "20-66666666-4", "Alta", "En Preparación");
            OrdenesPreparacionGridView.Rows.Add(false, "22", "20-77777777-4", "Baja", "En Preparación");
            OrdenesPreparacionGridView.Rows.Add(false, "23", "20-88888888-4", "Alta", "En Preparación");
            OrdenesPreparacionGridView.Rows.Add(false, "23", "20-99999999-4", "Alta", "En Preparación");


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
            // Verificar si la celda modificada es de la columna de CheckBox (asumamos que es la columna 0)
            if (e.ColumnIndex == 0 && OrdenesPreparacionGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
            {
                // Si la celda fue seleccionada (true)
                if ((bool)OrdenesPreparacionGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true)
                {
                    // Desmarcar todos los demás CheckBoxes en la misma columna
                    foreach (DataGridViewRow row in OrdenesPreparacionGridView.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells[0].Value = false; // Desmarcar
                        }
                    }

                    // Habilitar el botón cuando un checkbox esté seleccionado
                    GenerarOrdenButton.Enabled = true;
                }
                else
                {
                    // Verificar si aún queda algún checkbox seleccionado
                    bool algunSeleccionado = OrdenesPreparacionGridView.Rows.Cast<DataGridViewRow>()
                        .Any(r => (bool)r.Cells[0].Value == true);

                    GenerarOrdenButton.Enabled = algunSeleccionado;
                }
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

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            bool excepcion = false;

            if (excepcion)
            {
                MessageBox.Show("El Empaquetado no pudo ser registrado correctamente. Por favor intente de nuevo o contacte al área de sistemas.");
            }

            MessageBox.Show("Se registró correctamente el empaquetado de la orden de preparación ID 0009");
        }

        private void VolverAlMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                     "Tienes una Órden de Preparación en proceso. Si sales se perderá el progreso y la órden no será creada, ¿deseas salir?",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
