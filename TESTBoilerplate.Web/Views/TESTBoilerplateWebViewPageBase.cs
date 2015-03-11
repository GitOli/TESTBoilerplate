using Abp.Web.Mvc.Views;

namespace TESTBoilerplate.Web.Views
{
    public abstract class TESTBoilerplateWebViewPageBase : TESTBoilerplateWebViewPageBase<dynamic>
    {

    }

    public abstract class TESTBoilerplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TESTBoilerplateWebViewPageBase()
        {
            LocalizationSourceName = TESTBoilerplateConsts.LocalizationSourceName;
        }
    }
}