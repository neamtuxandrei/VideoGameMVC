﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoWebMVC.Data;

#nullable disable

namespace RoWebMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230611144214_InitDBAndSeedData")]
    partial class InitDBAndSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RoWebMVC.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(7967),
                            Description = "Mi-a placut foarte mult jocul.",
                            UserName = "Daniel03",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(8002),
                            Description = "M-am jucat toata saptamana.",
                            UserName = "AndreiNeamtu26",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(8004),
                            Description = "Un joc mediocru.",
                            UserName = "Georgiana_32",
                            VideoGameId = 2
                        });
                });

            modelBuilder.Entity("RoWebMVC.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("YearReleased")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "MOBA",
                            Company = "Riot Games",
                            Title = "League of Legends",
                            YearReleased = 2009
                        },
                        new
                        {
                            Id = 2,
                            Category = "Survival",
                            Company = "Mojang",
                            Title = "Minecraft",
                            YearReleased = 2011
                        },
                        new
                        {
                            Id = 3,
                            Category = "Action-adventure",
                            Company = "Rockstar",
                            Title = "Grand Theft Auto V",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 4,
                            Category = "Action-adventure",
                            Company = "Rockstar",
                            Title = "Grand Theft Auto IV",
                            YearReleased = 2008
                        },
                        new
                        {
                            Id = 5,
                            Category = "MMORPG",
                            Company = "Blizzard",
                            Title = "World Of Warcraft",
                            YearReleased = 2004
                        },
                        new
                        {
                            Id = 6,
                            Category = "Shooter",
                            Company = "Blizzard",
                            Title = "OverWatch",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 7,
                            Category = "RPG",
                            Company = "Blizzard",
                            Title = "Diablo III",
                            YearReleased = 2012
                        },
                        new
                        {
                            Id = 8,
                            Category = "RPG",
                            Company = "Blizzard",
                            Title = "Diablo IV",
                            YearReleased = 2022
                        },
                        new
                        {
                            Id = 9,
                            Category = "MOBA",
                            Company = "Blizzard",
                            Title = "Heroes of the Storm",
                            YearReleased = 2015
                        },
                        new
                        {
                            Id = 10,
                            Category = "Card-game",
                            Company = "Blizzard",
                            Title = "Hearthstone",
                            YearReleased = 2014
                        },
                        new
                        {
                            Id = 11,
                            Category = "Strategy",
                            Company = "Blizzard",
                            Title = "Warcraft III",
                            YearReleased = 2002
                        },
                        new
                        {
                            Id = 12,
                            Category = "Football",
                            Company = "EA Sports",
                            Title = "FIFA 2023",
                            YearReleased = 2023
                        },
                        new
                        {
                            Id = 13,
                            Category = "Survival",
                            Company = "The Fun Pimps",
                            Title = "7 days to die",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 14,
                            Category = "MOBA",
                            Company = "Valve",
                            Title = "Dota 2",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 15,
                            Category = "Shooter",
                            Company = "Valve",
                            Title = "Counter-Strike: Global Offensive",
                            YearReleased = 2012
                        },
                        new
                        {
                            Id = 16,
                            Category = "Strategy",
                            Company = "Valve",
                            Title = "NorthGard",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 17,
                            Category = "Horror",
                            Company = "Kinetic Games",
                            Title = "Phasmophobia",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 18,
                            Category = "Survival",
                            Company = "Iron Gate Studio",
                            Title = "Valheim",
                            YearReleased = 2023
                        },
                        new
                        {
                            Id = 19,
                            Category = "RPG",
                            Company = "Grinding Gear Games",
                            Title = "Path of Exile",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 20,
                            Category = "Survival horror",
                            Company = "Behaviour Interactive",
                            Title = "Dead by Daylight",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 21,
                            Category = "Survival shooter",
                            Company = "Electronic Arts",
                            Title = "Apex Legends",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 22,
                            Category = "Survival shooter",
                            Company = "PUBG Studios",
                            Title = "PlayerUnknown's Battlegrounds",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 23,
                            Category = "Action RPG",
                            Company = "CD Projekt Red",
                            Title = "The Witcher 3: Wild Hunt",
                            YearReleased = 2015
                        },
                        new
                        {
                            Id = 24,
                            Category = "Action-adventure",
                            Company = "Rockstar Games",
                            Title = "Red Dead Redemption 2",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 25,
                            Category = "Action-adventure",
                            Company = "Nintendo",
                            Title = "The Legend of Zelda: Breath of the Wild",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 26,
                            Category = "Platformer",
                            Company = "Nintendo",
                            Title = "Super Mario Odyssey",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 27,
                            Category = "RPG",
                            Company = "Square Enix",
                            Title = "Final Fantasy VII Remake",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 28,
                            Category = "Action-adventure",
                            Company = "Santa Monica Studio",
                            Title = "God of War",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 29,
                            Category = "Action RPG",
                            Company = "Bethesda Game Studios",
                            Title = "Fallout 4",
                            YearReleased = 2015
                        },
                        new
                        {
                            Id = 30,
                            Category = "Action-adventure",
                            Company = "Ubisoft",
                            Title = "Assassin's Creed Valhalla",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 31,
                            Category = "Action RPG",
                            Company = "CD Projekt Red",
                            Title = "Cyberpunk 2077",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 32,
                            Category = "Fighting",
                            Company = "NetherRealm Studios",
                            Title = "Mortal Kombat 11",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 33,
                            Category = "Action RPG",
                            Company = "Bethesda Game Studios",
                            Title = "The Elder Scrolls V: Skyrim",
                            YearReleased = 2011
                        },
                        new
                        {
                            Id = 34,
                            Category = "Action-adventure",
                            Company = "Naughty Dog",
                            Title = "Uncharted 4: A Thief's End",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 35,
                            Category = "Survival horror",
                            Company = "Capcom",
                            Title = "Resident Evil Village",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 36,
                            Category = "First-person shooter",
                            Company = "Irrational Games",
                            Title = "Bioshock Infinite",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 37,
                            Category = "First-person shooter",
                            Company = "Bungie",
                            Title = "Destiny 2",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 38,
                            Category = "First-person shooter",
                            Company = "Gearbox Software",
                            Title = "Borderlands 3",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 39,
                            Category = "Tactical shooter",
                            Company = "Ubisoft",
                            Title = "Tom Clancy's Rainbow Six Siege",
                            YearReleased = 2015
                        },
                        new
                        {
                            Id = 40,
                            Category = "Action roguelike",
                            Company = "Supergiant Games",
                            Title = "Hades",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 41,
                            Category = "Action-adventure",
                            Company = "Naughty Dog",
                            Title = "The Last of Us Part II",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 42,
                            Category = "Action RPG",
                            Company = "miHoYo",
                            Title = "Genshin Impact",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 43,
                            Category = "Action RPG",
                            Company = "Capcom",
                            Title = "Monster Hunter: World",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 44,
                            Category = "First-person shooter",
                            Company = "Infinity Ward",
                            Title = "Call of Duty: Modern Warfare",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 45,
                            Category = "Football",
                            Company = "EA Sports",
                            Title = "FIFA 22",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 46,
                            Category = "Sports",
                            Company = "Visual Concepts",
                            Title = "NBA 2K21",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 47,
                            Category = "Sports",
                            Company = "Vicarious Visions",
                            Title = "Tony Hawk's Pro Skater 1 + 2",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 48,
                            Category = "Platformer",
                            Company = "Toys for Bob",
                            Title = "Crash Bandicoot 4: It's About Time",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 49,
                            Category = "Action-adventure",
                            Company = "Respawn Entertainment",
                            Title = "Star Wars Jedi: Fallen Order",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 50,
                            Category = "Sports",
                            Company = "EA Sports",
                            Title = "Madden NFL 22",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 51,
                            Category = "Stealth",
                            Company = "IO Interactive",
                            Title = "Hitman 3",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 52,
                            Category = "MMORPG",
                            Company = "Square Enix",
                            Title = "Final Fantasy XIV",
                            YearReleased = 2010
                        },
                        new
                        {
                            Id = 53,
                            Category = "Multiplayer shooter",
                            Company = "Valve",
                            Title = "Team Fortress 2",
                            YearReleased = 2007
                        },
                        new
                        {
                            Id = 54,
                            Category = "Virtual reality",
                            Company = "Valve",
                            Title = "Half-Life: Alyx",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 55,
                            Category = "Strategy",
                            Company = "Firaxis Games",
                            Title = "Civilization VI",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 56,
                            Category = "Simulation",
                            Company = "ConcernedApe",
                            Title = "Stardew Valley",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 57,
                            Category = "Battle royale",
                            Company = "Epic Games",
                            Title = "Fortnite",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 58,
                            Category = "Life simulation",
                            Company = "Maxis",
                            Title = "The Sims 4",
                            YearReleased = 2014
                        },
                        new
                        {
                            Id = 59,
                            Category = "Survival",
                            Company = "Unknown Worlds Entertainment",
                            Title = "Subnautica",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 60,
                            Category = "First-person shooter",
                            Company = "id Software",
                            Title = "DOOM Eternal",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 61,
                            Category = "Action RPG",
                            Company = "Square Enix",
                            Title = "Kingdom Hearts III",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 62,
                            Category = "Racing",
                            Company = "Playground Games",
                            Title = "Forza Horizon 4",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 63,
                            Category = "Action RPG",
                            Company = "Guerrilla Games",
                            Title = "Horizon Zero Dawn",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 64,
                            Category = "Third-person shooter",
                            Company = "People Can Fly",
                            Title = "Outriders",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 65,
                            Category = "Action-adventure",
                            Company = "Rare",
                            Title = "Sea of Thieves",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 66,
                            Category = "Survival horror",
                            Company = "Capcom",
                            Title = "Resident Evil 7: Biohazard",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 67,
                            Category = "Action-adventure",
                            Company = "Remedy Entertainment",
                            Title = "Control",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 68,
                            Category = "Action RPG",
                            Company = "Massive Entertainment",
                            Title = "Tom Clancy's The Division 2",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 69,
                            Category = "Action-adventure",
                            Company = "Kojima Productions",
                            Title = "Death Stranding",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 70,
                            Category = "Action-adventure",
                            Company = "Gunfire Games",
                            Title = "Darksiders III",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 71,
                            Category = "Action-adventure",
                            Company = "Ubisoft",
                            Title = "Watch Dogs: Legion",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 72,
                            Category = "Platformer",
                            Company = "Tarsier Studios",
                            Title = "Little Nightmares II",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 73,
                            Category = "Action-adventure",
                            Company = "Ubisoft",
                            Title = "Far Cry 5",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 74,
                            Category = "Action-adventure",
                            Company = "Sucker Punch Productions",
                            Title = "Ghost of Tsushima",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 75,
                            Category = "Action RPG",
                            Company = "Obsidian Entertainment",
                            Title = "The Outer Worlds",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 76,
                            Category = "First-person shooter",
                            Company = "4A Games",
                            Title = "Metro Exodus",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 77,
                            Category = "Action-adventure",
                            Company = "Ubisoft",
                            Title = "Far Cry 6",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 78,
                            Category = "Platformer",
                            Company = "Insomniac Games",
                            Title = "Ratchet & Clank: Rift Apart",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 79,
                            Category = "Action-adventure",
                            Company = "FromSoftware",
                            Title = "Sekiro: Shadows Die Twice",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 80,
                            Category = "Action-adventure",
                            Company = "Insomniac Games",
                            Title = "Marvel's Spider-Man: Miles Morales",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 81,
                            Category = "Platformer",
                            Company = "Moon Studios",
                            Title = "Ori and the Will of the Wisps",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 82,
                            Category = "Action-adventure",
                            Company = "Crystal Dynamics",
                            Title = "Marvel's Avengers",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 83,
                            Category = "Action-adventure",
                            Company = "Ryu Ga Gotoku Studio",
                            Title = "Yakuza: Like a Dragon",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 84,
                            Category = "Stealth",
                            Company = "IO Interactive",
                            Title = "Hitman 2",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 85,
                            Category = "Exploration",
                            Company = "Hello Games",
                            Title = "No Man's Sky",
                            YearReleased = 2016
                        },
                        new
                        {
                            Id = 86,
                            Category = "First-person shooter",
                            Company = "EA DICE",
                            Title = "Star Wars Battlefront II",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 87,
                            Category = "Racing",
                            Company = "Codemasters",
                            Title = "F1 2021",
                            YearReleased = 2021
                        },
                        new
                        {
                            Id = 88,
                            Category = "Action RPG",
                            Company = "Team Ninja",
                            Title = "Nioh 2",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 89,
                            Category = "Metroidvania",
                            Company = "Team Cherry",
                            Title = "Hollow Knight",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 90,
                            Category = "Run and gun",
                            Company = "Studio MDHR",
                            Title = "Cuphead",
                            YearReleased = 2017
                        },
                        new
                        {
                            Id = 91,
                            Category = "Interactive drama",
                            Company = "Quantic Dream",
                            Title = "Detroit: Become Human",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 92,
                            Category = "Action-adventure",
                            Company = "Capcom",
                            Title = "Devil May Cry 5",
                            YearReleased = 2019
                        },
                        new
                        {
                            Id = 93,
                            Category = "Fighting",
                            Company = "Bandai Namco Entertainment",
                            Title = "SoulCalibur VI",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 94,
                            Category = "Action-adventure",
                            Company = "Hangar 13",
                            Title = "Mafia: Definitive Edition",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 95,
                            Category = "MMO",
                            Company = "Digital Extremes",
                            Title = "Warframe",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 96,
                            Category = "First-person shooter",
                            Company = "Crytek",
                            Title = "Crysis Remastered",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 97,
                            Category = "Fighting",
                            Company = "Arc System Works",
                            Title = "Dragon Ball FighterZ",
                            YearReleased = 2018
                        },
                        new
                        {
                            Id = 98,
                            Category = "RPG",
                            Company = "inXile Entertainment",
                            Title = "Wasteland 3",
                            YearReleased = 2020
                        },
                        new
                        {
                            Id = 99,
                            Category = "Action-adventure",
                            Company = "Crystal Dynamics",
                            Title = "Tomb Raider",
                            YearReleased = 2013
                        },
                        new
                        {
                            Id = 100,
                            Category = "Psychological horror",
                            Company = "Bloober Team",
                            Title = "The Medium",
                            YearReleased = 2021
                        });
                });

            modelBuilder.Entity("RoWebMVC.Models.Review", b =>
                {
                    b.HasOne("RoWebMVC.Models.VideoGame", "VideoGame")
                        .WithMany("Reviews")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("RoWebMVC.Models.VideoGame", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
