using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebApplication6.Models;

namespace WebApplication6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160912162635_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication6.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerName");

                    b.Property<int>("SeasonId");

                    b.HasKey("PlayerId");
                });

            modelBuilder.Entity("WebApplication6.Models.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SeasonName");

                    b.Property<int>("TimePeriod");

                    b.HasKey("SeasonId");
                });

            modelBuilder.Entity("WebApplication6.Models.Player", b =>
                {
                    b.HasOne("WebApplication6.Models.Season")
                        .WithMany()
                        .HasForeignKey("SeasonId");
                });
        }
    }
}
