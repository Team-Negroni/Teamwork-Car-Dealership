//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dealership.ExcelFilesProcessing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int ShopId { get; set; }

        public int ProductId { get; set; }
        public Nullable<float> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> DateOfSale { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
