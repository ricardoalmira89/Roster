//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Roster.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Program
    {
        public int id { get; set; }
        public int student_id { get; set; }
        public int program_id { get; set; }
    
        public virtual Program Program { get; set; }
        public virtual Student Student { get; set; }
    }
}
