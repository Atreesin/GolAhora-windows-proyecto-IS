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
    public partial class ucCobros : UserControl
    {
        // Declaramos los nuevos controles para el formulario de registro
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblMetodo;
        private ComboBox cmbMetodoPago;
        private Button btnGuardarCobro;
        private Button btnVolver;

        public ucCobros()
        {
            InitializeComponent();
            CrearControlesRegistro(); // Inicializamos los componentes ocultos
        }

        // Diseñamos los nuevos campos que aparecerán al presionar "Registrar"
        private void CrearControlesRegistro()
        {
            // Etiqueta Monto
            lblMonto = new Label { Text = "Monto:", Location = new Point(20, 60), AutoSize = true, Visible = false };

            // Caja de texto Monto
            txtMonto = new TextBox { Location = new Point(120, 56), Width = 150, Visible = false };

            // Etiqueta Método de Pago
            lblMetodo = new Label { Text = "Método de Pago:", Location = new Point(20, 100), AutoSize = true, Visible = false };

            // Desplegable Método de Pago
            cmbMetodoPago = new ComboBox { Location = new Point(120, 96), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList, Visible = false };
            cmbMetodoPago.Items.AddRange(new string[] { "Efectivo", "Transferencia", "Tarjeta de Débito" });

            // Botón Guardar
            btnGuardarCobro = new Button { Text = "Guardar Cobro", Location = new Point(120, 150), Width = 110, BackColor = SystemColors.ControlLight, Visible = false };
            btnGuardarCobro.Click += BtnGuardarCobro_Click;

            // Botón Volver
            btnVolver = new Button { Text = "Volver", Location = new Point(20, 150), Width = 75, BackColor = SystemColors.ControlLight, Visible = false };
            btnVolver.Click += BtnVolver_Click;

            // Agregamos los controles al UserControl
            this.Controls.Add(lblMonto);
            this.Controls.Add(txtMonto);
            this.Controls.Add(lblMetodo);
            this.Controls.Add(cmbMetodoPago);
            this.Controls.Add(btnGuardarCobro);
            this.Controls.Add(btnVolver);
        }

        // Método auxiliar para alternar la vista entre el listado y el registro
        private void MostrarFormularioRegistro(bool mostrar)
        {
            // Oculta o muestra lo viejo (Grilla, botones de la derecha y etiquetas)
            lbCobros.Visible = !mostrar;
            btnRegistrar.Visible = !mostrar;
            btnListar.Visible = !mostrar;
            label1.Visible = !mostrar;
            label7.Visible = !mostrar;

            // Muestra o oculta lo nuevo (Formulario de carga)
            lblMonto.Visible = mostrar;
            txtMonto.Visible = mostrar;
            lblMetodo.Visible = mostrar;
            cmbMetodoPago.Visible = mostrar;
            btnGuardarCobro.Visible = mostrar;
            btnVolver.Visible = mostrar;
        }

        // --- EVENTOS ---

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            // Al presionar Registrar, pasamos a la vista de carga
            MostrarFormularioRegistro(true);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Limpiamos los campos y regresamos a la grilla principal
            txtMonto.Clear();
            cmbMetodoPago.SelectedIndex = -1;
            MostrarFormularioRegistro(false);
        }

        private void BtnGuardarCobro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text) || cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos del cobro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulación de guardado exitoso
            MessageBox.Show($"¡Cobro de ${txtMonto.Text} registrado con éxito mediante {cmbMetodoPago.SelectedItem}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volvemos automáticamente a la pantalla de la grilla
            BtnVolver_Click(sender, e);
        }
    }
}