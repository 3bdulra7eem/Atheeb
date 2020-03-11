using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//This File Was Made By Eng\ Abdulraheem Abdullah

using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AtheebTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
        public float Salary { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public byte[] Photo { get; set; }
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        [NotMapped]
        public IFormFile PhotoFile { get; set; }

    }
}
