using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using MvcApplication3.Domain;
using MvcApplication3.ViewModels;
using MvcApplication3.ApplicationServices;

namespace MvcApplication3.Controllers
{
    public class UserController : Controller
    {
        public IUserService UserService {get; set;}

        //
        // GET: /User/
        
        public ActionResult Index()
        {
            var r = new ViewUser();
            r.FirstName = "Bob";
            UserService.AddUser(r);
            ViewUser usr = UserService.GetUserById(1);
            return View();
        }

        /// <summary>
        /// Possible REST method to get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ViewUser Get(int id)
        {
            return UserService.GetUserById(id);
        }

        /// <summary>
        /// Possible REST method to add user
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(ViewUser user)
        {
            UserService.AddUser(user);
        }


    }
}
