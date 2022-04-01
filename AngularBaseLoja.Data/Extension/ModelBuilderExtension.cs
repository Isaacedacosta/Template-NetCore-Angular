using AngularBaseLoja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularBaseLoja.Data.Extension
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {

            //builder.Entity<User>().HasData(new User { Id = Guid.Parse("26add7b2-df82-45fe-841a-ffabd925bdf5"), Name = "User Test", Email = "user.test@email.com", DateCreated = new DateTime(2021, 04, 01), IsDeleted = false, DateUpdated = null }
            //);

            return builder;
        }
    }
}
