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
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.Student_Schedule = new HashSet<Student_Schedule>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string languages { get; set; }
        public int program_id { get; set; }
    
        public virtual Program Program { get; set; }
        public virtual ICollection<Student_Schedule> Student_Schedule { get; set; }
    }
}
