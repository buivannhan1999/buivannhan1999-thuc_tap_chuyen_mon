//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ttcm
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.cthoadons = new HashSet<cthoadon>();
            this.CTPHIEUNHAPs = new HashSet<CTPHIEUNHAP>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaNhom { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public byte[] HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cthoadon> cthoadons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUNHAP> CTPHIEUNHAPs { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}
