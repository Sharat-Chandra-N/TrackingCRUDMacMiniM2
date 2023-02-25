using System;
namespace Tracking.Modals
{
    public class Issue
    {
        public int Id { get; set; }

        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public Priority Priority { get; set; }

        public IssueType IssueType { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? Completed { get; set; }
    }

    public enum Priority
    {
        Low, Meduim, High
    }

    public enum IssueType
    {
        Feature, Bug, Documentation
    }
}

