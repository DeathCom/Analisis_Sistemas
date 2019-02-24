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
    public partial class Administrador_Inicio : Form
    {
        public Administrador_Inicio(string Usuario)
        {
            InitializeComponent();
            lblTipoUsuario.Text = "Bienvenido (a) " + Usuario;
        }
    }
}
