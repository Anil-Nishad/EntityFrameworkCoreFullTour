namespace EntityFrameworkCore.API.Modals
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public List<string> CoachName { get; internal set; }
        //public List<CoachDTO> Coaches { get; set; } = new List<CoachDTO>();
        //public string CoachName { get; set; } // Assuming a single coach for simplicity, can be modified for multiple coaches
    }
}