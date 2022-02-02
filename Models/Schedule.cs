using ScheduleCreator.Interfaces;
using System;
using ScheduleCreator.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ScheduleCreator.Models
{

    public class CreatePassengerScheduleModel : CreateScheduleModel
    {
        public string TrainName { get; set; }
        public List<PassengerFreightStopDto> PlannedStops { get; set; }
    }

    public class CreateFreightScheduleModel : CreateScheduleModel
    {
        public List<PassengerFreightStopDto> PlannedStops { get; set; }
        public List<string> Products { get; set; }
        public bool IsLoaded { get; set; }
    }


    public class CreateNRTScheduleModel : CreateScheduleModel
    {
        public List<NRTStopDto> PlannedStops { get; set; }
        public Guid MaintenanceId { get; set; }
    }

    public class CreateScheduleModel
    {
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
        public bool IsElectrified { get; set; }
    }


    public class PassengerFreightStopDto
    {
        public Guid StationId { get; set; }
        public int MinimumWaitTimeInMinutes { get; set; }
        public DateTime TimeTableArrivalTime { get; set; }
        public DateTime TimeTableDepartureTime { get; set; }
        public Tuple<Guid, int, DateTime, DateTime> ToTuple()
        {
            return Tuple.Create(this.StationId, this.MinimumWaitTimeInMinutes, this.TimeTableArrivalTime, this.TimeTableDepartureTime);
        }
    }
    public class NRTStopDto
    {
        public Guid LocationID { get; set; }
        public Guid MaintenanceId { get; set; }
        public string ArrivalPriority { get; set; }
        public bool IsBackTrack { get; set; }
        public bool IsOffTrack { get; set; }
        public Tuple<Guid, Guid, string, bool, bool> ToTuple()
        {
            return Tuple.Create(this.LocationID, this.MaintenanceId, this.ArrivalPriority, this.IsBackTrack, this.IsOffTrack);
        }

    }
}