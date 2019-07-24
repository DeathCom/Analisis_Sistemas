using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Entidades
{
    public class Encriptado
    {
        #region Varibles
        private string Palabra, Respuesta;
        private Byte[] arrHash;
        #endregion

        #region Metodos
        public string PALABRA
        {
            get
            {
                return Palabra;
            }

            set
            {
                Palabra = value;
            }
        }
        public string RESPUESTA
        {
            get
            {
                return Respuesta;
            }

            set
            {
                Respuesta = value;
            }
        }
        public byte[] ARRHASH
        {
            get
            {
                return arrHash;
            }

            set
            {
                arrHash = value;
            }
        }
        #endregion
    }
}
