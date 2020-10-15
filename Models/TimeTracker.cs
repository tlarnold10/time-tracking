using System;

// This is needed in order to use the list data type
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTrack.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string Location { get; set; }

        public List<Project> Projects { get; set; } 
    }

    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public int ProjectType { get; set; }

        // foreign key
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }

    public class TimeEntry
    {
        public int TimeEntryId { get; set; }
        public float Time { get; set; }

        [DataType(DataType.Date)]
        public DateTime WorkDate { get; set; }

        // foreign key
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }

    public class ReportViewClass
    {
        public int ReportId { get; set; }
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
    }
}