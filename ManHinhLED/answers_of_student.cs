//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManHinhLED
{
    using System;
    using System.Collections.Generic;
    
    public partial class answers_of_student
    {
        public int id_answer_of_student { get; set; }
        public Nullable<int> id_student { get; set; }
        public Nullable<int> id_question { get; set; }
        public Nullable<int> time_of_answer { get; set; }
        public string answers { get; set; }
    
        public virtual question question { get; set; }
        public virtual student student { get; set; }
    }
}
