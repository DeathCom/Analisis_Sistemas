﻿using System;
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

    }
}
