//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoMarniLopezLopez.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dtb_svc_sts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtb_svc_sts()
        {
            this.dtb_master = new HashSet<dtb_master>();
        }
    
        public int dtb_svc_sts_id { get; set; }
        public string dtb_svc_sts_dsc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtb_master> dtb_master { get; set; }
    }
}
