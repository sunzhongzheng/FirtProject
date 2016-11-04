using Abp.Web.Mvc.Views;

namespace ThumanSon.Web.Views
{
    public abstract class ThumanSonWebViewPageBase : ThumanSonWebViewPageBase<dynamic>
    {

    }

    public abstract class ThumanSonWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ThumanSonWebViewPageBase()
        {
            LocalizationSourceName = ThumanSonConsts.LocalizationSourceName;
        }
    }
}