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
    public partial class Administrador_Reporteria : Form
    {
        public Administrador_Reporteria()
        {
            InitializeComponent();
        }

        #region Metodo para cargar info del DataGrid
        private void CargarEnvios()
        {
           
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Envio

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
