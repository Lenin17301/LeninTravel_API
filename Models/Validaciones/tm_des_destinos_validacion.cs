using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeninTravel_API.Models
{
    [MetadataType(typeof(tm_des_destinos_validacion.Metadata))]
    public partial class tm_des_destinos_validacion
    {
        sealed class Metadata
        {
            [Required]
            public int cod_viaje;
            [Required]
            public int nro_plazas;
            [Required]
            public string origen;
            [Required]
            public string destino;
            [Required]
            public decimal precio;
        }
    }
}