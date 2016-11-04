using System.Reflection;
using Abp.Modules;

namespace ThumanSon
{
    [DependsOn(typeof(ThumanSonCoreModule))]
    public class ThumanSonApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
