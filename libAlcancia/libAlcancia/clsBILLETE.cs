using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcancia.Dominio
{
    public class clsBILLETE : clsMONEDA
    {
        #region Atributos
        #region Propios
        protected string atrSerie = "ninguna...";
        protected int atrMes = -1;
        protected int atrDia = -1;
        #endregion
        #endregion

        #region Operaciones
        #region Accesores
        public string darSerie() { return atrSerie; }
        public int darMes() { return atrMes; }
        public int darDia() { return atrDia; }
        #endregion
        #region Constructores
        public clsBILLETE() { }
        public clsBILLETE(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia):base(prmNombre, prmDenominacion, prmAño)
        {
            atrSerie = prmSerie;
            atrMes = prmMes;
            atrDia = prmDia;
        }
        public override void Generar()
        {
            atrSerie = "AD59757252";
            atrNombre = "COP";
            atrDenominacion = 5000;
            atrMes = 8;
            atrDia = 29;
            atrAño = 2017;

        }
        #endregion
        #endregion
    }
}
