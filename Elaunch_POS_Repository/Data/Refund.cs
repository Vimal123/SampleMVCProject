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
    
    public partial class Refund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Refund()
        {
            this.Refund_Details = new HashSet<Refund_Details>();
        }
    
        public int Refund_ID { get; set; }
        public Nullable<int> Original_Sales_Invoice_ID { get; set; }
        public Nullable<System.DateTime> Refund_Date { get; set; }
        public Nullable<int> Branch_ID { get; set; }
        public Nullable<int> Cashier_ID { get; set; }
        public Nullable<decimal> Total_Taxes { get; set; }
        public Nullable<decimal> Total_Refunded { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Cashier Cashier { get; set; }
        public virtual Invoice Invoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund_Details> Refund_Details { get; set; }
    }
}