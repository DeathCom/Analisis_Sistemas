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
    public partial class Cliente_DoPedido : Form
    {
        public Cliente_DoPedido(string codigo)
        {
            InitializeComponent();
            txtIdUsuario.Text = codigo;
        }

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            
        }
        #endregion

        #region Metodo Limpiar
        public void Limpiar()
        {
            txtIdPedido.Text = "";
            txtIdUsuario.Text = "";
            comboPaisOrigen.Text = "";
            comboPaisDestino.Text = "";
            comboPago.Text = "";
            comboEnvio.Text = "";
            txtIdEstado.Text = "";
            txtTotal.Text = "";
            txtDescripcion.Text = "";
        }
        #endregion

        #region Accion Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Cargar combos
        private void Cliente_DoPedido_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }
        #endregion

        #region Calcular Precio
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //intento hacer que txtTotal.Text se modifique con el precio
            int impuesto = Convert.ToInt32(comboImpuesto.Text);
            int CostEnvio = Convert.ToInt32(comboCostEnvio.Text);
            int Total = impuesto + CostEnvio;
            txtTotal.Text = Total.ToString();
        }
        #endregion
    }
}
