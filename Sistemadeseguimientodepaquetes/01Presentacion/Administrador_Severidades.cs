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
    public partial class Administrador_Severidades : Form
    {
        public Administrador_Severidades()
        {
            InitializeComponent();
        }

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtSeveridad.Text = "";
            this.txtDescSeveridad.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarSeveridades()
        {
            try
            {
                List<T_Severidades> lstSeveridades = Logica.obtSeveridad();
                this.dataGrid.DataSource = lstSeveridades;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos " + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Pago
        public T_Severidades processoBase()
        {
            T_Severidades Severidad = new T_Severidades();
            Severidad.Severidad = Convert.ToInt16(txtSeveridad.Text.Trim());
            Severidad.Descripcion_Severidad = txtDescSeveridad.Text;
            return Severidad;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Severidades Severidad = new T_Severidades();
                Severidad.Severidad = Convert.ToInt16(txtSeveridad.Text.Trim());
                Severidad.Descripcion_Severidad = txtDescSeveridad.Text;
                _02LogicaNegocio.Logica.GuardarDato(Severidad);
                MessageBox.Show("Datos Guardados Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Severidades " + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de la tabla de Severidades " + ex.Message);
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
                MessageBox.Show("Error al Eliminar Datos de la tabla de Severidadess " + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Severidades Severidad = new T_Severidades();
                if (!txtSeveridad.Text.Equals(""))
                {
                    Severidad.Severidad = Convert.ToInt32(txtSeveridad.Text.Trim());
                    List<T_Severidades> lstSeveridades = _02LogicaNegocio.Logica.BuscarDatoA(Severidad);
                    this.dataGrid.DataSource = lstSeveridades;
                    this.dataGrid.Refresh();

                }
                else if (!txtDescSeveridad.Text.Equals(""))
                {
                    Severidad.Descripcion_Severidad = txtDescSeveridad.Text.Trim();
                    List<T_Severidades> lstSeveridades = _02LogicaNegocio.Logica.BuscarDatoB(Severidad);
                    this.dataGrid.DataSource = lstSeveridades;
                    this.dataGrid.Refresh();
                }
                else if (txtSeveridad.Text.Equals("") && txtDescSeveridad.Text.Equals(""))
                {
                    CargarSeveridades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar los Datos en la Aplicación " + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Pago_Load(object sender, EventArgs e)
        {
            CargarSeveridades();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtSeveridad.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescSeveridad.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}

    
