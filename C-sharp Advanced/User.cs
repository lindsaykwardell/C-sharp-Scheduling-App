//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C_sharp_Advanced
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public byte active { get; set; }
        public System.DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public byte[] lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
