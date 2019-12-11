using System;
using System.Collections.Generic;
using System.Text;

namespace GameAdverb
{
    public class Game
    {
        public Game()
        {
                
        }
        public Game(string logo, string name, string description, DateTime realise, double price, string genre, string image, string lastVersion, string creator, string modeGame)
        {
            Logo = logo;
            Name = name;
            Description = description;
            Realise = realise;
            Price = price;
            Genre = genre;
            Image = image;
            LastVersion = lastVersion;
            Creator = creator;
            ModeGame = modeGame;
        }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Realise { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string LastVersion { get; set; }
        public string Creator { get; set; }
        public string ModeGame { get; set; }
    }
}
