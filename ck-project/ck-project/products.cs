//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ck_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        public int product_number { get; set; }
        public string cat_anme { get; set; }
        public int quantity { get; set; }
        public string Description { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string product_source { get; set; }
        public string manufacture { get; set; }
        public string location { get; set; }
        public double price { get; set; }
        public int lead_number { get; set; }
    
        public virtual leads leads { get; set; }
    }
}
