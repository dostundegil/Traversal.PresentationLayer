﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrate;
using Traversal.PresentationLayer.Areas.Admin.Models;
using Traversal.PresentationLayer.Models;

namespace Traversal.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Email = p.Mail,
                UserName = p.Username
            };
            if (p.Password == p.ConfirmPassword)
            {
                var result=await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);
                if (result.Succeeded)
                {
                    var user = _userManager.Users.FirstOrDefault(x => x.UserName == p.Username);
                    var roles = _roleManager.Roles.ToList();
                    var userRoles = await _userManager.GetRolesAsync(user);
                    foreach (var item in userRoles)
                    {
                        if (item == "Admin")
                        {
                            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                        }
                    }

                    return RedirectToAction("Index","Profile",new {area="Member"});
                }
                else 
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
