using System;

namespace ScheduleCreator.Models
{
    public class StationDto
    {
        public StationDto(Guid stationId, string stationName)
        {
            this.StationId = Guid.NewGuid();
            this.StationName = stationName;

        }
        public Guid StationId { get; set; }
        public string StationName { get; set; }
    }
}