using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace TESTBoilerplate
{
    [DependsOn(typeof(AbpWebApiModule), typeof(TESTBoilerplateApplicationModule))]
    public class TESTBoilerplateWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(TESTBoilerplateApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
