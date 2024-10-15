using System.ComponentModel.DataAnnotations;

namespace WebApplicationWebAppCheckMarx.Models
{
    public class SiteRequest
    {
        [Required]
        public long PlantId { get; set; }
        public byte Status { get; set; }
    }

}
