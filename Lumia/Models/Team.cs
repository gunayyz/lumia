using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lumia.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Desc { get; set; }
        public string Url { get; set; }

        [NotMapped, Required]
        public IFormFile Photo { get; set; }

    }
}
