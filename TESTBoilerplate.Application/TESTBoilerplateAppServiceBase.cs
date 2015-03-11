using Abp.Application.Services;

namespace TESTBoilerplate
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TESTBoilerplateAppServiceBase : ApplicationService
    {
        protected TESTBoilerplateAppServiceBase()
        {
            LocalizationSourceName = TESTBoilerplateConsts.LocalizationSourceName;
        }
    }
}