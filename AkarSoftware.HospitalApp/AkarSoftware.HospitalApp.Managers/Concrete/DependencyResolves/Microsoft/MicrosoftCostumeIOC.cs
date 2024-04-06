using AkarSoftware.HospitalApp.Managers.Abstract;
using AkarSoftware.HospitalApp.Managers.Concrete.Managers;
using AkarSoftware.HospitalApp.Managers.Concrete.Managers.Media;
using AkarSoftware.HospitalApp.Managers.Concrete.Options.Cloudinary;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Contexts;
using AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.UOW;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace AkarSoftware.HospitalApp.Managers.Concrete.DependencyResolves.Microsoft
{
    public static class MicrosoftCostumeIOC
    {
        public static void AddCostumeDependencies(this IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration )
        {
            AddDbContext(Services, Environment, Configuration);

            AddAutoMapper(Services, Environment, Configuration);

            AddValidator(Services, Environment, Configuration);

            AddUnitOfWork(Services, Environment, Configuration);

            AddDependencies(Services, Environment, Configuration);

            AppConfiguration(Services, Environment, Configuration);

            AddAuthentication(Services, Environment, Configuration);





        }

        #region Methods 
        /// <summary>
        /// Enviroment bazlı olarak DbContext üzerinde çeşitli yapılandırmalar uygulanabilir, lazyloading, pool, loglama gibi bazı özellikler yada enviroment a göre db değişikliği gibi bu sebeple ayrıştırıldı 
        /// </summary>
        private static void AddDbContext(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {

            if (Environment.IsProduction())
            {
                Services.AddDbContext<MyContexts>(opt =>
                {
                    opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
                });


            }
            else
            {
                Services.AddDbContext<MyContexts>(opt =>
                {
                    opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
                });

                using ( var context = Services.BuildServiceProvider().GetRequiredService<MyContexts>())
                {
                     context.Database.Migrate();
                }

            }
        }

        /// <summary>
        /// AutoMapper eklenmesi ve konfigürasyonu burada gerçekleştirilmektedir. 
        /// </summary>
        private static void AddAutoMapper(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {
            Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// ilgili Dto validasyonu için ilgili reflection çözümlemesi aşağıdaki koddur. bunun aktivasyonu sağlanır. 
        /// </summary>
        private static void AddValidator(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var validatorTypes = assembly.GetTypes().Where(x => x.BaseType != null && x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(AbstractValidator<>));

            foreach (var validatorType in validatorTypes)
            {
                var genericType = validatorType.BaseType.GetGenericArguments()[0];
                var validatorInterfaceType = typeof(IValidator<>).MakeGenericType(genericType);
                Services.AddScoped(validatorType, validatorInterfaceType);
            }
        }

        /// <summary>
        /// Unit Of Work eklenmesi  
        /// </summary>
        private static void AddUnitOfWork(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {
            Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        /// <summary>
        /// Konfigürasyonların eklenmesi (Option pattern, Enviroment appjson .... )
        /// </summary>
        private static void AppConfiguration(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {
            Services.Configure<CloudianryOptions>(Configuration.GetSection("CloudinarySettings"));


        }

        /// <summary>
        /// Authentication eklenmesi 
        /// </summary>
        /// 
        
        private static void AddAuthentication (IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {

        }


        /// <summary>
        /// Servislerin Eklenmesi  
        /// </summary>
        private static void AddDependencies(IServiceCollection Services, IHostEnvironment Environment, IConfiguration Configuration)
        {
            Services.AddScoped<IMediaServices, CloudinaryManager>();

            Services.AddScoped<ILandingService, LandingManager>();

        }


        #endregion
    }
}
