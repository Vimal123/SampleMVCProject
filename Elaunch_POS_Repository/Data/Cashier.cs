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
    
    public partial class Cashier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cashier()
        {
            this.Daily_Balance = new HashSet<Daily_Balance>();
            this.Invoices = new HashSet<Invoice>();
            this.Refunds = new HashSet<Refund>();
        }
    
        public int Cashier_ID { get; set; }
        public string Cashiers_Name { get; set; }
        public Nullable<int> Branch_ID { get; set; }
        public string Cashier_Prefix { get; set; }
        public string Refund_PIN_Code { get; set; }
        public string User_Name { get; set; }
        public string PIN_Code { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<bool> Is_Logged_In { get; set; }
        public string User_Created { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public string User_Updated { get; set; }
        public Nullable<System.DateTime> Date_Updated { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Cashier_Key Cashier_Key { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Daily_Balance> Daily_Balance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund> Refunds { get; set; }
    }
}