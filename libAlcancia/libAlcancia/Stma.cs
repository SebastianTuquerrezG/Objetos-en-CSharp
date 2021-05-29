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

        }
        #endregion
        #region Actualizadores
        public static bool actualizar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenominacionesAceptadasMonedas, List<int> prmDenominacionesAceptadasBilletes)
        {

        }
        public static bool actualizar(string prmNombre, int prmDenominacion, int prmAño)
        {

        }
        public static bool actualizar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {

        }
        #endregion
        #region Eliminar
        public static bool eliminar()
        {

        }
        public static bool eliminar(int prmDenominacion)
        {

        }
        public static bool eliminar(string prmSerie)
        {

        }
        #endregion
        #endregion
        #endregion
    }
}
