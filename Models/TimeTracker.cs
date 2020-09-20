using System;
using System.ComponentModel.DataAnnotations;

namespace TimeTrack.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
    }
}