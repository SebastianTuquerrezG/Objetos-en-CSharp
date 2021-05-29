// File:    clsALCANCIA.cs
// Author:  JOAN SEBASTIAN TUQUERREZ GOMEZ
// Created: martes, 25 de mayo de 2021 4:57:43 p. m.
// Purpose: Definition of Class clsALCANCIA
using System.Collections.Generic;
using System;
namespace Alcancia.Dominio
{
    public class clsALCANCIA
    {
        #region Atributos
        #region Atributos Propios
        private string atrNombre = "ninguno";
        private int atrCapacidadMonedas = 0;
        private List<int> atrDenominacionesAceptadasMonedas = null;
        private int atrCapacidadBilletes = 0;
        private List<int> atrDenominacionesAceptadasBilletes = null;
        #endregion
        #region Atributos Derivables
        private List<int> atrSaldoPorDenominacionMonedas = null;
        private List<int> atrConteoPorDenominacionMonedas = null;
        private int atrSaldoTotalMonedas = 0;
        private List<int> atrSaldoPorDenominacionBilletes = null;
        private List<int> atrConteoPorDenominacionBilletes = null;
        private int atrSaldoTotalBilletes = 0;
        private int atrSaldoTotal = 0;
        #endregion
        #region Atributos Asociativos
        private List<clsMONEDA> atrMonedas = null;
        private List<clsBILLETE> atrBilletes = null;
        #endregion
        #endregion

