using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolAhora.Forms.UserControls;
using GolAhora.Forms.UserControls.Driver;

namespace GolAhora.Forms
{
    public partial class PrincipalForm : Form
    {
        private List<UserControl> ucPrincipales = new List<UserControl>();
        public PrincipalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //al abrir la ventana, se muestra el panel de lobby por defecto (inaccesible una vez cerrado)
            //cuando se cambia de panel, se elimina esta pantalla del contenedor, por lo que no se puede volver a acceder a ella
            ChangePanel(new ucLobby());


            // inicializar los modelos de datos (proxi de los datos reales)
            // los datos se van a cargar desde la base de datos, pero por ahora se pueden cargar con datos de prueba
            // club 

            // canchas

            // usuarios

            //
        }


        /*
        private async void button1_Click(object sender, EventArgs e)
        {
            
            var result = await apiService.GetUserDataAsync();
            MessageBox.Show(result ?? "No se pudo obtener los datos del usuario");

        }

        private async void PrincipalForm_Load(object sender, EventArgs e)
        {
            
            var result = await apiService.GetUserDataAsync();
            var info = JsonNode.Parse(result);
            txtUsername.Text = ($"{info?["username"] ?? "Desconocido"}");
            MessageBox.Show(result ?? "No se pudo obtener los datos del usuario");
        }
        */


        //cambiar el panel del contenedor por el que se le pase por parámetro
        private void ChangePanel(UserControl pantallaNueva)
        {
            foreach (var button in lateralMenu.Items)
            {
                if (button is ToolStripButton btn)
                {
                    btn.Enabled = true;
                }
            }

            panelContenedor.Controls.Clear();
            pantallaNueva.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(pantallaNueva);
            pantallaNueva.BringToFront();
        }

        //eventos de click de cada botón del menú, que llaman a ChangePanel con el UserControl correspondiente
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucUsuarios>();
            ChangePanel(pantalla);
            btnUsuarios.Enabled = false;
        }
        
        private void btnReservas_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucReservas2>();
            ChangePanel(pantalla);
            btnReservas.Enabled = false;
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucDescuentos>();
            ChangePanel(pantalla);
            btnDescuentos.Enabled = false;
        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucCanchas>();
            ChangePanel(pantalla);
            btnCanchas.Enabled = false;
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucCapacitaciones>();
            ChangePanel(pantalla);
            btnCapacitaciones.Enabled = false;
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucCompetencias>();
            ChangePanel(pantalla);
            btnCompetencias.Enabled = false;
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucCobros2>();
            ChangePanel(pantalla);
            btnCobros.Enabled = false;
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            UserControl pantalla = Browser.Instance.GetView<ucRecibos>();
            ChangePanel(pantalla);
            btnRecibos.Enabled = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

            UserControl pantalla = Browser.Instance.GetView<ucReportes>();
            ChangePanel(pantalla);
            btnReportes.Enabled = false;
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Seguro que deseas salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (respuesta == DialogResult.No) e.Cancel = true;
        }
    }
}
