using System.Reflection;
using Abp.Modules;

namespace TESTBoilerplate
{
    public class TESTBoilerplateCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
