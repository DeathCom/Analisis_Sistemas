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
    public partial class Administrador_Estados : Form
    {
        public Administrador_Estados()
        {
            InitializeComponent();
        }
       
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdEstado.Text = "";
            this.txtDescEstado.Text = "";
          
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarEstados()
        {
            
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_ESTADO


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Estado_Load(object sender, EventArgs e)
        {
            this.CargarEstados();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdEstado.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescEstado.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtIdEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
