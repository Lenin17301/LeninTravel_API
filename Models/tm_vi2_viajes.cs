//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeninTravel_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tm_vi2_viajes
    {
        public int ID { get; set; }
        public int id_viajero { get; set; }
        public int id_destino { get; set; }
        public System.DateTime fecha_ida { get; set; }
        public System.DateTime fecha_vuelta { get; set; }
    
        public virtual tm_des_destinos tm_des_destinos { get; set; }
        public virtual tm_via_viajeros tm_via_viajeros { get; set; }
    }
}
