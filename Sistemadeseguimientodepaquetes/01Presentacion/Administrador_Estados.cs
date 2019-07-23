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
    public partial class Administrador_Estados : Form
    {
        public Administrador_Estados()
        {
            InitializeComponent();
        }
       
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtEstado.Text = "";
            this.txtDescEstado.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarEstadosClientes()
        {
            try
            {
                List<T_Estado_Clientes> lstEstadoClientes = Logica.obtE_Cliente();
                this.dataGridEstCliente.DataSource = lstEstadoClientes;
                this.dataGridEstCliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        private void CargarEstadosTiquete()
        {
            try
            {
                List<T_Estado_Tiquetes> lstEstadoTiquetes = Logica.obtE_Tiquete();
                this.dataGridEstTiquete.DataSource = lstEstadoTiquetes;
                this.dataGridEstTiquete.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_ESTADO
        public T_Estado_Clientes processoBaseEstClientes()
        {
            T_Estado_Clientes EstClientes = new T_Estado_Clientes();
            EstClientes.Id_Estado_Clientes = Convert.ToInt16(txtEstado.Text.Trim());
            EstClientes.Descripcion_Estado_Clientes = txtDescEstado.Text;
            return EstClientes;
        }
        public T_Estado_Tiquetes processoBaseEstTiquetes()
        {
            T_Estado_Tiquetes EstTiquetes = new T_Estado_Tiquetes();
            EstTiquetes.Id_Estado_Tiquete = Convert.ToInt16(txtEstado.Text.Trim());
            EstTiquetes.Descripcion_Estado_Tiquete = txtDescEstado.Text;
            return EstTiquetes;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ComboSelecCliente_tiquete.Text.Equals("Tiquetes"))
            {
                try
                {
                    T_Estado_Tiquetes EstTiquetes = new T_Estado_Tiquetes();
                    EstTiquetes.Id_Estado_Tiquete = Convert.ToInt16(txtEstado.Text.Trim());
                    EstTiquetes.Descripcion_Estado_Tiquete = txtDescEstado.Text;
                    _02LogicaNegocio.Logica.GuardarDato(EstTiquetes);
                    MessageBox.Show("Datos Guardados Exitosamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar Datos en Tabla de Estado de los Tiquetes" + ex.Message);
                }
            }
            if (ComboSelecCliente_tiquete.Text.Equals("Clientes"))
            {
                try
                {
                    T_Estado_Clientes EstClientes = new T_Estado_Clientes();
                    EstClientes.Id_Estado_Clientes = Convert.ToInt16(txtEstado.Text.Trim());
                    EstClientes.Descripcion_Estado_Clientes = txtDescEstado.Text;
                    MessageBox.Show("Datos Guardados Exitosamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar Datos en Tabla de Estado de los Clientes" + ex.Message);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ComboSelecCliente_tiquete.Text.Equals("Tiquetes"))
            {
                try
                {
                    _02LogicaNegocio.Logica.ModificarDato(processoBaseEstTiquetes());
                    MessageBox.Show("Datos Editados Satisfactoriamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Editar Datos de la tabla de Estados para tiquetes" + ex.Message);
                }
            }
            else
            {
                try
                {
                    _02LogicaNegocio.Logica.ModificarDato(processoBaseEstClientes());
                    MessageBox.Show("Datos Editados Satisfactoriamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Editar Datos de la tabla de Estados para clientes" + ex.Message);
                }
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ComboSelecCliente_tiquete.Text.Equals("Tiquetes"))
            {
                try
                {
                    _02LogicaNegocio.Logica.EliminarDato(processoBaseEstTiquetes());
                    MessageBox.Show("Datos Eliminados Satisfactoriamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Eliminar Datos de la tabla de Estados para Tiquete" + ex.Message);
                }
            }
            else
            {
                try
                {
                    _02LogicaNegocio.Logica.EliminarDato(processoBaseEstClientes());
                    MessageBox.Show("Datos Eliminados Satisfactoriamente");
                    Limpiar(); this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Eliminar Datos de la tabla de Estados para Clientes" + ex.Message);
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ComboSelecCliente_tiquete.Text.Equals("Tiquetes"))
            {
                try
                {
                    T_Estado_Tiquetes EstTiquetes = new T_Estado_Tiquetes();
                    if (!txtEstado.Text.Equals(""))
                    {
                        EstTiquetes.Id_Estado_Tiquete = Convert.ToInt32(txtEstado.Text.Trim());
                        List<T_Estado_Tiquetes> lstEstadoTiquetes = _02LogicaNegocio.Logica.BuscarDatoA(EstTiquetes);
                        this.dataGridEstTiquete.DataSource = lstEstadoTiquetes;
                        this.dataGridEstTiquete.Refresh();

                    }
                    else if (!txtDescEstado.Text.Equals(""))
                    {
                        EstTiquetes.Descripcion_Estado_Tiquete = txtDescEstado.Text.Trim();
                        List<T_Estado_Tiquetes> lstEstadoTiquetes = _02LogicaNegocio.Logica.BuscarDatoB(EstTiquetes);
                        this.dataGridEstTiquete.DataSource = lstEstadoTiquetes;
                        this.dataGridEstTiquete.Refresh();
                    }
                    else if (txtEstado.Text.Equals("") && txtDescEstado.Text.Equals(""))
                    {
                        CargarEstadosTiquete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al encontrar los Datos en la Aplicación" + ex.Message);
                }
            }
            else
            {
                try
                {
                    T_Estado_Clientes EstClientes = new T_Estado_Clientes();
                    if (!txtEstado.Text.Equals(""))
                    {
                        EstClientes.Id_Estado_Clientes = Convert.ToInt32(txtEstado.Text.Trim());
                        List<T_Estado_Clientes> lstEstadoClientes = _02LogicaNegocio.Logica.BuscarDatoA(EstClientes);
                        this.dataGridEstCliente.DataSource = lstEstadoClientes;
                        this.dataGridEstCliente.Refresh();

                    }
                    else if (!txtDescEstado.Text.Equals(""))
                    {
                        EstClientes.Descripcion_Estado_Clientes = txtDescEstado.Text.Trim();
                        List<T_Estado_Clientes> lstEstadoClientes = _02LogicaNegocio.Logica.BuscarDatoB(EstClientes);
                        this.dataGridEstCliente.DataSource = lstEstadoClientes;
                        this.dataGridEstCliente.Refresh();
                    }
                    else if (txtEstado.Text.Equals("") && txtDescEstado.Text.Equals(""))
                    {
                        this.CargarEstadosClientes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al encontrar los Datos en la Aplicación " + ex.Message);
                }
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Estado_Load(object sender, EventArgs e)
        {
            this.CargarEstadosClientes();
            this.CargarEstadosTiquete();
        }
        #endregion

        #region EventoDatagrid
        private void dataGridEstTiquete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtEstado.Text = dataGridEstTiquete.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescEstado.Text = dataGridEstTiquete.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dataGridEstCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtEstado.Text = dataGridEstCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtDescEstado.Text = dataGridEstCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
