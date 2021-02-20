using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Resume.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public string Experience // String to store in database containing all indivudual resume experiences.
        {
            get; set;

        }

        [NotMapped]
        public List<SingleExperience> Experiences
        {
            get; set;
        }

        public string ExperienceName { get; set; }
        public string Education { get; set; }
        public string EducationName { get; set; }
        public string Skills { get; set; }
        public string SkillsName { get; set; }
        public string Contact { get; set; }
        public string ContactName { get; set; }

    }

    [NotMapped]
    public class SingleExperience // Singe experience in a resume.
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int Order { get; set; }
    }

    //[NotMapped]
    //public class Education
    //{
    //    public string Degree { get; set; }
    //    public string School { get; set; }
    //    public string StartDate { get; set; }
    //    public string EndtDate { get; set; }
    //    public string Description { get; set; }
    //}

    //[NotMapped]
    //public class Skill
    //{
    //    public string SkillName { get; set; }
    //    public string ExperienceRating { get; set; }
    //}
}
