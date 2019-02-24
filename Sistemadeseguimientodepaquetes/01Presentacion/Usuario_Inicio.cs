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
    public partial class Usuario_Inicio : Form
    {
        public Usuario_Inicio(string Usuario)
        {
            InitializeComponent();
            lblTipoUsuario.Text = "Bienvenido (a) "+Usuario;
        }
    }
}
