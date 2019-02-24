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
    public partial class Usuario_Pedido : Form
    {
        public Usuario_Pedido()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdPedido.Text = "";
            txtIdUsuario.Text = "";
            txtIdPaisOrigen.Text = "";
            txtIdPaisDestino.Text = "";
            txtIdPago.Text = "";
            txtIdEnvio.Text = "";
            txtIdEstadoCB.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
            txtIdCiudadDestino.Text = "";
            txtIdCiudadOrigen.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarPedidos()
        {
                   }
        #endregion

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            
        
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion



        #region Evento Cargar Al Abrir
        private void Usuario_Pedido_Load(object sender, EventArgs e)
        {
            CargarPedidos(); CargarCombos();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion
    }
}
