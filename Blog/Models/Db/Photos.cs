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
    
    public partial class Photos
    {
        public Photos()
        {
            this.PhotosComments = new HashSet<PhotosComments>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<PhotosComments> PhotosComments { get; set; }
    }
}