// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TourOfHeroes_Backend.DataContext;

#nullable disable

namespace TourOfHeroesBackend.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230204001256_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TourOfHeroes_Backend.Models.Hero", b =>
                {
                    b.Property<int>("HeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeroId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeroId");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            HeroId = -1,
                            Name = "hero1"
                        },
                        new
                        {
                            HeroId = -2,
                            Name = "hero2"
                        },
                        new
                        {
                            HeroId = -3,
                            Name = "hero3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
