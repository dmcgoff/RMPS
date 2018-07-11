using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace ScaffoldFromDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new ARKSDatabaseStageContext())
            //{
            //    var id = new Guid("46DC8A84-AED3-4F1C-A465-C4707D14563B");
            //    var modality = context.Modalities.FirstOrDefault(m => m.Id == id);

            //    Debug.WriteLine("Name: " + modality.Name);
            //}
        }


    }

    public class MyDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            services.AddSingleton<IPluralizer, MyPluralizer>();
        }
    }

    public class MyPluralizer : IPluralizer
    {
        public string Pluralize(string name)
        {
            return Inflector.Inflector.Pluralize(name) ?? name;
        }

        public string Singularize(string name)
        {
            return Inflector.Inflector.Singularize(name) ?? name;
        }
    }
}
