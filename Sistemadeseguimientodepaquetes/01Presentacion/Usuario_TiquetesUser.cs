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
    public partial class Usuario_TiquetesUser : Form
    {
        public Usuario_TiquetesUser()
        {
            InitializeComponent();
        }
        
        #region Metodo para cargar info del DataGrid
        private void CargarPedidos()
        {
                   }
        #endregion

        #region CargarCombos Metodo
        private void CargarCombos()
        {
            
        
        }
        #endregion

        #region  Botones_Guardar_Buscar_Editar_Eliminar From Administrador_Pedido
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accion Pendiente de Cosntruccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion



        #region Evento Cargar Al Abrir
        private void Usuario_Pedido_Load(object sender, EventArgs e)
        {
            CargarPedidos(); CargarCombos();
        }
        #endregion

        #region EventoDatagrid
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion
    }
}