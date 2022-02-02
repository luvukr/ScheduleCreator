using System;

namespace ScheduleCreator.Models
{
    public class CommentDto
    {
        public string Value { get; set; }
        public Guid AddedByUserId { get; set; }
        public DateTime AddedAt { get; set; }
    }
}