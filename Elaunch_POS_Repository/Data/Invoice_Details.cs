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
    
    public partial class Invoice_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice_Details()
        {
            this.Product_Ratings = new HashSet<Product_Ratings>();
        }
    
        public int Detail_ID { get; set; }
        public Nullable<int> Invoice_ID { get; set; }
        public Nullable<int> Sub_Product_ID { get; set; }
        public string Bracode { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<decimal> Product_Discount { get; set; }
        public Nullable<decimal> Management_Discount { get; set; }
        public Nullable<decimal> Company_Commission { get; set; }
        public Nullable<decimal> Trader_Portion { get; set; }
        public Nullable<decimal> Selling_Price { get; set; }
        public Nullable<decimal> Product_Tax { get; set; }
        public Nullable<decimal> Net_Price { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Sub_Products Sub_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Ratings> Product_Ratings { get; set; }
    }
}
