using System;
using System.Collections.Generic;
using System.Text;

namespace Bu_projectle_elaqelendirecem
{
    public class Drink:Product
    {
        private double _alcoholpercent;


        public double AlcoholPercent
        {
            set
            {
                if (value>=0 && value <=100)
                {

                    _alcoholpercent = value;    
                }
             
            }


            get
            {
                 return _alcoholpercent;


            }

        }



    }
}
