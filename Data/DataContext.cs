using Microsoft.EntityFrameworkCore;
using PitchManagerAPI.Models;

namespace PitchManagerAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Match
            modelBuilder.Entity<Match>()
                .HasKey(m => m.MatchCode);
            modelBuilder.Entity<Match>()
                .HasOne(m => m.LeftTeam)
                .WithMany()
                .HasForeignKey(m => m.LeftTeamCode)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Match>()
                .HasOne(m => m.RightTeam)
                .WithMany()
                .HasForeignKey(m => m.RightTeamCode)
                .OnDelete(DeleteBehavior.Restrict);
            //luu y co kha nang loi doan nay
            modelBuilder.Entity<Match>()
                .HasOne<FootballField>(m => m.FootballField)
                .WithOne(f => f.Match)
                .HasForeignKey<FootballField>(f=>f.FootballFieldCode);
            modelBuilder.Entity<Match>()
                .HasOne<Referee>(m => m.Referee)
                .WithOne(r => r.Match)
                .HasForeignKey<Referee>(r => r.RefereeCode);
            //Team
            modelBuilder.Entity<Team>()
                .HasKey(t => t.TeamCode);
       
            //Card
            modelBuilder.Entity<Card>()
                .HasKey(c => c.CardCode);
            modelBuilder.Entity<Card>()
                .HasOne(m => m.Match)
                .WithMany()
                .HasForeignKey(c=> c.MatchCode);
            modelBuilder.Entity<Card>()
                .HasOne(p => p.Player)
                .WithMany()
                .HasForeignKey(c => c.PlayerCode);
            //Goal
            modelBuilder.Entity<Goal>()
                .HasKey(g => g.GoalCode);
            modelBuilder.Entity<Goal>()
                .HasOne(m => m.Match)
                .WithMany()
                .HasForeignKey(g=> g.MatchCode);
            modelBuilder.Entity<Goal>()
                .HasOne(p => p.Player)
                .WithMany()
                .HasForeignKey(g => g.PlayerCode);
            //Referee
            modelBuilder.Entity<Referee>()
                .HasKey(r => r.RefereeCode);
            //FootballField
            modelBuilder.Entity<FootballField>()
                .HasKey(f => f.FootballFieldCode);
            //Player
            modelBuilder.Entity<Player>()
                .HasKey(p=>p.PlayerCode);
            modelBuilder.Entity<Player>()
                .HasOne<Team>(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamCode);
    




        }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Referee> Referees { get; set;}
        public DbSet<FootballField> FootballFields { get; set;}
        public DbSet<Player> Players { get; set; }

        
    }
}
