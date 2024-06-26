﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PitchManagerAPI.Data;

#nullable disable

namespace PitchManagerAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240316133444_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PitchManagerAPI.Data.Card", b =>
                {
                    b.Property<string>("CardCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlayerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeSet")
                        .HasColumnType("datetime2");

                    b.HasKey("CardCode");

                    b.HasIndex("MatchCode");

                    b.HasIndex("PlayerCode");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.FootballField", b =>
                {
                    b.Property<string>("FootballFieldCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FootballFieldDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FootballFieldLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FootballFieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FootballFieldType")
                        .HasColumnType("int");

                    b.HasKey("FootballFieldCode");

                    b.ToTable("FootballFields");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Goal", b =>
                {
                    b.Property<string>("GoalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GoalType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlayerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TimeSet")
                        .HasColumnType("datetime2");

                    b.HasKey("GoalCode");

                    b.HasIndex("MatchCode");

                    b.HasIndex("PlayerCode");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Match", b =>
                {
                    b.Property<string>("MatchCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FooballFieldCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftTeamCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RefereeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightTeamCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("TournamentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchCode");

                    b.HasIndex("LeftTeamCode");

                    b.HasIndex("RightTeamCode");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Player", b =>
                {
                    b.Property<string>("PlayerCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Weigth")
                        .HasColumnType("real");

                    b.HasKey("PlayerCode");

                    b.HasIndex("TeamCode");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Referee", b =>
                {
                    b.Property<string>("RefereeCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RefereeCode");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Team", b =>
                {
                    b.Property<string>("TeamCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxMembers")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamCode");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Card", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PitchManagerAPI.Data.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.FootballField", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Match", "Match")
                        .WithOne("FootballField")
                        .HasForeignKey("PitchManagerAPI.Data.FootballField", "FootballFieldCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Goal", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PitchManagerAPI.Data.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Match", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Team", "LeftTeam")
                        .WithMany()
                        .HasForeignKey("LeftTeamCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PitchManagerAPI.Data.Team", "RightTeam")
                        .WithMany()
                        .HasForeignKey("RightTeamCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LeftTeam");

                    b.Navigation("RightTeam");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Player", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Referee", b =>
                {
                    b.HasOne("PitchManagerAPI.Data.Match", "Match")
                        .WithOne("Referee")
                        .HasForeignKey("PitchManagerAPI.Data.Referee", "RefereeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Match", b =>
                {
                    b.Navigation("FootballField")
                        .IsRequired();

                    b.Navigation("Referee")
                        .IsRequired();
                });

            modelBuilder.Entity("PitchManagerAPI.Data.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
