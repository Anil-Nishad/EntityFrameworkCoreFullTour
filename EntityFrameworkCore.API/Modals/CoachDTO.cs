namespace EntityFrameworkCore.API.Modals
{
    public class CoachDTO
    {
        public string Name { get; set; }
        public int? TeamId { get; internal set; }
    }
}