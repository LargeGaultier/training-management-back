using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace TrainingManagement.RestApi.Persistence.Extension
{
    public static class ModelBuilderExtension
    {

        public static void ApplyAllConfigurations(this ModelBuilder modelBuilder)
        {
            var applyConfigurationMethodInfo = modelBuilder
                .GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .First(m => m.Name.Equals("ApplyConfiguration", StringComparison.OrdinalIgnoreCase));

#pragma warning disable S1481 // Unused local variables should be removed
            System.Collections.Generic.List<object> ret = typeof(TrainingManagementRefDbContext).Assembly
#pragma warning restore S1481 // Unused local variables should be removed
                .GetTypes()
                .Select(t => (t, i: t.GetInterfaces().FirstOrDefault(i => i.Name.Equals(typeof(IEntityTypeConfiguration<>).Name, StringComparison.Ordinal))))
                .Where(it => it.i != null)
                .Select(it => (et: it.i.GetGenericArguments()[0], cfgObj: Activator.CreateInstance(it.t)))
                .Select(it => applyConfigurationMethodInfo.MakeGenericMethod(it.et).Invoke(modelBuilder, new[] { it.cfgObj }))
                .ToList();
        }

    }
}
