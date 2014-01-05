using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace MvcApplication3.Domain.Impl
{
    /// <summary>
    /// NHibernate DAO Repository implementation over User entities.
    /// The service is stateless and conforms to Singleton definition.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        public ISessionFactory SessionFactory { get; set; }

        public void AddUser(User user)
        {
            ISession session = SessionFactory.GetCurrentSession();
            session.Save(user);
        }

        public User GetUser(int id)
        {
            ISession session = SessionFactory.GetCurrentSession();
            return session.Get<User>(id);
        }
 
    }
}