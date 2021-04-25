using Microsoft.EntityFrameworkCore;
using SureCompli.SureCompli;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SureCompli.EntityFrameworkCore
{
    public static class SureCompliDbContextModelCreatingExtensions
    {
        public static void ConfigureSureCompli(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SureCompliConsts.DbTablePrefix + "YourEntities", SureCompliConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Country>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "Countries", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<RegulationCategory>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "RegulationCategories", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<Regulation>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "Regulations", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<Question>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "Questions", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                
            });

            builder.Entity<RegulationQuestion>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "RegulationQuestions", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<RegulationQuestion>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "RegulationQuestions", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<Engagement>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "Engagements", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<EngagementQA>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "EngagementQAs", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<EngagementCharge>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "EngagementCharges", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<BlockChain>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "BlockChains", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });

            builder.Entity<BlockChainNode>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "BlockChainNodes", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });

            builder.Entity<UserKey>(b =>
            {
                b.ToTable(SureCompliConsts.DbTablePrefix + "UserKeys", SureCompliConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props

            });


        }
    }
}