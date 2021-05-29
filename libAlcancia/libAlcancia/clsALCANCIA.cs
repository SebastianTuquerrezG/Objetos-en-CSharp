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
            atrCapacidadMonedas = 50;
            atrDenominacionesAceptadasMonedas = new List<int>() { 50, 100, 200, 500, 1000 };
            atrSaldoPorDenominacionMonedas = new List<int>() { 300, 0, 400, 500, 3000 };
            atrConteoPorDenominacionMonedas = new List<int>() { 6, 0, 2, 1, 3 };
            atrSaldoTotalMonedas = 4200;
            
            atrCapacidadBilletes = 20;
            atrDenominacionesAceptadasBilletes = new List<int>() { 1000, 2000, 5000, 10000, 20000, 50000 };
            atrSaldoPorDenominacionBilletes = new List<int>() { 5000, 4000, 0, 30000, 0, 0 };
            atrConteoPorDenominacionBilletes = new List<int>() { 5, 2, 0, 3, 0, 0 };
            atrSaldoTotalBilletes = 39000;

            atrSaldoTotal = 43200;
        }
        #endregion
        #endregion
    }
}