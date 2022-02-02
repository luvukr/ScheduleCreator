using System;

namespace ScheduleCreator.Models
{
    public class LinkDto
    {
        public Guid LinkedScheduleId { get; set; }
        public bool IsParent { get; set; }
        
    }
}