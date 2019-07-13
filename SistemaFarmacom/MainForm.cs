using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacom.Registros;
using SistemaFarmacom.Consulta;
namespace SistemaFarmacom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios VisualizarVentana = new rUsuarios();
            VisualizarVentana.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios VisualizarVentana = new cUsuarios();
            VisualizarVentana.Show();
        }
    }
}
