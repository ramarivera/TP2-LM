using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    /// <summary>
    /// Clase para manejar fechas, por defecto se crean con la fecha 01/01/1800.
    /// </summary>
    public class Fechas
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        private readonly int iDia;
        private readonly int iMes;
        private readonly int iAño;

        //Propiedades
        public int dd
        {
            get { return iDia; }
        }
        public string dddd
        {
            get
            {
                switch (Zeller())
                {
                    case 0: return "Sabado";
                    case 1: return "Domingo";
                    case 2: return "Lunes";
                    case 3: return "Martes";
                    case 4: return "Miercoles";
                    case 5: return "Jueves";
                    case 6: return "Viernes";
                    default: return "Error";
                };
            }
        }
        public int mm
        {
            get { return iMes; }
        }
        public int aa
        {
            get { return iAño; }
        }

        //Constructores
        public Fechas() :this(01, 01, 1800) { }
        public Fechas(int pDia,int pMes,int pAño)
        {
            if (pDia > 0)
            {
                if ((pMes == 2) && (pAño % 4 == 0) && (pDia <= 29)) { iDia = pDia; }
                else if ((pMes == 2) && (pDia <= 28)) { iDia = pDia; }
                else if (tiene31Dias(pMes) && (pDia <= 31)) { iDia = pDia; }
                else if ((0 < pDia) && (pDia <= 30)) { iDia = pDia; }
            }
            if ((pMes > 0) && (pMes <= 12)) { iMes = pMes; }
            if (pAño > 0) { iAño = pAño; }
        }

        //Mensajes
        /// <summary>
        /// Crea una nueva instancia de la clase Fechas con el día especificado y el mes y año del objeto que lo invocó.
        /// </summary>
        /// <param name="pDias"></param>
        /// <returns></returns>
        public Fechas agregarDias( int pDias)
        {
            if (pDias >= 0) { return new Fechas(this.dd + pDias, this.mm, this.aa); }
        }
        /// <summary>
        /// Crea una nueva instancia de la clase Fechas con el mes especificado y el día y año del objeto que lo invocó.
        /// </summary>
        /// <param name="pMeses"></param>
        /// <returns></returns>
        public Fechas agregarMeses(int pMeses)
        {
            if (pMeses >= 0) { return new Fechas(this.dd, this.mm + pMeses, this.aa); }
        }
        /// <summary>
        /// Crea una nueva instancia de la clase Fechas con el año especificado y el día y mes del objeto que lo invocó.
        /// </summary>
        /// <param name="pAños"></param>
        /// <returns></returns>
        public Fechas agregarAños(int pAños)
        {
            if (pAños >= 0) { return new Fechas(this.dd, this.mm, this.aa + pAños); }
        }
        /// <summary>
        /// Devuelve si el año de la fecha es bisiesto o no.
        /// </summary>
        /// <returns></returns>
        public Boolean esAñoBisiesto()
        {
            return (aa % 4 == 0);
        }
        /// <summary>
        /// Algoritmo de Zeller para calcular el nombre del día en función de la fecha.
        /// Devuelve un entero desde 0 = Sábado a 6 = Viernes.
        /// </summary>
        /// <returns></returns>
        private int Zeller()
        {
            return (dd + (((mm + 1) * 26) / 10) + (aa % 100) * (1 + 1 / 4) + 5 - aa / 100);
        }

        private static Boolean tiene31Dias(int pMes)
        {
            return ((pMes==1)|| (pMes == 3) || (pMes == 5) || (pMes == 6) || (pMes == 8) || (pMes == 10) || (pMes == 12));
        }
        private static int ajustarDiaFebrero(int pDia)
        {
            if (pDia % 4 == 0)
            {
                if (pDia < 1)
                {
                    pDia += 29;
                }
                else if (pDia > 29)
                {
                    pDia = 29;
                }
            }
            else
            {
                if (pDia < 1)
                {
                    pDia += 28;
                }
                else if (pDia > 28)
                {
                    pDia = 28;
                }
            }
            return pDia;
        }
        private static int ajustarDiaMes31(int pDia)
        {
            if (pDia < 1)
            {
                pDia += 31;
            }
            return pDia;
        }
        private static int ajustarDiaMes30(int pDia)
        {
            if (pDia < 1)
            {
                pDia += 30;
            }
            else if (pDia > 30)
            {
                pDia = 30;
            }
            return pDia;
        }

        //Sobrecarga de Operadores
        public static Boolean operator !=(Fechas F1, Fechas F2)
        {
            return ((F1.dd != F2.dd) || (F1.mm != F2.mm) || (F1.aa != F2.aa));
        }
        public static Boolean operator == (Fechas F1, Fechas F2)
        {
            return ((F1.dd == F2.dd) && (F1.mm == F2.mm) && (F1.aa == F2.aa));
        }
        public static Boolean operator <(Fechas F1, Fechas F2)
        {
            return 
                (
                (F1.aa < F2.aa) || 
                ((F1.aa == F2.aa) && (F1.mm < F2.mm)) || 
                (((F1.aa == F2.aa) && (F1.mm == F2.mm)) && (F1.dd < F2.dd))
                );
        }
        public static Boolean operator >(Fechas F1, Fechas F2)
        {
            return
                (
                (F1.aa > F2.aa) ||
                ((F1.aa == F2.aa) && (F1.mm > F2.mm)) ||
                (((F1.aa == F2.aa) && (F1.mm == F2.mm)) && (F1.dd > F2.dd))
                );
        }
        public static Fechas operator -(Fechas F1, Fechas F2)
        {
            int iNuevoDia;
            int iNuevoMes = 0;
            int iNuevoAño = 0;
            //Tratando el día
            iNuevoDia = F1.dd - F2.dd;
            if (iNuevoDia<1)
            {
                iNuevoMes--;
            }

            //Tratando el mes
            iNuevoMes += F1.mm - F2.mm;
            if (iNuevoMes < 1)
            {
                iNuevoAño --;
            }

            //Tratando el año
            iNuevoAño += F1.aa - F2.aa;

            //Corrigiendo días
            if (iNuevoMes==2) //caso especial Febrero
            {
                iNuevoDia = ajustarDiaFebrero(iNuevoDia);
            }
            else if (tiene31Dias(iNuevoMes))
            {
                iNuevoDia = ajustarDiaMes31(iNuevoDia);
            }
            else
            {
                iNuevoDia = ajustarDiaMes30(iNuevoDia);
            }

            //Corrigiendo meses
            if (iNuevoMes < 1) { iNuevoMes += 12; }

            //Corrigiendo años
            if (iNuevoAño < 1)
                {
                iNuevoDia = 1;
                iNuevoMes = 1;
                iNuevoAño = 0;
                }

            //Devolviendo nueva fecha
            return new Fechas(iNuevoDia, iNuevoMes, iNuevoAño);
        }
    }
}
