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
    public partial class Cliente_Pedido : Form
    {
        public Cliente_Pedido(string codigo)
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
            
        }

    }
}
