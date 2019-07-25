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
    public partial class Supervisor_Asignaciones : Form
    {
        public Supervisor_Asignaciones(string codigo)
        {
            InitializeComponent();
            txtSupervisor.Text = codigo;
        }
        #region Metodo Limpiar
        public void Limpiar()
        {
            this.txtNumTiquete.Text = "";
            this.txtSupervisor.Text = "";
            this.comboUsuarios.Text = "";
            this.comboClientes.Text = "";
            this.comboAplicaciones.Text = "";
            this.comboSeveridad.Text = "";
            this.comboEstadoTiquete.Text = "";
            this.txtComentario.Text = "";
        }
        #endregion

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            try
            {
                //Listas de asignacion a combos
                List<T_Usuarios> lstUsuarios = _02LogicaNegocio.Logica.obtUsuarios();
                List<T_Cliente> lstClientes = _02LogicaNegocio.Logica.obtCliente();
                List<T_Aplicacion> lstHerramientas = _02LogicaNegocio.Logica.obtAplicacion();
                List<T_Estado_Tiquetes> lstEstadoTiquetes = _02LogicaNegocio.Logica.obtE_Tiquete();
                List<T_Severidades> lstSeveridades = _02LogicaNegocio.Logica.obtSeveridad();

                foreach (var usuario in lstUsuarios)
                {
                    if (usuario.Tipo_Usuario.Equals("USER"))
                    {
                        comboUsuarios.Items.Add(usuario.Nombre_Usuario);
                        comboUsuarios.ValueMember = "Nombre_Usuario";
                        comboUsuarios.DisplayMember = "Nombre_Usuario";
                    }
                }
                comboClientes.DataSource = lstClientes;
                comboClientes.ValueMember = "Nombre_Cliente";
                comboClientes.DisplayMember = "Nombre_Cliente";

                comboAplicaciones.DataSource = lstHerramientas;
                comboAplicaciones.ValueMember = "Nombre_Aplicacion";
                comboAplicaciones.DisplayMember = "Nombre_Aplicacion";

                comboEstadoTiquete.DataSource = lstEstadoTiquetes;
                comboEstadoTiquete.ValueMember = "Descripcion_Estado_Tiquete";
                comboEstadoTiquete.DisplayMember = "Descripcion_Estado_Tiquete";

                comboSeveridad.DataSource = lstSeveridades;
                comboSeveridad.ValueMember = "Descripcion_Severidad";
                comboSeveridad.DisplayMember = "Descripcion_Severidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información desde la base de datos " + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Accion Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                T_Tiquete Tiquete = new T_Tiquete();
                Tiquete.Numero_Tiquete = txtNumTiquete.Text.Trim();
                Tiquete.Nombre_Supervisor = txtSupervisor.Text;
                Tiquete.Nombre_Usuario = comboUsuarios.Text;
                Tiquete.Nombre_Cliente = comboClientes.Text;
                Tiquete.Nombre_Aplicacion = comboAplicaciones.Text;
                Tiquete.Severidad_Tiquete = comboSeveridad.Text;
                Tiquete.Estado_Tiquete = comboEstadoTiquete.Text;
                Tiquete.Comentarios_Tiquete = txtComentario.Text;
                Tiquete.HorayFecha_Apertura = System.DateTime.Now;
                Tiquete.HorayFecha_Apertura = System.DateTime.Now;
                _02LogicaNegocio.Logica.GuardarDato(Tiquete);
                MessageBox.Show("Tiquete Guardado Exitosamente");
                Limpiar(); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar Datos en Tabla de Aplicaciones" + ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Cargar combos
        private void Cliente_DoPedido_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        #endregion

        

    }
}
