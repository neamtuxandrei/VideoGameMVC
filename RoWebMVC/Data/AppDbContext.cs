using Microsoft.EntityFrameworkCore;
using RoWebMVC.Models;

namespace RoWebMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>()
           .HasOne(e => e.VideoGame)
           .WithMany(e => e.Reviews)
           .HasForeignKey(e => e.VideoGameId)
           .IsRequired();

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "League of Legends", Category = "MOBA", YearReleased = 2009, Company = "Riot Games" },
                new VideoGame { Id = 2, Title = "Minecraft", Category = "Survival", YearReleased = 2011, Company = "Mojang" },
                new VideoGame { Id = 3, Title = "Grand Theft Auto V", Category = "Action-adventure", YearReleased = 2013, Company = "Rockstar" },
                new VideoGame { Id = 4, Title = "Grand Theft Auto IV", Category = "Action-adventure", YearReleased = 2008, Company = "Rockstar" },
                new VideoGame { Id = 5, Title = "World Of Warcraft", Category = "MMORPG", YearReleased = 2004, Company = "Blizzard" },
                new VideoGame { Id = 6, Title = "OverWatch", Category = "Shooter", YearReleased = 2016, Company = "Blizzard" },
                new VideoGame { Id = 7, Title = "Diablo III", Category = "RPG", YearReleased = 2012, Company = "Blizzard" },
                new VideoGame { Id = 8, Title = "Diablo IV", Category = "RPG", YearReleased = 2022, Company = "Blizzard" },
                new VideoGame { Id = 9, Title = "Heroes of the Storm", Category = "MOBA", YearReleased = 2015, Company = "Blizzard" },
                new VideoGame { Id = 10, Title = "Hearthstone", Category = "Card-game", YearReleased = 2014, Company = "Blizzard" },
                new VideoGame { Id = 11, Title = "Warcraft III", Category = "Strategy", YearReleased = 2002, Company = "Blizzard" },
                new VideoGame { Id = 12, Title = "FIFA 2023", Category = "Football", YearReleased = 2023, Company = "EA Sports" },
                new VideoGame { Id = 13, Title = "7 days to die", Category = "Survival", YearReleased = 2013, Company = "The Fun Pimps" },
                new VideoGame { Id = 14, Title = "Dota 2", Category = "MOBA", YearReleased = 2013, Company = "Valve" },
                new VideoGame { Id = 15, Title = "Counter-Strike: Global Offensive", Category = "Shooter", YearReleased = 2012, Company = "Valve" },
                new VideoGame { Id = 16, Title = "NorthGard", Category = "Strategy", YearReleased = 2018, Company = "Valve" },
                new VideoGame { Id = 17, Title = "Phasmophobia", Category = "Horror", YearReleased = 2020, Company = "Kinetic Games" },
                new VideoGame { Id = 18, Title = "Valheim", Category = "Survival", YearReleased = 2023, Company = "Iron Gate Studio" },
                new VideoGame { Id = 19, Title = "Path of Exile", Category = "RPG", YearReleased = 2013, Company = "Grinding Gear Games" },
                new VideoGame { Id = 20, Title = "Dead by Daylight", Category = "Survival horror", YearReleased = 2016, Company = "Behaviour Interactive" },
                new VideoGame { Id = 21, Title = "Apex Legends", Category = "Survival shooter", YearReleased = 2019, Company = "Electronic Arts" },
                new VideoGame { Id = 22, Title = "PlayerUnknown's Battlegrounds", Category = "Survival shooter", YearReleased = 2017, Company = "PUBG Studios" },
                new VideoGame { Id = 23, Title = "The Witcher 3: Wild Hunt", Category = "Action RPG", YearReleased = 2015, Company = "CD Projekt Red" },
                new VideoGame { Id = 24, Title = "Red Dead Redemption 2", Category = "Action-adventure", YearReleased = 2018, Company = "Rockstar Games" },
                new VideoGame { Id = 25, Title = "The Legend of Zelda: Breath of the Wild", Category = "Action-adventure", YearReleased = 2017, Company = "Nintendo" },
                new VideoGame { Id = 26, Title = "Super Mario Odyssey", Category = "Platformer", YearReleased = 2017, Company = "Nintendo" },
                new VideoGame { Id = 27, Title = "Final Fantasy VII Remake", Category = "RPG", YearReleased = 2020, Company = "Square Enix" },
                new VideoGame { Id = 28, Title = "God of War", Category = "Action-adventure", YearReleased = 2018, Company = "Santa Monica Studio" },
                new VideoGame { Id = 29, Title = "Fallout 4", Category = "Action RPG", YearReleased = 2015, Company = "Bethesda Game Studios" },
                new VideoGame { Id = 30, Title = "Assassin's Creed Valhalla", Category = "Action-adventure", YearReleased = 2020, Company = "Ubisoft" },
                new VideoGame { Id = 31, Title = "Cyberpunk 2077", Category = "Action RPG", YearReleased = 2020, Company = "CD Projekt Red" },
                new VideoGame { Id = 32, Title = "Mortal Kombat 11", Category = "Fighting", YearReleased = 2019, Company = "NetherRealm Studios" },
                new VideoGame { Id = 33, Title = "The Elder Scrolls V: Skyrim", Category = "Action RPG", YearReleased = 2011, Company = "Bethesda Game Studios" },
                new VideoGame { Id = 34, Title = "Uncharted 4: A Thief's End", Category = "Action-adventure", YearReleased = 2016, Company = "Naughty Dog" },
                new VideoGame { Id = 35, Title = "Resident Evil Village", Category = "Survival horror", YearReleased = 2021, Company = "Capcom" },
                new VideoGame { Id = 36, Title = "Bioshock Infinite", Category = "First-person shooter", YearReleased = 2013, Company = "Irrational Games" },
                new VideoGame { Id = 37, Title = "Destiny 2", Category = "First-person shooter", YearReleased = 2017, Company = "Bungie" },
                new VideoGame { Id = 38, Title = "Borderlands 3", Category = "First-person shooter", YearReleased = 2019, Company = "Gearbox Software" },
                new VideoGame { Id = 39, Title = "Tom Clancy's Rainbow Six Siege", Category = "Tactical shooter", YearReleased = 2015, Company = "Ubisoft" },
                new VideoGame { Id = 40, Title = "Hades", Category = "Action roguelike", YearReleased = 2020, Company = "Supergiant Games" },
                new VideoGame { Id = 41, Title = "The Last of Us Part II", Category = "Action-adventure", YearReleased = 2020, Company = "Naughty Dog" },
                new VideoGame { Id = 42, Title = "Genshin Impact", Category = "Action RPG", YearReleased = 2020, Company = "miHoYo" },
                new VideoGame { Id = 43, Title = "Monster Hunter: World", Category = "Action RPG", YearReleased = 2018, Company = "Capcom" },
                new VideoGame { Id = 44, Title = "Call of Duty: Modern Warfare", Category = "First-person shooter", YearReleased = 2019, Company = "Infinity Ward" },
                new VideoGame { Id = 45, Title = "FIFA 22", Category = "Football", YearReleased = 2021, Company = "EA Sports" },
                new VideoGame { Id = 46, Title = "NBA 2K21", Category = "Sports", YearReleased = 2020, Company = "Visual Concepts" },
                new VideoGame { Id = 47, Title = "Tony Hawk's Pro Skater 1 + 2", Category = "Sports", YearReleased = 2020, Company = "Vicarious Visions" },
                new VideoGame { Id = 48, Title = "Crash Bandicoot 4: It's About Time", Category = "Platformer", YearReleased = 2020, Company = "Toys for Bob" },
                new VideoGame { Id = 49, Title = "Star Wars Jedi: Fallen Order", Category = "Action-adventure", YearReleased = 2019, Company = "Respawn Entertainment" },
                new VideoGame { Id = 50, Title = "Madden NFL 22", Category = "Sports", YearReleased = 2021, Company = "EA Sports" },
                new VideoGame { Id = 51, Title = "Hitman 3", Category = "Stealth", YearReleased = 2021, Company = "IO Interactive" },
                new VideoGame { Id = 52, Title = "Final Fantasy XIV", Category = "MMORPG", YearReleased = 2010, Company = "Square Enix" },
                new VideoGame { Id = 53, Title = "Team Fortress 2", Category = "Multiplayer shooter", YearReleased = 2007, Company = "Valve" },
                new VideoGame { Id = 54, Title = "Half-Life: Alyx", Category = "Virtual reality", YearReleased = 2020, Company = "Valve" },
                new VideoGame { Id = 55, Title = "Civilization VI", Category = "Strategy", YearReleased = 2016, Company = "Firaxis Games" },
                new VideoGame { Id = 56, Title = "Stardew Valley", Category = "Simulation", YearReleased = 2016, Company = "ConcernedApe" },
                new VideoGame { Id = 57, Title = "Fortnite", Category = "Battle royale", YearReleased = 2017, Company = "Epic Games" },
                new VideoGame { Id = 58, Title = "The Sims 4", Category = "Life simulation", YearReleased = 2014, Company = "Maxis" },
                new VideoGame { Id = 59, Title = "Subnautica", Category = "Survival", YearReleased = 2018, Company = "Unknown Worlds Entertainment" },
                new VideoGame { Id = 60, Title = "DOOM Eternal", Category = "First-person shooter", YearReleased = 2020, Company = "id Software" },
                new VideoGame { Id = 61, Title = "Kingdom Hearts III", Category = "Action RPG", YearReleased = 2019, Company = "Square Enix" },
                new VideoGame { Id = 62, Title = "Forza Horizon 4", Category = "Racing", YearReleased = 2018, Company = "Playground Games" },
                new VideoGame { Id = 63, Title = "Horizon Zero Dawn", Category = "Action RPG", YearReleased = 2020, Company = "Guerrilla Games" },
                new VideoGame { Id = 64, Title = "Outriders", Category = "Third-person shooter", YearReleased = 2021, Company = "People Can Fly" },
                new VideoGame { Id = 65, Title = "Sea of Thieves", Category = "Action-adventure", YearReleased = 2018, Company = "Rare" },
                new VideoGame { Id = 66, Title = "Resident Evil 7: Biohazard", Category = "Survival horror", YearReleased = 2017, Company = "Capcom" },
                new VideoGame { Id = 67, Title = "Control", Category = "Action-adventure", YearReleased = 2019, Company = "Remedy Entertainment" },
                new VideoGame { Id = 68, Title = "Tom Clancy's The Division 2", Category = "Action RPG", YearReleased = 2019, Company = "Massive Entertainment" },
                new VideoGame { Id = 69, Title = "Death Stranding", Category = "Action-adventure", YearReleased = 2019, Company = "Kojima Productions" },
                new VideoGame { Id = 70, Title = "Darksiders III", Category = "Action-adventure", YearReleased = 2018, Company = "Gunfire Games" },
                new VideoGame { Id = 71, Title = "Watch Dogs: Legion", Category = "Action-adventure", YearReleased = 2020, Company = "Ubisoft" },
                new VideoGame { Id = 72, Title = "Little Nightmares II", Category = "Platformer", YearReleased = 2021, Company = "Tarsier Studios" },
                new VideoGame { Id = 73, Title = "Far Cry 5", Category = "Action-adventure", YearReleased = 2018, Company = "Ubisoft" },
                new VideoGame { Id = 74, Title = "Ghost of Tsushima", Category = "Action-adventure", YearReleased = 2020, Company = "Sucker Punch Productions" },
                new VideoGame { Id = 75, Title = "The Outer Worlds", Category = "Action RPG", YearReleased = 2019, Company = "Obsidian Entertainment" },
                new VideoGame { Id = 76, Title = "Metro Exodus", Category = "First-person shooter", YearReleased = 2019, Company = "4A Games" },
                new VideoGame { Id = 77, Title = "Far Cry 6", Category = "Action-adventure", YearReleased = 2021, Company = "Ubisoft" },
                new VideoGame { Id = 78, Title = "Ratchet & Clank: Rift Apart", Category = "Platformer", YearReleased = 2021, Company = "Insomniac Games" },
                new VideoGame { Id = 79, Title = "Sekiro: Shadows Die Twice", Category = "Action-adventure", YearReleased = 2019, Company = "FromSoftware" },
                new VideoGame { Id = 80, Title = "Marvel's Spider-Man: Miles Morales", Category = "Action-adventure", YearReleased = 2020, Company = "Insomniac Games" },
                new VideoGame { Id = 81, Title = "Ori and the Will of the Wisps", Category = "Platformer", YearReleased = 2020, Company = "Moon Studios" },
                new VideoGame { Id = 82, Title = "Marvel's Avengers", Category = "Action-adventure", YearReleased = 2020, Company = "Crystal Dynamics" },
                new VideoGame { Id = 83, Title = "Yakuza: Like a Dragon", Category = "Action-adventure", YearReleased = 2020, Company = "Ryu Ga Gotoku Studio" },
                new VideoGame { Id = 84, Title = "Hitman 2", Category = "Stealth", YearReleased = 2018, Company = "IO Interactive" },
                new VideoGame { Id = 85, Title = "No Man's Sky", Category = "Exploration", YearReleased = 2016, Company = "Hello Games" },
                new VideoGame { Id = 86, Title = "Star Wars Battlefront II", Category = "First-person shooter", YearReleased = 2017, Company = "EA DICE" },
                new VideoGame { Id = 87, Title = "F1 2021", Category = "Racing", YearReleased = 2021, Company = "Codemasters" },
                new VideoGame { Id = 88, Title = "Nioh 2", Category = "Action RPG", YearReleased = 2020, Company = "Team Ninja" },
                new VideoGame { Id = 89, Title = "Hollow Knight", Category = "Metroidvania", YearReleased = 2017, Company = "Team Cherry" },
                new VideoGame { Id = 90, Title = "Cuphead", Category = "Run and gun", YearReleased = 2017, Company = "Studio MDHR" },
                new VideoGame { Id = 91, Title = "Detroit: Become Human", Category = "Interactive drama", YearReleased = 2018, Company = "Quantic Dream" },
                new VideoGame { Id = 92, Title = "Devil May Cry 5", Category = "Action-adventure", YearReleased = 2019, Company = "Capcom" },
                new VideoGame { Id = 93, Title = "SoulCalibur VI", Category = "Fighting", YearReleased = 2018, Company = "Bandai Namco Entertainment" },
                new VideoGame { Id = 94, Title = "Mafia: Definitive Edition", Category = "Action-adventure", YearReleased = 2020, Company = "Hangar 13" },
                new VideoGame { Id = 95, Title = "Warframe", Category = "MMO", YearReleased = 2013, Company = "Digital Extremes" },
                new VideoGame { Id = 96, Title = "Crysis Remastered", Category = "First-person shooter", YearReleased = 2020, Company = "Crytek" },
                new VideoGame { Id = 97, Title = "Dragon Ball FighterZ", Category = "Fighting", YearReleased = 2018, Company = "Arc System Works" },
                new VideoGame { Id = 98, Title = "Wasteland 3", Category = "RPG", YearReleased = 2020, Company = "inXile Entertainment" },
                new VideoGame { Id = 99, Title = "Tomb Raider", Category = "Action-adventure", YearReleased = 2013, Company = "Crystal Dynamics" },
                new VideoGame { Id = 100, Title = "The Medium", Category = "Psychological horror", YearReleased = 2021, Company = "Bloober Team" }
                );
            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, UserName = "Daniel03", Description = "Mi-a placut foarte mult jocul.", VideoGameId = 1 },
                new Review { Id = 2, UserName = "AndreiNeamtu26", Description = "M-am jucat toata saptamana.", VideoGameId = 2 },
                new Review { Id = 3, UserName = "Georgiana_32", Description = "Un joc mediocru.", VideoGameId = 2 }
                );
        }
    }
}
