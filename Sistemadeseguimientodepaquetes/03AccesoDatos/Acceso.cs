using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04Entidades;
using System.Data;

namespace _03AccesoDatos
{
    public class Acceso
    {
        #region Atributos

        private string cadenaConexion = Properties.Settings.Default.Conexion;
        private SqlConnection objConexion;

        #endregion

        #region Constructor

        public Acceso()
        {
            try
            {
                //iniciamos la conexion con la base de datos
                objConexion = new SqlConnection(cadenaConexion);
                ABRIR(); //Llamamos el metodo Abrir para abrirr la conexion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR(); //Llamamos el metodo Cerrar para cerrar la conexion
            }
        }

        #endregion

        #region Metodos para Abrir y cerrar Conexion

        private void ABRIR() //metodo para verificar si la conexion esta cerrada y abrirla
        {
            if (objConexion.State == System.Data.ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }
        private void CERRAR()//metodo para verificar si la conexion esta abierta y cerrarla
        {
            if (objConexion.State == System.Data.ConnectionState.Open)
            {
                objConexion.Close();
            }
        }

        #endregion

        #region Metodo para enjecutar de Logica(update,delete,add)
        public int EjecutarSentencia(SQLSentencia objPeticion)
        {
            /*Este metodo se puede utilizar para actualizar, insertar o eliminar info en las tablas de la db*/
            try
            {
                SqlCommand cmd = new SqlCommand(); //instaciamos configuracion para hace4r peticiones por medio del  SqlCommand
                cmd.Connection = objConexion; //asgnacion de la conexion
                cmd.CommandText = objPeticion.PETICION; //Asignamos la peticion a ejecutar
                cmd.CommandType = System.Data.CommandType.Text; //determinamos el tipo de data
                if (objPeticion.LSTPARAMETROS.Count > 0)
                {
                    cmd.Parameters.AddRange(objPeticion.LSTPARAMETROS.ToArray());
                }
                ABRIR(); //abrimos la conexion
                return cmd.ExecuteNonQuery(); //Ejecutamos la peticion almacenada en cmd.CommandText
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }
        #endregion

        #region Metod para obtener Informacion de las Tablas
        #region Administrador_Aplicaciones
        public List<T_Aplicacion> Obtener_Aplicaciones(SQLSentencia objsentencia)
        {
            List<T_Aplicacion> lstAplicacion = new List<T_Aplicacion>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = objsentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);

                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Aplicacion objAplicacion = new T_Aplicacion();
                    objAplicacion.Id_Aplicacion = Convert.ToInt16(item.ItemArray[0].ToString());
                    objAplicacion.Nombre_Aplicacion = item.ItemArray[1].ToString();
                    objAplicacion.Descripcion_Aplicacion = item.ItemArray[2].ToString();
                    lstAplicacion.Add(objAplicacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstAplicacion;
        }
        #endregion

        #region Administrador_Estados_Tiquetes_Clientes
        public List<T_Estado_Tiquetes> Obtener_Estado_Tiquetes(SQLSentencia objsentencia)
        {
            List<T_Estado_Tiquetes> lstEstado_Tiquetes = new List<T_Estado_Tiquetes>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = objsentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);

                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Estado_Tiquetes objEstado_Tiquetes = new T_Estado_Tiquetes();
                    objEstado_Tiquetes.Id_Estado_Tiquete = Convert.ToInt16(item.ItemArray[0].ToString());
                    objEstado_Tiquetes.Descripcion_Estado_Tiquete = item.ItemArray[1].ToString();
                    lstEstado_Tiquetes.Add(objEstado_Tiquetes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstEstado_Tiquetes;
        }
        //public List<T_Estado_Clientes> Obtener_Estado_Clientes(SQLSentencia objsentencia)
        //{
        //    List<T_Estado_Clientes> lstEstado_Clientes = new List<T_Estado_Clientes>();
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.CommandText = objsentencia.PETICION;
        //        cmd.Connection = objConexion;
        //        cmd.CommandType = System.Data.CommandType.Text;

        //        SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
        //        objcarga.Fill(dt);

        //        foreach (System.Data.DataRow item in dt.Rows)
        //        {
        //            T_Estado_Clientes objEstado_Clientes = new T_Estado_Clientes();
        //            objEstado_Clientes.Id_Estado_Clientes = Convert.ToInt16(item.ItemArray[0].ToString());
        //            objEstado_Clientes.Descripcion_Estado_Clientes = item.ItemArray[1].ToString();
        //            lstEstado_Clientes.Add(objEstado_Clientes);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.CERRAR();
        //    }

        //    return lstEstado_Clientes;
        //}
        #endregion

        #region Administrador_Clientes
        public List<T_Cliente> Obtener_Clientes(SQLSentencia objsentencia)
        {
            List<T_Cliente> lstClientes= new List<T_Cliente>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = objsentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);

                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Cliente objCliente = new T_Cliente();
                    objCliente.Id_Cliente = Convert.ToInt16(item.ItemArray[0].ToString());
                    objCliente.Nombre_Cliente= item.ItemArray[1].ToString();
                    objCliente.Telefono_Cliente = item.ItemArray[2].ToString();
                    objCliente.Correo_Cliente = item.ItemArray[3].ToString();
                    objCliente.Region_Cliente = item.ItemArray[4].ToString();
                    objCliente.Pais_Cliente = item.ItemArray[5].ToString();
                    objCliente.Focal_Cliente = item.ItemArray[6].ToString();
                    objCliente.Tipo_Servidor = item.ItemArray[7].ToString();
                    objCliente.Nombre_Servidor = item.ItemArray[8].ToString();
                    objCliente.Ip_Servidor = item.ItemArray[9].ToString();
                    objCliente.Estado_Servidor = item.ItemArray[10].ToString();
                    lstClientes.Add(objCliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstClientes;
        }
        #endregion

        #region Administrador_Roles
        //public List<T_Roles> Obtener_Roles(SQLSentencia objsentencia)
        //{
        //    List<T_Roles> lstRoles = new List<T_Roles>();
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.CommandText = objsentencia.PETICION;
        //        cmd.Connection = objConexion;
        //        cmd.CommandType = System.Data.CommandType.Text;

        //        SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
        //        objcarga.Fill(dt);

        //        foreach (System.Data.DataRow item in dt.Rows)
        //        {
        //            T_Roles objRol = new T_Roles();
        //            objRol.Id_Rol = Convert.ToInt16(item.ItemArray[0].ToString());
        //            objRol.Nombre_Rol = item.ItemArray[1].ToString();
        //            objRol.Descripcion_Rol = item.ItemArray[2].ToString();
        //            lstRoles.Add(objRol);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.CERRAR();
        //    }

        //    return lstRoles;
        //}
        #endregion

        #region Administrador_Severidades
        public List<T_Severidades> Obtener_Severidades(SQLSentencia objSentencia)
        {
            List<T_Severidades> lstSeveridades = new List<T_Severidades>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = objSentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);
                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Severidades objSeveridades = new T_Severidades();
                    objSeveridades.Severidad = Convert.ToInt32(item.ItemArray[0].ToString());
                    objSeveridades.Descripcion_Severidad = item.ItemArray[1].ToString();
                    lstSeveridades.Add(objSeveridades);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CERRAR();
            }
            return lstSeveridades;
        }

