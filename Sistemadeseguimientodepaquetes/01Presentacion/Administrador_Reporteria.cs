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
    public partial class Administrador_Reporteria : Form
    {
        public Administrador_Reporteria()
        {
            InitializeComponent();
        }

        #region Metodo para cargar info del DataGrid
        private void CargarTiquetes()
        {
            try
            {
                List<T_Tiquete> lstTiquetes = Logica.obtTiquetes();
                this.dataGridView.DataSource = lstTiquetes;
                this.dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar Form Administrador_Envio
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Tiquete Tiquete = new T_Tiquete();
                if (!txtBuscar.Text.Equals(""))
                {
                    if (comboOpcion.Text.Equals("Numero de Tiquete"))
                    {
                        Tiquete.Numero_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Numero_Tiquete(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Estado de Tiquete"))
                    {
                        Tiquete.Estado_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Numero_Tiquete(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Nombre del Usuario"))
                    {
                        Tiquete.Nombre_Usuario = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Usuario(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Nombre del Cliente"))
                    {
                        Tiquete.Nombre_Cliente = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Cliente(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Nombre del Supervisor"))
                    {
                        Tiquete.Nombre_Supervisor = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Supervisor(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Severidad del Tiquete"))
                    {
                        Tiquete.Severidad_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Severidad_Tiquete(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                    else if (comboOpcion.Text.Equals("Nombre de la Aplicacion"))
                    {
                        Tiquete.Nombre_Aplicacion = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Aplicacion(Tiquete);
                        this.dataGridView.DataSource = lstTiquetes;
                        this.dataGridView.Refresh();
                    }
                }
                else if (txtBuscar.Text.Equals(""))
                {
                    CargarTiquetes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar los Datos en la Aplicación " + ex.Message);
            }
        }
        #endregion
       
        #region Evento Cargar Al Abrir
        private void Administrador_Envio_Load(object sender, EventArgs e)
        {
            this.CargarTiquetes();
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
