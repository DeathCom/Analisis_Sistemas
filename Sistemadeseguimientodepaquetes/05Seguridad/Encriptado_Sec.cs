using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04Entidades;

namespace _05Seguridad
{
    public class Encriptado_Sec
    {
        #region Metodo Encriptar
        public Encriptado Encriptar(Encriptado ObjEncriptar)
        {
            try
            {
                ObjEncriptar.ARRHASH = System.Text.Encoding.Unicode.GetBytes(ObjEncriptar.PALABRA);
                ObjEncriptar.RESPUESTA = Convert.ToBase64String(ObjEncriptar.ARRHASH);
                return ObjEncriptar;
            }
            catch (Exception ex)
            {
                ObjEncriptar.RESPUESTA = ex.Message.ToString();
                return ObjEncriptar;
            }
        }
        #endregion

        #region Metodo DesEncriptar
        public Encriptado DesEncriptar(Encriptado ObjDesEncriptar)
        {
            try
            {
                ObjDesEncriptar.ARRHASH = Convert.FromBase64String(ObjDesEncriptar.PALABRA);
                ObjDesEncriptar.RESPUESTA = System.Text.Encoding.Unicode.GetString(ObjDesEncriptar.ARRHASH);
                return ObjDesEncriptar;
            }
            catch (Exception ex)
            {
                ObjDesEncriptar.RESPUESTA = ex.Message.ToString();
                return ObjDesEncriptar;
            }
        }
        #endregion
    }
}
