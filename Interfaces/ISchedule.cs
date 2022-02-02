using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ScheduleCreator.Enums;
using ScheduleCreator.Models;

namespace ScheduleCreator.Interfaces
{
 
    public interface ISchedule 
    {
        public Guid ScenarioId { get; set; }
        public string TrainId { get; set; }
        public TrainType Type { get; set; }
        public TrainSubTypeDto TrainSubType { get; set; }
        public StationDto Origin { get; set; }
        public StationDto Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public IList<LinkDto> Links { get; set; }
        public IList<ViaPointDto> ViaPoints { get; set; }
        public Guid RouteId { get; set; }
        public IList<CommentDto> Comments { get; set; }
        public Guid CurrentLocationID { get; set; }
        public TrainStatus TrainStatus { get; set; }
        public int? MaxSpeed { get; set; }
        public int Priority { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsElectrified { get; set; }

        public Guid Id { get; set; }
        
    }
}