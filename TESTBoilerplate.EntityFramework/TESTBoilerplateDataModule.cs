using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using TESTBoilerplate.EntityFramework;

namespace TESTBoilerplate
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(TESTBoilerplateCoreModule))]
    public class TESTBoilerplateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<TESTBoilerplateDbContext>(null);
        }
    }
}
