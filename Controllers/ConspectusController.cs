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
using Resume.Areas.Identity.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Resume.Controllers
{
    public class ConspectusController : Controller
    {
        private readonly ConspectusContext _context;
        private readonly ApplicationDbContext _icontext;
        private readonly UserManager<ApplicationUser> _userManager;
       

        public ConspectusController(ConspectusContext context, ApplicationDbContext icontext, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _icontext = icontext;
            _userManager = userManager;
        }

        // GET: Conspectus
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            
            var query = $"SELECT * FROM Conspectus WHERE UId = '{user.Id.ToString().ToUpper()}'";
            return View(await _context.Conspectus.FromSqlRaw(query).ToListAsync());

            //return View(await _context.Conspectus.ToListAsync());
        }

        // GET: Conspectus/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conspectus = await _context.Conspectus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conspectus == null)
            {
                return NotFound();
            }

            return View(conspectus);
        }

        // GET: Conspectus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conspectus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UId,ResumeName,UserDisplayName,Summary,SummaryName,Experience,ExperienceName,Education,EducationName,Skills,SkillsName,Contact,ContactName")] Conspectus conspectus)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            
            if (ModelState.IsValid)
            {
                conspectus.Id = Guid.NewGuid();
                conspectus.UId = user.Id;
                _context.Add(conspectus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conspectus);
        }

        // GET: Conspectus/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conspectus = await _context.Conspectus.FindAsync(id);
            if (conspectus == null)
            {
                return NotFound();
            }
            conspectus.Experiences = JsonSerializer.Deserialize<List<SingleExperience>>(conspectus.Experience);
            return View(conspectus);
        }

        // POST: Conspectus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UId,ResumeName,UserDisplayName,Summary,SummaryName, Experiences, ExperienceName,Education,EducationName,Skills,SkillsName,Contact,ContactName")] Conspectus conspectus)
        {
            
            if (id != conspectus.Id)
            {
                return NotFound();
            }
            var test2 = conspectus.Experiences.Count; //Bingo
            var test1 = conspectus.ResumeName; // works
            if (ModelState.IsValid)
            {
                try
                {
                    if (conspectus.Experience != null)
                    {
                        conspectus.Experience = JsonSerializer.Serialize(conspectus.Experiences);
                    }
                    
                    _context.Update(conspectus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConspectusExists(conspectus.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(conspectus);
        }

        // GET: Conspectus/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conspectus = await _context.Conspectus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conspectus == null)
            {
                return NotFound();
            }

            return View(conspectus);
        }

        // POST: Conspectus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var conspectus = await _context.Conspectus.FindAsync(id);
            _context.Conspectus.Remove(conspectus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConspectusExists(Guid id)
        {
            return _context.Conspectus.Any(e => e.Id == id);
        }
    }
}
