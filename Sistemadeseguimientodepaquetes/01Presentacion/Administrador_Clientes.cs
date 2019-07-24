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
    public partial class Administrador_Clientes : Form
    {
        public Administrador_Clientes()
        {
            InitializeComponent();
        }
        //#region Cargar_Combo_Estados_Cliente
        //private void CargarCombos()
        //{
        //    try
        //    {
        //        //Listas de asignacion a combos
        //        List<T_Estado_Clientes> lstEstados = _02LogicaNegocio.Logica.obtE_Cliente();

        //        //Asigancion del listado a la fuente de datos del elemento
        //        ComboEstadoServer.DataSource = lstEstados;

        //        //Especificacion de campos de la fuente de datos a cada caracteristica del
        //        //combo. El valuemember es el valor escondido
        //        ComboEstadoServer.ValueMember = "Estado_Servidor";
        //        ComboEstadoServer.DisplayMember = "Estado_Servidor";
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        //#endregion

        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtIdCliente.Text = "";
            this.txtNomCliente.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.comboRegion.Text = "";
            this.txtPais.Text = "";
            this.txtFocal.Text = "";
            this.comboTipoServer.Text = "";
            this.txtNomServer.Text = "";
            this.txtIpServer.Text = "";
            this.ComboEstadoServer.Text = "";
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarClientes()
        {
            try
            {
                List<T_Cliente> lstAplicaciones = Logica.obtCliente();
                this.dataGrid.DataSource = lstAplicaciones;
                this.dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        public T_Cliente processoBase()
        {
            T_Cliente Cliente = new T_Cliente();
            Cliente.Id_Cliente = Convert.ToInt32(txtIdCliente.Text.Trim());
            Cliente.Nombre_Cliente = txtNomCliente.Text;
            Cliente.Telefono_Cliente = txtTelefono.Text;
            Cliente.Correo_Cliente = txtCorreo.Text;
            Cliente.Region_Cliente = comboRegion.Text;
            Cliente.Pais_Cliente = txtPais.Text;
            Cliente.Focal_Cliente = txtFocal.Text;
            Cliente.Tipo_Servidor = comboTipoServer.Text;
            Cliente.Nombre_Servidor = txtNomServer.Text;
            Cliente.Ip_Servidor = txtIpServer.Text;
            Cliente.Estado_Servidor = ComboEstadoServer.Text;
            return Cliente;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Cliente Cliente = new T_Cliente();
                Cliente.Id_Cliente = Convert.ToInt16(txtIdCliente.Text.Trim());
                Cliente.Nombre_Cliente = txtNomCliente.Text;
                Cliente.Telefono_Cliente = txtTelefono.Text;
                Cliente.Correo_Cliente = txtCorreo.Text;
                Cliente.Region_Cliente = comboRegion.Text;
                Cliente.Pais_Cliente = txtPais.Text;
                Cliente.Focal_Cliente = txtFocal.Text;
                Cliente.Tipo_Servidor = comboTipoServer.Text;
                Cliente.Nombre_Servidor = txtNomServer.Text;
                Cliente.Estado_Servidor = ComboEstadoServer.Text;
                Cliente.Ip_Servidor = txtIpServer.Text;
                _02LogicaNegocio.Logica.GuardarDatoCliente(Cliente);
                MessageBox.Show("Cliente Guardado Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Clientes " + ex.Message);
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
                MessageBox.Show("Error al Editar Datos de la Clientes" + ex.Message);
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
                T_Cliente Clientes = new T_Cliente();
                if (!txtIdCliente.Text.Equals(""))
                {
                    Clientes.Id_Cliente = Convert.ToInt32(txtIdCliente.Text.Trim());
                    List<T_Cliente> lstAplicaciones = _02LogicaNegocio.Logica.BuscarDatoA(Clientes);
                    this.dataGrid.DataSource = lstAplicaciones;
                    this.dataGrid.Refresh();

                }
                else if (!txtNomCliente.Text.Equals(""))
                {
                    Clientes.Nombre_Cliente = txtNomCliente.Text.Trim();
                    List<T_Cliente> lstAplicaciones = _02LogicaNegocio.Logica.BuscarDatoB(Clientes);
                    this.dataGrid.DataSource = lstAplicaciones;
                    this.dataGrid.Refresh();
                }
                else if (txtIdCliente.Text.Equals("") && txtNomCliente.Text.Equals(""))
                {
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar los Datos en la Aplicación" + ex.Message);
            }
        }
        #endregion

        #region Evento Cargar Al Abrir
        private void Administrador_Pedido_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdCliente.Text = dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtNomCliente.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtTelefono.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtCorreo.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.comboRegion.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtPais.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txtFocal.Text = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.comboTipoServer.Text = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.txtNomServer.Text = dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.txtIpServer.Text = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                this.ComboEstadoServer.Text = dataGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar colocar datos en la casilla" + ex.Message);
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
