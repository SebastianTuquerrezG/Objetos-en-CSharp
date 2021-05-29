using System;
using System.Collections.Generic;

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
        #region Asociativos
        public clsALCANCIA darAlcancia() { return atrAlcancia; }
        #endregion
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

            atrAlcancia = new clsALCANCIA("Mi Platica", 50, 100, new List<int>(), new List<int>());
        }
        #endregion
        #region Asociadores
        public bool Asociar(clsALCANCIA prmObjeto)
        {
            if(atrAlcancia == null)
            {
                atrAlcancia = prmObjeto;
                return true;
            }
            return false;
        }
        #endregion
        #region Disocicadores
        public bool Disociar(ref clsALCANCIA prmObjeto)
        {
            if(atrAlcancia != null)
            {
                prmObjeto = atrAlcancia;
                atrAlcancia = null;
                return true;
            }
            return false;
        }
        #endregion
        #endregion
    }
}