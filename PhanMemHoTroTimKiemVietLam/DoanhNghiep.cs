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
    
    public partial class DoanhNghiep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoanhNghiep()
        {
            this.LyLichXinViecs = new HashSet<LyLichXinViec>();
        }
    
        public string maDN { get; set; }
        public string tenDN { get; set; }
        public string diaC { get; set; }
        public string soDT { get; set; }
        public string eMail { get; set; }
        public string chuDN { get; set; }
        public string quanDN { get; set; }
        public string maNN { get; set; }
    
        public virtual NganhNghe NganhNghe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LyLichXinViec> LyLichXinViecs { get; set; }
    }
}