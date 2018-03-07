//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elaunch_POS_Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Management_Discounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Management_Discounts()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int Discount_ID { get; set; }
        public string Discount_Name { get; set; }
        public string Discount_Code { get; set; }
        public Nullable<decimal> Doscount_Percentage { get; set; }
        public Nullable<System.DateTime> From_Date { get; set; }
        public Nullable<System.DateTime> To_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public string User_Created { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public string User_Updated { get; set; }
        public Nullable<System.DateTime> Date_Updated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}