using AM.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AM.Data.Configurations
{
    internal class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new { r.PassengerId, r.FlightId });
            builder.HasOne(r => r.MyPassenger)
                .WithMany(p => p.Reservations)
                .HasForeignKey(r => r.PassengerId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(r => r.MyFlight)
               .WithMany(f => f.Reservations)
               .HasForeignKey(r => r.FlightId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
