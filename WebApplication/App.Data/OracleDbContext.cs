using App.Core;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace App.Data
{
    public class OracleDbContext : DbContext, IDbContext
    {
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] {
            new DebugLoggerProvider()
        });
        public OracleDbContext()
        {
        }

        public OracleDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //加入调试日志
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            IEnumerable<Type> typesToRegister = Assembly.GetExecutingAssembly().GetTypes();
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            // .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));
            // .Where(type => type.ReflectedType != null && ((TypeInfo)type.ReflectedType).ImplementedInterfaces.Count()>0 && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                TypeInfo typeInfo = type.GetTypeInfo();
                foreach (var t in typeInfo.ImplementedInterfaces)
                {
                    if (t.Name == typeof(IEntityTypeConfiguration<>).Name)
                    {
                        dynamic instance = Activator.CreateInstance(type);
                        modelBuilder.ApplyConfiguration(instance);
                    }
                }
            }

            // modelBuilder.ApplyConfiguration(new Mapping.DocRecordsMap());
            base.OnModelCreating(modelBuilder);
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public new EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            return base.Entry(entity);
        }


    }
}
