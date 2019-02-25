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
    public partial class Administrador_Aplicaciones : Form
    {
        public Administrador_Aplicaciones()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdOrigen.Text = "";
            this.txtPais.Text = "";
            this.txtCiudad.Text = "";           
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarOrigen()
        {
            
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Origen


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Origen_Load(object sender, EventArgs e)
        {
            this.CargarOrigen();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdOrigen.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtPais.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtCiudad.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();     
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}