using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    Student name = Aniket passi
    studentID = 301044427
    Description : this is the hero data container class
     */
namespace COMP123_S2019_FINALTESTA.Objects
{
    class Hero
    {
      

        public string HeroName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //physical abilities
        public string Fighting { get; set; }

        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }
        
            //mental abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Psyche { get; set; }
        public string Popularity { get; set; }
        

        //power list
        List<Power> Powers;

        //constructor
        Hero()
        {
            //instantiate an empty power list
            Powers = new List<Power>();
        }


    }
}
