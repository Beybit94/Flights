using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class UsersWithRolesConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private const string adminUserId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        private const string adminRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string managerUserId = "78A7570F-3CE5-48BA-9461-80283ED1D94D";
        private const string managerRoleId = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = managerRoleId,
                    UserId = managerUserId
                }
            );
        }
    }
}
