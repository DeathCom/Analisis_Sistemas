using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03AccesoDatos;
using _04Entidades;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace _02LogicaNegocio
{
    public class Logica
    {
        #region ProcesoLogin
        _03AccesoDatos.Acceso objAD = new _03AccesoDatos.Acceso();

        public DataTable LNlogin(_04Entidades.SQLSentencia objE)
        {
            try
            {
                return objAD.Login(objE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tablas

        #region Metodos Para Tabla T_Aplicacion 
        public static void GuardarDato(T_Aplicacion Aplicacion) //Metodo para Agregar informacion a la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Aplicacion VALUES (@Id_Aplicacion,@Nombre_Aplicacion,@Descripcion_Aplicacion)";
                #region Parametrización
                SqlParameter Id_Aplicacion = new SqlParameter();
                Id_Aplicacion.SqlDbType = System.Data.SqlDbType.Int;
                Id_Aplicacion.ParameterName = "@Id_Aplicacion";
                Id_Aplicacion.Value = Aplicacion.Id_Aplicacion;

                SqlParameter Nombre_Aplicacion = new SqlParameter();
                Nombre_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Aplicacion.ParameterName = "@Nombre_Aplicacion";
                Nombre_Aplicacion.Value = Aplicacion.Nombre_Aplicacion;

                SqlParameter Descripcion_Aplicacion = new SqlParameter();
                Descripcion_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Aplicacion.ParameterName = "@Descripcion_Aplicacion";
                Descripcion_Aplicacion.Value = Aplicacion.Descripcion_Aplicacion;

                listParametros.Add(Id_Aplicacion);
                listParametros.Add(Nombre_Aplicacion);
                listParametros.Add(Descripcion_Aplicacion);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion

                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void ModificarDato(T_Aplicacion Aplicacion) //Metodo para Modificar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE T_Aplicacion SET Nombre_Aplicacion= @Nombre_Aplicacion, Descripcion_Aplicacion= @Descripcion_Aplicacion WHERE Id_Aplicacion= @Id_Aplicacion";

                #region Parametrización
                SqlParameter Id_Aplicacion = new SqlParameter();
                Id_Aplicacion.SqlDbType = System.Data.SqlDbType.Int;
                Id_Aplicacion.ParameterName = "@Id_Aplicacion";
                Id_Aplicacion.Value = Aplicacion.Id_Aplicacion;

                SqlParameter Nombre_Aplicacion = new SqlParameter();
                Nombre_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Aplicacion.ParameterName = "@Nombre_Aplicacion";
                Nombre_Aplicacion.Value = Aplicacion.Nombre_Aplicacion;

                SqlParameter Descripcion_Aplicacion = new SqlParameter();
                Descripcion_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Aplicacion.ParameterName = "@Descripcion_Aplicacion";
                Descripcion_Aplicacion.Value = Aplicacion.Descripcion_Aplicacion;

                listParametros.Add(Id_Aplicacion);
                listParametros.Add(Nombre_Aplicacion);
                listParametros.Add(Descripcion_Aplicacion);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion

                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void EliminarDato(T_Aplicacion Aplicacion) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM T_Aplicacion WHERE Id_Aplicacion= @Id_Aplicacion";
                #region Parametrización
                SqlParameter Id_Aplicacion = new SqlParameter();
                Id_Aplicacion.SqlDbType = System.Data.SqlDbType.Int;
                Id_Aplicacion.ParameterName = "@Id_Aplicacion";
                Id_Aplicacion.Value = Aplicacion.Id_Aplicacion;

                listParametros.Add(Id_Aplicacion);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<T_Aplicacion> obtAplicacion()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Aplicacion, Nombre_Aplicacion, Descripcion_Aplicacion FROM T_Aplicacion";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Aplicaciones(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Aplicacion> BuscarDatoA(T_Aplicacion Aplicacion) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Aplicacion, Nombre_Aplicacion, Descripcion_Aplicacion FROM T_Aplicacion WHERE Id_Aplicacion='" + Aplicacion.Id_Aplicacion + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Aplicaciones(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Aplicacion> BuscarDatoB(T_Aplicacion Aplicacion) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Aplicacion, Nombre_Aplicacion, Descripcion_Aplicacion FROM T_Aplicacion WHERE Nombre_Aplicacion='" + Aplicacion.Nombre_Aplicacion + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Aplicaciones(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region Metodos Para Tabla T_Estado_Tiquetes 
        public static void GuardarDato(T_Estado_Tiquetes E_Tiquete) //Metodo para Agregar informacion a la tabla Envio
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Estado_Tiquetes VALUES (@Id_Estado_Tiquete, @Descripcion_Estado_Tiquete)";
                #region Parametrización
                SqlParameter Id_Estado_Tiquete = new SqlParameter();
                Id_Estado_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Tiquete.ParameterName = "@Id_Estado_Tiquete";
                Id_Estado_Tiquete.Value = E_Tiquete.Id_Estado_Tiquete;

                SqlParameter Descripcion_Estado_Tiquete = new SqlParameter();
                Descripcion_Estado_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Estado_Tiquete.ParameterName = "@Descripcion_Estado_Tiquete";
                Descripcion_Estado_Tiquete.Value = E_Tiquete.Descripcion_Estado_Tiquete;

                listParametros.Add(Id_Estado_Tiquete);
                listParametros.Add(Descripcion_Estado_Tiquete);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void ModificarDato(T_Estado_Tiquetes E_Tiquete) //Metodo para Modificar informacion en la tabla envio

        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE T_Estado_Tiquetes SET Descripcion_Estado_Tiquete= @Descripcion_Estado_Tiquete WHERE Id_Estado_Tiquete= @Id_Estado_Tiquete";
                #region Parametrización
                SqlParameter Id_Estado_Tiquete = new SqlParameter();
                Id_Estado_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Tiquete.ParameterName = "@Id_Estado_Tiquete";
                Id_Estado_Tiquete.Value = E_Tiquete.Id_Estado_Tiquete;

                SqlParameter Descripcion_Estado_Tiquete = new SqlParameter();
                Descripcion_Estado_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Estado_Tiquete.ParameterName = "@Descripcion_Estado_Tiquete";
                Descripcion_Estado_Tiquete.Value = E_Tiquete.Descripcion_Estado_Tiquete;

                listParametros.Add(Id_Estado_Tiquete);
                listParametros.Add(Descripcion_Estado_Tiquete);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void EliminarDato(T_Estado_Tiquetes E_Tiquete) //Metodo para Eliminar informacion en la tabla envio

        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM T_Estado_Tiquetes WHERE Id_Estado_Tiquete= @Id_Estado_Tiquete";
                #region Parametrización
                SqlParameter Id_Estado_Tiquete = new SqlParameter();
                Id_Estado_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Tiquete.ParameterName = "@Id_Estado_Tiquete";
                Id_Estado_Tiquete.Value = E_Tiquete.Id_Estado_Tiquete;

                listParametros.Add(Id_Estado_Tiquete);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<T_Estado_Tiquetes> obtE_Tiquete()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Tiquete, Descripcion_Estado_Tiquete FROM T_Estado_Tiquetes";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Estado_Tiquetes(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Estado_Tiquetes> BuscarDatoA(T_Estado_Tiquetes E_Tiquete) //Metodo para Buscar informacion en la tabla envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Tiquete, Descripcion_Estado_Tiquete FROM T_Estado_Tiquetes WHERE Id_Estado_Tiquete='" + E_Tiquete.Id_Estado_Tiquete + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Estado_Tiquetes(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Estado_Tiquetes> BuscarDatoB(T_Estado_Tiquetes E_Tiquete) //Metodo para Buscar informacion en la tabla envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Tiquete, Descripcion_Estado_Tiquete FROM T_Estado_Tiquetes WHERE Descripcion_Estado_Tiquete='" + E_Tiquete.Descripcion_Estado_Tiquete + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Estado_Tiquetes(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Estado_Clientes 
        public static void GuardarDato(T_Estado_Clientes E_Cliente) //Metodo para Agregar informacion a la tabla Estado
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Estado_Clientes VALUES (@Id_Estado_Clientes, @Descripcion_Estado_Clientes)";
                #region Parametrización
                SqlParameter Id_Estado_Clientes = new SqlParameter();
                Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
                Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

                SqlParameter Descripcion_Estado_Clientes = new SqlParameter();
                Descripcion_Estado_Clientes.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Estado_Clientes.ParameterName = "@Descripcion_Estado_Clientes";
                Descripcion_Estado_Clientes.Value = E_Cliente.Descripcion_Estado_Clientes;

                listParametros.Add(Id_Estado_Clientes);
                listParametros.Add(Descripcion_Estado_Clientes);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarDato(T_Estado_Clientes E_Cliente) //Metodo para Modificar informacion en la tabla Estado
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE T_Estado_Clientes SET Descripcion_Estado_Clientes= @Descripcion_Estado_Clientes WHERE Id_Estado_Clientes= @Id_Estado_Clientes";
                #region Parametrización
                SqlParameter Id_Estado_Clientes = new SqlParameter();
                Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
                Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

                SqlParameter Descripcion_Estado_Clientes = new SqlParameter();
                Descripcion_Estado_Clientes.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Estado_Clientes.ParameterName = "@Descripcion_Estado_Clientes";
                Descripcion_Estado_Clientes.Value = E_Cliente.Descripcion_Estado_Clientes;

                listParametros.Add(Id_Estado_Clientes);
                listParametros.Add(Descripcion_Estado_Clientes);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarDato(T_Estado_Clientes E_Cliente) //Metodo para Eliminar informacion en la tabla Estado

        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM T_Estado_Clientes WHERE Id_Estado_Clientes= @Id_Estado_Clientes";
                #region Parametrización
                SqlParameter Id_Estado_Clientes = new SqlParameter();
                Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
                Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
                Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

                listParametros.Add(Id_Estado_Clientes);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Estado_Clientes> obtE_Cliente()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes  FROM T_Estado_Clientes";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Estado_Clientes(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Estado_Clientes> BuscarDatoA(T_Estado_Clientes E_Cliente) //Metodo para Buscar informacion en la tabla estado
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes FROM T_Estado_Clientes WHERE Id_Estado_Clientes='" + E_Cliente.Id_Estado_Clientes + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Estado_Clientes(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Estado_Clientes> BuscarDatoB(T_Estado_Clientes E_Cliente) //Metodo para Buscar informacion en la tabla envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes FROM T_Estado_Clientes WHERE Descripcion_Estado_Clientes='" + E_Cliente.Descripcion_Estado_Clientes + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Estado_Clientes(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Roles
        public static void GuardarDato(T_Roles Roles) //Metodo para Agregar informacion a la tabla Pago
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Roles VALUES (@Id_Rol, @Nombre_Rol, @Descripcion_Rol)";
                #region Parametrización
                SqlParameter Id_Rol = new SqlParameter();
                Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
                Id_Rol.ParameterName = "@Id_Rol";
                Id_Rol.Value = Roles.Id_Rol;

                SqlParameter Nombre_Rol = new SqlParameter();
                Nombre_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Rol.ParameterName = "@Nombre_Rol";
                Nombre_Rol.Value = Roles.Nombre_Rol;

                SqlParameter Descripcion_Rol = new SqlParameter();
                Descripcion_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Rol.ParameterName = "@Descripcion_Rol";
                Descripcion_Rol.Value = Roles.Descripcion_Rol;

                listParametros.Add(Id_Rol);
                listParametros.Add(Nombre_Rol);
                listParametros.Add(Descripcion_Rol);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarDato(T_Roles Roles) //Metodo para Modificar informacion en la tabla Pago
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE T_Roles SET Nombre_Rol= @Nombre_Rol, Descripcion_Rol= @Descripcion_Rol WHERE Id_Rol= @Id_Rol";
                #region Parametrización
                SqlParameter Id_Rol = new SqlParameter();
                Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
                Id_Rol.ParameterName = "@Id_Rol";
                Id_Rol.Value = Roles.Id_Rol;

                SqlParameter Nombre_Rol = new SqlParameter();
                Nombre_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Rol.ParameterName = "@Nombre_Rol";
                Nombre_Rol.Value = Roles.Nombre_Rol;

                SqlParameter Descripcion_Rol = new SqlParameter();
                Descripcion_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Rol.ParameterName = "@Descripcion_Rol";
                Descripcion_Rol.Value = Roles.Descripcion_Rol;

                listParametros.Add(Id_Rol);
                listParametros.Add(Nombre_Rol);
                listParametros.Add(Descripcion_Rol);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarDato(T_Roles Roles) //Metodo para Eliminar informacion en la tabla Pago
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM T_Roles WHERE Id_Rol= @Id_Rol";
                #region Parametrización
                SqlParameter Id_Rol = new SqlParameter();
                Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
                Id_Rol.ParameterName = "@Id_Rol";
                Id_Rol.Value = Roles.Id_Rol;

                listParametros.Add(Id_Rol);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Roles> obtRoles()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_Roles";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Roles(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Roles> BuscarDatoA(T_Roles Roles) //Metodo para Buscar informacion en la tabla estado
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_Roles WHERE Id_Rol='" + Roles.Id_Rol + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Roles(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Roles> BuscarDatoB(T_Roles Roles) //Metodo para Buscar informacion en la tabla envio
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_RolesO WHERE Nombre_Rol='" + Roles.Nombre_Rol + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Roles(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Severidades 
        public static void GuardarDato(T_Severidades Severidad) //Metodo para Agregar informacion a la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Severidades VALUES (@Severidad, @Descripcion_Severidad)";
                #region Parametrización
                SqlParameter Severity = new SqlParameter();
                Severity.SqlDbType = System.Data.SqlDbType.Int;
                Severity.ParameterName = "@Severidad";
                Severity.Value = Severidad.Severidad;

                SqlParameter Descripcion_Severidad = new SqlParameter();
                Descripcion_Severidad.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Severidad.ParameterName = "@Descripcion_Severidad";
                Descripcion_Severidad.Value = Severidad.Descripcion_Severidad;

                listParametros.Add(Severity);
                listParametros.Add(Descripcion_Severidad);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void ModificarDato(T_Severidades Severidad) //Metodo para Modificar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE T_Severidades SET Descripcion_Severidad= @Descripcion_Severidad WHERE Severidad= @Severidad";
                #region Parametrización
                SqlParameter Severity = new SqlParameter();
                Severity.SqlDbType = System.Data.SqlDbType.Int;
                Severity.ParameterName = "@Severidad";
                Severity.Value = Severidad.Severidad;

                SqlParameter Descripcion_Severidad = new SqlParameter();
                Descripcion_Severidad.SqlDbType = System.Data.SqlDbType.NVarChar;
                Descripcion_Severidad.ParameterName = "@Descripcion_Severidad";
                Descripcion_Severidad.Value = Severidad.Descripcion_Severidad;

                listParametros.Add(Severity);
                listParametros.Add(Descripcion_Severidad);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static void EliminarDato(T_Severidades Severidad) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM T_Severidades WHERE Severidad=@Severidad";
                #region Parametrización
                SqlParameter Severity = new SqlParameter();
                Severity.SqlDbType = System.Data.SqlDbType.Int;
                Severity.ParameterName = "@Severidad";
                Severity.Value = Severidad.Severidad;

                listParametros.Add(Severity);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Severidades> obtSeveridad()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Severidad, Descripcion_Severidad  FROM T_Severidades";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Severidades(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Severidades> BuscarDatoA(T_Severidades Severidad) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Severidad, Descripcion_Severidad FROM T_Severidades WHERE Severidad ='" + Severidad.Severidad + "'";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Severidades(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Severidades> BuscarDatoB(T_Severidades Severidad) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Severidad, Descripcion_Severidad FROM T_Severidades WHEREE Descripcion_Severidad='" + Severidad.Descripcion_Severidad + "'";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Severidades(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Cliente 
        public static void GuardarDato(T_Cliente Cliente) //Metodo para Agregar informacion a la tabla Origen
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"INSERT INTO ORIGEN VALUES ('" + origen.PAIS + "','" + origen.CIUDAD + "')";
                sentencia.PETICION = @"INSERT INTO ORIGEN VALUES (@PAIS, @CIUDAD)";
                #region Parametrización
                SqlParameter PAIS = new SqlParameter();
                PAIS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PAIS.ParameterName = "@PAIS";
                PAIS.Value = origen.PAIS;

                SqlParameter CIUDAD = new SqlParameter();
                CIUDAD.SqlDbType = System.Data.SqlDbType.NVarChar;
                CIUDAD.ParameterName = "@CIUDAD";
                CIUDAD.Value = origen.CIUDAD;

                listParametros.Add(PAIS);
                listParametros.Add(CIUDAD);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarDato(T_Cliente Cliente) //Metodo para Modificar informacion en la tabla Origen
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"UPDATE ORIGEN SET PAIS= @PAIS, CIUDAD= @CIUDAD WHERE IDORIGEN= @IDORIGEN";
                #region Parametrización
                SqlParameter PAIS = new SqlParameter();
                PAIS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PAIS.ParameterName = "@PAIS";
                PAIS.Value = origen.PAIS;

                SqlParameter CIUDAD = new SqlParameter();
                CIUDAD.SqlDbType = System.Data.SqlDbType.NVarChar;
                CIUDAD.ParameterName = "@CIUDAD";
                CIUDAD.Value = origen.CIUDAD;

                SqlParameter IDORIGEN = new SqlParameter();
                IDORIGEN.SqlDbType = System.Data.SqlDbType.Int;
                IDORIGEN.ParameterName = "@IDORIGEN";
                IDORIGEN.Value = origen.IDORIGEN;

                listParametros.Add(PAIS);
                listParametros.Add(CIUDAD);
                listParametros.Add(IDORIGEN);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarDato(T_Cliente Cliente) //Metodo para Eliminar informacion en la tabla origen
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"DELETE FROM ORIGEN WHERE IDORIGEN= @IDORIGEN";
                #region Parametrización
                SqlParameter IDORIGEN = new SqlParameter();
                IDORIGEN.SqlDbType = System.Data.SqlDbType.Int;
                IDORIGEN.ParameterName = "@IDORIGEN";
                IDORIGEN.Value = origen.IDORIGEN;

                listParametros.Add(IDORIGEN);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Cliente> obtCliente()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDORIGEN, PAIS,CIUDAD FROM ORIGEN";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Origen(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Cliente> BuscarDatoA(T_Cliente Cliente) //Metodo para Buscar informacion en la tabla origen
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT * FROM ORIGEN WHERE IDORIGEN='" + origen.IDORIGEN + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Origen(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Cliente> BuscarDatoB(T_Cliente Cliente) //Metodo para Buscar informacion en la tabla origen
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT * FROM ORIGEN WHERE PAIS='" + origen.PAIS + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Origen(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Usuarios
        public static void GuardarDato(T_Usuarios user) //Metodo para Agregar informacion a la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"INSERT INTO USUARIOS VALUES ('" + user.NOMBRE + "','" + user.ALIAS + "','" + user.PASS + "','" + user.TIPO_USUARIO + "','" + user.ESTADO_USUARIO + "')";
                sentencia.PETICION = @"INSERT INTO USUARIOS VALUES (@NOMBRE, @ALIAS, @PASS, @TIPO_USUARIO, @ESTADO_USUARIO)";
                #region Parametrización
                SqlParameter NOMBRE = new SqlParameter();
                NOMBRE.SqlDbType = System.Data.SqlDbType.NVarChar;
                NOMBRE.ParameterName = "@NOMBRE";
                NOMBRE.Value = user.NOMBRE;

                SqlParameter ALIAS = new SqlParameter();
                ALIAS.SqlDbType = System.Data.SqlDbType.NVarChar;
                ALIAS.ParameterName = "@ALIAS";
                ALIAS.Value = user.ALIAS;

                SqlParameter PASS = new SqlParameter();
                PASS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PASS.ParameterName = "@PASS";
                PASS.Value = user.PASS;

                SqlParameter TIPO_USUARIO = new SqlParameter();
                TIPO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                TIPO_USUARIO.ParameterName = "@TIPO_USUARIO";
                TIPO_USUARIO.Value = user.TIPO_USUARIO;

                SqlParameter ESTADO_USUARIO = new SqlParameter();
                ESTADO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                ESTADO_USUARIO.ParameterName = "@ESTADO_USUARIO";
                ESTADO_USUARIO.Value = user.ESTADO_USUARIO;

                listParametros.Add(NOMBRE);
                listParametros.Add(ALIAS);
                listParametros.Add(PASS);
                listParametros.Add(TIPO_USUARIO);
                listParametros.Add(ESTADO_USUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static void ModificarDato(T_Usuarios user) //Metodo para Modificar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE='" + user.NOMBRE + "', ALIAS='" + user.ALIAS + "', PASS='" + user.PASS + "', TIPO_USUARIO='" + user.TIPO_USUARIO + "', ESTADO_USUARIO='" + user.ESTADO_USUARIO + "' WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE= @NOMBRE, ALIAS= @ALIAS, PASS= @PASS, TIPO_USUARIO= @TIPO_USUARIO, ESTADO_USUARIO= @ESTADO_USUARIO WHERE IDUSUARIO= @IDUSUARIO";
                #region Parametrización
                SqlParameter NOMBRE = new SqlParameter();
                NOMBRE.SqlDbType = System.Data.SqlDbType.NVarChar;
                NOMBRE.ParameterName = "@NOMBRE";
                NOMBRE.Value = user.NOMBRE;

                SqlParameter ALIAS = new SqlParameter();
                ALIAS.SqlDbType = System.Data.SqlDbType.NVarChar;
                ALIAS.ParameterName = "@ALIAS";
                ALIAS.Value = user.ALIAS;

                SqlParameter PASS = new SqlParameter();
                PASS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PASS.ParameterName = "@PASS";
                PASS.Value = user.PASS;

                SqlParameter TIPO_USUARIO = new SqlParameter();
                TIPO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                TIPO_USUARIO.ParameterName = "@TIPO_USUARIO";
                TIPO_USUARIO.Value = user.TIPO_USUARIO;

                SqlParameter ESTADO_USUARIO = new SqlParameter();
                ESTADO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                ESTADO_USUARIO.ParameterName = "@ESTADO_USUARIO";
                ESTADO_USUARIO.Value = user.ESTADO_USUARIO;

                SqlParameter IDUSUARIO = new SqlParameter();
                IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                IDUSUARIO.ParameterName = "@IDUSUARIO";
                IDUSUARIO.Value = user.IDUSUARIO;

                listParametros.Add(NOMBRE);
                listParametros.Add(ALIAS);
                listParametros.Add(PASS);
                listParametros.Add(TIPO_USUARIO);
                listParametros.Add(ESTADO_USUARIO);
                listParametros.Add(IDUSUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static void EliminarDato(T_Usuarios user) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO= @IDUSUARIO";
                #region Parametrización
                SqlParameter IDUSUARIO = new SqlParameter();
                IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                IDUSUARIO.ParameterName = "@IDUSUARIO";
                IDUSUARIO.Value = user.IDUSUARIO;

                listParametros.Add(IDUSUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Usuarios> obtUsuarios()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDUSUARIO, NOMBRE, ALIAS, PASS, TIPO_USUARIO, ESTADO_USUARIO FROM USUARIOS";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Usuarios> BuscarDatoA(T_Usuarios user) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT *  FROM USUARIOS WHERE IDUSUARIO ='" + user.IDUSUARIO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Usuarios> BuscarDatoB(T_Usuarios user) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT *  FROM USUARIOS WHERE ALIAS ='" + user.ALIAS + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #region Metodos Para Tabla T_Tiquete
        public static void GuardarDato(T_Tiquete Tiquete) //Metodo para Agregar informacion a la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"INSERT INTO USUARIOS VALUES ('" + user.NOMBRE + "','" + user.ALIAS + "','" + user.PASS + "','" + user.TIPO_USUARIO + "','" + user.ESTADO_USUARIO + "')";
                sentencia.PETICION = @"INSERT INTO USUARIOS VALUES (@NOMBRE, @ALIAS, @PASS, @TIPO_USUARIO, @ESTADO_USUARIO)";
                #region Parametrización
                SqlParameter NOMBRE = new SqlParameter();
                NOMBRE.SqlDbType = System.Data.SqlDbType.NVarChar;
                NOMBRE.ParameterName = "@NOMBRE";
                NOMBRE.Value = user.NOMBRE;

                SqlParameter ALIAS = new SqlParameter();
                ALIAS.SqlDbType = System.Data.SqlDbType.NVarChar;
                ALIAS.ParameterName = "@ALIAS";
                ALIAS.Value = user.ALIAS;

                SqlParameter PASS = new SqlParameter();
                PASS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PASS.ParameterName = "@PASS";
                PASS.Value = user.PASS;

                SqlParameter TIPO_USUARIO = new SqlParameter();
                TIPO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                TIPO_USUARIO.ParameterName = "@TIPO_USUARIO";
                TIPO_USUARIO.Value = user.TIPO_USUARIO;

                SqlParameter ESTADO_USUARIO = new SqlParameter();
                ESTADO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                ESTADO_USUARIO.ParameterName = "@ESTADO_USUARIO";
                ESTADO_USUARIO.Value = user.ESTADO_USUARIO;

                listParametros.Add(NOMBRE);
                listParametros.Add(ALIAS);
                listParametros.Add(PASS);
                listParametros.Add(TIPO_USUARIO);
                listParametros.Add(ESTADO_USUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static void ModificarDato(T_Tiquete Tiquete) //Metodo para Modificar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE='" + user.NOMBRE + "', ALIAS='" + user.ALIAS + "', PASS='" + user.PASS + "', TIPO_USUARIO='" + user.TIPO_USUARIO + "', ESTADO_USUARIO='" + user.ESTADO_USUARIO + "' WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                sentencia.PETICION = @"UPDATE USUARIOS SET NOMBRE= @NOMBRE, ALIAS= @ALIAS, PASS= @PASS, TIPO_USUARIO= @TIPO_USUARIO, ESTADO_USUARIO= @ESTADO_USUARIO WHERE IDUSUARIO= @IDUSUARIO";
                #region Parametrización
                SqlParameter NOMBRE = new SqlParameter();
                NOMBRE.SqlDbType = System.Data.SqlDbType.NVarChar;
                NOMBRE.ParameterName = "@NOMBRE";
                NOMBRE.Value = user.NOMBRE;

                SqlParameter ALIAS = new SqlParameter();
                ALIAS.SqlDbType = System.Data.SqlDbType.NVarChar;
                ALIAS.ParameterName = "@ALIAS";
                ALIAS.Value = user.ALIAS;

                SqlParameter PASS = new SqlParameter();
                PASS.SqlDbType = System.Data.SqlDbType.NVarChar;
                PASS.ParameterName = "@PASS";
                PASS.Value = user.PASS;

                SqlParameter TIPO_USUARIO = new SqlParameter();
                TIPO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                TIPO_USUARIO.ParameterName = "@TIPO_USUARIO";
                TIPO_USUARIO.Value = user.TIPO_USUARIO;

                SqlParameter ESTADO_USUARIO = new SqlParameter();
                ESTADO_USUARIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                ESTADO_USUARIO.ParameterName = "@ESTADO_USUARIO";
                ESTADO_USUARIO.Value = user.ESTADO_USUARIO;

                SqlParameter IDUSUARIO = new SqlParameter();
                IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                IDUSUARIO.ParameterName = "@IDUSUARIO";
                IDUSUARIO.Value = user.IDUSUARIO;

                listParametros.Add(NOMBRE);
                listParametros.Add(ALIAS);
                listParametros.Add(PASS);
                listParametros.Add(TIPO_USUARIO);
                listParametros.Add(ESTADO_USUARIO);
                listParametros.Add(IDUSUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static void EliminarDato(T_Tiquete Tiquete) //Metodo para Eliminar informacion en la tabla DESTINO
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                //sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO='" + user.IDUSUARIO + "'";
                sentencia.PETICION = @"DELETE FROM USUARIOS WHERE IDUSUARIO= @IDUSUARIO";
                #region Parametrización
                SqlParameter IDUSUARIO = new SqlParameter();
                IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                IDUSUARIO.ParameterName = "@IDUSUARIO";
                IDUSUARIO.Value = user.IDUSUARIO;

                listParametros.Add(IDUSUARIO);

                sentencia.LSTPARAMETROS = listParametros;
                #endregion
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                objAcceso.EjecutarSentencia(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Tiquete> obtTiquetes()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT IDUSUARIO, NOMBRE, ALIAS, PASS, TIPO_USUARIO, ESTADO_USUARIO FROM USUARIOS";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<T_Tiquete> BuscarDatoA(T_Tiquete Tiquete) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT *  FROM USUARIOS WHERE IDUSUARIO ='" + user.IDUSUARIO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Tiquete> BuscarDatoB(T_Tiquete Tiquete) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT *  FROM USUARIOS WHERE ALIAS ='" + user.ALIAS + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        #endregion

        #endregion
    }
}
