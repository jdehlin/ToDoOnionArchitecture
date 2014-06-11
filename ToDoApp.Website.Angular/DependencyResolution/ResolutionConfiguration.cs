using System.Reflection;
using System.Web.Configuration;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace ToDoApp.Website.DependencyResolution
{
    public class ResolutionConfiguration : Registry
    {
        public ResolutionConfiguration()
        {
            Scan(s =>
            {
                s.WithDefaultConventions();
                s.AssembliesFromApplicationBaseDirectory(AssemblyFilter);
            });
        }

        private bool AssemblyFilter(Assembly assembly)
        {
            var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (customAttributes.Length == 0)
            {
                return false;
            }
            return ((AssemblyProductAttribute)customAttributes[0]).Product.Contains("ToDoApp");
        }
    }
}