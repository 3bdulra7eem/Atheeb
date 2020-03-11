//This File Was Made By Eng\ Abdulraheem Abdullah

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtheebTask.Models
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(2)]
        public string Code { get; set; }
    }
}
