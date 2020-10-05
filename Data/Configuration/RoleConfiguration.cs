using Data.Entity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        private const string adminId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string managerId = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
              new Role
              {
                  Id = adminId,
                  Name = "admin",
                  NormalizedName = "admin".ToUpper()
              },
              new Role
              {
                  Id = managerId,
                  Name = "manager",
                  NormalizedName = "manager".ToUpper()
              }
          );
        }
    }
}
