using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                   new User { Id = Guid.Parse("4D57EF40-3BEB-4D24-97AF-7E57EB71CA77"), Name = "User Default", Email = "UserDefault@templat.com" }
                );

            return builder;
        }
    }
}
