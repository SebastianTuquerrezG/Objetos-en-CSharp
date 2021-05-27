using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcancia.Dominio
{
    class clsBILLETE
    {
        #region Atributos
        #region Propios
        protected string atrSerie = "n.n";
        protected int atrMes = -1;
        protected int atrDia = -1;
        #endregion
        #endregion

        #region Operaciones
        #region Accesores
        public string darSerie()
        {
            return atrSerie;
        }
        public int darMes()
        {
            return atrMes;
        }
        public int darDia()
        {
            return atrDia;
        }
        #endregion
        #region Constructores
        #endregion
        #endregion
    }
}
