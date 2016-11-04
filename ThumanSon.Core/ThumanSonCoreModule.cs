using System.Reflection;
using Abp.Modules;

namespace ThumanSon
{
    public class ThumanSonCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
