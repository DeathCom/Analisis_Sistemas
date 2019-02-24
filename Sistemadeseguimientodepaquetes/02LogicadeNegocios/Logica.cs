using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03AccesoDatos;
using _04Entidades;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace _02LogicadeNegocios
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

            #region Metodos Para Tabla DESTINO 
            public static void GuardarDato(DESTINO destino) //Metodo para Agregar informacion a la tabla DESTINO
            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    //sentencia.PETICION = @"INSERT INTO DESTINO VALUES ('" + destino.PAIS + "','" + destino.CIUDAD + "','" + destino.IMPUESTO + "')";
                    sentencia.PETICION = @"INSERT INTO DESTINO VALUES (@pais,@ciudad,@impuesto)";
                    #region Parametrización
                    SqlParameter pais = new SqlParameter();
                    pais.SqlDbType = System.Data.SqlDbType.NVarChar;
                    pais.ParameterName = "@pais";
                    pais.Value = destino.PAIS;

                        SqlParameter ciudad = new SqlParameter();
                    ciudad.SqlDbType = System.Data.SqlDbType.NVarChar;
                    ciudad.ParameterName = "@ciudad";
                    ciudad.Value = destino.CIUDAD;

                        SqlParameter impuesto = new SqlParameter();
                    impuesto.SqlDbType = System.Data.SqlDbType.Int;
                    impuesto.ParameterName = "@impuesto";
                    impuesto.Value = destino.IMPUESTO;

                    listParametros.Add(pais);
                    listParametros.Add(ciudad);
                    listParametros.Add(impuesto);

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
            public static void ModificarDato(DESTINO destino) //Metodo para Modificar informacion en la tabla DESTINO
            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    //sentencia.PETICION = @"UPDATE DESTINO SET PAIS='" + destino.PAIS + "', CIUDAD='" + destino.CIUDAD + "', IMPUESTO='" + destino.IMPUESTO + "' WHERE IDDESTINO='" + destino.IDDESTINO + "'";
                    sentencia.PETICION = @"UPDATE DESTINO SET PAIS= @pais, CIUDAD= @ciudad, IMPUESTO= @impuesto WHERE IDDESTINO= @iDdestino";
                    #region Parametrización
                    SqlParameter pais = new SqlParameter();
                    pais.SqlDbType = System.Data.SqlDbType.NVarChar;
                    pais.ParameterName = "@pais";
                    pais.Value = destino.PAIS;

                        SqlParameter ciudad = new SqlParameter();
                    ciudad.SqlDbType = System.Data.SqlDbType.NVarChar;
                    ciudad.ParameterName = "@ciudad";
                    ciudad.Value = destino.CIUDAD;

                        SqlParameter impuesto = new SqlParameter();
                    impuesto.SqlDbType = System.Data.SqlDbType.Int;
                    impuesto.ParameterName = "@impuesto";
                    impuesto.Value = destino.IMPUESTO;

                        SqlParameter iDdestino = new SqlParameter();
                    iDdestino.SqlDbType = System.Data.SqlDbType.Int;
                    iDdestino.ParameterName = "@iDdestino";
                    iDdestino.Value = destino.IDDESTINO;

                    listParametros.Add(pais);
                    listParametros.Add(ciudad);
                    listParametros.Add(impuesto);
                    listParametros.Add(iDdestino);

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
            public static void EliminarDato(DESTINO destino) //Metodo para Eliminar informacion en la tabla DESTINO
            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"DELETE FROM DESTINO WHERE IDDESTINO= @iDdestino";
                    #region Parametrización
                    SqlParameter iDdestino = new SqlParameter();
                    iDdestino.SqlDbType = System.Data.SqlDbType.Int;
                    iDdestino.ParameterName = "@iDdestino";
                    iDdestino.Value = destino.IDDESTINO;

                    listParametros.Add(iDdestino);

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
            public static List<DESTINO> obtDestinos()
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDDESTINO, PAIS, CIUDAD, IMPUESTO FROM DESTINO";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Destino(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } 
            public static List<DESTINO> BuscarDatoA(DESTINO destino) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM DESTINO WHERE IDDESTINO='" + destino.IDDESTINO + "'";
                _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Destino(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<DESTINO> BuscarDatoB(DESTINO destino) //Metodo para Buscar informacion en la tabla DESTINO
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM DESTINO WHERE PAIS='" + destino.PAIS + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Destino(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            #endregion

            #region Metodos Para Tabla ENVIO 
            public static void GuardarDato(ENVIO envio) //Metodo para Agregar informacion a la tabla Envio
            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    //sentencia.PETICION = @"INSERT INTO ENVIO VALUES ('" + envio.DESC_ENVIO + "','" + envio.PRECIO_ENVIO + "')";
                    sentencia.PETICION = @"INSERT INTO ENVIO VALUES (@DESC_ENVIO, @PRECIO_ENVIO)";
                    #region Parametrización
                    SqlParameter DESC_ENVIO = new SqlParameter();
                    DESC_ENVIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                    DESC_ENVIO.ParameterName = "@DESC_ENVIO";
                    DESC_ENVIO.Value = envio.DESC_ENVIO;

                    SqlParameter PRECIO_ENVIO = new SqlParameter();
                    PRECIO_ENVIO.SqlDbType = System.Data.SqlDbType.Int;
                    PRECIO_ENVIO.ParameterName = "@PRECIO_ENVIO";
                    PRECIO_ENVIO.Value = envio.PRECIO_ENVIO;

                    listParametros.Add(DESC_ENVIO);
                    listParametros.Add(PRECIO_ENVIO);

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
            public static void ModificarDato(ENVIO envio) //Metodo para Modificar informacion en la tabla envio

            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    //sentencia.PETICION = @"UPDATE ENVIO SET IDENVIO='" + envio.IDENVIO + "', DESC_ENVIO='" + envio.DESC_ENVIO + "', , PRECIO_ENVIO='" + envio.PRECIO_ENVIO + "' WHERE IDENVIO='" + envio.IDENVIO + "'";
                    sentencia.PETICION = @"UPDATE ENVIO SET DESC_ENVIO= @DESC_ENVIO, PRECIO_ENVIO= @PRECIO_ENVIO WHERE IDENVIO= @IDENVIO";
                    #region Parametrización
                    SqlParameter IDENVIO = new SqlParameter();
                    IDENVIO.SqlDbType = System.Data.SqlDbType.Int;
                    IDENVIO.ParameterName = "@IDENVIO";
                    IDENVIO.Value = envio.IDENVIO;

                    SqlParameter DESC_ENVIO = new SqlParameter();
                    DESC_ENVIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                    DESC_ENVIO.ParameterName = "@DESC_ENVIO";
                    DESC_ENVIO.Value = envio.DESC_ENVIO;

                    SqlParameter PRECIO_ENVIO = new SqlParameter();
                    PRECIO_ENVIO.SqlDbType = System.Data.SqlDbType.Int;
                    PRECIO_ENVIO.ParameterName = "@PRECIO_ENVIO";
                    PRECIO_ENVIO.Value = envio.PRECIO_ENVIO;

                    listParametros.Add(DESC_ENVIO);
                    listParametros.Add(PRECIO_ENVIO);
                    listParametros.Add(IDENVIO);

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
            public static void EliminarDato(ENVIO envio) //Metodo para Eliminar informacion en la tabla envio

            {
                try
                {
                    ArrayList listParametros = new ArrayList();
                    SQLSentencia sentencia = new SQLSentencia();
                    //sentencia.PETICION = @"DELETE FROM ENVIO WHERE IDENVIO='" + envio.IDENVIO + "'";
                    sentencia.PETICION = @"DELETE FROM ENVIO WHERE IDENVIO= @IDENVIO";
                    #region Parametrización
                    SqlParameter IDENVIO = new SqlParameter();
                    IDENVIO.SqlDbType = System.Data.SqlDbType.Int;
                    IDENVIO.ParameterName = "@IDENVIO";
                    IDENVIO.Value = envio.IDENVIO;

                    listParametros.Add(IDENVIO);

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
            public static List<ENVIO> obtEnvio()
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT IDENVIO, DESC_ENVIO, PRECIO_ENVIO FROM ENVIO";
                    Acceso objacceso = new Acceso();
                    return objacceso.Obtener_Envio(sentencia);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static List<ENVIO> BuscarDatoA(ENVIO envio) //Metodo para Buscar informacion en la tabla envio
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM ENVIO WHERE IDENVIO='" + envio.IDENVIO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Envio(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<ENVIO> BuscarDatoB(ENVIO envio) //Metodo para Buscar informacion en la tabla envio
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM ENVIO WHERE DESC_ENVIO='" + envio.DESC_ENVIO+ "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Envio(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            #endregion

            #region Metodos Para Tabla ESTADO 
            public static void GuardarDato(ESTADO estado) //Metodo para Agregar informacion a la tabla Estado
                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        //sentencia.PETICION = @"INSERT INTO ESTADO VALUES ('" + estado.DESC_ESTADO + "')";
                        sentencia.PETICION = @"INSERT INTO ESTADO VALUES (@DESC_ESTADO)";
                        #region Parametrización
                        SqlParameter DESC_ESTADO = new SqlParameter();
                        DESC_ESTADO.SqlDbType = System.Data.SqlDbType.NVarChar;
                        DESC_ESTADO.ParameterName = "@DESC_ESTADO";
                        DESC_ESTADO.Value = estado.DESC_ESTADO;

                        listParametros.Add(DESC_ESTADO);

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
            public static void ModificarDato(ESTADO estado) //Metodo para Modificar informacion en la tabla Estado
                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        //sentencia.PETICION = @"UPDATE ESTADO SET IDESTADO='" + estado.IDESTADO + "', DESC_ESTADO='" + estado.DESC_ESTADO + "' WHERE IDESTADO='" + estado.IDESTADO + "'";
                        sentencia.PETICION = @"UPDATE ESTADO SET DESC_ESTADO= @DESC_ESTADO WHERE IDESTADO= @IDESTADO";
                        #region Parametrización
                        SqlParameter DESC_ESTADO = new SqlParameter();
                        DESC_ESTADO.SqlDbType = System.Data.SqlDbType.NVarChar;
                        DESC_ESTADO.ParameterName = "@DESC_ESTADO";
                        DESC_ESTADO.Value = estado.DESC_ESTADO;

                        SqlParameter IDESTADO = new SqlParameter();
                        IDESTADO.SqlDbType = System.Data.SqlDbType.Int;
                        IDESTADO.ParameterName = "@IDESTADO";
                        IDESTADO.Value = estado.IDESTADO;

                        listParametros.Add(DESC_ESTADO);
                        listParametros.Add(IDESTADO);

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
            public static void EliminarDato(ESTADO estado) //Metodo para Eliminar informacion en la tabla Estado

                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        //sentencia.PETICION = @"DELETE FROM ESTADO WHERE IDESTADO='" + estado.IDESTADO + "'";
                        sentencia.PETICION = @"DELETE FROM ESTADO WHERE IDESTADO= @IDESTADO";
                        #region Parametrización
                        SqlParameter IDESTADO = new SqlParameter();
                        IDESTADO.SqlDbType = System.Data.SqlDbType.Int;
                        IDESTADO.ParameterName = "@IDESTADO";
                        IDESTADO.Value = estado.IDESTADO;

                        listParametros.Add(IDESTADO);

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
            public static List<ESTADO> obtEstado()
                {
                    try
                    {
                        SQLSentencia sentencia = new SQLSentencia();
                        sentencia.PETICION = @"SELECT IDESTADO, DESC_ESTADO  FROM ESTADO";
                        Acceso objacceso = new Acceso();
                        return objacceso.Obtener_Estado(sentencia);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            public static List<ESTADO> BuscarDatoA(ESTADO estado) //Metodo para Buscar informacion en la tabla estado
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM ESTADO WHERE IDESTADO='" + estado.IDESTADO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Estado(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<ESTADO> BuscarDatoB(ESTADO estado) //Metodo para Buscar informacion en la tabla envio
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM ESTADO WHERE DESC_ESTADO='" + estado.DESC_ESTADO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Estado(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            #endregion

            #region Metodos Para Tabla ORIGEN 
            public static void GuardarDato(ORIGEN origen) //Metodo para Agregar informacion a la tabla Origen
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
            public static void ModificarDato(ORIGEN origen) //Metodo para Modificar informacion en la tabla Origen
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
            public static void EliminarDato(ORIGEN origen) //Metodo para Eliminar informacion en la tabla origen
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
            public static List<ORIGEN> obtOrigen()
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
            public static List<ORIGEN> BuscarDatoA(ORIGEN origen) //Metodo para Buscar informacion en la tabla origen
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM ORIGEN WHERE IDORIGEN='" + origen.IDORIGEN+ "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Origen(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<ORIGEN> BuscarDatoB(ORIGEN origen) //Metodo para Buscar informacion en la tabla origen
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

            #region Metodos Para Tabla PAGO
            public static void GuardarDato(PAGO pago) //Metodo para Agregar informacion a la tabla Pago
                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        //sentencia.PETICION = @"INSERT INTO PAGO VALUES ('" + pago.DESC_PAGO + "')";
                        sentencia.PETICION = @"INSERT INTO PAGO VALUES (@DESC_PAGO)";
                        #region Parametrización
                        SqlParameter DESC_PAGO = new SqlParameter();
                        DESC_PAGO.SqlDbType = System.Data.SqlDbType.NVarChar;
                        DESC_PAGO.ParameterName = "@DESC_PAGO";
                        DESC_PAGO.Value = pago.DESC_PAGO;

                        listParametros.Add(DESC_PAGO);

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
            public static void ModificarDato(PAGO pago) //Metodo para Modificar informacion en la tabla Pago
                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        sentencia.PETICION = @"UPDATE PAGO SET DESC_PAGO= @DESC_PAGO WHERE IDPAGO= @IDPAGO";
                        #region Parametrización
                        SqlParameter DESC_PAGO = new SqlParameter();
                        DESC_PAGO.SqlDbType = System.Data.SqlDbType.NVarChar;
                        DESC_PAGO.ParameterName = "@DESC_PAGO";
                        DESC_PAGO.Value = pago.DESC_PAGO;

                        SqlParameter IDPAGO = new SqlParameter();
                        IDPAGO.SqlDbType = System.Data.SqlDbType.Int;
                        IDPAGO.ParameterName = "@IDPAGO";
                        IDPAGO.Value = pago.IDPAGO;

                        listParametros.Add(DESC_PAGO);
                        listParametros.Add(IDPAGO);

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
            public static void EliminarDato(PAGO pago) //Metodo para Eliminar informacion en la tabla Pago
                {
                    try
                    {
                        ArrayList listParametros = new ArrayList();
                        SQLSentencia sentencia = new SQLSentencia();
                        //sentencia.PETICION = @"DELETE FROM PAGO WHERE IDPAGO='" + pago.IDPAGO + "'";
                        sentencia.PETICION = @"DELETE FROM PAGO WHERE IDPAGO= @IDPAGO";
                        #region Parametrización
                        SqlParameter IDPAGO = new SqlParameter();
                        IDPAGO.SqlDbType = System.Data.SqlDbType.Int;
                        IDPAGO.ParameterName = "@IDPAGO";
                        IDPAGO.Value = pago.IDPAGO;

                        listParametros.Add(IDPAGO);

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
            public static List<PAGO> obtPago()
                {
                    try
                    {
                        SQLSentencia sentencia = new SQLSentencia();
                        sentencia.PETICION = @"SELECT IDPAGO, DESC_PAGO FROM PAGO";
                        Acceso objacceso = new Acceso();
                        return objacceso.Obtener_Pago(sentencia);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            public static List<PAGO> BuscarDatoA(PAGO pago) //Metodo para Buscar informacion en la tabla estado
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM PAGO WHERE IDPAGO='" + pago.IDPAGO+ "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Pago(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public static List<PAGO> BuscarDatoB(PAGO pago) //Metodo para Buscar informacion en la tabla envio
            {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.PETICION = @"SELECT * FROM PAGO WHERE DESC_PAGO='" + pago.DESC_PAGO + "'";
                    _03AccesoDatos.Acceso objAcceso = new _03AccesoDatos.Acceso();
                    return objAcceso.Obtener_Pago(sentencia);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            #endregion

            #region Metodos Para Tabla PEDIDOS 
            public static void GuardarDato(PEDIDOS pedido) //Metodo para Agregar informacion a la tabla DESTINO
                    {
                        try
                        {
                            ArrayList listParametros = new ArrayList();
                            SQLSentencia sentencia = new SQLSentencia();
                            sentencia.PETICION = @"INSERT INTO PEDIDOS VALUES (@IDUSUARIO, @IDPAISORIGEN, @IDPAISDESTINO, @IDPAGO, @IDENVIO, @IDESTADO, @TOTAL, @DESCRIPCION, @IDCIUDADDESTINO, @IDCIUDADORIGEN)";
                            #region Parametrización
                            SqlParameter IDUSUARIO = new SqlParameter();
                            IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                            IDUSUARIO.ParameterName = "@IDUSUARIO";
                            IDUSUARIO.Value = pedido.IDUSUARIO;

                            SqlParameter IDPAISORIGEN = new SqlParameter();
                            IDPAISORIGEN.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAISORIGEN.ParameterName = "@IDPAISORIGEN";
                            IDPAISORIGEN.Value = pedido.IDPAISORIGEN;

                            SqlParameter IDPAISDESTINO = new SqlParameter();
                            IDPAISDESTINO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAISDESTINO.ParameterName = "@IDPAISDESTINO";
                            IDPAISDESTINO.Value = pedido.IDPAISDESTINO;

                            SqlParameter IDPAGO = new SqlParameter();
                            IDPAGO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAGO.ParameterName = "@IDPAGO";
                            IDPAGO.Value = pedido.IDPAGO;

                            SqlParameter IDENVIO = new SqlParameter();
                            IDENVIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDENVIO.ParameterName = "@IDENVIO";
                            IDENVIO.Value = pedido.IDENVIO;

                            SqlParameter IDESTADO = new SqlParameter();
                            IDESTADO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDESTADO.ParameterName = "@IDESTADO";
                            IDESTADO.Value = pedido.IDESTADO;

                            SqlParameter TOTAL = new SqlParameter();
                            TOTAL.SqlDbType = System.Data.SqlDbType.Int;
                            TOTAL.ParameterName = "@TOTAL";
                            TOTAL.Value = pedido.TOTAL;

                            SqlParameter DESCRIPCION = new SqlParameter();
                            DESCRIPCION.SqlDbType = System.Data.SqlDbType.NVarChar;
                            DESCRIPCION.ParameterName = "@DESCRIPCION";
                            DESCRIPCION.Value = pedido.DESCRIPCION;

                            SqlParameter IDCIUDADDESTINO = new SqlParameter();
                            IDCIUDADDESTINO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDCIUDADDESTINO.ParameterName = "@IDCIUDADDESTINO";
                            IDCIUDADDESTINO.Value = pedido.IDCIUDADDESTINO;

                            SqlParameter IDCIUDADORIGEN = new SqlParameter();
                            IDCIUDADORIGEN.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDCIUDADORIGEN.ParameterName = "@IDCIUDADORIGEN";
                            IDCIUDADORIGEN.Value = pedido.IDCIUDADORIGEN;

                            listParametros.Add(IDUSUARIO);
                            listParametros.Add(IDPAISORIGEN);
                            listParametros.Add(IDPAISDESTINO);
                            listParametros.Add(IDPAGO);
                            listParametros.Add(IDENVIO);
                            listParametros.Add(IDESTADO);
                            listParametros.Add(TOTAL);
                            listParametros.Add(DESCRIPCION);
                            listParametros.Add(IDCIUDADDESTINO);
                            listParametros.Add(IDCIUDADORIGEN);

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
            public static void ModificarDato(PEDIDOS pedido) //Metodo para Modificar informacion en la tabla DESTINO
                    {
                        try
                        {
                            ArrayList listParametros = new ArrayList();
                            SQLSentencia sentencia = new SQLSentencia();
                            //sentencia.PETICION = @"UPDATE PEDIDOS SET IDUSUARIO='" + pedido.IDUSUARIO + "', IDORIGEN='" + pedido.IDORIGEN + "', IDDESTINO='" + pedido.IDDESTINO + "', IDPAGO='" + pedido.IDPAGO + "', IDENVIO='" + pedido.IDENVIO + "', IDESTADO='" + pedido.IDESTADO + "', TOTAL='" + pedido.TOTAL + "', DESCRIPCION='" + pedido.DESCRIPCION + "' WHERE IDPEDIDO='" + pedido.IDPEDIDO + "'";
                            sentencia.PETICION = @"UPDATE PEDIDOS SET IDUSUARIO= @IDUSUARIO, IDPAISORIGEN= @IDPAISORIGEN, IDPAISDESTINO= @IDPAISDESTINO, IDPAGO= @IDPAGO, IDENVIO= @IDENVIO, IDESTADO= @IDESTADO, TOTAL= @TOTAL, DESCRIPCION= @DESCRIPCION, IDCIUDADDESTINO= @IDCIUDADDESTINO, IDCIUDADORIGEN= @IDCIUDADORIGEN WHERE IDPEDIDO= @IDPEDIDO";
                            #region Parametrización
                            SqlParameter IDUSUARIO = new SqlParameter();
                            IDUSUARIO.SqlDbType = System.Data.SqlDbType.Int;
                            IDUSUARIO.ParameterName = "@IDUSUARIO";
                            IDUSUARIO.Value = pedido.IDUSUARIO;

                            SqlParameter IDPAISORIGEN = new SqlParameter();
                            IDPAISORIGEN.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAISORIGEN.ParameterName = "@IDPAISORIGEN";
                            IDPAISORIGEN.Value = pedido.IDPAISORIGEN;

                            SqlParameter IDPAISDESTINO = new SqlParameter();
                            IDPAISDESTINO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAISDESTINO.ParameterName = "@IDPAISDESTINO";
                            IDPAISDESTINO.Value = pedido.IDPAISDESTINO;

                            SqlParameter IDPAGO = new SqlParameter();
                            IDPAGO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDPAGO.ParameterName = "@IDPAGO";
                            IDPAGO.Value = pedido.IDPAGO;

                            SqlParameter IDENVIO = new SqlParameter();
                            IDENVIO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDENVIO.ParameterName = "@IDENVIO";
                            IDENVIO.Value = pedido.IDENVIO;

                            SqlParameter IDESTADO = new SqlParameter();
                            IDESTADO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDESTADO.ParameterName = "@IDESTADO";
                            IDESTADO.Value = pedido.IDESTADO;

                            SqlParameter TOTAL = new SqlParameter();
                            TOTAL.SqlDbType = System.Data.SqlDbType.Int;
                            TOTAL.ParameterName = "@TOTAL";
                            TOTAL.Value = pedido.TOTAL;

                            SqlParameter DESCRIPCION = new SqlParameter();
                            DESCRIPCION.SqlDbType = System.Data.SqlDbType.NVarChar;
                            DESCRIPCION.ParameterName = "@DESCRIPCION";
                            DESCRIPCION.Value = pedido.DESCRIPCION;

                            SqlParameter IDCIUDADDESTINO = new SqlParameter();
                            IDCIUDADDESTINO.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDCIUDADDESTINO.ParameterName = "@IDCIUDADDESTINO";
                            IDCIUDADDESTINO.Value = pedido.IDCIUDADDESTINO;

                            SqlParameter IDCIUDADORIGEN = new SqlParameter();
                            IDCIUDADORIGEN.SqlDbType = System.Data.SqlDbType.NVarChar;
                            IDCIUDADORIGEN.ParameterName = "@IDCIUDADORIGEN";
                            IDCIUDADORIGEN.Value = pedido.IDCIUDADORIGEN;

                            SqlParameter IDPEDIDO = new SqlParameter();
                            IDPEDIDO.SqlDbType = System.Data.SqlDbType.Int;
                            IDPEDIDO.ParameterName = "@IDPEDIDO";
                            IDPEDIDO.Value = pedido.IDPEDIDO;

                            listParametros.Add(IDUSUARIO);
                            listParametros.Add(IDPAISORIGEN);
                            listParametros.Add(IDPAISDESTINO);
                            listParametros.Add(IDPAGO);
                            listParametros.Add(IDENVIO);
                            listParametros.Add(IDESTADO);
                            listParametros.Add(TOTAL);
                            listParametros.Add(DESCRIPCION);
                            listParametros.Add(IDPEDIDO);
                            listParametros.Add(IDCIUDADDESTINO);
                            listParametros.Add(IDCIUDADORIGEN);

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
            public static void EliminarDato(PEDIDOS pedido) //Metodo para Eliminar informacion en la tabla DESTINO
                    {
                        try
                        {
                            ArrayList listParametros = new ArrayList();
                            SQLSentencia sentencia = new SQLSentencia();
                            sentencia.PETICION = @"DELETE FROM PEDIDOS WHERE IDPEDIDO=@IDPEDIDO";
                            #region Parametrización
                            SqlParameter IDPEDIDO = new SqlParameter();
                            IDPEDIDO.SqlDbType = System.Data.SqlDbType.Int;
                            IDPEDIDO.ParameterName = "@IDPEDIDO";
                            IDPEDIDO.Value = pedido.IDPEDIDO;

                            listParametros.Add(IDPEDIDO);

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
            public static List<PEDIDOS> obtPedidos()
                    {
                        try
                        {
                            SQLSentencia sentencia = new SQLSentencia();
                            sentencia.PETICION = @"SELECT IDPEDIDO, IDUSUARIO, IDPAISORIGEN, IDPAISDESTINO, IDPAGO, IDENVIO, IDESTADO, TOTAL, DESCRIPCION, IDCIUDADDESTINO, IDCIUDADORIGEN  FROM PEDIDOS";
                            Acceso objacceso = new Acceso();
                            return objacceso.Obtener_Pedidos(sentencia);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
            public static List<PEDIDOS> BuscarDatoA(PEDIDOS pedido) //Metodo para Buscar informacion en la tabla DESTINO
                    {
                        /*Metodo recibe un parametro objeto PEDIDOS que viene de Presentacion con un campo pedido.IDUSUARIO
                         para realizar la bussqueda y el retorno de una lista, este metodo es transacionado por el acceso a datos
                         en su metodo Obtener_Pedidos*/
                        try
                        {
                            SQLSentencia sentencia = new SQLSentencia();
                            sentencia.PETICION = @"SELECT *  FROM PEDIDOS WHERE IDUSUARIO ='" + pedido.IDUSUARIO+ "'";
                            Acceso objacceso = new Acceso();
                            return objacceso.Obtener_Pedidos(sentencia);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
            public static List<PEDIDOS> BuscarDatoB(PEDIDOS pedido) //Metodo para Buscar informacion en la tabla DESTINO
                    {
                        /*Metodo recibe un parametro objeto PEDIDOS que viene de Presentacion con un campo pedido.IDPEDIDO
                            para realizar la bussqueda y el retorno de una lista, este metodo es transacionado por el acceso a datos
                            en su metodo Obtener_Pedidos*/
                        try
                        {
                            SQLSentencia sentencia = new SQLSentencia();
                            sentencia.PETICION = @"SELECT *  FROM PEDIDOS WHERE IDPEDIDO='" + pedido.IDPEDIDO + "'";
                            Acceso objacceso = new Acceso();
                            return objacceso.Obtener_Pedidos(sentencia);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
            #endregion

            #region Metodos Para Tabla USUARIO
            public static void GuardarDato(USUARIOS user) //Metodo para Agregar informacion a la tabla DESTINO
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
            public static void ModificarDato(USUARIOS user) //Metodo para Modificar informacion en la tabla DESTINO
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
            public static void EliminarDato(USUARIOS user) //Metodo para Eliminar informacion en la tabla DESTINO
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
            public static List<USUARIOS> obtUsuarios()
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
            public static List<USUARIOS> BuscarDatoA(USUARIOS user) //Metodo para Buscar informacion en la tabla DESTINO
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
            public static List<USUARIOS> BuscarDatoB(USUARIOS user) //Metodo para Buscar informacion en la tabla DESTINO
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
