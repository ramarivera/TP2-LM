using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Homogeiniza el acceso a las diferentes operaciones sobre el garage.
    /// </summary>
    class Fachada
    {
        //Crea una nueva instancia de Garage.
        Garage iGarage = new Garage();
        
        /// <summary>
        /// Controla si el Garage esta ocupado por un auto.
        /// </summary>
        /// <returns>Devuelve true en caso de que el garage este disponible y false en caso contrario.</returns>
        public Boolean GarageDisponible ()
        {
            if (iGarage.Auto == null)
	        {
		        return true;
	        }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Ingresa un auto al garage.
        /// </summary>
        /// <param name="pMarca">Marca del auto que ingresará al garage.</param>
        /// <param name="pModelo">Modelo del auto que ingresará al garage.</param>
        /// <param name="pCV">Caballos Vapor del motor del auto.</param>
        public void IngresarAuto (string pMarca, string pModelo, int pCV)
        {
            //Crea una nueva instacia de Auto pasando como parámetros la marca, el modelo y los caballos vapor del motor.
            Auto iAuto = new Auto(pMarca,pModelo,pCV);
            iGarage.AceptarAuto(iAuto);
        }

        /// <summary>
        /// Le ingresa una averia al auto que se encuentra en el garage. 
        /// </summary>
        /// <param name="pDescripcionAveria">Descripción acerca de la averia que se ingresa.</param>
        /// <param name="pPrecioAveria">Precio de la averia.</param>
        public void IngresarAveria (string pDescripcionAveria, double pPrecioAveria)
        {
            iGarage.IncorporarAveria(pPrecioAveria, pDescripcionAveria);
        }
        
        /// <summary>
        /// Obtiene la información correspondiente al auto que se encuentra en el garage.
        /// </summary>
        /// <returns>Devuelve un vector que contiene en cada posición información correspondiente al auto
        /// que se encuentra en el garage.</returns>
        public string[] RecuperarInformacionAuto ()
        {
            string[] Auto = new string[5];
            Auto[0] = iGarage.Auto.Marca;
            Auto[1] = iGarage.Auto.Modelo;
            Auto[2] = Convert.ToString(iGarage.Auto.Motor.CV);
            Auto[3] = Convert.ToString(iGarage.Auto.PrecioAverias);
            Auto[4] = Convert.ToString(iGarage.Auto.Motor.LitrosAceite);
            return Auto;
        }

        public void RetirarAuto()
        {
            iGarage.AceptarAuto(null);
        }
    }
}
