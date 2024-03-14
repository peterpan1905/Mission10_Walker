using System.ComponentModel.DataAnnotations;

namespace mission10_walker_backend.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }
}
