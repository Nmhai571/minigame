﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gameshowhannguEntities : DbContext
    {
        public gameshowhannguEntities()
            : base("name=gameshowhannguEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<answers_of_student> answers_of_student { get; set; }
        public virtual DbSet<question_topic> question_topic { get; set; }
        public virtual DbSet<question_type> question_type { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<status_led> status_led { get; set; }
        public virtual DbSet<statuss> statusses { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<team_battle> team_battle { get; set; }
        public virtual DbSet<status_team> status_team { get; set; }
        public virtual DbSet<status_next_question> status_next_question { get; set; }
    }
}
