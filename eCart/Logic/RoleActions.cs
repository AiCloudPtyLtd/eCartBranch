using eCart.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace eCart.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(roleStore);
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "NenadRakas@outlook.com",
                Email = "NenadRakas@outlook.com"
            };
            //IdUserResult = userMgr.Create(appUser, ConfigurationManager.AppSettings["AppUserPasswordKey"]);
            if (!userMgr.IsInRole(userMgr.FindByEmail("NenadRakas@outlook.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("NenadRakas@outlook.com").Id, "canEdit");
            }
        }
    }
}