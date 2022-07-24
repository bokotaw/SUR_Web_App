// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SUR_Web_App.Models;

namespace SUR_Web_App.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;

        public PersonalDataModel(
            UserManager<ApplicationUser> userManager,
            ILogger<PersonalDataModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public const string SessionUserId = "_UserId";

        public async Task<IActionResult> OnGet()
        {
            if (!string.IsNullOrEmpty(Request.Query["userId"]))
            {
                HttpContext.Session.SetString(SessionUserId, Request.Query["userId"]);
            }

            string uid = HttpContext.Session.GetString(SessionUserId);

            var user = _userManager.Users.FirstOrDefault(u => u.Id == uid);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return Page();
        }
    }
}
