//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MidYearFeedback
    {
        public long MidYearFeedbackId { get; set; }
        public string MidPerfIndicator { get; set; }
        public string MidCommentsPositive { get; set; }
        public string MidCommentsImprove { get; set; }
        public Nullable<long> MidYearFeedbackCycleId { get; set; }
        public long MidYearFeedbackAssignmentId { get; set; }
    
        public virtual FeedbackAssignment FeedbackAssignment { get; set; }
    }
}
