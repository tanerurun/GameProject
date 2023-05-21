using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IRealyCheckPlayerService _realyCheckPlayerService;

        public PlayerManager(IRealyCheckPlayerService realyCheckPlayerService)
        {
            _realyCheckPlayerService = realyCheckPlayerService;
        }

        public void Add(Player player)
        {
           if(_realyCheckPlayerService.Validate(player)==true)
            {
                Console.WriteLine(player.FirstName+" Oyuncu eklendi.");
            }
           else
            {
                Console.WriteLine("Kullanici bilgiler eklenmedi lutfen kontrol ediniz.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName+" Oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName+" Oyuncu guncelendi.");
        }
    }
}
