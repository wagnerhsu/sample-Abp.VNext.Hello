using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Abp.VNext.Hello.EntityFrameworkCore
{
    [DependsOn(
        typeof(HelloDomainModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpIdentityServerEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),
        typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
        typeof(AbpAuditLoggingEntityFrameworkCoreModule),
        typeof(AbpTenantManagementEntityFrameworkCoreModule),
        typeof(AbpFeatureManagementEntityFrameworkCoreModule)
        )]
    public class HelloEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            HelloEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HelloDbContext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also HelloMigrationsDbContextFactory for EF Core tooling. */
                options.UseSqlServer();//UseSqlServer
            });


            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<HelloDbContext>(x =>
                {

                });
            });
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<BackgroundJobsDbContext>(x =>
                {

                });
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<FeatureManagementDbContext>(x =>
                {

                });
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<AbpAuditLoggingDbContext>(x =>
                {
                });
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<TenantManagementDbContext>(x =>
                {

                });
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer<SettingManagementDbContext>(x =>
                {

                });
            });

            Configure<AbpDbContextOptions>((options) =>
            {
                options.UseSqlServer<IdentityDbContext>(x =>
                {
                    // x.CommandTimeout(6_000);
                });
            });

            Configure<AbpDbContextOptions>((options) =>
            {
                options.UseSqlServer<PermissionManagementDbContext>(x =>
                {
                    x.CommandTimeout(6_000);
                });
            });

            Configure<AbpDbContextOptions>((options) =>
            {
                options.UseSqlServer<IdentityServerDbContext>(x =>
                {
                    // x.MaxBatchSize(4096);
                    // x.CommandTimeout(6_000);
                });
            });
        }
    }
}
