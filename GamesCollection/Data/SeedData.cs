using GamesCollection.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace GamesCollection.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Games.Any())
                {
                    return;
                }

                context.Games.AddRange(
                    new GameDbModel
                    {
                        Title = "Fifa 23",
                        Producer = "Electronic Arts",
                        Platform = "PC",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2023-10-01"),
                        Genre = "Sports",
                        Price = 7.99M
                    },

                    new GameDbModel
                    {
                        Title = "Assassin's Creed Valhalla",
                        Producer = "Ubisoft",
                        Platform = "PlayStation 5",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2020-11-10"),
                        Genre = "Action",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "The Legend of Zelda: Breath of the Wild",
                        Producer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2017-03-03"),
                        Genre = "Adventure",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Call of Duty: Modern Warfare",
                        Producer = "Activision",
                        Platform = "Xbox One",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2019-10-25"),
                        Genre = "Shooter",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Minecraft",
                        Producer = "Mojang Studios",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2011-11-18"),
                        Genre = "Sandbox",
                        Price = 26.95M
                    },

                    new GameDbModel
                    {
                        Title = "Super Mario Odyssey",
                        Producer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Region = "Japan",
                        ReleaseDate = DateTime.Parse("2017-10-27"),
                        Genre = "Platformer",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Grand Theft Auto V",
                        Producer = "Rockstar Games",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2014-09-17"),
                        Genre = "Action",
                        Price = 29.99M
                    },

                    new GameDbModel
                    {
                        Title = "The Witcher 3: Wild Hunt",
                        Producer = "CD Projekt",
                        Platform = "PC",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2015-05-19"),
                        Genre = "RPG",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "Fortnite",
                        Producer = "Epic Games",
                        Platform = "Xbox Series X",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2017-07-25"),
                        Genre = "Battle Royale",
                        Price = 0M
                    },

                    new GameDbModel
                    {
                        Title = "God of War",
                        Producer = "Santa Monica Studio",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2018-04-20"),
                        Genre = "Action",
                        Price = 19.99M
                    },
                    new GameDbModel
                    {
                        Title = "F1 2022",
                        Producer = "Codemasters",
                        Platform = "PC",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2022-07-16"),
                        Genre = "Racing",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Red Dead Redemption 2",
                        Producer = "Rockstar Games",
                        Platform = "Xbox One",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Action",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Cyberpunk 2077",
                        Producer = "CD Projekt",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-12-10"),
                        Genre = "RPG",
                        Price = 49.99M
                    },

                    new GameDbModel
                    {
                        Title = "Overwatch",
                        Producer = "Blizzard Entertainment",
                        Platform = "PlayStation 4",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2016-05-24"),
                        Genre = "Shooter",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "Animal Crossing: New Horizons",
                        Producer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-03-20"),
                        Genre = "Life simulation",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Borderlands 3",
                        Producer = "Gearbox Software",
                        Platform = "PC",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2019-09-13"),
                        Genre = "Shooter",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Minecraft Dungeons",
                        Producer = "Mojang Studios",
                        Platform = "Nintendo Switch",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-05-26"),
                        Genre = "Action RPG",
                        Price = 19.99M
                    },

                    new GameDbModel
                    {
                        Title = "Destiny 2",
                        Producer = "Bungie",
                        Platform = "PlayStation 5",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2017-09-06"),
                        Genre = "Shooter",
                        Price = 20M
                    },

                    new GameDbModel
                    {
                        Title = "The Sims 4",
                        Producer = "Maxis",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2014-09-02"),
                        Genre = "Life simulation",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "World of Warcraft: Shadowlands",
                        Producer = "Blizzard Entertainment",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-11-23"),
                        Genre = "MMORPG",
                        Price = 39.99M
                    },
                    new GameDbModel
                    {
                        Title = "Monster Hunter: World",
                        Producer = "Capcom",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2018-01-26"),
                        Genre = "Action RPG",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "Super Smash Bros. Ultimate",
                        Producer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2018-12-07"),
                        Genre = "Fighting",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Horizon Zero Dawn",
                        Producer = "Guerrilla Games",
                        Platform = "PlayStation 4",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2017-02-28"),
                        Genre = "Action",
                        Price = 19.99M
                    },

                    new GameDbModel
                    {
                        Title = "Apex Legends",
                        Producer = "Respawn Entertainment",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2019-02-04"),
                        Genre = "Battle Royale",
                        Price = 0M
                    },

                    new GameDbModel
                    {
                        Title = "Final Fantasy VII Remake",
                        Producer = "Square Enix",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2020-04-10"),
                        Genre = "RPG",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Death Stranding",
                        Producer = "Kojima Productions",
                        Platform = "PC",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2019-11-08"),
                        Genre = "Action",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "Super Mario 3D World + Bowser's Fury",
                        Producer = "Nintendo",
                        Platform = "Nintendo Switch",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2021-02-12"),
                        Genre = "Platformer",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "Hades",
                        Producer = "Supergiant Games",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-09-17"),
                        Genre = "Action RPG",
                        Price = 24.99M
                    },

                    new GameDbModel
                    {
                        Title = "Marvel's Spider-Man: Miles Morales",
                        Producer = "Insomniac Games",
                        Platform = "PlayStation 5",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2020-11-12"),
                        Genre = "Action",
                        Price = 49.99M
                    },
                    new GameDbModel
                    {
                        Title = "Persona 5",
                        Producer = "Atlus",
                        Platform = "PlayStation 4",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2017-04-04"),
                        Genre = "RPG",
                        Price = 19.99M
                    },
                    new GameDbModel
                    {
                        Title = "Resident Evil Village",
                        Producer = "Capcom",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2021-05-07"),
                        Genre = "Survival Horror",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "The Elder Scrolls V: Skyrim",
                        Producer = "Bethesda Game Studios",
                        Platform = "Xbox One",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2011-11-11"),
                        Genre = "RPG",
                        Price = 39.99M
                    },

                    new GameDbModel
                    {
                        Title = "Among Us",
                        Producer = "InnerSloth",
                        Platform = "Mobile",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2018-06-15"),
                        Genre = "Social deduction",
                        Price = 0M
                    },

                    new GameDbModel
                    {
                        Title = "Baldur's Gate III",
                        Producer = "Larian Studios",
                        Platform = "PC",
                        Region = "Europe",
                        ReleaseDate = DateTime.Parse("2020-10-06"),
                        Genre = "RPG",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "The Last of Us Part II",
                        Producer = "Naughty Dog",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2020-06-19"),
                        Genre = "Action",
                        Price = 59.99M
                    },

                    new GameDbModel
                    {
                        Title = "League of Legends",
                        Producer = "Riot Games",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2009-10-27"),
                        Genre = "MOBA",
                        Price = 0M
                    },

                    new GameDbModel
                    {
                        Title = "World of Tanks",
                        Producer = "Wargaming",
                        Platform = "PC",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2010-08-12"),
                        Genre = "Tank simulation",
                        Price = 0M
                    },
                    new GameDbModel
                    {
                        Title = "Uncharted 4: A Thief's End",
                        Producer = "Naughty Dog",
                        Platform = "PlayStation 4",
                        Region = "North America",
                        ReleaseDate = DateTime.Parse("2016-05-10"),
                        Genre = "Action",
                        Price = 19.99M
                    },
                    new GameDbModel
                    {
                        Title = "Genshin Impact",
                        Producer = "miHoYo",
                        Platform = "Mobile",
                        Region = "Global",
                        ReleaseDate = DateTime.Parse("2020-09-28"),
                        Genre = "Action RPG",
                        Price = 0M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
