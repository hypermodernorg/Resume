using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Resume.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Resume.Models
{
    public class Conspectus
    {
        public Guid Id { get; set; } // Auto primary key by convention.
        public Guid UId { get; set; } // Key to User
        public string ResumeName { get; set; }
        public string UserDisplayName { get; set; }
        public string Summary { get; set; }
        public string SummaryName { get; set; }
        public string Experience { get; set; }
        public string ExperienceName { get; set; }
        public string Education { get; set; }
        public string EducationName { get; set; }
        public string Skills { get; set; }
        public string SkillsName { get; set; }
        public string Contact { get; set; }
        public string ContactName { get; set; }
    }
}
