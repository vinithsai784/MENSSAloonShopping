//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MENSSAloonShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Audit
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> AppointmentID { get; set; }
        public string TypeOfAction { get; set; }
        public string TypeOfworkflow { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public Nullable<System.DateTime> AccesedDatetime { get; set; }
        public string FieldName { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual User User { get; set; }
    }
}