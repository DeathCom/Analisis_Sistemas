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
        //public static void GuardarDato(T_Estado_Clientes E_Cliente) //Metodo para Agregar informacion a la tabla Estado
        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"INSERT INTO T_Estado_Clientes VALUES (@Id_Estado_Clientes, @Descripcion_Estado_Clientes)";
        //        #region Parametrización
        //        SqlParameter Id_Estado_Clientes = new SqlParameter();
        //        Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
        //        Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

        //        SqlParameter Descripcion_Estado_Clientes = new SqlParameter();
        //        Descripcion_Estado_Clientes.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Descripcion_Estado_Clientes.ParameterName = "@Descripcion_Estado_Clientes";
        //        Descripcion_Estado_Clientes.Value = E_Cliente.Descripcion_Estado_Clientes;

        //        listParametros.Add(Id_Estado_Clientes);
        //        listParametros.Add(Descripcion_Estado_Clientes);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static void ModificarDato(T_Estado_Clientes E_Cliente) //Metodo para Modificar informacion en la tabla Estado
        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"UPDATE T_Estado_Clientes SET Descripcion_Estado_Clientes= @Descripcion_Estado_Clientes WHERE Id_Estado_Clientes= @Id_Estado_Clientes";
        //        #region Parametrización
        //        SqlParameter Id_Estado_Clientes = new SqlParameter();
        //        Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
        //        Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

        //        SqlParameter Descripcion_Estado_Clientes = new SqlParameter();
        //        Descripcion_Estado_Clientes.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Descripcion_Estado_Clientes.ParameterName = "@Descripcion_Estado_Clientes";
        //        Descripcion_Estado_Clientes.Value = E_Cliente.Descripcion_Estado_Clientes;

        //        listParametros.Add(Id_Estado_Clientes);
        //        listParametros.Add(Descripcion_Estado_Clientes);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static void EliminarDato(T_Estado_Clientes E_Cliente) //Metodo para Eliminar informacion en la tabla Estado

        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"DELETE FROM T_Estado_Clientes WHERE Id_Estado_Clientes= @Id_Estado_Clientes";
        //        #region Parametrización
        //        SqlParameter Id_Estado_Clientes = new SqlParameter();
        //        Id_Estado_Clientes.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Estado_Clientes.ParameterName = "@Id_Estado_Clientes";
        //        Id_Estado_Clientes.Value = E_Cliente.Id_Estado_Clientes;

        //        listParametros.Add(Id_Estado_Clientes);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static List<T_Estado_Clientes> obtE_Cliente()
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes  FROM T_Estado_Clientes";
        //        Acceso objacceso = new Acceso();
        //        return objacceso.Obtener_Estado_Clientes(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static List<T_Estado_Clientes> BuscarDatoA(T_Estado_Clientes E_Cliente) //Metodo para Buscar informacion en la tabla estado
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes FROM T_Estado_Clientes WHERE Id_Estado_Clientes='" + E_Cliente.Id_Estado_Clientes + "'";
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        return objAcceso.Obtener_Estado_Clientes(sentencia);
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}
        //public static List<T_Estado_Clientes> BuscarDatoB(T_Estado_Clientes E_Cliente) //Metodo para Buscar informacion en la tabla envio
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Estado_Clientes, Descripcion_Estado_Clientes FROM T_Estado_Clientes WHERE Descripcion_Estado_Clientes='" + E_Cliente.Descripcion_Estado_Clientes + "'";
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        return objAcceso.Obtener_Estado_Clientes(sentencia);
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}
        #endregion

        #region Metodos Para Tabla T_Roles
        //public static void GuardarDato(T_Roles Roles) //Metodo para Agregar informacion a la tabla Pago
        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"INSERT INTO T_Roles VALUES (@Id_Rol, @Nombre_Rol, @Descripcion_Rol)";
        //        #region Parametrización
        //        SqlParameter Id_Rol = new SqlParameter();
        //        Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Rol.ParameterName = "@Id_Rol";
        //        Id_Rol.Value = Roles.Id_Rol;

        //        SqlParameter Nombre_Rol = new SqlParameter();
        //        Nombre_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Nombre_Rol.ParameterName = "@Nombre_Rol";
        //        Nombre_Rol.Value = Roles.Nombre_Rol;

        //        SqlParameter Descripcion_Rol = new SqlParameter();
        //        Descripcion_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Descripcion_Rol.ParameterName = "@Descripcion_Rol";
        //        Descripcion_Rol.Value = Roles.Descripcion_Rol;

        //        listParametros.Add(Id_Rol);
        //        listParametros.Add(Nombre_Rol);
        //        listParametros.Add(Descripcion_Rol);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static void ModificarDato(T_Roles Roles) //Metodo para Modificar informacion en la tabla Pago
        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"UPDATE T_Roles SET Nombre_Rol= @Nombre_Rol, Descripcion_Rol= @Descripcion_Rol WHERE Id_Rol= @Id_Rol";
        //        #region Parametrización
        //        SqlParameter Id_Rol = new SqlParameter();
        //        Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Rol.ParameterName = "@Id_Rol";
        //        Id_Rol.Value = Roles.Id_Rol;

        //        SqlParameter Nombre_Rol = new SqlParameter();
        //        Nombre_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Nombre_Rol.ParameterName = "@Nombre_Rol";
        //        Nombre_Rol.Value = Roles.Nombre_Rol;

        //        SqlParameter Descripcion_Rol = new SqlParameter();
        //        Descripcion_Rol.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        Descripcion_Rol.ParameterName = "@Descripcion_Rol";
        //        Descripcion_Rol.Value = Roles.Descripcion_Rol;

        //        listParametros.Add(Id_Rol);
        //        listParametros.Add(Nombre_Rol);
        //        listParametros.Add(Descripcion_Rol);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static void EliminarDato(T_Roles Roles) //Metodo para Eliminar informacion en la tabla Pago
        //{
        //    try
        //    {
        //        ArrayList listParametros = new ArrayList();
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"DELETE FROM T_Roles WHERE Id_Rol= @Id_Rol";
        //        #region Parametrización
        //        SqlParameter Id_Rol = new SqlParameter();
        //        Id_Rol.SqlDbType = System.Data.SqlDbType.Int;
        //        Id_Rol.ParameterName = "@Id_Rol";
        //        Id_Rol.Value = Roles.Id_Rol;

        //        listParametros.Add(Id_Rol);

        //        sentencia.LSTPARAMETROS = listParametros;
        //        #endregion
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        objAcceso.EjecutarSentencia(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static List<T_Roles> obtRoles()
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_Roles";
        //        Acceso objacceso = new Acceso();
        //        return objacceso.Obtener_Roles(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public static List<T_Roles> BuscarDatoA(T_Roles Roles) //Metodo para Buscar informacion en la tabla estado
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_Roles WHERE Id_Rol='" + Roles.Id_Rol + "'";
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        return objAcceso.Obtener_Roles(sentencia);
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}
        //public static List<T_Roles> BuscarDatoB(T_Roles Roles) //Metodo para Buscar informacion en la tabla envio
        //{
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.PETICION = @"SELECT Id_Rol, Nombre_Rol, Descripcion_Rol FROM T_RolesO WHERE Nombre_Rol='" + Roles.Nombre_Rol + "'";
        //        _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
        //        return objAcceso.Obtener_Roles(sentencia);
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}
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
        public static void GuardarDatoCliente(T_Cliente Cliente) //Metodo para Agregar informacion a la tabla Origen
        {
            try
            {
                ArrayList listParametros = new ArrayList();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"INSERT INTO T_Cliente VALUES (@Id_Cliente, @Nombre_Cliente, @Telefono_Cliente, @Correo_Cliente, 
                @Region_Cliente, @Pais_Cliente, @Focal_Cliente, @Tipo_Servidor, @Nombre_Servidor, @Ip_Servidor, @Estado_Servidor)";
                #region Parametrización
                SqlParameter Id_Cliente = new SqlParameter();
                Id_Cliente.SqlDbType = System.Data.SqlDbType.Int;
                Id_Cliente.ParameterName = "@Id_Cliente";
                Id_Cliente.Value = Cliente.Id_Cliente;

                SqlParameter Nombre_Cliente = new SqlParameter();
                Nombre_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Cliente.ParameterName = "@Nombre_Cliente";
                Nombre_Cliente.Value = Cliente.Nombre_Cliente;

                SqlParameter Telefono_Cliente = new SqlParameter();
                Telefono_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Telefono_Cliente.ParameterName = "@Telefono_Cliente";
                Telefono_Cliente.Value = Cliente.Telefono_Cliente;

                SqlParameter Correo_Cliente = new SqlParameter();
                Correo_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Correo_Cliente.ParameterName = "@Correo_Cliente";
                Correo_Cliente.Value = Cliente.Correo_Cliente;

                SqlParameter Region_Cliente = new SqlParameter();
                Region_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Region_Cliente.ParameterName = "@Region_Cliente";
                Region_Cliente.Value = Cliente.Region_Cliente;

                SqlParameter Pais_Cliente = new SqlParameter();
                Pais_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Pais_Cliente.ParameterName = "@Pais_Cliente";
                Pais_Cliente.Value = Cliente.Pais_Cliente;

                SqlParameter Focal_Cliente = new SqlParameter();
                Focal_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Focal_Cliente.ParameterName = "@Focal_Cliente";
                Focal_Cliente.Value = Cliente.Focal_Cliente;

                SqlParameter Tipo_Servidor = new SqlParameter();
                Tipo_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Tipo_Servidor.ParameterName = "@Tipo_Servidor";
                Tipo_Servidor.Value = Cliente.Tipo_Servidor;

                SqlParameter Nombre_Servidor = new SqlParameter();
                Nombre_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Servidor.ParameterName = "@Nombre_Servidor";
                Nombre_Servidor.Value = Cliente.Nombre_Servidor;

                SqlParameter Ip_Servidor = new SqlParameter();
                Ip_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Ip_Servidor.ParameterName = "@Ip_Servidor";
                Ip_Servidor.Value = Cliente.Ip_Servidor;

                SqlParameter Estado_Servidor = new SqlParameter();
                Estado_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Servidor.ParameterName = "@Estado_Servidor";
                Estado_Servidor.Value = Cliente.Estado_Servidor;

                listParametros.Add(Id_Cliente);
                listParametros.Add(Nombre_Cliente);
                listParametros.Add(Telefono_Cliente);
                listParametros.Add(Correo_Cliente);
                listParametros.Add(Region_Cliente);
                listParametros.Add(Pais_Cliente);
                listParametros.Add(Focal_Cliente);
                listParametros.Add(Tipo_Servidor);
                listParametros.Add(Nombre_Servidor);
                listParametros.Add(Ip_Servidor);
                listParametros.Add(Estado_Servidor);

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
                sentencia.PETICION = @"UPDATE T_Cliente SET Nombre_Cliente= @Nombre_Cliente, Telefono_Cliente= @Telefono_Cliente,
                Correo_Cliente= @Correo_Cliente, Region_Cliente= @Region_Cliente, Pais_Cliente= @Pais_Cliente, Focal_Cliente= @Focal_Cliente,
                Tipo_Servidor= @Tipo_Servidor, Nombre_Servidor= @Nombre_Servidor, Ip_Servidor= @Ip_Servidor, Estado_Servidor= @Estado_Servidor
                WHERE Id_Cliente= @Id_Cliente";
                #region Parametrización
                SqlParameter Id_Cliente = new SqlParameter();
                Id_Cliente.SqlDbType = System.Data.SqlDbType.Int;
                Id_Cliente.ParameterName = "@Id_Cliente";
                Id_Cliente.Value = Cliente.Id_Cliente;

                SqlParameter Nombre_Cliente = new SqlParameter();
                Nombre_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Cliente.ParameterName = "@Nombre_Cliente";
                Nombre_Cliente.Value = Cliente.Nombre_Cliente;

                SqlParameter Telefono_Cliente = new SqlParameter();
                Telefono_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Telefono_Cliente.ParameterName = "@Telefono_Cliente";
                Telefono_Cliente.Value = Cliente.Telefono_Cliente;

                SqlParameter Correo_Cliente = new SqlParameter();
                Correo_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Correo_Cliente.ParameterName = "@Correo_Cliente";
                Correo_Cliente.Value = Cliente.Correo_Cliente;

                SqlParameter Region_Cliente = new SqlParameter();
                Region_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Region_Cliente.ParameterName = "@Region_Cliente";
                Region_Cliente.Value = Cliente.Region_Cliente;

                SqlParameter Pais_Cliente = new SqlParameter();
                Pais_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Pais_Cliente.ParameterName = "@Pais_Cliente";
                Pais_Cliente.Value = Cliente.Pais_Cliente;

                SqlParameter Focal_Cliente = new SqlParameter();
                Focal_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Focal_Cliente.ParameterName = "@Focal_Cliente";
                Focal_Cliente.Value = Cliente.Focal_Cliente;

                SqlParameter Tipo_Servidor = new SqlParameter();
                Tipo_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Tipo_Servidor.ParameterName = "@Tipo_Servidor";
                Tipo_Servidor.Value = Cliente.Tipo_Servidor;

                SqlParameter Nombre_Servidor = new SqlParameter();
                Nombre_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Servidor.ParameterName = "@Nombre_Servidor";
                Nombre_Servidor.Value = Cliente.Nombre_Servidor;

                SqlParameter Ip_Servidor = new SqlParameter();
                Ip_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Ip_Servidor.ParameterName = "@Ip_Servidor";
                Ip_Servidor.Value = Cliente.Ip_Servidor;

                SqlParameter Estado_Servidor = new SqlParameter();
                Estado_Servidor.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Servidor.ParameterName = "@Estado_Servidor";
                Estado_Servidor.Value = Cliente.Estado_Servidor;

                listParametros.Add(Id_Cliente);
                listParametros.Add(Nombre_Cliente);
                listParametros.Add(Telefono_Cliente);
                listParametros.Add(Correo_Cliente);
                listParametros.Add(Region_Cliente);
                listParametros.Add(Pais_Cliente);
                listParametros.Add(Focal_Cliente);
                listParametros.Add(Tipo_Servidor);
                listParametros.Add(Nombre_Servidor);
                listParametros.Add(Ip_Servidor);
                listParametros.Add(Estado_Servidor);

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
                sentencia.PETICION = @"DELETE FROM T_Cliente WHERE Id_Cliente= @Id_Cliente";
                #region Parametrización
                SqlParameter Id_Cliente = new SqlParameter();
                Id_Cliente.SqlDbType = System.Data.SqlDbType.Int;
                Id_Cliente.ParameterName = "@Id_Cliente";
                Id_Cliente.Value = Cliente.Id_Cliente;

                listParametros.Add(Id_Cliente);

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
                sentencia.PETICION = @"SELECT Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente, Region_Cliente,
                Pais_Cliente, Focal_Cliente, Tipo_Servidor, Nombre_Servidor, Ip_Servidor, Estado_Servidor FROM T_Cliente";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Clientes(sentencia);
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
                sentencia.PETICION = @"SELECT Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente, Region_Cliente,
                Pais_Cliente, Focal_Cliente, Tipo_Servidor, Nombre_Servidor, Ip_Servidor, Estado_Servidor FROM T_Cliente WHERE Id_Cliente='" + Cliente.Id_Cliente + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Clientes(sentencia);
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
                sentencia.PETICION = @"SELECT Id_Cliente, Nombre_Cliente, Telefono_Cliente, Correo_Cliente, Region_Cliente,
                Pais_Cliente, Focal_Cliente, Tipo_Servidor, Nombre_Servidor, Ip_Servidor, Estado_Servidor FROM T_Cliente WHERE Nombre_Cliente='" + Cliente.Nombre_Cliente + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Clientes(sentencia);
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
                sentencia.PETICION = @"INSERT INTO T_Usuarios VALUES (@Id_Usuario, @Usuario, @Nombre_Usuario, @Contrasena_Usuario, @Estado_Usuario, @Tipo_Usuario)";
                #region Parametrización
                SqlParameter Id_Usuario = new SqlParameter();
                Id_Usuario.SqlDbType = System.Data.SqlDbType.Int;
                Id_Usuario.ParameterName = "@Id_Usuario";
                Id_Usuario.Value = user.Id_Usuario;

                SqlParameter Usuario = new SqlParameter();
                Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Usuario.ParameterName = "@Usuario";
                Usuario.Value = user.Usuario;

                SqlParameter Nombre_Usuario = new SqlParameter();
                Nombre_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Usuario.ParameterName = "@Nombre_Usuario";
                Nombre_Usuario.Value = user.Nombre_Usuario;

                SqlParameter Contrasena_Usuario = new SqlParameter();
                Contrasena_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Contrasena_Usuario.ParameterName = "@Contrasena_Usuario";
                Contrasena_Usuario.Value = user.Contrasena_Usuario;

                SqlParameter Estado_Usuario = new SqlParameter();
                Estado_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Usuario.ParameterName = "@Estado_Usuario";
                Estado_Usuario.Value = user.Estado_Usuario;

                SqlParameter Tipo_Usuario = new SqlParameter();
                Tipo_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Tipo_Usuario.ParameterName = "@Tipo_Usuario";
                Tipo_Usuario.Value = user.Tipo_Usuario;

                listParametros.Add(Id_Usuario);
                listParametros.Add(Usuario);
                listParametros.Add(Nombre_Usuario);
                listParametros.Add(Contrasena_Usuario);
                listParametros.Add(Estado_Usuario);
                listParametros.Add(Tipo_Usuario);

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
                sentencia.PETICION = @"UPDATE T_Usuarios SET Usuario= @Usuario, Nombre_Usuario= @Nombre_Usuario, 
                Contrasena_Usuario= @Contrasena_Usuario, Estado_Usuario= @Estado_Usuario, Tipo_Usuario= @Tipo_Usuario
                WHERE Id_Usuario= @Id_Usuario";
                #region Parametrización
                SqlParameter Id_Usuario = new SqlParameter();
                Id_Usuario.SqlDbType = System.Data.SqlDbType.Int;
                Id_Usuario.ParameterName = "@Id_Usuario";
                Id_Usuario.Value = user.Id_Usuario;

                SqlParameter Usuario = new SqlParameter();
                Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Usuario.ParameterName = "@Usuario";
                Usuario.Value = user.Usuario;

                SqlParameter Nombre_Usuario = new SqlParameter();
                Nombre_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Usuario.ParameterName = "@Nombre_Usuario";
                Nombre_Usuario.Value = user.Nombre_Usuario;

                SqlParameter Contrasena_Usuario = new SqlParameter();
                Contrasena_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Contrasena_Usuario.ParameterName = "@Contrasena_Usuario";
                Contrasena_Usuario.Value = user.Contrasena_Usuario;

                SqlParameter Estado_Usuario = new SqlParameter();
                Estado_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Usuario.ParameterName = "@Estado_Usuario";
                Estado_Usuario.Value = user.Estado_Usuario;

                SqlParameter Tipo_Usuario = new SqlParameter();
                Tipo_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Tipo_Usuario.ParameterName = "@Tipo_Usuario";
                Tipo_Usuario.Value = user.Tipo_Usuario;

                listParametros.Add(Id_Usuario);
                listParametros.Add(Usuario);
                listParametros.Add(Nombre_Usuario);
                listParametros.Add(Contrasena_Usuario);
                listParametros.Add(Estado_Usuario);
                listParametros.Add(Tipo_Usuario);

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
                sentencia.PETICION = @"DELETE FROM T_Usuarios WHERE Id_Usuario= @Id_Usuario";
                #region Parametrización
                SqlParameter Id_Usuario = new SqlParameter();
                Id_Usuario.SqlDbType = System.Data.SqlDbType.Int;
                Id_Usuario.ParameterName = "@Id_Usuario";
                Id_Usuario.Value = user.Id_Usuario;

                listParametros.Add(Id_Usuario);

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
                sentencia.PETICION = @"SELECT Id_Usuario, Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario 
                FROM T_Usuarios";
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
                sentencia.PETICION = @"SELECT Id_Usuario, Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario
                FROM T_Usuarios WHERE Id_Usuario ='" + user.Id_Usuario + "'";
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
                sentencia.PETICION = @"SELECT Id_Usuario, Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario
                FROM T_Usuarios WHERE Id_Usuario ='" + user.Usuario + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Usuarios(sentencia);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static List<T_Usuarios> BuscarDatoC(T_Usuarios user) //Metodo para Buscar informacion en la tabla DESTINO
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.PETICION = @"SELECT Id_Usuario, Usuario, Nombre_Usuario, Contrasena_Usuario, Estado_Usuario, Tipo_Usuario
                FROM T_Usuarios WHERE Id_Usuario ='" + user.Nombre_Usuario + "'";
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
                sentencia.PETICION = @"INSERT INTO T_Tiquete VALUES (@Id_Tiquete, @Id_Supervisor, @Nombre_Usuario, @Nombre_Cliente, @Nombre_Aplicacion, @Numero_Tiquete,
                @Severidad_Tiquete, @Estado_Tiquete, @Comentarios_Tiquete, @HorayFecha_Apertura, @HorayFecha_Cierre)";
                #region Parametrización
                SqlParameter Id_Tiquete = new SqlParameter();
                Id_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Tiquete.ParameterName = "@Id_Tiquete";
                Id_Tiquete.Value = Tiquete.Id_Tiquete;

                SqlParameter Id_Supervisor = new SqlParameter();
                Id_Supervisor.SqlDbType = System.Data.SqlDbType.Int;
                Id_Supervisor.ParameterName = "@Id_Supervisor";
                Id_Supervisor.Value = Tiquete.Id_Supervisor;

                SqlParameter Nombre_Usuario = new SqlParameter();
                Nombre_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Usuario.ParameterName = "@Nombre_Usuario";
                Nombre_Usuario.Value = Tiquete.Nombre_Usuario;

                SqlParameter Nombre_Cliente = new SqlParameter();
                Nombre_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Cliente.ParameterName = "@Nombre_Cliente";
                Nombre_Cliente.Value = Tiquete.Nombre_Cliente;

                SqlParameter Nombre_Aplicacion = new SqlParameter();
                Nombre_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Aplicacion.ParameterName = "@Nombre_Aplicacion";
                Nombre_Aplicacion.Value = Tiquete.Nombre_Aplicacion;

                SqlParameter Numero_Tiquete = new SqlParameter();
                Numero_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Numero_Tiquete.ParameterName = "@Numero_Tiquete";
                Numero_Tiquete.Value = Tiquete.Numero_Tiquete;

                SqlParameter Severidad_Tiquete = new SqlParameter();
                Severidad_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Severidad_Tiquete.ParameterName = "@Severidad_Tiquete";
                Severidad_Tiquete.Value = Tiquete.Severidad_Tiquete;

                SqlParameter Estado_Tiquete = new SqlParameter();
                Estado_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Tiquete.ParameterName = "@Estado_Tiquete";
                Estado_Tiquete.Value = Tiquete.Estado_Tiquete;

                SqlParameter Comentarios_Tiquete = new SqlParameter();
                Comentarios_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Comentarios_Tiquete.ParameterName = "@Comentarios_Tiquete";
                Comentarios_Tiquete.Value = Tiquete.Comentarios_Tiquete;

                SqlParameter HorayFecha_Apertura = new SqlParameter();
                HorayFecha_Apertura.SqlDbType = System.Data.SqlDbType.DateTime;
                HorayFecha_Apertura.ParameterName = "@HorayFecha_Apertura";
                HorayFecha_Apertura.Value = Tiquete.HorayFecha_Apertura;

                SqlParameter HorayFecha_Cierre = new SqlParameter();
                HorayFecha_Cierre.SqlDbType = System.Data.SqlDbType.DateTime;
                HorayFecha_Cierre.ParameterName = "@HorayFecha_Cierre";
                HorayFecha_Cierre.Value = Tiquete.HorayFecha_Cierre;

                listParametros.Add(Id_Tiquete);
                listParametros.Add(Id_Supervisor);
                listParametros.Add(Nombre_Usuario);
                listParametros.Add(Nombre_Cliente);
                listParametros.Add(Nombre_Aplicacion);
                listParametros.Add(Numero_Tiquete);
                listParametros.Add(Severidad_Tiquete);
                listParametros.Add(Estado_Tiquete);
                listParametros.Add(Comentarios_Tiquete);
                listParametros.Add(HorayFecha_Apertura);
                listParametros.Add(HorayFecha_Cierre);

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
                sentencia.PETICION = @"UPDATE T_Tiquete SET Id_Supervisor= @Id_Supervisor, Nombre_Usuario= @Nombre_Usuario, Nombre_Cliente= @Nombre_Cliente, 
                Nombre_Aplicacion= @Nombre_Aplicacion, Numero_Tiquete= @Numero_Tiquete, Severidad_Tiquete= @Severidad_Tiquete,  Estado_Tiquete= @Estado_Tiquete,
                Comentarios_Tiquete= @Comentarios_Tiquete, HorayFecha_Apertura= @HorayFecha_Apertura, HorayFecha_Cierre= @HorayFecha_Cierre WHERE Id_Tiquete= @Id_Tiquete";
                #region Parametrización
                SqlParameter Id_Tiquete = new SqlParameter();
                Id_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Tiquete.ParameterName = "@Id_Tiquete";
                Id_Tiquete.Value = Tiquete.Id_Tiquete;

                SqlParameter Id_Supervisor = new SqlParameter();
                Id_Supervisor.SqlDbType = System.Data.SqlDbType.Int;
                Id_Supervisor.ParameterName = "@Id_Supervisor";
                Id_Supervisor.Value = Tiquete.Id_Supervisor;

                SqlParameter Nombre_Usuario = new SqlParameter();
                Nombre_Usuario.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Usuario.ParameterName = "@Nombre_Usuario";
                Nombre_Usuario.Value = Tiquete.Nombre_Usuario;

                SqlParameter Nombre_Cliente = new SqlParameter();
                Nombre_Cliente.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Cliente.ParameterName = "@Nombre_Cliente";
                Nombre_Cliente.Value = Tiquete.Nombre_Cliente;

                SqlParameter Nombre_Aplicacion = new SqlParameter();
                Nombre_Aplicacion.SqlDbType = System.Data.SqlDbType.NVarChar;
                Nombre_Aplicacion.ParameterName = "@Nombre_Aplicacion";
                Nombre_Aplicacion.Value = Tiquete.Nombre_Aplicacion;

                SqlParameter Numero_Tiquete = new SqlParameter();
                Numero_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Numero_Tiquete.ParameterName = "@Numero_Tiquete";
                Numero_Tiquete.Value = Tiquete.Numero_Tiquete;

                SqlParameter Severidad_Tiquete = new SqlParameter();
                Severidad_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Severidad_Tiquete.ParameterName = "@Severidad_Tiquete";
                Severidad_Tiquete.Value = Tiquete.Severidad_Tiquete;

                SqlParameter Estado_Tiquete = new SqlParameter();
                Estado_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Estado_Tiquete.ParameterName = "@Estado_Tiquete";
                Estado_Tiquete.Value = Tiquete.Estado_Tiquete;

                SqlParameter Comentarios_Tiquete = new SqlParameter();
                Comentarios_Tiquete.SqlDbType = System.Data.SqlDbType.NVarChar;
                Comentarios_Tiquete.ParameterName = "@Comentarios_Tiquete";
                Comentarios_Tiquete.Value = Tiquete.Comentarios_Tiquete;

                SqlParameter HorayFecha_Apertura = new SqlParameter();
                HorayFecha_Apertura.SqlDbType = System.Data.SqlDbType.DateTime;
                HorayFecha_Apertura.ParameterName = "@HorayFecha_Apertura";
                HorayFecha_Apertura.Value = Tiquete.HorayFecha_Apertura;

                SqlParameter HorayFecha_Cierre = new SqlParameter();
                HorayFecha_Cierre.SqlDbType = System.Data.SqlDbType.DateTime;
                HorayFecha_Cierre.ParameterName = "@HorayFecha_Cierre";
                HorayFecha_Cierre.Value = Tiquete.HorayFecha_Cierre;

                listParametros.Add(Id_Tiquete);
                listParametros.Add(Id_Supervisor);
                listParametros.Add(Nombre_Usuario);
                listParametros.Add(Nombre_Cliente);
                listParametros.Add(Nombre_Aplicacion);
                listParametros.Add(Numero_Tiquete);
                listParametros.Add(Severidad_Tiquete);
                listParametros.Add(Estado_Tiquete);
                listParametros.Add(Comentarios_Tiquete);
                listParametros.Add(HorayFecha_Apertura);
                listParametros.Add(HorayFecha_Cierre);

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
                sentencia.PETICION = @"DELETE FROM T_Tiquete WHERE Id_Tiquete= @Id_Tiquete";
                #region Parametrización
                SqlParameter Id_Tiquete = new SqlParameter();
                Id_Tiquete.SqlDbType = System.Data.SqlDbType.Int;
                Id_Tiquete.ParameterName = "@Id_Tiquete";
                Id_Tiquete.Value = Tiquete.Id_Tiquete;

                listParametros.Add(Id_Tiquete);

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
                sentencia.PETICION = @"SELECT Id_Tiquete, Id_Supervisor, Nombre_Usuario, Nombre_Cliente, Nombre_Aplicacion, 
                Numero_Tiquete, Severidad_Tiquete, Estado_Tiquete, Comentarios_Tiquete, HorayFecha_Apertura, HorayFecha_Cierre FROM T_Tiquete";
                Acceso objacceso = new Acceso();
                return objacceso.Obtener_Tiquetes(sentencia);
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
                sentencia.PETICION = @"SELECT Id_Tiquete, Id_Supervisor, Nombre_Usuario, Nombre_Cliente, Nombre_Aplicacion, 
                Numero_Tiquete, Severidad_Tiquete, Estado_Tiquete, Comentarios_Tiquete, HorayFecha_Apertura, HorayFecha_Cierre FROM T_Tiquete
                WHERE Id_Tiquete ='" + Tiquete.Id_Tiquete + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Tiquetes(sentencia);
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
                sentencia.PETICION = @"SELECT Id_Tiquete, Id_Supervisor, Nombre_Usuario, Nombre_Cliente, Nombre_Aplicacion, 
                Numero_Tiquete, Severidad_Tiquete, Estado_Tiquete, Comentarios_Tiquete, HorayFecha_Apertura, HorayFecha_Cierre FROM T_Tiquete
                WHERE Numero_Tiquete ='" + Tiquete.Numero_Tiquete + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                return objAcceso.Obtener_Tiquetes(sentencia);
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
