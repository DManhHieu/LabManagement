//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThanhVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salary
    {
        public int IDEmployee { get; set; }
        public System.DateTime Month { get; set; }
        public Nullable<int> LuongCoBan { get; set; }
        public Nullable<int> Phat { get; set; }
        public Nullable<int> Thuong { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}