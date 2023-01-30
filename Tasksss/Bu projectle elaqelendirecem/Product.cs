using System;
using System.Collections.Generic;
using System.Text;

namespace Bu_projectle_elaqelendirecem
{
    public class Product
    {
        private string _name;
        private double _price;

        public double Price
        {
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }

            get
            {

                return _price;

            }

        }
        public string Name
        {
            set
            {
                if (value.Length > 1 && value.Length < 21)
                {

                    _name = value;
                }

            }

            get
            {

                return _name;
            }

        }
    }
}
