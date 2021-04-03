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
    [Index(nameof(ResumeSlug), IsUnique = true)]
    public class Conspectus
    {
        public Guid Id { get; set; } // Auto primary key by convention.
        public Guid UId { get; set; } // Key to User

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\s]{3,40}$",ErrorMessage = "Alphanumeric characters and spaces only. Min three characters; max 40")]
        public string ResumeName { get; set; }
        public string ResumeSlug { get; set; }
        public string UserDisplayName { get; set; }
        [Display(Name = "Job Apiration or Job Title Desired", Description = "testgbfxfg gfsgggfd  fdgssdgf")]
     
        public string UserAspiration { get; set; }
        public string Summary { get; set; }
        public string SummaryName { get; set; }
        public string Experience { get; set; } // Store as Json
        public string Education { get; set; } // Store as Json
        public string Skill { get; set; } // Store as Json

        [NotMapped]
        public List<SingleExperience> Experiences { get; set; }

        [NotMapped]
        public List<SingleEducation> Educations { get; set; }

        [NotMapped]
        public List<SingleSkill> Skills { get; set; }

        [NotMapped]
        public ContactInformation Contacts { get; set; }

        public string ExperienceName { get; set; }
        public string EducationName { get; set; }
        public string SkillName { get; set; }

        public string Contact { get; set; }
        public string ContactName { get; set; }

    }

    [NotMapped]
    public class ContactInformation
    {
        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Linkedin { get; set; }

        [Url]
        public string PersonalWebsite { get; set; }
    }

    [NotMapped]
    public class SingleExperience 
    {
        [Required]
        public string Position { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool Enabled { get; set; }
        public bool Current { get; set; }
        public int Order { get; set; }
    }

    [NotMapped]
    public class SingleEducation
    {
        public string Degree { get; set; }
        public string School { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string GPA { get; set; }
        public bool Enabled { get; set; }
        public bool Current { get; set; }
        public int Order { get; set; }
    }

    [NotMapped]
    public class SingleSkill
    {
        public string Name { get; set; }
        public int SkillRating { get; set; }
    }
}
