using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.DataAccess.Helpers
{
    public static class ModelBuilderExtensions
    {
        public static void SetDefaults(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes().Where(x => x.ClrType.GetCustomAttribute(typeof(TableAttribute)) != null))
            {
                var entityClass = entity.ClrType;

                SetDefaultTableName(modelBuilder, entityClass);
                SetDefaultValue(modelBuilder, entityClass);
            }
        }

        private static void SetDefaultTableName(ModelBuilder modelBuilder, Type entityClass)
        {
            var tAttr = entityClass.GetCustomAttribute(typeof(TableAttribute)) as TableAttribute;
            if (tAttr != null)
                modelBuilder.Entity(entityClass).ToTable(tAttr.Name);
        }

        private static void SetDefaultValue(ModelBuilder modelBuilder, Type entityClass)
        {
            foreach (var property in entityClass.GetProperties())
            {
                if (property.Name == "CreatedAt")
                {
                    modelBuilder.Entity(entityClass).Property(property.Name).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd();
                }
                else if (property.Name == "LastModifiedAt")
                {
                    modelBuilder.Entity(entityClass).Property(property.Name).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAddOrUpdate();
                }
                else
                {
                    var pAttr = property.GetCustomAttribute(typeof(DefaultValueAttribute)) as DefaultValueAttribute;
                    if (pAttr != null && pAttr.Value != null)
                        modelBuilder.Entity(entityClass).Property(property.Name).HasDefaultValueSql(pAttr.Value.ToString());
                }
            }
        }
    }
}