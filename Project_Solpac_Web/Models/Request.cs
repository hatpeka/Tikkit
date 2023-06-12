using System.ComponentModel.DataAnnotations;

namespace Project_Solpac_Web.Models
{
    public class Request
    {

        [Key]
        public int RequestNo { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public string? RequestPerson { get; set; }
        public string? Partner { get; set; }
        public string? EndUser { get; set; }
        public string? SoftwareProduct { get; set; }
        public string? ProgramName { get; set; }
        [Required]
        public string? CurrentSituation { get; set; }
        [Required]
        public string? ContentsOfRequest { get; set; }
        [Required]
        public string? CorrectSituation { get; set; }
        public string? Contact { get; set; }
    }
}
