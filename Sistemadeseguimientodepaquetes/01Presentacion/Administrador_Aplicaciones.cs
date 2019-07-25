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
    public partial class Administrador_Aplicaciones : Form
    {
        public Administrador_Aplicaciones()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdAplicacion.Text = "";
            this.txtNomAplicacion.Text = "";
            this.txtDescAplicacion.Text = "";           
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarAplicaciones()
        {
            try
            {
                List<T_Aplicacion> lstAplicaciones = Logica.obtAplicacion();
                this.dataGrid.DataSource = lstAplicaciones;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Origen
        public T_Aplicacion processoBase()
        {
            T_Aplicacion aplicacion = new T_Aplicacion();
            aplicacion.Id_Aplicacion = Convert.ToInt16(txtIdAplicacion.Text.Trim());
            aplicacion.Nombre_Aplicacion = txtNomAplicacion.Text;
            aplicacion.Descripcion_Aplicacion = txtDescAplicacion.Text;
            return aplicacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Aplicacion aplicacion = new T_Aplicacion();
                aplicacion.Id_Aplicacion = Convert.ToInt16(txtIdAplicacion.Text.Trim());
                aplicacion.Nombre_Aplicacion = txtNomAplicacion.Text;
                aplicacion.Descripcion_Aplicacion = txtDescAplicacion.Text;
                _02LogicaNegocio.Logica.GuardarDato(aplicacion);
                MessageBox.Show("Aplicación Guardada Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Aplicaciones" + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de la Aplicación" + ex.Message);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                _02LogicaNegocio.Logica.EliminarDato(processoBase());
                MessageBox.Show("Datos Eliminados Satisfactoriamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos de la Aplicación" + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Aplicacion Aplicaciones = new T_Aplicacion();
                if (!txtIdAplicacion.Text.Equals(""))
                {
                    Aplicaciones.Id_Aplicacion = Convert.ToInt32(txtIdAplicacion.Text.Trim());
                    List<T_Aplicacion> lstAplicaciones = _02LogicaNegocio.Logica.BuscarDatoA(Aplicaciones);
                    this.dataGrid.DataSource = lstAplicaciones;
                    this.dataGrid.Refresh();

                }
                else if (!txtNomAplicacion.Text.Equals(""))
                {
                    Aplicaciones.Nombre_Aplicacion= txtNomAplicacion.Text.Trim();
                    List<T_Aplicacion> lstAplicaciones = _02LogicaNegocio.Logica.BuscarDatoB(Aplicaciones);
                    this.dataGrid.DataSource = lstAplicaciones;
                    this.dataGrid.Refresh();
                }
                else if (txtIdAplicacion.Text.Equals("") && txtNomAplicacion.Text.Equals(""))
                {
                    CargarAplicaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar los Datos en la Aplicación" + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Origen_Load(object sender, EventArgs e)
        {
            this.CargarAplicaciones();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdAplicacion.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtNomAplicacion.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtDescAplicacion.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar colocar datos en la casilla" + ex.Message);
            }
        }
        #endregion

        #region Botones_Excel_Pdf
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Boton de PDF
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Boton de Excel
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}