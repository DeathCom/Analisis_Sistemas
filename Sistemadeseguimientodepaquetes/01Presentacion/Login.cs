using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //para poder mover la ventana
using System.Data.SqlClient; //para conexion de db quitar despues de las pruebas
using _02LogicaNegocio;
using _04Entidades;


namespace _01Presentacion
{
    public partial class FormLogin : Form
    {
        //referenciamos las librerias de Entidades y Logica de negocions
        _04Entidades.SQLSentencia objE = new _04Entidades.SQLSentencia();
        _02LogicaNegocio.Logica objLN = new _02LogicaNegocio.Logica();

        public FormLogin()
        {
            InitializeComponent();
        }
        #region BotonesBarraArriba
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region CodigoMoverVentana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /*buscamos en la barra de arriba el evento MouseDown, le damos
         doble click y se agrega:
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        */
        private void BarraPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                #region ProcesoLogin_Analisis
                //string nombre = txtUsuario.Text;
                //this.Hide();

                //if (txtUsuario.Text == "Admin" && txtPassword.Text == "0987")
                //{
                //    new Administrador(nombre).Show();
                //}
                //else if (txtUsuario.Text == "User" && txtPassword.Text == "6543")
                //{
                //    new Usuario(nombre).Show();
                //}
                //else if (txtUsuario.Text == "Supervisor" && txtPassword.Text == "1234")
                //{
                //    new Supervisor(nombre).Show();
                //}
                //else
                //{
                //    MessageBox.Show("Usuario o contraseña Invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    /*MessageBox.Show("Usuario Inactivo",
                //                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                //    this.Show();
                //}
                #endregion
                #region Proceso_Login_Teoria_Sistemas
                DataTable dt = new DataTable();
                objE.iduser = txtUsuario.Text;
                objE.password = txtPassword.Text;
                dt = objLN.LNlogin(objE);

                //creo objeto Usuario
                T_Usuarios user = new T_Usuarios();
                user.Usuario = dt.Rows[0][0].ToString(); 
                user.Nombre_Usuario = dt.Rows[0][1].ToString();
                user.Contrasena_Usuario = dt.Rows[0][2].ToString();
                user.Estado_Usuario = dt.Rows[0][3].ToString();
                user.Tipo_Usuario = dt.Rows[0][4].ToString();

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (user.Estado_Usuario.Equals("ACTIVO"))
                    {
                        if (user.Tipo_Usuario.Equals("ADMIN"))
                        {
                            new Administrador(user.Nombre_Usuario).Show();
                        }
                        else if (user.Tipo_Usuario.Equals("USER"))
                        {
                            new Usuario(user.Nombre_Usuario).Show();
                        }
                        else if (user.Tipo_Usuario.Equals("SUPERVISOR"))
                        {
                            new Supervisor(user.Nombre_Usuario).Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inactivo",
                                   "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Show();
                    }
                }
                /*else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }*/
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña Invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
