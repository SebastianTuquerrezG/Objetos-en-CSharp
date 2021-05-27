using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcancia.Dominio
{
    class clsMONEDA
    {
        #region Atributos
        #region Propios
        protected string atrNombre = "n.n";
        protected int atrDenominacion = -1;
        protected int atrAño = -1;
        #endregion
        #endregion

        #region Operaciones
        #region Accesores
        public string darNombre()
        {
            return null;
        }
        public int darDenominacion()
        {
            return atrDenominacion;
        }
        public int darAño()
        {
            return atrAño;
        }
        #endregion
        #region Constructores
        public clsMONEDA(string prmNombre, int prmDenominacion, int prmAño)
        {

        }
        public void Generar() { }
        #endregion
        #endregion
    }
}
