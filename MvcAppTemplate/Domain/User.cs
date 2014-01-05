using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace MvcApplication3.Domain
{
    /// <summary>
    /// Our Entity
    /// </summary>
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
    }

    /// <summary>
    /// Corresponding Map class
    /// </summary>
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);

            Map(x => x.FirstName);

            Table("[User]");
        }
    }
}