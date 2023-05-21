using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string Description { get; set; }
        public Game()
        {
            
        }

        public Game(int ıd, string gameName, double gamePrice, string description)
        {
            Id = ıd;
            GameName = gameName;
            GamePrice = gamePrice;
            Description = description;
        }
    }
}
