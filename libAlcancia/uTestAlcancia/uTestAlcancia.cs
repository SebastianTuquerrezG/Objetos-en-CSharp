using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alcancia;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        #region Atributos
        clsALCANCIA atrObjTestAlcancia;
        #endregion

        #region Metodos de Prueba
        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("Marranito", atrObjTestAlcancia.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarCapacidadMonedas()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(50, atrObjTestAlcancia.darCapacidadMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDenominacionesAeptadasMonedas()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(50, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[0]);
            Assert.AreEqual(100, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[1]);
            Assert.AreEqual(200, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[2]);
            Assert.AreEqual(500, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[3]);
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoPorDenominacionMonedas()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(300, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[0]);
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[1]);
            Assert.AreEqual(400, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[2]);
            Assert.AreEqual(500, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[3]);
            Assert.AreEqual(3000, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionMonedas()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(6, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[0]);
            Assert.AreEqual(0, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[1]);
            Assert.AreEqual(2, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[2]);
            Assert.AreEqual(1, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[3]);
            Assert.AreEqual(3, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoTotalMonedas()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(4200, atrObjTestAlcancia.darSaldoTotalMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDarCapacidadBilletes()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(20, atrObjTestAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDenominacionesAceptadasBilletes()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(2000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[1]);
            Assert.AreEqual(5000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[2]);
            Assert.AreEqual(10000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[3]);
            Assert.AreEqual(20000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[4]);
            Assert.AreEqual(50000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[5]);
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoPorDenominacionBilletes()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(5000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[0]);
            Assert.AreEqual(4000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[1]);
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[2]);
            Assert.AreEqual(30000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[3]);
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[4]);
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[5]);
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionBilletes()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(5, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[0]);
            Assert.AreEqual(2, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[1]);
            Assert.AreEqual(0, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[2]);
            Assert.AreEqual(3, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[3]);
            Assert.AreEqual(0, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[4]);
            Assert.AreEqual(0, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[5]);
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoTotalBilletes()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(39000, atrObjTestAlcancia.darSaldoTotalBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoTotal()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(43200, atrObjTestAlcancia.darSaldoTotal());
            #endregion
        }
        #endregion
    }
}
