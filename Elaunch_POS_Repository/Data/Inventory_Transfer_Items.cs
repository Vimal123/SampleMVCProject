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
    
    public partial class Inventory_Transfer_Items
    {
        public int Item_ID { get; set; }
        public Nullable<int> Transfer_ID { get; set; }
        public Nullable<int> Sub_Product_ID { get; set; }
        public string Barcode { get; set; }
        public Nullable<int> Transfer_Quantity { get; set; }
        public Nullable<bool> Is_Accepted { get; set; }
        public string User_Updated { get; set; }
        public Nullable<System.DateTime> Date_Updated { get; set; }
        public string User_Accepted { get; set; }
        public Nullable<System.DateTime> Date_Accepted { get; set; }
    
        public virtual Inventory_Transfers Inventory_Transfers { get; set; }
    }
}
