//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace electronicComponents.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Decentralization
    {
        public int id { get; set; }
        public Nullable<int> roleID { get; set; }
        public string note { get; set; }
        public Nullable<int> employeeTypeID { get; set; }
    
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Rolee Rolee { get; set; }
    }
}
