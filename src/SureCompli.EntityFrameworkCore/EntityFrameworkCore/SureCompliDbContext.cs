using Microsoft.EntityFrameworkCore;
using SureCompli.SureCompli;
using SureCompli.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace SureCompli.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See SureCompliMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class SureCompliDbContext : AbpDbContext<SureCompliDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<RegulationCategory> RegulationCategories { get; set; }
        public DbSet<Regulation> Regulations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RegulationQuestion> RegulationQuestions { get; set; }

        public DbSet<Engagement> Engagements { get; set; }
        public DbSet<EngagementQA> EngagementQAs { get; set; }
        public DbSet<EngagementCharge> EngagementCharges { get; set; }

        public DbSet<BlockChain> BlockChains { get; set; }
        public DbSet<BlockChainNode> BlockChainNodes { get; set; }
        public DbSet<UserKey> UserKeys { get; set; }


        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside SureCompliDbContextModelCreatingExtensions.ConfigureSureCompli
         */

        public SureCompliDbContext(DbContextOptions<SureCompliDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the SureCompliEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureSureCompli method */

            builder.ConfigureSureCompli();
        }
    }
}
