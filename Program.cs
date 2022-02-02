using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using ScheduleCreator.Enums;
using ScheduleCreator.ExcelModel;
using ScheduleCreator.Helpers;
using ScheduleCreator.Models;

namespace ScheduleCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<CreateScheduleModel> formattedSchedules= new List<CreateScheduleModel>();

                string excelPath = "D:\\repos\\ScheduleCreatorFromETLProcessedData\\ScheduleCreator\\Resources\\TrainScheduleDetails.xlsx";
                var data = ExcelHelper.GetExcel(excelPath, "Sheet1");
                var csharpData = data.Rows.Cast<ScheduleModel>().ToList();
                //for (int i = 0; i < data.Rows.Count; i++)
                //{
                //    var trainType = GetTrainType((int)data.Rows[i]["TrainType"]);
                //    switch (trainType)
                //    {
                //        case TrainType.Passenger:
                //            var train1 = CreatePassangerModel(data.Rows[i]);
                //            formattedSchedules.Add(train1);
                //            break;
                //        case TrainType.Freight:
                //            var train2 = CreateFreightModel(data.Rows[i]);
                //            formattedSchedules.Add(train2);
                //            break;
                //        case TrainType.Others:
                //            var train3 = CreateNRTModel(data.Rows[i]);
                //            formattedSchedules.Add(train3);
                //            break;
                //        default:
                //            break;
                        
                //    }

                //}
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        //static CreateScheduleModel CreatePassangerModel(DataRow row)
        //{
        //    CreatePassengerScheduleModel s = new CreatePassengerScheduleModel
        //    {
        //            TrainId = (string)row["TrainID"],
        //            Origin = new StationDto(Guid.Empty, (string)row["Origin"]),
        //            Destination = new StationDto(Guid.Empty, (string)row["Destination"]),
        //            TrainStatus = GetTrainStatus((int)row["Status"]),
        //            Priority = (int)row["TrainPriority"],
        //            TrainSubType = ((int?)row["TrainSubType"]) == null ? null : new TrainSubTypeDto(((int?)row["TrainSubType"]).Value),

        //            DepartureTime = (DateTime)row["StartTime"],
        //            //ArrivalTime = 
        //            Type = ,
        //            ArrivalTime = ((DateTime)row["StartTime"]).Add((TimeSpan)row["DepartureTime"]),
        //            MaxSpeed = (int?)row["UserDefinedSpeed"],

        //        };
        //    throw new NotImplementedException();
        //}
        //static CreateScheduleModel CreateFreightModel(DataRow row)
        //{
        //    throw new NotImplementedException();
        //}
        //static CreateScheduleModel CreateNRTModel(DataRow row)
        //{
        //    throw new NotImplementedException();
        //}

        static TrainType GetTrainType(int data)
        {
            TrainType t = TrainType.Others;
            switch(data)
            {
                case 40:
                    t = TrainType.Freight;
                    break;
                case 39:
                    t = TrainType.Passenger;
                    break;
                case 41:
                    t = TrainType.Others;
                    break;
                default:
                    break;
            }
            return t;
        }

        static TrainStatus GetTrainStatus(int data)
        {
            TrainStatus t = TrainStatus.Scheduled;
            switch (data)
            {
                case 1:
                    t = TrainStatus.Scheduled;
                    break;
                case 2:
                    t = TrainStatus.LoadedTravel;
                    break;
                case 3:
                    t = TrainStatus.Canceled;
                    break;
                case 4:
                    t = TrainStatus.Completed;
                    break;
                default:
                    break;
            }
            return t;
        }
    }
}
