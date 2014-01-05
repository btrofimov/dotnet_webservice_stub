using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spring.Data.NHibernate;
using System.Reflection;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;


namespace MvcApplication3.Infrastructure
{
    /// <summary>
    /// Thanks to http://blog.bennymichielsen.be/2009/01/04/using-fluent-nhibernate-in-spring-net/
    /// </summary>
    public class FluentNhibernateLocalSessionFactoryObject: LocalSessionFactoryObject
    {
        /// <summary>
        /// Sets the assemblies to load that contain fluent nhibernate mappings.
        /// </summary>
        /// <value>The mapping assemblies.</value>
        public string[] FluentNhibernateMappingAssemblies
        {
            get;
            set;
        }
 
        protected override void PostProcessConfiguration(Configuration config)
        {
            base.PostProcessConfiguration(config);
            Fluently.Configure(config)
            .Mappings(m =>
            {
                foreach (string assemblyName in FluentNhibernateMappingAssemblies)
                {
                    m.HbmMappings
                    .AddFromAssembly(Assembly.Load(assemblyName));

                    m.FluentMappings
                    .AddFromAssembly(Assembly.Load(assemblyName));
                }
            })
            .BuildConfiguration();
        }
    }   
}