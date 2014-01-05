using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MvcApplication3.Domain;
using MvcApplication3.ViewModels;
using Spring.Transaction.Interceptor;

namespace MvcApplication3.ApplicationServices.Impl
{
    /// <summary>
    /// Application Service implementation. It implements predefined use cases over User entities.
    /// Each method is transactional. 
    /// In fact, the component might be called from any place and transactions will work.
    /// As example this application is called from Controller object.
    /// 
    /// The service is stateless and conforms to Singleton definition.
    /// 
    /// In addition, the service might be considered as Bounded Context with
    /// own transactional isolation over our domain (as example covers just User).
    /// </summary>
    public class UserService : IUserService
    {
        public IUserRepository UserRepository { get; set; }
        
        public UserService()
        {
            Mapper.CreateMap<User, ViewUser>();
            Mapper.CreateMap<ViewUser, User>();
        }
        
        /// <summary>
        /// Method uses ordinary transaction for write/read access
        /// </summary>
        /// <param name="newUser"></param>
        
        [Transaction]
        public void AddUser(ViewUser newUser)
        {
            UserRepository.AddUser(Mapper.Map<ViewUser, User>(newUser));
        }

        /// <summary>
        /// Important thing, we use declarative transaction with read-only flag. 
        /// This allows improving performance for such methods.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [Transaction (ReadOnly=true)]
        public ViewUser GetUserById(int id)
        {
            var user = UserRepository.GetUser(id);
            return Mapper.Map<User, ViewUser>(user);
        }
    }
}