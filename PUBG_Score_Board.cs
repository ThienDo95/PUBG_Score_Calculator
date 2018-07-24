using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Score_Calculator
{
    class PUBG_Score_Board
    {

        private Dictionary<String, int> p = new Dictionary<String, int>(); //Placement and point corresponding

        private int aKillPoint = 15;

        //Constructor 
        public PUBG_Score_Board()
        {
            //Adding to dictionary
            p.Add("1", 500);
            p.Add("2", 410);
            p.Add("3", 345);
            p.Add("4", 295);
            p.Add("5", 250);
            p.Add("6", 210);
            p.Add("7", 175);
            p.Add("8", 145);
            p.Add("9", 120);
            p.Add("10", 100);
            p.Add("11", 580);
            p.Add("12", 65);
            p.Add("13", 50);
            p.Add("14", 40);
            p.Add("15", 30);
            p.Add("16", 20);
            p.Add("17", 15);
            p.Add("18", 10);
            p.Add("19", 5);
            p.Add("20", 0);
            //
        }

      
        public int calculateWholeGame(String placement, int kill)
        {
            int placementPoint = 0;
            int result = 0;

            foreach(KeyValuePair<String, int> value in p)
            {
                if (value.Key.Equals(placement))
                {
                    placementPoint = value.Value;

                    result = placementPoint + (aKillPoint * kill);
                }
            }

            return result;
        }

    }
}
