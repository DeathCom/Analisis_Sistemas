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
            ComboTipoUsusario.Text = "";
            ComboEstadoUsuario.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarUsuarios()
        {
            try
            {
                List<T_Usuarios> lstUsuarios = Logica.obtUsuarios();
                this.dataGrid.DataSource = lstUsuarios;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos " + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Usuario
        public T_Usuarios processoBase()
        {
            T_Usuarios Usuarios = new T_Usuarios();
            Usuarios.Id_Usuario = Convert.ToInt16(txtIdUsuario.Text.Trim());
            Usuarios.Usuario = txtAlias.Text;
            Usuarios.Nombre_Usuario = txtNombre.Text;
            Usuarios.Contrasena_Usuario = txtPassword.Text;
            Usuarios.Estado_Usuario = ComboEstadoUsuario.Text;
            Usuarios.Tipo_Usuario = ComboTipoUsusario.Text;
            return Usuarios;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Usuarios Usuarios = new T_Usuarios();
                Usuarios.Id_Usuario = Convert.ToInt16(txtIdUsuario.Text.Trim());
                Usuarios.Usuario = txtAlias.Text;
                Usuarios.Nombre_Usuario = txtNombre.Text;
                Usuarios.Contrasena_Usuario = txtPassword.Text;
                Usuarios.Estado_Usuario = ComboEstadoUsuario.Text;
                Usuarios.Tipo_Usuario = ComboTipoUsusario.Text;
                _02LogicaNegocio.Logica.GuardarDato(Usuarios);
                MessageBox.Show("Datos Guardados Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Usuarios " + ex.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                _02LogicaNegocio.Logica.ModificarDato(processoBase());
                MessageBox.Show("Datos Editados Satisfactoriamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Editar Datos de la tabla de Usuarios " + ex.Message);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                _02LogicaNegocio.Logica.EliminarDato(processoBase());
                MessageBox.Show("Datos Editados Satisfactoriamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos de la tabla de Usuarios " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Usuarios Usuario = new T_Usuarios();
                if (!txtIdUsuario.Text.Equals(""))
                {
                    Usuario.Id_Usuario = Convert.ToInt32(txtIdUsuario.Text.Trim());
                    List<T_Usuarios> lstUsuarios = _02LogicaNegocio.Logica.BuscarDatoA(Usuario);
                    this.dataGrid.DataSource = lstUsuarios;
                    this.dataGrid.Refresh();

                }
                else if (!txtAlias.Text.Equals(""))
                {
                    Usuario.Usuario = txtAlias.Text.Trim();
                    List<T_Usuarios> lstUsuarios = _02LogicaNegocio.Logica.BuscarDatoB(Usuario);
                    this.dataGrid.DataSource = lstUsuarios;
                    this.dataGrid.Refresh();
                }
                else if (!txtNombre.Text.Equals(""))
                {
                    Usuario.Nombre_Usuario = txtNombre.Text.Trim();
                    List<T_Usuarios> lstUsuarios = _02LogicaNegocio.Logica.BuscarDatoC(Usuario);
                    this.dataGrid.DataSource = lstUsuarios;
                    this.dataGrid.Refresh();
                }
                else if (txtIdUsuario.Text.Equals("") && txtAlias.Text.Equals("") && txtNombre.Text.Equals(""))
                {
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar los Datos en la Aplicación " + ex.Message);
            }
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
                this.ComboTipoUsusario.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.ComboEstadoUsuario.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Botones_Excel_Pdf
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
