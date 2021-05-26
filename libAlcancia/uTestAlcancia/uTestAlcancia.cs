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
        public void uTestDarSaldoPorDenominacionMonedas()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(300, varObjAlcancia.darSaldoPorDenominacionMonedas()[0]);
            Assert.AreEqual(0, varObjAlcancia.darSaldoPorDenominacionMonedas()[1]);
            Assert.AreEqual(400, varObjAlcancia.darSaldoPorDenominacionMonedas()[2]);
            Assert.AreEqual(500, varObjAlcancia.darSaldoPorDenominacionMonedas()[3]);
            Assert.AreEqual(3000, varObjAlcancia.darSaldoPorDenominacionMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionMonedas()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(6, varObjAlcancia.darConteoPorDenominacionMonedas()[0]);
            Assert.AreEqual(0, varObjAlcancia.darConteoPorDenominacionMonedas()[1]);
            Assert.AreEqual(2, varObjAlcancia.darConteoPorDenominacionMonedas()[2]);
            Assert.AreEqual(1, varObjAlcancia.darConteoPorDenominacionMonedas()[3]);
            Assert.AreEqual(3, varObjAlcancia.darConteoPorDenominacionMonedas()[4]);
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
        [TestMethod]
        public void uTestDarSaldoPorDenominacioBilletes()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(5000, varObjAlcancia.darSaldoPorDenominacionBilletes()[0]);
            Assert.AreEqual(4000, varObjAlcancia.darSaldoPorDenominacionBilletes()[1]);
            Assert.AreEqual(0, varObjAlcancia.darSaldoPorDenominacionBilletes()[2]);
            Assert.AreEqual(30000, varObjAlcancia.darSaldoPorDenominacionBilletes()[3]);
            Assert.AreEqual(0, varObjAlcancia.darSaldoPorDenominacionBilletes()[4]);
            Assert.AreEqual(0, varObjAlcancia.darSaldoPorDenominacionBilletes()[5]);
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionBilletes()
        {
            #region Configurar
            varObjAlcancia = new clsALCANCIA();
            varObjAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(5, varObjAlcancia.darConteoPorDenominacionBilletes()[0]);
            Assert.AreEqual(2, varObjAlcancia.darConteoPorDenominacionBilletes()[1]);
            Assert.AreEqual(0, varObjAlcancia.darConteoPorDenominacionBilletes()[2]);
            Assert.AreEqual(3, varObjAlcancia.darConteoPorDenominacionBilletes()[3]);
            Assert.AreEqual(0, varObjAlcancia.darConteoPorDenominacionBilletes()[4]);
            Assert.AreEqual(0, varObjAlcancia.darConteoPorDenominacionBilletes()[5]);
            #endregion
        }
        #endregion
    }
}
