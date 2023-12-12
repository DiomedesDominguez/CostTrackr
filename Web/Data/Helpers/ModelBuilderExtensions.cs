using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.EntityFrameworkCore
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
            foreach (var property in entityClass.GetProperties()
                             .Where(p => p.PropertyType != typeof(DateTime) && p.CustomAttributes.Any(c => c.AttributeType == typeof(DefaultValueAttribute))))
            {

                if (property.Name == "Created")
                {
                    modelBuilder.Entity(entityClass).Property(property.Name)
                    .HasDefaultValueSql("SYSDATETIME()")
                    .ValueGeneratedOnAdd();
                }
                else if (property.Name == "LastUpdated")
                {
                    modelBuilder.Entity(entityClass).Property(property.Name).HasDefaultValue(DateTime.Now)
                    .HasDefaultValueSql("SYSDATETIME()")
                    .ValueGeneratedOnAddOrUpdate();
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