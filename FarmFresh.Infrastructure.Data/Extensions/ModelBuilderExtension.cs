﻿using FarmFresh.Core.Enums;
using FarmFresh.Domain.Entities.Products;
using FarmFresh.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFresh.Infrastructure.Data.Extensions
{
    internal static class ModelBuilderExtension
    {
        internal static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Role_Data
            modelBuilder.Entity<Role>().HasData(
                new[]
                {
                    new Role
                    {
                        Id = 1,
                        CreatedOn = new DateTime(2022, 11, 13, 8, 38, 30, 656, DateTimeKind.Local).AddTicks(3059),
                        Name = RoleType.Admin.ToString(),
                        RoleType = RoleType.Admin
                    },
                    new Role
                    {
                        Id = 2,
                        CreatedOn = new DateTime(2022, 11, 13, 8, 38, 30, 656, DateTimeKind.Local).AddTicks(3059),
                        Name = RoleType.Customer.ToString(),
                        RoleType = RoleType.Customer
                    }
                });
            #endregion Role_Data

            #region Brand_Data
            modelBuilder.Entity<ProductBrand>().HasData(
                new[]
                {
                    new ProductBrand
                    {
                        Id = 1,
                        CreatedOn = new DateTime(2022, 11, 13, 8, 38, 30, 656, DateTimeKind.Local).AddTicks(3059),
                        Name = "Apple",
                        Description = "Apple Brand"
                    },
                    new ProductBrand
                    {
                        Id = 2,
                        CreatedOn = new DateTime(2022, 11, 13, 8, 38, 30, 656, DateTimeKind.Local).AddTicks(3059),
                        Name = "Samsung",
                        Description = "Samsung Brand"
                    },
                    new ProductBrand
                    {
                        Id = 3,
                        CreatedOn = new DateTime(2022, 11, 13, 8, 38, 30, 656, DateTimeKind.Local).AddTicks(3059),
                        Name = "Huawei",
                        Description = "Huawei Brand"
                    }
                });
            #endregion Brand_Data
        }
    }
}
