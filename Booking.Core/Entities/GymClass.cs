namespace PumpingIronGyms.Core.Entities
{
    public class GymClass
    {
       
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; } = String.Empty;

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set;} = new List<ApplicationUserGymClass>();
     
    }
}
