using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnumDropDownListForMVC5.Models
{
    public enum TipoCliente
    {
        General = 0,
        Asociado = 1,
        Vip = 2,
        Propietario = 3
    }
    public class ViewModelCliente
    {
        [Required()]
        [Display(Name = "Id. del Cliente")]
        public int idCliente { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        public Nullable<TipoCliente> Tipo { get; set; }
    }
}