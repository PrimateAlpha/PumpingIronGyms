
namespace PumpingIronGyms.Core.Entities
{
#nullable disable
    public class ApplicationUserGymClass
    {
        public string ApplicationUserId { get; set; }
        
        public int GymClassId { get; set; } //FK
        public GymClass GymClass { get; set; } //FK
        public ApplicationUser ApplicationUser { get; set;} //Navigation
    }
}
