//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.Models.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotesComments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Nullable<int> IdComm { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Notes Notes { get; set; }
    }
}
