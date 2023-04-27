using Estacionamiento_D.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_D.Models
{
    public class Cliente : Persona
    {
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [Range(Restrictiones.FloorCUIL, Restrictiones.CeilCUIL, ErrorMessage = ErrMsgs.RangoMinMax)]
        public long CUIT { get; set; }

        public Direccion Direccion { get; set; }

        //public List<ClienteVehiculo> VehiculosAutorizados { get; set; }


    }
}
