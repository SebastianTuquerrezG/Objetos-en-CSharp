using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestMoneda
    {
        #region Atributos
        clsMONEDA atrObjTestMoneda;
        #endregion
        #region Metodos de Prueba
        #region Test Accesores
        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            atrObjTestMoneda = new clsMONEDA();
            atrObjTestMoneda.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("COP", atrObjTestMoneda.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarDenominacion()
        {
            #region Configurar
            atrObjTestMoneda = new clsMONEDA();
            atrObjTestMoneda.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, atrObjTestMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestDarAño()
        {
            #region Configurar
            atrObjTestMoneda = new clsMONEDA();
            atrObjTestMoneda.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(2010, atrObjTestMoneda.darAño());
            #endregion
        }
        #endregion
        #region Test Constructores
        [TestMethod]
        public void uTestConstructorNoParametrizado()
        {
            #region Configurar
            atrObjTestMoneda = new clsMONEDA();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("n.n", atrObjTestMoneda.darNombre());
            Assert.AreEqual(-1, atrObjTestMoneda.darDenominacion());
            Assert.AreEqual(-1, atrObjTestMoneda.darAño());
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            atrObjTestMoneda = new clsMONEDA("COP", 1000, 2010);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("COP", atrObjTestMoneda.darNombre());
            Assert.AreEqual(1000, atrObjTestMoneda.darDenominacion());
            Assert.AreEqual(2010, atrObjTestMoneda.darAño());
            #endregion
        }
        #endregion
        #endregion
    }
}
