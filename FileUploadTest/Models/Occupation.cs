//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileUploadTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Occupation
    {
        public Occupation()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int OccupationId { get; set; }
        public string OccupationName { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
    }
}