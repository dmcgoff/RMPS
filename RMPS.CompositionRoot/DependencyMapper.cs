using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RMPS.Business.Interface;
using RMPS.Business.Logic;
using RMPS.DataAccess;
using RMPS.DataAccess.Interface;

namespace RMPS.CompositionRoot
{
    public static class DependencyMapper
    {
        public static void SetDependencies(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddEntityFramework()
            //    .AddDbContext<SonoPeopleContext>(options =>
            //        options.UseSqlServer(configuration["Data:DefaultConnection:ConnectionString"])
            //    );

            //MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new AutoMapperProfileConfiguration());
            //});
            //serviceCollection.AddSingleton<IMapper>(sp => mapperConfiguration.CreateMapper());

            serviceCollection.AddScoped<ICourseService, CourseService>();
            serviceCollection.AddScoped<ICourseCatalogService, CourseCatalogService>();

            serviceCollection.AddScoped<ICourseCatalogRepository, CourseCatalogRepository>();
            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();

            serviceCollection.AddScoped<IRmpsDbContext, RmpsDbContext>();
            
        }
    }
}
