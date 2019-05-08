using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finhelp_back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace finhelp_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        //POST : /api/ApplicationUser/Register
        public object PostApplicationUser(ApplicationUserModel model)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.user_name,
                Email = model.email,
                FullName = model.full_name
            };

            try
            {
                var result = _userManager.CreateAsync(applicationUser, model.password);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}