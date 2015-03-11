using Abp.Web.Mvc.Controllers;

namespace TESTBoilerplate.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class TESTBoilerplateControllerBase : AbpController
    {
        protected TESTBoilerplateControllerBase()
        {
            LocalizationSourceName = TESTBoilerplateConsts.LocalizationSourceName;
        }
    }
}