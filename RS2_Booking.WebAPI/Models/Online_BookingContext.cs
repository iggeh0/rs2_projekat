using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RS2_Booking.WebAPI.Models
{
    public partial class Online_BookingContext : DbContext
    {
        public Online_BookingContext()
        {
        }

        public Online_BookingContext(DbContextOptions<Online_BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Inventar> Inventar { get; set; }
        public virtual DbSet<InventarSoba> InventarSoba { get; set; }
        public virtual DbSet<Izdavac> Izdavac { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KreditnaKartica> KreditnaKartica { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Okolina> Okolina { get; set; }
        public virtual DbSet<OkolinaSmjestaj> OkolinaSmjestaj { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<RezervacijaSoba> RezervacijaSoba { get; set; }
        public virtual DbSet<Slika> Slika { get; set; }
        public virtual DbSet<Smjestaj> Smjestaj { get; set; }
        public virtual DbSet<Soba> Soba { get; set; }
        public virtual DbSet<StatusRezervacije> StatusRezervacije { get; set; }
        public virtual DbSet<Uplata> Uplata { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }
        public virtual DbSet<UslugaSmjestaj> UslugaSmjestaj { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Online_Booking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Inventar>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<InventarSoba>(entity =>
            {
                entity.ToTable("Inventar_Soba");

                entity.Property(e => e.InventarSobaId).HasColumnName("Inventar_SobaId");

                entity.HasOne(d => d.Inventar)
                    .WithMany(p => p.InventarSoba)
                    .HasForeignKey(d => d.InventarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventar___Inven__4D94879B");

                entity.HasOne(d => d.Soba)
                    .WithMany(p => p.InventarSoba)
                    .HasForeignKey(d => d.SobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventar___SobaI__4CA06362");
            });

            modelBuilder.Entity<Izdavac>(entity =>
            {
                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Izdavac)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Izdavac__Korisni__3C69FB99");
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Klijent__Korisni__398D8EEE");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.BrojTelefona).IsRequired();

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG")
                    .HasMaxLength(13);

                entity.Property(e => e.KorisnickoIme).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();
            });

            modelBuilder.Entity<KreditnaKartica>(entity =>
            {
                entity.Property(e => e.BrojKartice).IsRequired();

                entity.Property(e => e.TipKartice).IsRequired();
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocjena__KlijentI__6FE99F9F");

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.SmjestajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocjena__Smjestaj__70DDC3D8");
            });

            modelBuilder.Entity<Okolina>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<OkolinaSmjestaj>(entity =>
            {
                entity.ToTable("Okolina_Smjestaj");

                entity.Property(e => e.OkolinaSmjestajId).HasColumnName("Okolina_SmjestajId");

                entity.HasOne(d => d.Okolina)
                    .WithMany(p => p.OkolinaSmjestaj)
                    .HasForeignKey(d => d.OkolinaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Okolina_S__Okoli__5812160E");

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.OkolinaSmjestaj)
                    .HasForeignKey(d => d.SmjestajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Okolina_S__Smjes__59063A47");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.RezervacijaDo).HasColumnType("datetime");

                entity.Property(e => e.RezervacijaOd).HasColumnType("datetime");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezervaci__Klije__5BE2A6F2");

                entity.HasOne(d => d.StatusRezervacije)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.StatusRezervacijeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezervaci__Statu__5FB337D6");
            });

            modelBuilder.Entity<RezervacijaSoba>(entity =>
            {
                entity.ToTable("Rezervacija_Soba");

                entity.Property(e => e.RezervacijaSobaId).HasColumnName("Rezervacija_SobaId");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.RezervacijaSoba)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezervaci__Rezer__66603565");

                entity.HasOne(d => d.Soba)
                    .WithMany(p => p.RezervacijaSoba)
                    .HasForeignKey(d => d.SobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezervaci__SobaI__6754599E");
            });

            modelBuilder.Entity<Slika>(entity =>
            {
                entity.Property(e => e.SlikaFile)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.Slika)
                    .HasForeignKey(d => d.SmjestajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Slika__SmjestajI__4222D4EF");
            });

            modelBuilder.Entity<Smjestaj>(entity =>
            {
                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.KontaktTelefon).IsRequired();

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).IsRequired();

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Smjestaj)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Smjestaj__GradId__44FF419A");

                entity.HasOne(d => d.Izdavac)
                    .WithMany(p => p.Smjestaj)
                    .HasForeignKey(d => d.IzdavacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Smjestaj__Izdava__3F466844");
            });

            modelBuilder.Entity<Soba>(entity =>
            {
                entity.Property(e => e.Opis).IsRequired();

                entity.Property(e => e.VrstaSmjestaja).IsRequired();

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.Soba)
                    .HasForeignKey(d => d.SmjestajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Soba__SmjestajId__47DBAE45");
            });

            modelBuilder.Entity<StatusRezervacije>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Uplata>(entity =>
            {
                entity.Property(e => e.DatumUplate).HasColumnType("datetime");

                entity.Property(e => e.SifraUplate).HasMaxLength(15);

                entity.HasOne(d => d.KreditnaKartica)
                    .WithMany(p => p.Uplata)
                    .HasForeignKey(d => d.KreditnaKarticaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uplata__Kreditna__6D0D32F4");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Uplata)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uplata__Rezervac__6C190EBB");
            });

            modelBuilder.Entity<Usluga>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).IsRequired();
            });

            modelBuilder.Entity<UslugaSmjestaj>(entity =>
            {
                entity.ToTable("Usluga_Smjestaj");

                entity.Property(e => e.UslugaSmjestajId).HasColumnName("Usluga_SmjestajId");

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.UslugaSmjestaj)
                    .HasForeignKey(d => d.SmjestajId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usluga_Sm__Smjes__52593CB8");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.UslugaSmjestaj)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usluga_Sm__Uslug__534D60F1");
            });
        }
    }
}
