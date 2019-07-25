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
    public partial class Supervisor_Reporteria : Form
    {
        public Supervisor_Reporteria(string codigo)
        {
            InitializeComponent();
            CargarTiquetes();
        }

        #region Metodo para cargar info del DataGrid
        private void CargarTiquetes()
        {
            try
            {
                List<T_Tiquete> lstTiquetes = Logica.obtTiquetes();
                this.dataGridView1.DataSource = lstTiquetes;
                this.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos" + ex.Message); ;
            }
        }
        #endregion

        #region  Boton_Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                T_Tiquete Tiquete = new T_Tiquete();
                if (!txtBuscar.Text.Equals(""))
                {
                    if (comboBuscarPor.Text.Equals("Numero de Tiquete"))
                    {
                        Tiquete.Numero_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Numero_Tiquete(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Estado de Tiquete"))
                    {
                        Tiquete.Estado_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Numero_Tiquete(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Nombre del Usuario"))
                    {
                        Tiquete.Nombre_Usuario = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Usuario(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Nombre del Cliente"))
                    {
                        Tiquete.Nombre_Cliente = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Cliente(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Nombre del Supervisor"))
                    {
                        Tiquete.Nombre_Supervisor = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Supervisor(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Severidad del Tiquete"))
                    {
                        Tiquete.Severidad_Tiquete = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Severidad_Tiquete(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
                    }
                    else if (comboBuscarPor.Text.Equals("Nombre de la Aplicacion"))
                    {
                        Tiquete.Nombre_Aplicacion = txtBuscar.Text.Trim();
                        List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Nombre_Aplicacion(Tiquete);
                        this.dataGridView1.DataSource = lstTiquetes;
                        this.dataGridView1.Refresh();
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

        #region Cargar_Datagrid
        private void Cliente_Pedido_Load(object sender, EventArgs e)
        {
            CargarTiquetes();
        }
        #endregion

        #region Botones_Excel_Pdf
        private void btnPDF_Click_1(object sender, EventArgs e)
        {

        }
        private void btnExcel_Click_1(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
