using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02LogicaNegocio;
using _04Entidades;

namespace _01Presentacion
{
    public partial class Supervisor_Inicio : Form
    {
        public Supervisor_Inicio(string Usuario)
        {
            InitializeComponent();
            lblTipoUsuario.Text = "Bienvenido (a) " + Usuario;
            CargarTiquetes();
        }
        #region Metodo para cargar info del DataGrid
        private void CargarTiquetes()
        {
            try
            {
                List<T_Tiquete> lstTiquetes = Logica.obtTiquetes();
                this.dataGridView1.DataSource = lstTiquetes;
                this.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos " + ex.Message); ;
            }
        }
        #endregion
    }
}
