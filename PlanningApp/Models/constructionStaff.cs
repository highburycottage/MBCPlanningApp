//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanningApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class constructionStaff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public constructionStaff()
        {
            this.projectRequisitions = new HashSet<projectRequisition>();
        }
    
        public int staffID { get; set; }
        public string userName { get; set; }
        public string emailAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projectRequisition> projectRequisitions { get; set; }
    }
}
