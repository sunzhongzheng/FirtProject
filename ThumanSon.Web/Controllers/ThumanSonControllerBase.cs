using Abp.Web.Mvc.Controllers;

namespace ThumanSon.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ThumanSonControllerBase : AbpController
    {
        protected ThumanSonControllerBase()
        {
            LocalizationSourceName = ThumanSonConsts.LocalizationSourceName;
        }
    }
}