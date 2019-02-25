using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _01Presentacion
{
    public partial class Cliente_Asignaciones : Form
    {
        public Cliente_Asignaciones(string codigo)
        {
            InitializeComponent();
            txtIdUsuario.Text = codigo;
        }

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            
        }
        #endregion

        #region Accion Botones
        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
