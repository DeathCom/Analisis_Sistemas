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
    public partial class Administrador_Envios : Form
    {
        public Administrador_Envios()
        {
            InitializeComponent();
        }
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdEnvio.Text = "";
            this.txtDesc.Text = "";
            this.txtPrecio.Text = "";
            
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarEnvios()
        {
           
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Envio
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
       
        #region Evento Cargar Al Abrir
        private void Administrador_Envio_Load(object sender, EventArgs e)
        {
            this.CargarEnvios();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdEnvio.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDesc.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtPrecio.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
