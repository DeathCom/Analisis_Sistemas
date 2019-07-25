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
    public partial class Usuario_TiquetesUser : Form
    {
        string DatoComp = "";
        public Usuario_TiquetesUser(string Usuario)
        {
            InitializeComponent();
            DatoComp = Usuario;
        }
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtNumeroTiquete.Text = "";
            this.txtAplicacion.Text = "";
            this.txtCliente.Text = "";
            this.comboSeveridades.Text = "";
            this.ComboEstados.Text = "";
            this.txtHoraAsignacion.Text = "";
            this.txtComentarios.Text = "";
        }
        #endregion

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            try
            {
                //Listas de asignacion a combos
                List<T_Estado_Tiquetes> lstEstadoTiquetes = _02LogicaNegocio.Logica.obtE_Tiquete();
                List<T_Severidades> lstSeveridades = _02LogicaNegocio.Logica.obtSeveridad();

                ComboEstados.DataSource = lstEstadoTiquetes;
                ComboEstados.ValueMember = "Descripcion_Estado_Tiquete";
                ComboEstados.DisplayMember = "Descripcion_Estado_Tiquete";

                comboSeveridades.DataSource = lstSeveridades;
                comboSeveridades.ValueMember = "Descripcion_Severidad";
                comboSeveridades.DisplayMember = "Descripcion_Severidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información desde la base de datos " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Metodo para cargar info del DataGrid
        private void CargarTiquetes()
        {
            try
            {
                List<T_Tiquete> lstTiquetes = Logica.obtTiquetes();

                foreach (var tiquete in lstTiquetes)
                {
                    if (tiquete.Nombre_Usuario.Equals(DatoComp))
                    {
                        this.dataGridView.Rows.Add(tiquete.Numero_Tiquete, tiquete.Nombre_Supervisor, tiquete.Nombre_Usuario,
                            tiquete.Nombre_Cliente, tiquete.Nombre_Aplicacion, tiquete.Severidad_Tiquete, tiquete.Estado_Tiquete,
                            tiquete.Comentarios_Tiquete, tiquete.HorayFecha_Apertura, tiquete.HorayFecha_Cierre);
                        this.dataGridView.Refresh();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos " + ex.Message); ;
            }
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Tiquete Tiquete = new T_Tiquete();
                Tiquete.Numero_Tiquete = txtNumeroTiquete.Text.Trim();
                Tiquete.Nombre_Supervisor = txtSupervisor.Text;
                Tiquete.Nombre_Usuario = txtUsusario.Text;
                Tiquete.Nombre_Cliente = txtCliente.Text;
                Tiquete.Nombre_Aplicacion = txtAplicacion.Text;
                Tiquete.Severidad_Tiquete = comboSeveridades.Text;
                Tiquete.Estado_Tiquete = ComboEstados.Text;
                Tiquete.Comentarios_Tiquete = txtComentarios.Text;
                Tiquete.HorayFecha_Apertura = Convert.ToDateTime(txtHoraAsignacion.Text);
                Tiquete.HorayFecha_Cierre = System.DateTime.Now;
                _02LogicaNegocio.Logica.ModificarDato(Tiquete);
                MessageBox.Show("Tiquete Actualizado Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Aplicaciones" + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Tiquete Tiquete = new T_Tiquete();
                if (!txtNumeroTiquete.Text.Equals(""))
                {
                    Tiquete.Numero_Tiquete = txtNumeroTiquete.Text.Trim();
                    List<T_Tiquete> lstTiquetes = _02LogicaNegocio.Logica.Buscar_Numero_Tiquete(Tiquete);
                    foreach (var tiquete in lstTiquetes)
                    {
                        this.dataGridView.Rows.Clear();
                        this.dataGridView.Rows.Add (tiquete.Numero_Tiquete, tiquete.Nombre_Supervisor, tiquete.Nombre_Usuario,
                            tiquete.Nombre_Cliente, tiquete.Nombre_Aplicacion, tiquete.Severidad_Tiquete, tiquete.Estado_Tiquete,
                            tiquete.Comentarios_Tiquete, tiquete.HorayFecha_Apertura, tiquete.HorayFecha_Cierre);
                        this.dataGridView.Refresh();
                    }
                }
                else if (txtNumeroTiquete.Text.Equals(""))
                {
                    this.dataGridView.Rows.Clear();
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
        private void Usuario_Pedido_Load(object sender, EventArgs e)
        {
            CargarTiquetes();
            CargarCombos();
        }
        #endregion

        #region EventoDatagrid
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtNumeroTiquete.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtSupervisor.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtUsusario.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtCliente.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtAplicacion.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.comboSeveridades.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.ComboEstados.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.txtComentarios.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.txtHoraAsignacion.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar colocar datos en la casilla" + ex.Message);
            }
        }
        #endregion
    }
}
