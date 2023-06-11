using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoWebMVC.Migrations
{
    public partial class InitDBAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearReleased = table.Column<int>(type: "int", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Category", "Company", "Title", "YearReleased" },
                values: new object[,]
                {
                    { 1, "MOBA", "Riot Games", "League of Legends", 2009 },
                    { 2, "Survival", "Mojang", "Minecraft", 2011 },
                    { 3, "Action-adventure", "Rockstar", "Grand Theft Auto V", 2013 },
                    { 4, "Action-adventure", "Rockstar", "Grand Theft Auto IV", 2008 },
                    { 5, "MMORPG", "Blizzard", "World Of Warcraft", 2004 },
                    { 6, "Shooter", "Blizzard", "OverWatch", 2016 },
                    { 7, "RPG", "Blizzard", "Diablo III", 2012 },
                    { 8, "RPG", "Blizzard", "Diablo IV", 2022 },
                    { 9, "MOBA", "Blizzard", "Heroes of the Storm", 2015 },
                    { 10, "Card-game", "Blizzard", "Hearthstone", 2014 },
                    { 11, "Strategy", "Blizzard", "Warcraft III", 2002 },
                    { 12, "Football", "EA Sports", "FIFA 2023", 2023 },
                    { 13, "Survival", "The Fun Pimps", "7 days to die", 2013 },
                    { 14, "MOBA", "Valve", "Dota 2", 2013 },
                    { 15, "Shooter", "Valve", "Counter-Strike: Global Offensive", 2012 },
                    { 16, "Strategy", "Valve", "NorthGard", 2018 },
                    { 17, "Horror", "Kinetic Games", "Phasmophobia", 2020 },
                    { 18, "Survival", "Iron Gate Studio", "Valheim", 2023 },
                    { 19, "RPG", "Grinding Gear Games", "Path of Exile", 2013 },
                    { 20, "Survival horror", "Behaviour Interactive", "Dead by Daylight", 2016 },
                    { 21, "Survival shooter", "Electronic Arts", "Apex Legends", 2019 },
                    { 22, "Survival shooter", "PUBG Studios", "PlayerUnknown's Battlegrounds", 2017 },
                    { 23, "Action RPG", "CD Projekt Red", "The Witcher 3: Wild Hunt", 2015 },
                    { 24, "Action-adventure", "Rockstar Games", "Red Dead Redemption 2", 2018 },
                    { 25, "Action-adventure", "Nintendo", "The Legend of Zelda: Breath of the Wild", 2017 },
                    { 26, "Platformer", "Nintendo", "Super Mario Odyssey", 2017 },
                    { 27, "RPG", "Square Enix", "Final Fantasy VII Remake", 2020 },
                    { 28, "Action-adventure", "Santa Monica Studio", "God of War", 2018 },
                    { 29, "Action RPG", "Bethesda Game Studios", "Fallout 4", 2015 },
                    { 30, "Action-adventure", "Ubisoft", "Assassin's Creed Valhalla", 2020 },
                    { 31, "Action RPG", "CD Projekt Red", "Cyberpunk 2077", 2020 },
                    { 32, "Fighting", "NetherRealm Studios", "Mortal Kombat 11", 2019 },
                    { 33, "Action RPG", "Bethesda Game Studios", "The Elder Scrolls V: Skyrim", 2011 },
                    { 34, "Action-adventure", "Naughty Dog", "Uncharted 4: A Thief's End", 2016 },
                    { 35, "Survival horror", "Capcom", "Resident Evil Village", 2021 },
                    { 36, "First-person shooter", "Irrational Games", "Bioshock Infinite", 2013 },
                    { 37, "First-person shooter", "Bungie", "Destiny 2", 2017 },
                    { 38, "First-person shooter", "Gearbox Software", "Borderlands 3", 2019 },
                    { 39, "Tactical shooter", "Ubisoft", "Tom Clancy's Rainbow Six Siege", 2015 },
                    { 40, "Action roguelike", "Supergiant Games", "Hades", 2020 },
                    { 41, "Action-adventure", "Naughty Dog", "The Last of Us Part II", 2020 },
                    { 42, "Action RPG", "miHoYo", "Genshin Impact", 2020 }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Category", "Company", "Title", "YearReleased" },
                values: new object[,]
                {
                    { 43, "Action RPG", "Capcom", "Monster Hunter: World", 2018 },
                    { 44, "First-person shooter", "Infinity Ward", "Call of Duty: Modern Warfare", 2019 },
                    { 45, "Football", "EA Sports", "FIFA 22", 2021 },
                    { 46, "Sports", "Visual Concepts", "NBA 2K21", 2020 },
                    { 47, "Sports", "Vicarious Visions", "Tony Hawk's Pro Skater 1 + 2", 2020 },
                    { 48, "Platformer", "Toys for Bob", "Crash Bandicoot 4: It's About Time", 2020 },
                    { 49, "Action-adventure", "Respawn Entertainment", "Star Wars Jedi: Fallen Order", 2019 },
                    { 50, "Sports", "EA Sports", "Madden NFL 22", 2021 },
                    { 51, "Stealth", "IO Interactive", "Hitman 3", 2021 },
                    { 52, "MMORPG", "Square Enix", "Final Fantasy XIV", 2010 },
                    { 53, "Multiplayer shooter", "Valve", "Team Fortress 2", 2007 },
                    { 54, "Virtual reality", "Valve", "Half-Life: Alyx", 2020 },
                    { 55, "Strategy", "Firaxis Games", "Civilization VI", 2016 },
                    { 56, "Simulation", "ConcernedApe", "Stardew Valley", 2016 },
                    { 57, "Battle royale", "Epic Games", "Fortnite", 2017 },
                    { 58, "Life simulation", "Maxis", "The Sims 4", 2014 },
                    { 59, "Survival", "Unknown Worlds Entertainment", "Subnautica", 2018 },
                    { 60, "First-person shooter", "id Software", "DOOM Eternal", 2020 },
                    { 61, "Action RPG", "Square Enix", "Kingdom Hearts III", 2019 },
                    { 62, "Racing", "Playground Games", "Forza Horizon 4", 2018 },
                    { 63, "Action RPG", "Guerrilla Games", "Horizon Zero Dawn", 2020 },
                    { 64, "Third-person shooter", "People Can Fly", "Outriders", 2021 },
                    { 65, "Action-adventure", "Rare", "Sea of Thieves", 2018 },
                    { 66, "Survival horror", "Capcom", "Resident Evil 7: Biohazard", 2017 },
                    { 67, "Action-adventure", "Remedy Entertainment", "Control", 2019 },
                    { 68, "Action RPG", "Massive Entertainment", "Tom Clancy's The Division 2", 2019 },
                    { 69, "Action-adventure", "Kojima Productions", "Death Stranding", 2019 },
                    { 70, "Action-adventure", "Gunfire Games", "Darksiders III", 2018 },
                    { 71, "Action-adventure", "Ubisoft", "Watch Dogs: Legion", 2020 },
                    { 72, "Platformer", "Tarsier Studios", "Little Nightmares II", 2021 },
                    { 73, "Action-adventure", "Ubisoft", "Far Cry 5", 2018 },
                    { 74, "Action-adventure", "Sucker Punch Productions", "Ghost of Tsushima", 2020 },
                    { 75, "Action RPG", "Obsidian Entertainment", "The Outer Worlds", 2019 },
                    { 76, "First-person shooter", "4A Games", "Metro Exodus", 2019 },
                    { 77, "Action-adventure", "Ubisoft", "Far Cry 6", 2021 },
                    { 78, "Platformer", "Insomniac Games", "Ratchet & Clank: Rift Apart", 2021 },
                    { 79, "Action-adventure", "FromSoftware", "Sekiro: Shadows Die Twice", 2019 },
                    { 80, "Action-adventure", "Insomniac Games", "Marvel's Spider-Man: Miles Morales", 2020 },
                    { 81, "Platformer", "Moon Studios", "Ori and the Will of the Wisps", 2020 },
                    { 82, "Action-adventure", "Crystal Dynamics", "Marvel's Avengers", 2020 },
                    { 83, "Action-adventure", "Ryu Ga Gotoku Studio", "Yakuza: Like a Dragon", 2020 },
                    { 84, "Stealth", "IO Interactive", "Hitman 2", 2018 }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Category", "Company", "Title", "YearReleased" },
                values: new object[,]
                {
                    { 85, "Exploration", "Hello Games", "No Man's Sky", 2016 },
                    { 86, "First-person shooter", "EA DICE", "Star Wars Battlefront II", 2017 },
                    { 87, "Racing", "Codemasters", "F1 2021", 2021 },
                    { 88, "Action RPG", "Team Ninja", "Nioh 2", 2020 },
                    { 89, "Metroidvania", "Team Cherry", "Hollow Knight", 2017 },
                    { 90, "Run and gun", "Studio MDHR", "Cuphead", 2017 },
                    { 91, "Interactive drama", "Quantic Dream", "Detroit: Become Human", 2018 },
                    { 92, "Action-adventure", "Capcom", "Devil May Cry 5", 2019 },
                    { 93, "Fighting", "Bandai Namco Entertainment", "SoulCalibur VI", 2018 },
                    { 94, "Action-adventure", "Hangar 13", "Mafia: Definitive Edition", 2020 },
                    { 95, "MMO", "Digital Extremes", "Warframe", 2013 },
                    { 96, "First-person shooter", "Crytek", "Crysis Remastered", 2020 },
                    { 97, "Fighting", "Arc System Works", "Dragon Ball FighterZ", 2018 },
                    { 98, "RPG", "inXile Entertainment", "Wasteland 3", 2020 },
                    { 99, "Action-adventure", "Crystal Dynamics", "Tomb Raider", 2013 },
                    { 100, "Psychological horror", "Bloober Team", "The Medium", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Date", "Description", "UserName", "VideoGameId" },
                values: new object[] { 1, new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(7967), "Mi-a placut foarte mult jocul.", "Daniel03", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Date", "Description", "UserName", "VideoGameId" },
                values: new object[] { 2, new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(8002), "M-am jucat toata saptamana.", "AndreiNeamtu26", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Date", "Description", "UserName", "VideoGameId" },
                values: new object[] { 3, new DateTime(2023, 6, 11, 17, 42, 14, 807, DateTimeKind.Local).AddTicks(8004), "Un joc mediocru.", "Georgiana_32", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_VideoGameId",
                table: "Reviews",
                column: "VideoGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
