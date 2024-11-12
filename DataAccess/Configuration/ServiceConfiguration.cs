﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(35);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Deleted).HasDefaultValue<int>(0);
        }
    }
}
