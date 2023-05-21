using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer, Game game);
        void Upgrade(Game game,Offer offer);
        void Delete(Offer offer,Game game);

    }
}
