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
    
    public partial class srv_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public srv_master()
        {
            this.srv_detail = new HashSet<srv_detail>();
        }
    
        public int srv_id { get; set; }
        public System.DateTime srv_date { get; set; }
        public decimal srv_total { get; set; }
        public int dtb_id { get; set; }
        public Nullable<int> pay_id { get; set; }
        public int sts_id { get; set; }
        public string usr_id { get; set; }
    
        public virtual dtb_master dtb_master { get; set; }
        public virtual pay_master pay_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<srv_detail> srv_detail { get; set; }
        public virtual sts_master sts_master { get; set; }
        public virtual usr_master usr_master { get; set; }
        public virtual dtb_svc_sts dtb_svc_sts { get; set; }
    }
}
