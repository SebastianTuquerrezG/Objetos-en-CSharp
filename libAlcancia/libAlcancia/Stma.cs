using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcancia.Dominio
{
    public static class Stma
    {
        #region Atributos
        #region Asociativos
        private static clsALCANCIA atrAlcancia;
        private static List<clsMONEDA> atrMonedas;
        private static List<clsBILLETE> atrBilletes;
        #endregion
        #endregion

        #region Operaciones
        #region Cruds
        #region Registradores
        public static bool retirar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenominacionesAceptadasMonedas, List<int> prmDenominacionesAceptadasBilletes)
        {
            if(atrAlcancia == null)
            {
                atrAlcancia = new clsALCANCIA(prmNombre, prmCapacidadMonedas, prmCapacidadBilletes, prmDenominacionesAceptadasMonedas, prmDenominacionesAceptadasBilletes);
                return true;
            }
            return false;
        }
        public static bool retirar(string prmNombre, int prmDenominacion, int prmAño)
        {
            atrMonedas.Add(new clsMONEDA(prmNombre, prmDenominacion, prmAño));
            return true;
        }
        public static bool retirar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            foreach (clsBILLETE varObjeto in atrBilletes)
                if (varObjeto.darSerie() == prmSerie)
                    return false;
            atrBilletes.Add(new clsBILLETE(prmSerie, prmNombre, prmDenominacion, prmAño, prmMes, prmDia));
            return true;
        }
        #endregion
        #region Actualizadores
        public static bool actualizar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenominacionesAceptadasMonedas, List<int> prmDenominacionesAceptadasBilletes)
        {
            throw new NotImplementedException();
        }
        public static bool actualizar(string prmNombre, int prmDenominacion, int prmAño)
        {
            throw new NotImplementedException();
        }
        public static bool actualizar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Eliminar
        public static bool eliminar()
        {
            throw new NotImplementedException();
        }
        public static bool eliminar(int prmDenominacion)
        {
            throw new NotImplementedException();
        }
        public static bool eliminar(string prmSerie)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
        #endregion
    }
}
