
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Proyecto.Logica.Entidades
{

using System;
    using System.Collections.Generic;
    
public partial class tbRelacionadoCon
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tbRelacionadoCon()
    {

        this.tbEventos = new HashSet<tbEventos>();

    }


    public int recoCodigo { get; set; }

    public string recoDescripcion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tbEventos> tbEventos { get; set; }

}

}