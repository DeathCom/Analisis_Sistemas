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


namespace _01Presentacion
{
    public partial class FormLogin : Form
    {
        

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

        #region CodigoLoginELIMINARPOSTERIORMENTE
        /*SqlConnection con = new SqlConnection(@"Server=JPRR1ER\SQLSERVER;Database=SeguimientoPaquetesTest;Trusted_Connection=True;");
        public void login(string usuario, string password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM Usuarios Where Usuario = @Usuario AND password = @Password", con);
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "User")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Client")
                    {
                        new Cliente(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }*/
        #endregion

        #region Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                #region ProcesoLogin
                string nombre = txtUsuario.Text;
                this.Hide();

                if (txtUsuario.Text == "Admin" && txtPassword.Text == "0987")
                {
                    new Administrador(nombre).Show();
                }
                else if (txtUsuario.Text == "User" && txtPassword.Text == "6543")
                {
                    new Usuario(nombre).Show();
                }
                else if (txtUsuario.Text == "Supervisor" && txtPassword.Text == "1234")
                {
                    new Cliente(nombre).Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /*MessageBox.Show("Usuario Inactivo",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                    this.Show();
                }
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
