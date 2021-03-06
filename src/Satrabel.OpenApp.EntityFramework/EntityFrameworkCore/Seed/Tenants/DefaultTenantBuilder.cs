﻿using System.Linq;
using Satrabel.OpenApp.Editions;
using Satrabel.OpenApp.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Satrabel.OpenApp.EntityFramework.Seed.Tenants
{
    public class DefaultTenantBuilder<TSelf>
         where TSelf : OpenAppDbContext<TSelf>
    {
        private readonly OpenAppDbContext<TSelf> _context;

        public DefaultTenantBuilder(OpenAppDbContext<TSelf> context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(Tenant.DefaultTenantName, Tenant.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
