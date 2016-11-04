using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ThumanSon.EntityFramework;

namespace ThumanSon
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ThumanSonCoreModule))]
    public class ThumanSonDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ThumanSonDbContext>(null);
        }
    }
}
