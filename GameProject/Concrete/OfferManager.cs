using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer, Game game)
        {
            Console.WriteLine(offer.OfferName+" isimli kampanya eklendi.");
        }

        public void Delete(Offer offer, Game game)
        {
            Console.WriteLine(offer.OfferName+" isimli kampanya silindi.");
        }

        public void Upgrade(Game game, Offer offer)
        {
            Console.WriteLine(offer.OfferName+" kampanya guncellendi.");
        }
    }
}
