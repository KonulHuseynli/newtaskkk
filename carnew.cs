using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class car
    {
        public string Model { get; set; }

        public string Brand { get; set; }

        private int _probek;
        public int Probek
        {
            get
            {
                return _probek;
            }


            set
            {
                int temp = value;
                int reverse = 0;
                while (value > 0)
                {
                    reverse = reverse * 10 + value % 10;
                    value = value / 10;
                }
                if (temp == reverse)
                {
                    _probek = temp;
                }
                else
                {
                    _probek = 0;
                }
            }

        }
    }
}
}
