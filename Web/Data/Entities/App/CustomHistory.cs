using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations.Internal;

namespace DNMOFT.CostTrackR.Web.Data.Entities.App
{
#pragma warning disable EF1001 // Internal EF Core API usage.
    public class CustomHistory : NpgsqlHistoryRepository
    {
        public CustomHistory(HistoryRepositoryDependencies dependencies) : base(dependencies)
#pragma warning restore EF1001 // Internal EF Core API usage.
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<HistoryRow> history)
        {
            base.ConfigureTable(history);

            history.Property(h => h.MigrationId).HasColumnName("Id");
        }
    }
}