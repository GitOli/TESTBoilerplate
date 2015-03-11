using System.Reflection;
using Abp.Modules;

namespace TESTBoilerplate
{
    [DependsOn(typeof(TESTBoilerplateCoreModule))]
    public class TESTBoilerplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
