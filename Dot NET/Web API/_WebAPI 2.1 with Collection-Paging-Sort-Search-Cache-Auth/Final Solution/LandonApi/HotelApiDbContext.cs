using LandonApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LandonApi {
    public class HotelApiDbContext : IdentityDbContext<UserEntity, UserRoleEntity, Guid> {
        public HotelApiDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<RoomEntity> Rooms { get; set; }

        public DbSet<BookingEntity> Bookings { get; set; }
    }
}