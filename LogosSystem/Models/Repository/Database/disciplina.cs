
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LogosSystem.Models.Repository.Database
{

using System;
    using System.Collections.Generic;
    
public partial class disciplina
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public disciplina()
    {

        this.falta = new HashSet<falta>();

        this.nota = new HashSet<nota>();

    }


    public int Disciplina_ID { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int Creditos_Qtt { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<falta> falta { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<nota> nota { get; set; }

}

}
