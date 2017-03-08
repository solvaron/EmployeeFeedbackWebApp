﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeFeedbackWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeFeedbackSystemEntities1 : DbContext
    {
        public EmployeeFeedbackSystemEntities1()
            : base("name=EmployeeFeedbackSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EndOfYearFeedback> EndOfYearFeedbacks { get; set; }
        public virtual DbSet<FeedbackAssignment> FeedbackAssignments { get; set; }
        public virtual DbSet<FeedbackCycle> FeedbackCycles { get; set; }
        public virtual DbSet<MidYearFeedback> MidYearFeedbacks { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int spEndOfYearReviewSetFeedbackCycles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEndOfYearReviewSetFeedbackCycles");
        }
    
        public virtual int spMidYearReviewSetFeedbackCycles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spMidYearReviewSetFeedbackCycles");
        }
    
        public virtual int midYearReviewSetFeedbackCycles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("midYearReviewSetFeedbackCycles");
        }
    
        public virtual ObjectResult<Nullable<long>> spMaxFeedBackCycleId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("spMaxFeedBackCycleId");
        }
    
        public virtual int spEndofYearReviewUpdateFeedbackCycles(Nullable<int> feedbackId)
        {
            var feedbackIdParameter = feedbackId.HasValue ?
                new ObjectParameter("feedbackId", feedbackId) :
                new ObjectParameter("feedbackId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEndofYearReviewUpdateFeedbackCycles", feedbackIdParameter);
        }
    
        public virtual int spMidYearReviewUpdateFeedbackCycles(Nullable<int> feedbackId)
        {
            var feedbackIdParameter = feedbackId.HasValue ?
                new ObjectParameter("feedbackId", feedbackId) :
                new ObjectParameter("feedbackId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spMidYearReviewUpdateFeedbackCycles", feedbackIdParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> spMaxUserId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("spMaxUserId");
        }
    
        public virtual ObjectResult<Nullable<long>> spMaxEOYId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("spMaxEOYId");
        }
    
        public virtual ObjectResult<Nullable<long>> spMaxMidYearId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("spMaxMidYearId");
        }
    }
}
