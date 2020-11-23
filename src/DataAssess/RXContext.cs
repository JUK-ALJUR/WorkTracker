using Domain.DataModelConfigurations;
using Domain.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class RXContext : DbContext
    {
        public RXContext(DbContextOptions<RXContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }
        public DbSet<RX_Job> RXJobs;
        public DbSet<RX_RoomType> RXRoomTypes;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RX_RoomType>(Rx_RoomTypeConfiguration.RoomTypeConfiguration);
            modelBuilder.Entity<RX_Job>(RX_JobConfiguration.JobConfiguration);
        }
    }
}
