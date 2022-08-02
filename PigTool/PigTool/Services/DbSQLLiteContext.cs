using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PigTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SQLLiteDbContext
{
    public class DbSQLLiteContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<UserInfo> userInfos { get; set; }

        public DbSQLLiteContext()
        {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Pigs.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasKey(x => x.RowKey);
#if DEBUG
            modelBuilder.Entity<Translation>(x =>
                {
                    x.HasData(
                        new Translation() { RowKey = "LoginButton", English = "Login", Lang1 = "SignUP", Lang2 = "OverHere" },
                        new Translation() { RowKey = "Name", English = "Name", Lang1 = "NameLang1", Lang2 = "NameLang2" },
                        new Translation() { RowKey = "Village", English = "Village", Lang1 = "VillageLang1", Lang2 = "VillageLang2" },
                        new Translation() { RowKey = "DateLastUploaded", English = "Data last uploaded", Lang1 = "Data last uploaded lang1", Lang2 = "Data last uploaded lang2" },
                        new Translation() { RowKey = "AddData", English = "Add Data", Lang1 = "Add Data lang1", Lang2 = "Add Data lang2" },
                        new Translation() { RowKey = "EditData", English = "View / Edit / Delete data", Lang1 = "View / Edit / Delete data lang1", Lang2 = "View / Edit / Delete data lang2" }
                    );
                }
            );
# endif

            //Convert Enum To String
            modelBuilder.Entity<UserInfo>().Property(x => x.UserLang)
                .HasConversion( new EnumToStringConverter<UserLangSettings>());


            modelBuilder.Entity<UserInfo>(x =>
            {
                x.HasData(
                    new UserInfo() { Id = "1", LastUploadDate = DateTime.Now, UserName = "Marty", Village = "Dunedin", UserLang = UserLangSettings.Eng}
                );
            }
           );


        }

    }
}
