//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace soruSor.servis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Soru
    {
        public Soru()
        {
            this.cevap = new HashSet<cevap>();
        }
    
        public int soruId { get; set; }
        public int kullaniciId { get; set; }
        public string soru1 { get; set; }
        public System.DateTime soruTarih { get; set; }
        public int soruGoruntule { get; set; }
    
        public virtual ICollection<cevap> cevap { get; set; }
        public virtual kullanici kullanici { get; set; }
    }
}