using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicMeetingApp.Models
{
    public class MeetingInfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }

        public int NumberOfPeople { get; set; }
    }
}