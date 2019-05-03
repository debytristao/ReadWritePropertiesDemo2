using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class Car
    {
        //Qdo colocar question marque ? significa que nao pode ser null
        private int? speed;
        //private decimal? price2; isso e o mesmo q o debaixo
        private Nullable<decimal> price;
        private int numberOffDoors;
        private string carType;

        public string CarType{get; set;}
        public int? Yeay { get; set; }
        public Nullable<decimal> Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int? Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int NumOffDoors
        { get
            {
                return numberOffDoors;
             }
            set
            {
                //ensure the value < 10
                if(value < 10)
                {
                    numberOffDoors = value;
                }
            }
        }

    }
}
