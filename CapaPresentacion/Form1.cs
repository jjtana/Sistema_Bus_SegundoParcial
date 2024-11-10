using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly N_Bus negocioBus = new N_Bus();
        private readonly N_Chofer negocioChofer = new N_Chofer();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;  
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Llamamos a CargarDatos para llenar el DataGridView al cargar el formulario
            CargarDataGridView();
            CargarDataGridViewChoferes();

        }

        // Cargar los datos en el DataGridView
        private void CargarDataGridView()
        {
            dataGridView1.DataSource = negocioBus.ObtenerBuses();
        }

  

        private void CargarDataGridViewChoferes()
        {
            dataGridView2.DataSource = negocioChofer.ObtenerChoferes();
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            // Validar que los campos no esten vac�os
            if (string.IsNullOrWhiteSpace(TextBox1.Text) ||
                string.IsNullOrWhiteSpace(TextBox2.Text) ||
                string.IsNullOrWhiteSpace(TextBox3.Text) ||
                string.IsNullOrWhiteSpace(TextBox4.Text) ||
                string.IsNullOrWhiteSpace(TextBox5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que el a�o sea un n�mero
            if (!int.TryParse(TextBox5.Text, out int anio))
            {
                MessageBox.Show("El a�o debe ser un n�mero v�lido.");
                return;
            }

            E_Bus nuevoBus = new E_Bus
            {
                Marca = TextBox1.Text,
                Modelo = TextBox2.Text,
                Placa = TextBox3.Text,
                Color = TextBox4.Text,
                Anio = anio
            };

            if (negocioBus.AgregarBus(nuevoBus))
            {
                MessageBox.Show("Autob�s agregado correctamente.");
                CargarDataGridView(); // Recargar el DataGridView
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el autob�s.");
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Verificar que los campos no est�n vac�os
                if (string.IsNullOrWhiteSpace(TextBox1.Text) ||
                    string.IsNullOrWhiteSpace(TextBox2.Text) ||
                    string.IsNullOrWhiteSpace(TextBox3.Text) ||
                    string.IsNullOrWhiteSpace(TextBox4.Text) ||
                    string.IsNullOrWhiteSpace(TextBox5.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Validar que el a�o sea un n�mero
                if (!int.TryParse(TextBox5.Text, out int anio))
                {
                    MessageBox.Show("El a�o debe ser un n�mero v�lido.");
                    return;
                }

                int autobusID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AutobusID"].Value);
                E_Bus bus = new E_Bus
                {
                    AutobusID = autobusID,
                    Marca = TextBox1.Text,
                    Modelo = TextBox2.Text,
                    Placa = TextBox3.Text,
                    Color = TextBox4.Text,
                    Anio = anio
                };

                if (negocioBus.ActualizarBus(bus))
                {
                    MessageBox.Show("Autob�s actualizado correctamente.");
                    CargarDataGridView();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el autob�s.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un autob�s de la lista para actualizar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int autobusID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AutobusID"].Value);

                if (negocioBus.EliminarBus(autobusID))
                {
                    MessageBox.Show("Autob�s eliminado correctamente.");
                    CargarDataGridView();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el autob�s.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un autob�s de la lista para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarCamposChofer();

        }

        private void LimpiarCampos()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
        }

        private void btnGuardarChofer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                !DateTime.TryParse(txtFechaNacimiento.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            E_Chofer nuevoChofer = new E_Chofer
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = fechaNacimiento,
                Cedula = txtCedula.Text
            };

            if (negocioChofer.AgregarChofer(nuevoChofer))
            {
                MessageBox.Show("Chofer agregado correctamente.");
                CargarDataGridViewChoferes();
                LimpiarCamposChofer();
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el chofer.");
            }
        }

        private void LimpiarCamposChofer()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCedula.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}