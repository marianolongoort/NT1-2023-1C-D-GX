using Estacionamiento_D.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Estacionamiento_D.Models
{
    public class Persona
    {

        public int Id { get; set; }
        public string UserName { get; set; }       
        
        public string Password { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [StringLength(Restrictiones.CeilL3, MinimumLength = Restrictiones.FloorL1, ErrorMessage = ErrMsgs.StrMaxMin)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [MaxLength(Restrictiones.CeilL3, ErrorMessage = ErrMsgs.StrMax)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [Range(Restrictiones.FloorDNI, Restrictiones.CeilDNI, ErrorMessage = ErrMsgs.RangoMinMax)]
        [Display(Name = Alias.DNI)]
        public int DNI { get; set; }


        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [EmailAddress(ErrorMessage = ErrMsgs.NoValido)]
        [Display(Name = Alias.Email)]
        public string Email { get; set; }

        public List<Telefono> Telefonos { get; set; }

        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(Apellido) && string.IsNullOrEmpty(Nombre)) return Configs.NotDefined;
                if (string.IsNullOrEmpty(Apellido)) return Nombre;
                if (string.IsNullOrEmpty(Nombre)) return Apellido;
                return $"{Apellido.ToUpper()}, {Nombre}";
            }
        }


        public Direccion Direccion { get; set; }
    }
}
