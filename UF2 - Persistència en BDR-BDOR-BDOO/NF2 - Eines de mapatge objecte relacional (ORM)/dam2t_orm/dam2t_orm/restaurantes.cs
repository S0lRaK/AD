//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dam2t_orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class restaurantes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string especialidad { get; set; }
        public Nullable<int> id_ciudad { get; set; }
        public string nombre_hot { get; set; }
    
        public virtual hoteles hoteles { get; set; }
    }
}
