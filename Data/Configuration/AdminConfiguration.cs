using Data.Entity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<User>
    {
        private const string adminId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        private const string managerId = "78A7570F-3CE5-48BA-9461-80283ED1D94D";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admin = new User
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "Admin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
            };
            admin.PasswordHash = PassGenerate(admin);

            var manager = new User
            {
                Id = managerId,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "Admin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
            };
            manager.PasswordHash = PassGenerate(admin);

            builder.HasData(admin,manager);
        }

        public string PassGenerate(User user)
        {
            var passHash = new PasswordHasher<User>();
            return passHash.HashPassword(user, "password");
        }
    }
}
