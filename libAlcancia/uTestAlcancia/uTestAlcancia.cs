using System.Collections.Generic;
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
        #region Test de Accesores
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
        #region Test Mutadores
        [TestMethod]
        public void uTestPonerNombre()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            atrObjTestAlcancia.ponerNombre("Ahorros");
            Assert.AreEqual("Ahorros", atrObjTestAlcancia.darNombre()); 
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadMonedasMayor()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            atrObjTestAlcancia.ponerCapacidadMonedas(10);
            Assert.AreEqual(10, atrObjTestAlcancia.darCapacidadMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadMonedasMenor()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            atrObjTestAlcancia.ponerCapacidadMonedas(-1);
            Assert.AreEqual(0, atrObjTestAlcancia.darCapacidadMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadBilletesMayor()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            atrObjTestAlcancia.ponerCapacidadBilletes(10);
            Assert.AreEqual(10, atrObjTestAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadBilletesMenor()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            atrObjTestAlcancia.ponerCapacidadBilletes(-1);
            Assert.AreEqual(0, atrObjTestAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionesAceptadasMonedas_Caso1()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, atrObjTestAlcancia.ponerDenominacionesAceptadasMonedas(new List<int> { 100, 200}));
            Assert.AreEqual(100, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[0]);
            Assert.AreEqual(200, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[1]);
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionesAceptadasMonedas_Caso2()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrObjTestAlcancia.ponerDenominacionesAceptadasMonedas(new List<int> { 100, 200 }));
            Assert.AreEqual(50, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[0]);
            Assert.AreEqual(100, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[1]);
            Assert.AreEqual(200, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[2]);
            Assert.AreEqual(500, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[3]);
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[4]);
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionesAceptadasMonedas_Caso3()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, atrObjTestAlcancia.ponerDenominacionesAceptadasMonedas(new List<int> { 50, 200, 500, 1000 }));
            Assert.AreEqual(50, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[0]); 
            Assert.AreEqual(200, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[1]);
            Assert.AreEqual(500, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[2]);
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[3]);

            Assert.AreEqual(300, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[0]);
            Assert.AreEqual(400, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[1]);
            Assert.AreEqual(500, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[2]);
            Assert.AreEqual(3000, atrObjTestAlcancia.darSaldoPorDenominacionMonedas()[3]);

            Assert.AreEqual(6, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[0]);
            Assert.AreEqual(2, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[1]);
            Assert.AreEqual(1, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[2]);
            Assert.AreEqual(3, atrObjTestAlcancia.darConteoPorDenominacionMonedas()[3]);
            #endregion
        }
        [TestMethod]
        public void utestPonerDenominacionesAceptadasBilletes_Caso1()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, atrObjTestAlcancia.ponerDenominacionesAceptadasBilletes(new List<int> { 1000, 2000}));
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(2000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[1]);
            #endregion
        }
        [TestMethod]
        public void UtestPonerDenominacionesAceptadasBilletes_Caso2()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, atrObjTestAlcancia.ponerDenominacionesAceptadasBilletes(new List<int> { 1000, 2000 }));
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(2000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[1]);
            Assert.AreEqual(5000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[2]);
            Assert.AreEqual(10000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[3]);
            Assert.AreEqual(20000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[4]);
            Assert.AreEqual(50000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[5]);
            #endregion
        }
        [TestMethod]
        public void UtestPonerDenominacionesAceptadasBilletes_Caso3()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            atrObjTestAlcancia.Generar();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, atrObjTestAlcancia.ponerDenominacionesAceptadasBilletes(new List<int> { 1000, 2000, 10000 }));
            Assert.AreEqual(1000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(2000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[1]);
            Assert.AreEqual(10000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[2]);

            Assert.AreEqual(5000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[0]);
            Assert.AreEqual(4000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[1]);
            Assert.AreEqual(30000, atrObjTestAlcancia.darSaldoPorDenominacionBilletes()[2]);

            Assert.AreEqual(5, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[0]);
            Assert.AreEqual(2, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[1]);
            Assert.AreEqual(3, atrObjTestAlcancia.darConteoPorDenominacionBilletes()[2]);
            #endregion
        }
        #endregion
        #region  Test de Constructores
        [TestMethod]
        public void uTestConstructorNoParametrizado()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("ninguno", atrObjTestAlcancia.darNombre());

            Assert.AreEqual(0, atrObjTestAlcancia.darCapacidadMonedas());
            Assert.AreEqual(null, atrObjTestAlcancia.darDenominacionesAceptadasMonedas());
            Assert.AreEqual(null, atrObjTestAlcancia.darSaldoPorDenominacionMonedas());
            Assert.AreEqual(null, atrObjTestAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoTotalMonedas());

            Assert.AreEqual(0, atrObjTestAlcancia.darCapacidadBilletes());
            Assert.AreEqual(null, atrObjTestAlcancia.darDenominacionesAceptadasBilletes());
            Assert.AreEqual(null, atrObjTestAlcancia.darSaldoPorDenominacionBilletes());
            Assert.AreEqual(null, atrObjTestAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(0, atrObjTestAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            atrObjTestAlcancia = new clsALCANCIA("Ahorros", 10, 5, new List<int> { 100, 500 }, new List<int> { 5000, 10000 });
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual("Ahorros", atrObjTestAlcancia.darNombre());

            Assert.AreEqual(10, atrObjTestAlcancia.darCapacidadMonedas());
            Assert.AreEqual(100, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[0]);
            Assert.AreEqual(500, atrObjTestAlcancia.darDenominacionesAceptadasMonedas()[1]);

            Assert.AreEqual(5, atrObjTestAlcancia.darCapacidadBilletes());
            Assert.AreEqual(5000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[0]);
            Assert.AreEqual(10000, atrObjTestAlcancia.darDenominacionesAceptadasBilletes()[1]);
            #endregion
        }
        #endregion
        #endregion
    }
}
