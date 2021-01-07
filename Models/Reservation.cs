//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIControllers.Models
{
    public class Reservation
    {
        [Required]
        [Range(1,13)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StartLocation { get; set; }

        [JsonIgnore]
        public string EndLocation { get; set; }
    }
}