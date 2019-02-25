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
    public partial class Administrador_Usuarios : Form
    {
        public Administrador_Usuarios()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdUsuario.Text = "";
            txtNombre.Text = "";
            txtAlias.Text = "";
            txtPassword.Text = "";
            txtTipoUserCB.Text = "";
            txtEstadoCB.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarUsuarios()
        {
            
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Usuario
       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
        private void Administrador_Usuario_Load(object sender, EventArgs e)
        {
            this.CargarUsuarios();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdUsuario.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtNombre.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtAlias.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtPassword.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtTipoUserCB.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtEstadoCB.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                /*Preguntar al profe como llenar un combo con datos directos desde la base 
                 y no quemados*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