        #endregion

        #region Administrador_Usuarios
        public List<T_Usuarios> Obtener_Usuarios(SQLSentencia objSentencia)
        {
            List<T_Usuarios> lstUsuarios = new List<T_Usuarios>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = objSentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);
                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Usuarios objUsuario = new T_Usuarios();
                    objUsuario.Id_Usuario = Convert.ToInt32(item.ItemArray[0].ToString());
                    objUsuario.Usuario = item.ItemArray[1].ToString();
                    objUsuario.Nombre_Usuario = item.ItemArray[2].ToString();
                    objUsuario.Contrasena_Usuario = item.ItemArray[3].ToString();
                    objUsuario.Estado_Usuario = item.ItemArray[4].ToString();
                    objUsuario.Tipo_Usuario = item.ItemArray[5].ToString();
                    lstUsuarios.Add(objUsuario);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CERRAR();
            }
            return lstUsuarios;
        }
        #endregion

        #region Administrador_Tiquetes
        public List<T_Tiquete> Obtener_Tiquetes(SQLSentencia objsentencia)
        {
            List<T_Tiquete> lstTiquetes = new List<T_Tiquete>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = objsentencia.PETICION;
                cmd.Connection = objConexion;
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter objcarga = new SqlDataAdapter(cmd);
                objcarga.Fill(dt);

                foreach (System.Data.DataRow item in dt.Rows)
                {
                    T_Tiquete objTiquete = new T_Tiquete();
                    objTiquete.Numero_Tiquete = item.ItemArray[0].ToString();
                    objTiquete.Nombre_Supervisor = item.ItemArray[1].ToString();
                    objTiquete.Nombre_Usuario = item.ItemArray[2].ToString();
                    objTiquete.Nombre_Cliente = item.ItemArray[3].ToString();
                    objTiquete.Nombre_Aplicacion = item.ItemArray[4].ToString();
                    objTiquete.Severidad_Tiquete = item.ItemArray[5].ToString();
                    objTiquete.Estado_Tiquete = item.ItemArray[6].ToString();
                    objTiquete.Comentarios_Tiquete = item.ItemArray[7].ToString();
                    objTiquete.HorayFecha_Apertura = Convert.ToDateTime(item.ItemArray[8].ToString());
                    objTiquete.HorayFecha_Cierre = Convert.ToDateTime(item.ItemArray[9].ToString());
                    lstTiquetes.Add(objTiquete);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstTiquetes;
        }
        #endregion
        #endregion

        #region ProcesoLogin
        public DataTable Login(_04Entidades.SQLSentencia objE)
        {
            SqlCommand cmd = new SqlCommand("LOGIN", objConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDUSER", objE.iduser);
            cmd.Parameters.AddWithValue("@PASSW", objE.password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            sda.Fill(datatable);
            return datatable;
        }
        #endregion
    }
}
