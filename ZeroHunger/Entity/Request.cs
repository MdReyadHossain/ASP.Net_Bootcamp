//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int id { get; set; }
        public string restaurant_name { get; set; }
        public System.DateTime created_time { get; set; }
        public Nullable<System.DateTime> accept_time { get; set; }
        public Nullable<System.DateTime> done_time { get; set; }
        public int employee_id { get; set; }
        public string status { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}