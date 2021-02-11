using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeninTravel_API.Models
{
    [MetadataType(typeof(tm_via_viajeros.Metadata))]
    public partial class tm_via_viajeros
    {
        sealed class Metadata
        {
            [Required]
            public string via_nombre;
            [Required]
            public string via_apellido;
            [Required]
            public string via_ci;
            [Required]
            public string via_pasaporte;
            [Required]
            public string via_direccion;
            [Required]
            public string via_telefono;
        }
    }
}