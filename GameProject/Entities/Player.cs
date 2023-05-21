using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long  NationalNumber { get; set; }
        public Player()
        {
            
        }

        public Player(int ıd, string firstName, string lastName, long nationalNumber)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalNumber = nationalNumber;
        }
    }
}
