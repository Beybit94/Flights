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
        private string adminUserId = "b4e863c7-4b83-485d-9547-3ff6244e0653";
        private string adminRoleId = "848a7716-143d-49e7-913a-1a7ee1d90d94";

        private const string managerUserId = "7c8ce7a1-566e-48df-bada-96943846cf38";
        private const string managerRoleId = "c8c37a8b-e246-4013-9085-795fb0e17919";

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
