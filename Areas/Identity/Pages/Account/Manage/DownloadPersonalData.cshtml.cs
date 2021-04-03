using Resume.Areas.Identity.Data;
using Resume.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
//using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume.Areas.Identity.Pages.Account.Manage
{
    public class DownloadPersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<DownloadPersonalDataModel> _logger;
        private readonly ConspectusContext _context;

        public DownloadPersonalDataModel(
            UserManager<ApplicationUser> userManager,
            ILogger<DownloadPersonalDataModel> logger,
            ConspectusContext context)
        {
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("User with ID '{UserId}' asked for their personal data.", _userManager.GetUserId(User));

            // Only include personal data for download
            var personalData = new Dictionary<string, string>();
            var personalDataProps = typeof(ApplicationUser).GetProperties().Where(
                            prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));
            foreach (var p in personalDataProps)
            {
                personalData.Add(p.Name, p.GetValue(user)?.ToString() ?? "null");
            }

            var logins = await _userManager.GetLoginsAsync(user);
            foreach (var l in logins)
            {
                personalData.Add($"{l.LoginProvider} external login provider key", l.ProviderKey);
            }


            // resume data
            var query = $"SELECT * FROM Conspectus WHERE UId = '{user.Id.ToString().ToUpper()}'";
            var conspectus1 = await _context.Conspectus.FromSqlRaw(query).ToListAsync();
            //var x = JsonConvert.SerializeObject(conspectus1);
            //var y = JsonConvert.SerializeObject(personalData);

            byte[] utf8array = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(personalData)); //Log-in information and etc
            byte[] utf8array2 = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(conspectus1)); // Resume data
            byte[] utf8Array3 = new byte[utf8array.Length + utf8array2.Length];
            Array.Copy(utf8array, utf8Array3, utf8array.Length);
            Array.Copy(utf8array2, 0, utf8Array3, utf8array.Length, utf8array2.Length);



            Response.Headers.Add("Content-Disposition", "attachment; filename=PersonalData.json");
            //return new FileContentResult(JsonSerializer.SerializeToUtf8Bytes(personalData), "application/json");

            return new FileContentResult(utf8Array3, "application/json");
        }
    }
}