        #region Operaciones
        #region Accesores
        #region Accesores Atributos Propios
        public string darNombre()
        {
            return atrNombre;
        }
        public int darCapacidadMonedas()
        {
            return atrCapacidadMonedas;
        }
        public int darCapacidadBilletes()
        {
            return atrCapacidadBilletes;
        }
        public List<int> darDenominacionesAceptadasMonedas()
        {
            return atrDenominacionesAceptadasMonedas;
        }
        public List<int> darDenominacionesAceptadasBilletes()
        {
            return atrDenominacionesAceptadasBilletes;
        }
        #endregion
        #region Accesores Atributos Derivables
        public List<int> darSaldoPorDenominacionMonedas()
        {
            return atrSaldoPorDenominacionMonedas;
        }
        public List<int> darSaldoPorDenominacionBilletes()
        {
            return atrSaldoPorDenominacionBilletes;
        }
        public List<int> darConteoPorDenominacionMonedas()
        {
            return atrConteoPorDenominacionMonedas;
        }
        public List<int> darConteoPorDenominacionBilletes()
        {
            return atrConteoPorDenominacionBilletes;
        }
        public int darSaldoTotalMonedas()
        {
            return atrSaldoTotalMonedas;
        }
        public int darSaldoTotalBilletes()
        {
            return atrSaldoTotalBilletes;
        }
        public int darSaldoTotal()
        {
            return atrSaldoTotal;
        }
        #endregion
        #region Accesores Atributos Asociativos
        public List<clsMONEDA> darMonedas()
        {
            return atrMonedas;
        }
        public List<clsBILLETE> darBilletes()
        {
            return atrBilletes;
        }
        #endregion
        #endregion
        #region Mutadores
        public void ponerNombre(string prmValor)
        {
            atrNombre = prmValor;
        }
        public void ponerCapacidadMonedas(int prmValor)
        {
            if (prmValor > atrCapacidadMonedas)
                atrCapacidadMonedas = prmValor;
        }
        public void ponerCapacidadBilletes(int prmValor)
        {
            if (prmValor > atrCapacidadBilletes)
                atrCapacidadBilletes = prmValor;
        }
        public bool ponerDenominacionesAceptadasMonedas(List<int> prmLista)
        {
            if(atrDenominacionesAceptadasMonedas != null)
            {
                #region Verificar No Eliminar con Saldos y Conteo Distinto de Cero
                for (int varIndice = 0; varIndice < atrDenominacionesAceptadasMonedas.Count; varIndice++)
                    if (!prmLista.Contains(atrDenominacionesAceptadasMonedas[varIndice]) && atrConteoPorDenominacionMonedas[varIndice] != 0)
                        return false;
                #endregion
                #region Eliminar Saldos y Conteos (en Cero) para una Denominacion Descartada
                for (int varIndice = 0; varIndice < atrDenominacionesAceptadasMonedas.Count; varIndice++)
                {
                    bool varDenominacionEncontrada = false;
                    for(int varIndice2 = 0; varIndice2 <prmLista.Count; varIndice2++)
                    {
                        if(atrDenominacionesAceptadasMonedas[varIndice] == prmLista[varIndice2])
                        {
                            varDenominacionEncontrada = true;
                            break;
                        }
                    }
                    if(!varDenominacionEncontrada)
                    {
                        atrDenominacionesAceptadasMonedas.RemoveAt(varIndice);
                        atrSaldoPorDenominacionMonedas.RemoveAt(varIndice);
                        atrConteoPorDenominacionMonedas.RemoveAt(varIndice);
                    }
                }
                return true;
                #endregion
            }
            atrDenominacionesAceptadasMonedas = prmLista;
            return true;
        }
        public bool ponerDenominacionesAceptadasBilletes(List<int> prmLista)
        {
            if (atrDenominacionesAceptadasBilletes != null)
            {
                #region Verificar No Eliminar con Saldos y Conteo Distinto de Cero
                for (int varIndice = 0; varIndice < atrDenominacionesAceptadasBilletes.Count; varIndice++)
                    if (!prmLista.Contains(atrDenominacionesAceptadasBilletes[varIndice]) && atrConteoPorDenominacionBilletes[varIndice] != 0)
                        return false;
                #endregion
                #region Eliminar Saldos y Conteos (en Cero) para una Denominacion Descartada
                for (int varIndice = 0; varIndice < atrDenominacionesAceptadasBilletes.Count; varIndice++)
                {
                    bool varDenominacionEncontrada = false;
                    for (int varIndice2 = 0; varIndice2 < prmLista.Count; varIndice2++)
                    {
                        if (atrDenominacionesAceptadasBilletes[varIndice] == prmLista[varIndice2])
                        {
                            varDenominacionEncontrada = true;
                            break;
                        }
                    }
                    if (!varDenominacionEncontrada)
                    {
                        atrDenominacionesAceptadasBilletes.RemoveAt(varIndice);
                        atrSaldoPorDenominacionBilletes.RemoveAt(varIndice);
                        atrConteoPorDenominacionBilletes.RemoveAt(varIndice);
                    }
                }
                return true;
                #endregion
            }
            atrDenominacionesAceptadasBilletes = prmLista;
            return true;
        }
        #endregion
        #region Constructores
        public clsALCANCIA(){ }
        public clsALCANCIA(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenominacionesAceptadasMonedas, List<int> prmDenominacionesAceptadasBilletes)
        {
            atrNombre = prmNombre;
            atrCapacidadMonedas = prmCapacidadMonedas;
            atrDenominacionesAceptadasMonedas = prmDenominacionesAceptadasMonedas;
            atrCapacidadBilletes = prmCapacidadBilletes;
            atrDenominacionesAceptadasBilletes = prmDenominacionesAceptadasBilletes;
        }
        public void Generar()
        {
            atrNombre = "Marranito";
            atrCapacidadMonedas = 13;
            atrDenominacionesAceptadasMonedas = new List<int>() { 50, 100, 200, 500, 1000 };
            atrSaldoPorDenominacionMonedas = new List<int>() { 300, 0, 400, 500, 3000 };
            atrConteoPorDenominacionMonedas = new List<int>() { 6, 0, 2, 1, 3 };
            atrSaldoTotalMonedas = 4200;

            #region Monedas
            atrMonedas = new List<clsMONEDA>();
            atrMonedas.Add(new clsMONEDA("COP", 50, 1990));
            atrMonedas.Add(new clsMONEDA("COP", 50, 1991));
            atrMonedas.Add(new clsMONEDA("COP", 50, 1990));
            atrMonedas.Add(new clsMONEDA("COP", 50, 1994));
            atrMonedas.Add(new clsMONEDA("COP", 50, 1990));
            atrMonedas.Add(new clsMONEDA("COP", 50, 1990));

            atrMonedas.Add(new clsMONEDA("COP", 200, 1993));
            atrMonedas.Add(new clsMONEDA("COP", 200, 1999));

            atrMonedas.Add(new clsMONEDA("COP", 500, 1993));

            atrMonedas.Add(new clsMONEDA("COP", 1000, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 1000, 2011));
            atrMonedas.Add(new clsMONEDA("COP", 1000, 2010));
            #endregion

            atrCapacidadBilletes = 20;
            atrDenominacionesAceptadasBilletes = new List<int>() { 1000, 2000, 5000, 10000, 20000, 50000 };
            atrSaldoPorDenominacionBilletes = new List<int>() { 5000, 4000, 0, 30000, 0, 0 };
            atrConteoPorDenominacionBilletes = new List<int>() { 5, 2, 0, 3, 0, 0 };
            atrSaldoTotalBilletes = 39000;

            #region Billetes
            atrBilletes = new List<clsBILLETE>();
            atrBilletes.Add(new clsBILLETE("ABC123", "COP", 1000, 1990, 1, 1));
            atrBilletes.Add(new clsBILLETE("DEF129", "COP", 1000, 1991, 1, 1));
            atrBilletes.Add(new clsBILLETE("GHI173", "COP", 1000, 1990, 1, 1));
            atrBilletes.Add(new clsBILLETE("JKL143", "COP", 1000, 1994, 1, 1));
            atrBilletes.Add(new clsBILLETE("QWE133", "COP", 1000, 1990, 1, 1));
        
            atrBilletes.Add(new clsBILLETE("BBC153", "COP", 2000, 1993, 1, 1));
            atrBilletes.Add(new clsBILLETE("CBC129", "COP", 2000, 1999, 1, 1));

            atrBilletes.Add(new clsBILLETE("QBC323", "COP", 10000, 2010, 1, 1));
            atrBilletes.Add(new clsBILLETE("RBC623", "COP", 10000, 2011, 1, 1));
            atrBilletes.Add(new clsBILLETE("TBC723", "COP", 10000, 2010, 1, 1));
            #endregion
            atrSaldoTotal = 43200;
        }
        #endregion
        #region Asociadores
        public bool asociar(clsMONEDA prmObjeto)
        {
            if (atrMonedas.Count < atrCapacidadMonedas)
            {
                atrMonedas.Add(prmObjeto);
                return true;
            }
            return false;
        }
        public bool asociar(clsBILLETE prmObjeto)
        {
            atrBilletes.Add(prmObjeto);
            return true;
        }
        #endregion
        #region Disociadores
        public bool Disociar(int prmDenominacion, ref clsMONEDA prmObjeto)
        {
            throw new NotImplementedException();
        }
        public bool Disociar(int prmDenominacion, ref clsBILLETE prmObjeto)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Transacciones
        public bool consignar(clsMONEDA prmObjeto)
        {
            if (atrDenominacionesAceptadasMonedas.Contains(prmObjeto.darDenominacion()) && asociar(prmObjeto))
            {
                    atrSaldoPorDenominacionMonedas[atrDenominacionesAceptadasMonedas.IndexOf(prmObjeto.darDenominacion())] += prmObjeto.darDenominacion();
                    atrConteoPorDenominacionMonedas[atrDenominacionesAceptadasMonedas.IndexOf(prmObjeto.darDenominacion())] += 1;
                    atrSaldoTotalMonedas += prmObjeto.darDenominacion();
                    atrSaldoTotal += prmObjeto.darDenominacion();
                    return true;
            }
            return false;
        }
        #endregion
        #endregion
    }
}