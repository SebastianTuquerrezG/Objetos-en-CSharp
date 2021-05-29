using System;

namespace Alcancia.Dominio
{
    public class clsMONEDA
    {
        #region Atributos
        #region Propios
        protected string atrNombre = "n.n";
        protected int atrDenominacion = -1;
        protected int atrAño = -1;
        #endregion
        #region Atributos Asociativos
        private clsALCANCIA atrAlcancia = null;
        #endregion
        #endregion

        #region Operaciones
        #region Accesores
        public string darNombre() { return atrNombre; }
        public int darDenominacion() { return atrDenominacion; }
        public int darAño() { return atrAño; }
        #endregion
        #region Constructores
        public clsMONEDA() { }
        public clsMONEDA(string prmNombre, int prmDenominacion, int prmAño)
        {
            atrNombre = prmNombre;
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        public virtual void Generar()
        {
            atrNombre = "COP";
            atrDenominacion = 1000;
            atrAño = 2010;
        }
        #endregion
        #region Asociadores
        public bool Asociar(clsALCANCIA prmObjeto)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region
        public bool Disociar(ref clsALCANCIA prmObjeto)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}