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
    public partial class Usuario_Inicio : Form
    {
        string DatoComp = "";
        public Usuario_Inicio(string Usuario)
        {
            InitializeComponent();
            lblTipoUsuario.Text = "Bienvenido (a) "+Usuario;
            DatoComp = Usuario;
            CargarTiquetes();
        }

        private void CargarTiquetes()
        {
            try
            {
                List<T_Tiquete> lstTiquetes = Logica.obtTiquetes();

                foreach (var tiquete in lstTiquetes)
                {
                    if (tiquete.Nombre_Usuario.Equals(DatoComp))
                    {
                        this.dataGridView1.Rows.Add(tiquete.Numero_Tiquete, tiquete.Nombre_Supervisor, tiquete.Nombre_Usuario,
                            tiquete.Nombre_Cliente, tiquete.Nombre_Aplicacion, tiquete.Severidad_Tiquete, tiquete.Estado_Tiquete,
                            tiquete.Comentarios_Tiquete, tiquete.HorayFecha_Apertura, tiquete.HorayFecha_Cierre);
                        this.dataGridView1.Refresh();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar los datos desde la base de datos " + ex.Message); ;
            }
        }
    }
}
