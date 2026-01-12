using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryManagement.Domain;

namespace FoodDeliveryManagement.Data
{
    public class FoodDeliveryManagementContext : DbContext
    {
        public FoodDeliveryManagementContext (DbContextOptions<FoodDeliveryManagementContext> options)
            : base(options)
        {
        }

        public DbSet<FoodDeliveryManagement.Domain.Vendor> Vendor { get; set; } = default!;
    }
}
