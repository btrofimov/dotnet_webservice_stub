using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Domain
{
    /// <summary>
    /// Abstraction, might implement different DAO implementations over User entities.
    /// </summary>
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUser(int id);
    }
}