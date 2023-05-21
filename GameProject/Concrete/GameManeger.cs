using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManeger : IGameService
    {
        public int Id { get ; set ; }

        public void Sale(Player player, Game game)
        {
            Console.WriteLine(player.FirstName+" Kullanici "+game.GameName+"  adli oyunu satin aldi");
        }
    }
}
