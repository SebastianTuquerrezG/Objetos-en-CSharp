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
        public static bool registrar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenominacionesAceptadasMonedas, List<int> prmDenominacionesAceptadasBilletes)
        {
            if(atrAlcancia == null)
            {
                atrAlcancia = new clsALCANCIA(prmNombre, prmCapacidadMonedas, prmCapacidadBilletes, prmDenominacionesAceptadasMonedas, prmDenominacionesAceptadasBilletes);
                return true;
            }
            return false;
        }
        public static bool registrar(string prmNombre, int prmDenominacion, int prmAño)
        {
            atrMonedas.Add(new clsMONEDA(prmNombre, prmDenominacion, prmAño));
            return true;
        }
        public static bool registrar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
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
            if (atrAlcancia != null)
            {
                atrAlcancia.ponerNombre(prmNombre);
                atrAlcancia.ponerCapacidadMonedas(prmCapacidadMonedas);
                atrAlcancia.ponerCapacidadBilletes(prmCapacidadBilletes);
                atrAlcancia.ponerDenominacionesAceptadasMonedas(prmDenominacionesAceptadasMonedas);
                atrAlcancia.ponerDenominacionesAceptadasBilletes(prmDenominacionesAceptadasBilletes);
                return true;
            }
            return false;
        }
        public static bool actualizar(string prmNombre, int prmDenominacion, int prmAño)
        {
            foreach(clsMONEDA varObjeto in atrMonedas)
            {
                if (prmDenominacion == varObjeto.darDenominacion())
                {
                    if (varObjeto.darAlcancia() == null)
                    {
                        varObjeto.ponerNombre(prmNombre);
                        varObjeto.ponerDenominacion(prmDenominacion);
                    }
                    varObjeto.ponerAño(prmAño);
                    return true;
                }
            }
            return false;
        }
        public static bool actualizar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            foreach (clsBILLETE varObjeto in atrBilletes)
            {
                if (prmSerie == varObjeto.darSerie())
                {
                    if (varObjeto.darAlcancia() == null)
                    {
                        varObjeto.ponerNombre(prmNombre);
                        varObjeto.ponerDenominacion(prmDenominacion);
                    }
                    varObjeto.ponerAño(prmAño);
                    varObjeto.ponerMes(prmMes);
                    varObjeto.ponerDia(prmDia);
                    varObjeto.ponerSerie(prmSerie);
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Eliminar
        public static bool eliminar()
        {
            throw new NotImplementedException();
        }
        public static bool eliminar(int prmDenominacion)
        {
            foreach(clsMONEDA varObjeto in atrMonedas)
            {
                if(varObjeto.darAlcancia() == null && varObjeto.darDenominacion() == prmDenominacion)
                {
                    atrMonedas.Remove(varObjeto);
                    return true;
                }
            }
            return false;
        }
        public static bool eliminar(string prmSerie)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Transsaccion
        public static bool consignar(clsMONEDA prmObjeto)
        {
            throw new NotImplementedException();
        }
        public static bool consignar(clsBILLETE prmObjeto)
        {
            throw new NotImplementedException();
        }
        public static bool retirar(int prmDenominacion, clsMONEDA prmObjeto)
        {
            throw new NotImplementedException();
        }
        public static bool retirar(int prmDenominacion, clsBILLETE prmObjeto)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
        #endregion
    }
}
