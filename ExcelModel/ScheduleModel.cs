using System;

namespace ScheduleCreator.ExcelModel
{
    public class ScheduleModel
    {
        public int ScheduleID { get; set; }

        public int TrainType { get; set; }
        public int? Trainnumber { get; set; }
        public string Trainname{ get; set; }
        public string TrainID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public bool Direction { get; set; }
        public string Route { get; set; }
        public string Laststationdeparture { get; set; }
        public string NextBlockSection { get; set; }
        public int Status { get; set; }
        public int AverageSpeed { get; set; }
        public int Numberofwagons { get; set; }
        public int TrainPriority { get; set; }
        public int? CommodityID { get; set; }
        public int? RakeTypeID { get; set; }
        public bool? Emptyloaded { get; set; }
        public string LonghaulID { get; set; }
        public string LoadID { get; set; }

        public int? TrainSubType { get; set; }
        public DateTime DepartureTime { get; set; }
        public string CreatedBy { get; set; }
        public bool? Isdiverted { get; set; }
        public bool? Recommended { get; set; }

    }

    public class ScheduleDetailModel
    {
        public int ScheduleID { get; set; }

        public string StopLocationName { get; set; }
        public DateTime? PlannedArrival { get; set; }
        public DateTime? ActualArrival { get; set; }
        public DateTime? PlannedDeparture { get; set; }
        public DateTime? ActualDeparture { get; set; }
        public int? ScheduleStopID { get; set; }
        public int? StopLocationID { get; set; }
        public int SequenceID { get; set; }
    }
}