//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace minigame
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.answers_of_student = new HashSet<answers_of_student>();
        }
    
        public int id_student { get; set; }
        public string name_account { get; set; }
        public string pass { get; set; }
        public string fullname { get; set; }
        public Nullable<int> point { get; set; }
        public Nullable<int> id_team { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<answers_of_student> answers_of_student { get; set; }
        public virtual team_battle team_battle { get; set; }
    }
}
