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
    
    public partial class dtb_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dtb_master()
        {
            this.srv_master = new HashSet<srv_master>();
        }
    
        public int dtb_id { get; set; }
        public bool dtb_status { get; set; }
        public string dtb_descr { get; set; }
        public int dtb_svc_sts_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<srv_master> srv_master { get; set; }
        public virtual dtb_svc_sts dtb_svc_sts { get; set; }
    }
}
