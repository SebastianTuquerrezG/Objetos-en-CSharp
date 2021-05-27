using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestBillete
    {
        #region Atributos
        clsBILLETE atrObjTetBillete;
        #endregion

        #region Metodos de Prueba
        #region Test Accesores
        [TestMethod]
        public void uTestDarSerie()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("AD59757252", atrObjTetBillete.darSerie());
            #endregion
        }
        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("COP", atrObjTetBillete.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarDenominacion()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(5000, atrObjTetBillete.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestDarDia()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(29, atrObjTetBillete.darDia());
            #endregion
        }
        [TestMethod]
        public void uTestDarMes()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(8, atrObjTetBillete.darMes());
            #endregion
        }
        [TestMethod]
        public void uTestDarAño()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            atrObjTetBillete.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(2017, atrObjTetBillete.darAño());
            #endregion
        }
        #endregion
        #region Test Constructores
        [TestMethod]
        public void uTestConstructorNoParametrizados()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("ninguna...", atrObjTetBillete.darSerie());
            Assert.AreEqual(-1, atrObjTetBillete.darMes());
            Assert.AreEqual(-1, atrObjTetBillete.darDia());
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            atrObjTetBillete = new clsBILLETE("AD59757252", "COP", 5000, 2017, 8, 29);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("AD59757252", atrObjTetBillete.darSerie());
            Assert.AreEqual("COP", atrObjTetBillete.darNombre());
            Assert.AreEqual(5000, atrObjTetBillete.darDenominacion());
            Assert.AreEqual(2017, atrObjTetBillete.darAño());
            Assert.AreEqual(8, atrObjTetBillete.darMes());
            Assert.AreEqual(29, atrObjTetBillete.darDia());
            #endregion
        }
        #endregion
        #endregion
    }
}
