using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace ThumanSon
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ThumanSonApplicationModule))]
    public class ThumanSonWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ThumanSonApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
