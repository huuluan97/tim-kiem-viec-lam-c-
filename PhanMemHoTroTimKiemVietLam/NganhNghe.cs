//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanMemHoTroTimKiemVietLam
{
    using System;
    using System.Collections.Generic;
    
    public partial class NganhNghe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NganhNghe()
        {
            this.DoanhNghieps = new HashSet<DoanhNghiep>();
        }
    
        public string maNN { get; set; }
        public string tenNN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanhNghiep> DoanhNghieps { get; set; }
    }
}
