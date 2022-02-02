namespace ScheduleCreator.Models
{
    public class TrainSubTypeDto
    {
        public TrainSubTypeDto(int trainSubTypeID)
        {
            this.TrainSubTypeID = trainSubTypeID;


        }
        public int TrainSubTypeID { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}