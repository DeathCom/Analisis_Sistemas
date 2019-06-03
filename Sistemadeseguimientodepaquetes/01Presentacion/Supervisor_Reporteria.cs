using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Presentacion
{
    public partial class Supervisor_Reporteria : Form
    {
        public Supervisor_Reporteria(string codigo)
        {
            InitializeComponent();
        }

        #region Metodo para cargar info del DataGrid
        private void CargarPedidos()
        {
            
        }
        #endregion

        #region  Boton_Eliminar 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void Cliente_Pedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
