using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolAhora.Forms.UserControls
{
    public partial class ucReservas : UserControl
    {
        private Label lblCliente, lblCancha, lblHorario, lblDia;
        private TextBox txtCliente;
        private ComboBox cmbTipoCancha, cmbHorariosDisponibles;
        private DateTimePicker dtpDia;
        private CheckBox chkDescuento;
        private Button btnRegistrarPago, btnFinalizarReserva, btnVolverAlta;
        private int indiceModificacion = -1;
        public ucReservas()
        {
            InitializeComponent();
            ConfigurarEstadoInicial();
        }

        private void ConfigurarEstadoInicial()
        {
            LblNuevaReserva.Text = "Nueva Reserva:";
            btnCrear.Text = "Crear";

            pnlAltaReserva.Visible = false;
            btnModificar.Visible = false;
            btnDarBaja.Visible = false;
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            listBoxReservas.Items.Clear();
            listBoxReservas.Items.Add("Juan Pérez - Cancha 1 (Fútbol 5) - 19:00 Hs - 25/05/2026");
            listBoxReservas.Items.Add("Gaston Rodriguez - Cancha 2 (Fútbol 7) - 21:00 Hs - 25/05/2026");
            listBoxReservas.Items.Add("Maria Lopez - Cancha 2 (Fútbol 7) - 18:00 Hs - 26/05/2026");
        }

        // Método de Intercambio de Pantallas (Lista <--> Panel de Alta)
        private void MostrarFormularioAlta(bool mostrar, bool soloLectura = false)
        {
            
            comboBox2.Visible = !mostrar;       // Filtro (Usuario/Cancha)
            comboBox1.Visible = !mostrar;       // Buscador
            button1.Visible = !mostrar;         // Botón Buscar
            listBoxReservas.Visible = !mostrar; // El ListBox
            btnCrear.Visible = !mostrar;        // Botón Crear
            LblNuevaReserva.Visible = !mostrar;
            btnModificar.Visible = false;
            btnDarBaja.Visible = false;

            pnlAltaReserva.Visible = mostrar;

            txtnNombreUsu.ReadOnly = soloLectura;
            cbTipoCancha.Enabled = !soloLectura;
            dtpDiaR.Enabled = !soloLectura;
            cmbHorarios.Enabled = !soloLectura;
            chbDescuento.Enabled = !soloLectura;
            btnPago.Enabled = !soloLectura;

            btnFinalizar.Visible = !soloLectura;
        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxReservas.SelectedIndex != -1)
            {
                btnModificar.Visible = true;
                btnDarBaja.Visible = true;
            }
            else
            {
                btnModificar.Visible = false;
                btnDarBaja.Visible = false;
            }
        }

        
            private void listBoxReservas_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxReservas.SelectedIndex != -1)
            {
                string reservaSeleccionada = listBoxReservas.SelectedItem.ToString();
                string[] datos = reservaSeleccionada.Split('-');

                MostrarFormularioAlta(true, true);
                txtnNombreUsu.Text = datos[0].Trim();
                if (cbTipoCancha.Items.Count > 0) cbTipoCancha.SelectedIndex = 0;
                cmbHorarios.Text = datos[2].Trim();
            }
        }
    

      
        private void btnCrear_Click(object sender, EventArgs e)
        {
            indiceModificacion = -1;
            MostrarFormularioAlta(true, false); // Modo edición habilitado
            btnFinalizar.Enabled = false;       // Bloqueado hasta que se ejecute el pago (Inclusión)
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listBoxReservas.SelectedIndex != -1)
            {
                indiceModificacion = listBoxReservas.SelectedIndex;

                string[] datos = listBoxReservas.SelectedItem.ToString().Split('-');

                // Abre el panel en modo edición(false)
                MostrarFormularioAlta(true, false);

                // Rellenamos los campos con variables
                txtnNombreUsu.Text = datos[0].Trim();
                cmbHorarios.Text = datos[2].Trim();

                // Valor por defecto al combo de canchas para que pase la validación
                if (cbTipoCancha.Items.Count > 0) cbTipoCancha.SelectedIndex = 0;

                btnFinalizar.Enabled = true; //
            }
        }

        // Botón Dar de Baja 
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (listBoxReservas.SelectedIndex != -1)
            {
                string reserva = listBoxReservas.SelectedItem.ToString();
                DialogResult res = MessageBox.Show($"¿Seguro que desea dar de baja la reserva:\n{reserva}?\n\nSe aplicará el reembolso automático correspondiente del club.", "Baja de Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    listBoxReservas.Items.Remove(listBoxReservas.SelectedItem);
                    MessageBox.Show("Reserva cancelada y reembolso emitido con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cobro registrado de forma correcta en la caja del complejo.", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnFinalizar.Enabled = true;
        }

        // Botón Finalizar Reserva
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnNombreUsu.Text.Trim()) || cbTipoCancha.SelectedIndex == -1 || cmbHorarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los datos antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           
            string reservaFormateada = $"{txtnNombreUsu.Text.Trim()} - {cbTipoCancha.SelectedItem} - {cmbHorarios.SelectedItem} - {dtpDiaR.Value.ToShortDateString()}";

            if (indiceModificacion == -1)
            {
               //Se agrega al final de la lista
                listBoxReservas.Items.Add(reservaFormateada);
                MessageBox.Show("¡Reserva creada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Sobrescribe el elemento en la misma posición exacta
                listBoxReservas.Items[indiceModificacion] = reservaFormateada;
                MessageBox.Show("¡Reserva modificada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarCamposPanel();
            MostrarFormularioAlta(false); // Volvemos a la lista
        }

        // Botón Volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            LimpiarCamposPanel();
            MostrarFormularioAlta(false); // Cancela y vuelve a la lista original
        }

        private void LimpiarCamposPanel()
        {
            txtnNombreUsu.Clear();
            cbTipoCancha.SelectedIndex = -1;
            cmbHorarios.SelectedIndex = -1;
            chbDescuento.Checked = false;
            listBoxReservas.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = ""; // Resetea el texto visual

            if (comboBox2.SelectedItem.ToString() == "Usuario")
            {
                // Si elige Usuario, cargamos nombres de ejemplo
                comboBox1.Items.AddRange(new string[] { "Juan Pérez", "Gaston Rodriguez", "Maria Lopez" });
            }
            else if (comboBox2.SelectedItem.ToString() == "Cancha")
            {
                // Si elige Cancha, cargamos los tipos de cancha
                comboBox1.Items.AddRange(new string[] { "Cancha 1 (Fútbol 5)", "Cancha 2 (Fútbol 7)" });
            }
        }
    }
}