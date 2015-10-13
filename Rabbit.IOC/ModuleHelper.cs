using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Rabbit.IOC
{
    public static class ModuleHelper
    {
        /// <summary>
        /// Filter modules that are not satisfied with a given condition by calling the IsSatisfied method of IModule
        /// </summary>
        public static IEnumerable<IModule> FilterWith(this IEnumerable<IModule> modules, object condition)
        {
            return modules.Where(x => x.IsSatisfied(condition));
        }

        /// <summary>
        /// Create instances from IModule types
        /// </summary>
        public static IEnumerable<IModule> CreateModules(this IEnumerable<Type> moduleTypes)
        {
            return moduleTypes.Select(Activator.CreateInstance)
                .Cast<IModule>()
                .Where(x => x != null).OrderBy(x => x.Index);
        }

        /// <summary>
        /// Get all types which implemented IModule interface
        /// </summary>
        public static IEnumerable<Type> GetModuleTypes(params Assembly[] assemblies)
        {
            return assemblies.SelectMany(GetIModuleTypes);
        }

        private static IEnumerable<Type> GetIModuleTypes(Assembly assembly)
        {
            return
                assembly.GetTypes()
                    .Where(t => t.IsPublic && !t.IsAbstract && !t.IsGenericType && typeof(IModule).IsAssignableFrom(t));
        }
    }
}
