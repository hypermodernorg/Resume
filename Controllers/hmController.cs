using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resume.Data;
using Resume.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Resume.Areas.Identity.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Resume.Controllers
{
    public class hmController : Controller
    {
        private readonly ConspectusContext _context;
        private readonly ApplicationDbContext _icontext;
        private readonly UserManager<ApplicationUser> _userManager;


        public hmController(ConspectusContext context, ApplicationDbContext icontext, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _icontext = icontext;
            _userManager = userManager;
        }

        // GET: Conspectus/Details/5
        public async Task<IActionResult> Index(string id)
        {
            if (id == null)
            {
                return RedirectToAction("ResumeNotFound", "Home");
            }

            var conspectus = await _context.Conspectus
                .FirstOrDefaultAsync(m => m.ResumeSlug == id);
            if (conspectus == null)
            {
                return RedirectToAction("ResumeNotFound", "Home");
            }


            if (conspectus.Experience != null)
            {
                conspectus.Experiences = JsonSerializer.Deserialize<List<SingleExperience>>(conspectus.Experience);
            }
            if (conspectus.Education != null)
            {
                conspectus.Educations = JsonSerializer.Deserialize<List<SingleEducation>>(conspectus.Education);
            }
            if (conspectus.Skill != null)
            {
                conspectus.Skills = JsonSerializer.Deserialize<List<SingleSkill>>(conspectus.Skill);
            }
            if (conspectus.Contact != null)
            {
                conspectus.Contacts = JsonSerializer.Deserialize<ContactInformation>(conspectus.Contact);
            }

            return View(conspectus);
        }
    }
}
