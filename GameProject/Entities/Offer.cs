using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Offer:IEntity
    {
        public int Id { get; set; }
        public string OfferName { get; set; }
        public string OfferDescription { get; set; }
        public float OfferDiscountRate { get; set; }
        public Offer()
        {
            
        }

        public Offer(int ıd, string offerName, string offerDescription, float offerDiscountRate)
        {
            Id = ıd;
            OfferName = offerName;
            OfferDescription = offerDescription;
            OfferDiscountRate = offerDiscountRate;
        }
    }
}
