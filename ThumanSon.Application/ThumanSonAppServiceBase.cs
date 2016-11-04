using Abp.Application.Services;

namespace ThumanSon
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ThumanSonAppServiceBase : ApplicationService
    {
        protected ThumanSonAppServiceBase()
        {
            LocalizationSourceName = ThumanSonConsts.LocalizationSourceName;
        }
    }
}