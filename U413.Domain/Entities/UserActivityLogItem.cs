//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U413.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserActivityLogItem
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public System.DateTime Date { get; set; }
        public string Information { get; set; }
        public string Type { get; set; }
    
        public virtual User User { get; set; }
    }
}
