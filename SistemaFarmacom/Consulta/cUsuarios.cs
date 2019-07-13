using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacom.Consulta
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();

            try
            {
                if (CriterioTextBox.Text.Trim().Length > 0)
                {
                    switch (FiltroComboBox.Text)
                    {
                        case "Todo":
                            listado = dbe.GetList(p => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = dbe.GetList(p => p.UsuarioId == id);
                            break;

                        case "Nombres":
                            listado = dbe.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;


                        case "Email":
                            listado = dbe.GetList(p => p.Email.Contains(CriterioTextBox.Text));

                            break;

                        case "Usuario":
                            listado = dbe.GetList(p => p.Usuario.Contains(CriterioTextBox.Text));
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    listado = dbe.GetList(p => true);
                }
                UsuariosDataGridView.DataSource = null;
                UsuariosDataGridView.DataSource = listado;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
