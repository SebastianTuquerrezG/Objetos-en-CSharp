using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alcancia;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        #region Atributos
        clsALCANCIA varObjAlcancia;
        #endregion

        #region Metodos de Prueba
        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("Marranito", varObjAlcancia.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarCapacidadMonedas()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(50, varObjAlcancia.darCapacidadMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDenominacionesAeptadasMonedas()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(50, varObjAlcancia.darDenominacionesAceptadasMonedas()[0]);
            Assert.AreEqual(100, varObjAlcancia.darDenominacionesAceptadasMonedas()[1]);
            Assert.AreEqual(200, varObjAlcancia.darDenominacionesAceptadasMonedas()[2]);
            Assert.AreEqual(500, varObjAlcancia.darDenominacionesAceptadasMonedas()[3]);
            Assert.AreEqual(1000, varObjAlcancia.darDenominacionesAceptadasMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestDarCapacidadBilletes()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(20, varObjAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDenominacionesAeptadasBilletes()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, varObjAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(2000, varObjAlcancia.darDenominacionesAceptadasBilletes()[1]);
            Assert.AreEqual(5000, varObjAlcancia.darDenominacionesAceptadasBilletes()[2]);
            Assert.AreEqual(10000, varObjAlcancia.darDenominacionesAceptadasBilletes()[3]);
            Assert.AreEqual(20000, varObjAlcancia.darDenominacionesAceptadasBilletes()[4]);
            Assert.AreEqual(50000, varObjAlcancia.darDenominacionesAceptadasBilletes()[5]);
            #endregion
        }
        #endregion
    }
}
