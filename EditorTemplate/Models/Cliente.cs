using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EditorTemplate.Models
{
    public enum TipoCliente
    {
        General,
        Vip
    }
    public class Cliente
    {
        public string Nombre { get; set; }
        [UIHint("Enum")]
        [DisplayName("Tipo de cliente")]
        public TipoCliente tipoCliente { get; set; }
    }
}