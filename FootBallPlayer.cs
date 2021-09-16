using System;

namespace FootBall
{
    public class FootBallPlayer
    {
        private int _id;
        private string _name;
        private double _price;
        private int _shirtNumber;


        public FootBallPlayer(int id, string name, double price, int shirtnumber)
        {
            _id = id;
            _name = name;
            _price = price;
            _shirtNumber = shirtnumber;
        }



        public int Id
        {
            get => _id;
            set
            {
                if (0 < value && value > 2) _id = value;
                {
                    throw new ArgumentException("Bad Id Length");
                    _id = value;
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Bad Name Length");
                    _name = value;

                }
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Bad Pricing");
                    _price = value;
                }
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (1 <= value && value <= 100) _shirtNumber = value;
                else throw new ArgumentException("Bad Shirt Number");
            }
        }



        

    }
}
