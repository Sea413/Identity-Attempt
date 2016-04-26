using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Http.Internal;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using StackOverflow.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc.Rendering;
using StackOverflow.ViewModels;




// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace StackOverflow.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _rolesManager;

        public AdminController(UserManager<ApplicationUser> userManager, ApplicationDbContext db, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _rolesManager = roleManager;
            _db = db;
        }

        // GET: /<controller>/
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(string RoleName)
        {
            _db.Roles.Add(new IdentityRole()
            {
                Name = RoleName
            });
            _db.SaveChanges();

               return RedirectToAction("Index");
            }
        }




        //public ActionResult Edit(string roleName)
        //{
        //    var thisRole = _db.Roles.Where(r => r.Name.Equals(roleName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

        //    return View(thisRole);
        //}

        ////
        //// POST: /Roles/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Microsoft.AspNet.Identity.EntityFramework.IdentityRole role)
        //{
        //    try
        //    {
        //        _db.Entry(role).State = Microsoft.Data.Entity.EntityState.Modified;
        //        _db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        //public ActionResult ManageUserRoles()
        //{
        //    // prepopulat roles for the view dropdown
        //    var list = _db.Roles.OrderBy(r => r.Name).ToList().Select(rr =>

        //    new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
        //    ViewBag.Roles = list;
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult RoleAddToUser(string UserName, string RoleName)
        //{
        //    ApplicationUser user = _db.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        //    var account = new AccountController();
        //    account.UserManager.AddToRole(user.Id, RoleName);

        //    ViewBag.ResultMessage = "Role created successfully !";

        //    // prepopulat roles for the view dropdown
        //    var list = _db.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
        //    ViewBag.Roles = list;

        //    return View("ManageUserRoles");
        //}
    }
