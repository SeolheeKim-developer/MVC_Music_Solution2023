﻿// <auto-generated />
using System;
using MVC_Music.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Music.Data.MusicMigrations
{
    [DbContext(typeof(MusicContext))]
    partial class MusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("MVC_Music.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("GenreID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("YearProduced")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MVC_Music.Models.FileContent", b =>
                {
                    b.Property<int>("FileContentID")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .HasColumnType("BLOB");

                    b.HasKey("FileContentID");

                    b.ToTable("FileContent");
                });

            modelBuilder.Entity("MVC_Music.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MVC_Music.Models.Instrument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("MVC_Music.Models.Musician", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("EMail")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("InstrumentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("SIN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("InstrumentID");

                    b.HasIndex("SIN")
                        .IsUnique();

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianPhoto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .HasColumnType("BLOB");

                    b.Property<string>("MimeType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("MusicianID")
                        .IsUnique();

                    b.ToTable("MusicianPhotos");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianThumbnail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .HasColumnType("BLOB");

                    b.Property<string>("MimeType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("MusicianID")
                        .IsUnique();

                    b.ToTable("MusicianThumbnails");
                });

            modelBuilder.Entity("MVC_Music.Models.Performance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<double>("FeePaid")
                        .HasColumnType("REAL");

                    b.Property<int>("InstrumentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SongID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("InstrumentID");

                    b.HasIndex("MusicianID");

                    b.HasIndex("SongID", "MusicianID", "InstrumentID")
                        .IsUnique();

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("MVC_Music.Models.Play", b =>
                {
                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstrumentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("MusicianID", "InstrumentID");

                    b.HasIndex("InstrumentID");

                    b.ToTable("Plays");
                });

            modelBuilder.Entity("MVC_Music.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlbumID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateRecorded")
                        .HasColumnType("TEXT");

                    b.Property<int>("GenreID")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.HasIndex("GenreID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MVC_Music.Models.UploadedFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("MimeType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("UploadedFiles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UploadedFile");
                });

            modelBuilder.Entity("MVC_Music.ViewModels.PerformanceSongSummaryVM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AverageFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<double>("HighestFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<double>("LowestFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPerformances")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfSongs")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToView("PerformanceSongSummaries");
                });

            modelBuilder.Entity("MVC_Music.ViewModels.PerformanceSummaryVM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AverageFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<double>("HighestFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<double>("LowestFeePaid")
                        .HasColumnType("REAL");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPerformances")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToView("PerformanceSummaries");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianDocument", b =>
                {
                    b.HasBaseType("MVC_Music.Models.UploadedFile");

                    b.Property<int>("MusicianID")
                        .HasColumnType("INTEGER");

                    b.HasIndex("MusicianID");

                    b.HasDiscriminator().HasValue("MusicianDocument");
                });

            modelBuilder.Entity("MVC_Music.Models.Album", b =>
                {
                    b.HasOne("MVC_Music.Models.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MVC_Music.Models.FileContent", b =>
                {
                    b.HasOne("MVC_Music.Models.UploadedFile", "UploadedFile")
                        .WithOne("FileContent")
                        .HasForeignKey("MVC_Music.Models.FileContent", "FileContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UploadedFile");
                });

            modelBuilder.Entity("MVC_Music.Models.Musician", b =>
                {
                    b.HasOne("MVC_Music.Models.Instrument", "Instrument")
                        .WithMany("Musicians")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Instrument");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianPhoto", b =>
                {
                    b.HasOne("MVC_Music.Models.Musician", "Musician")
                        .WithOne("MusicianPhoto")
                        .HasForeignKey("MVC_Music.Models.MusicianPhoto", "MusicianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianThumbnail", b =>
                {
                    b.HasOne("MVC_Music.Models.Musician", "Musician")
                        .WithOne("MusicianThumbnail")
                        .HasForeignKey("MVC_Music.Models.MusicianThumbnail", "MusicianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("MVC_Music.Models.Performance", b =>
                {
                    b.HasOne("MVC_Music.Models.Instrument", "Instrument")
                        .WithMany("Performances")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Music.Models.Musician", "Musician")
                        .WithMany("Performances")
                        .HasForeignKey("MusicianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Music.Models.Song", "Song")
                        .WithMany("Performances")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Musician");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("MVC_Music.Models.Play", b =>
                {
                    b.HasOne("MVC_Music.Models.Instrument", "Instrument")
                        .WithMany("Plays")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MVC_Music.Models.Musician", "Musician")
                        .WithMany("Plays")
                        .HasForeignKey("MusicianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("MVC_Music.Models.Song", b =>
                {
                    b.HasOne("MVC_Music.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MVC_Music.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MVC_Music.Models.MusicianDocument", b =>
                {
                    b.HasOne("MVC_Music.Models.Musician", "Musician")
                        .WithMany("MusicianDocuments")
                        .HasForeignKey("MusicianID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musician");
                });

            modelBuilder.Entity("MVC_Music.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MVC_Music.Models.Genre", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MVC_Music.Models.Instrument", b =>
                {
                    b.Navigation("Musicians");

                    b.Navigation("Performances");

                    b.Navigation("Plays");
                });

            modelBuilder.Entity("MVC_Music.Models.Musician", b =>
                {
                    b.Navigation("MusicianDocuments");

                    b.Navigation("MusicianPhoto");

                    b.Navigation("MusicianThumbnail");

                    b.Navigation("Performances");

                    b.Navigation("Plays");
                });

            modelBuilder.Entity("MVC_Music.Models.Song", b =>
                {
                    b.Navigation("Performances");
                });

            modelBuilder.Entity("MVC_Music.Models.UploadedFile", b =>
                {
                    b.Navigation("FileContent");
                });
#pragma warning restore 612, 618
        }
    }
}
