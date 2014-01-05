using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication3.ViewModels;

namespace MvcApplication3.ApplicationServices
{
    /// <summary>
    /// The interface provides abstraction over operations with User entities.
    /// 
    /// </summary>
    public interface IUserService
    {
        void AddUser(ViewUser newUser);
        ViewUser GetUserById(int id);
    }
}