//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutorial.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_DISTRITO
    {
        public TBL_DISTRITO()
        {
            this.TBL_EQUIPO = new HashSet<TBL_EQUIPO>();
            this.TBL_JUGADORES = new HashSet<TBL_JUGADORES>();
        }
    
        public int id_Distrito { get; set; }
        public Nullable<int> id_Canton { get; set; }
        public string nombre { get; set; }
        public string usuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCrea { get; set; }
        public string usuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModifica { get; set; }
        public string vc_Estado { get; set; }
        public Nullable<int> id_DistritoInec { get; set; }
    
        public virtual TBL_CANTON TBL_CANTON { get; set; }
        public virtual ICollection<TBL_EQUIPO> TBL_EQUIPO { get; set; }
        public virtual ICollection<TBL_JUGADORES> TBL_JUGADORES { get; set; }
    }
}
