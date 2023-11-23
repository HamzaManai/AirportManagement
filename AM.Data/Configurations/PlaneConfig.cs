using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Data.Configurations
{
    internal class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes").Property(p => p.Capacity).HasColumnName("PlaneCapacity");
            builder.HasKey(p => p.PlaneId);
        }
    }
}
