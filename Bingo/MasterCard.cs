using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class MasterCard
    {
        // properties
        public CardSpot[,] Card = new CardSpot[5, 15];
        //public List<CardSpot> List = new List<CardSpot>(); // could have used this instead of array

       
        // constructors
        public MasterCard() 
        {
            this.ResetCard();
        }

        // methods
        private void ResetCard() 
        {
            // setting the master card logic          
            int _number = 1;

            for (int letters = 0; letters < 5; letters++) // B  I  N  G O
            {
                
                for (int numbers = 0; numbers < 15; numbers++) // 1 thru 15
                {
                    this.Card[letters, numbers] = new CardSpot(_number, false);
                    _number = _number + 1;
                }

            }             
        }

        public int Pick() 
        {
            // get a random number from 1 to  75
            // 75 =  [4, 14]

            Random _random = new Random();
            int _number = _random.Next((int)CardRange.min, (int)CardRange.max);

            // if that number already picked? if so, pick again
            while (IsPicked(_number))
            {
                _number = _random.Next((int)CardRange.min, (int)CardRange.max);
            }

            // keep picking randomly until I get a number

            // update the CardSpot array

            return 0;
        }


        private bool IsPicked(int inNumber) 
        {
            bool _return = false;
            for (int letters = 0; letters < 5; letters++) // B  I  N  G O
            {
                for (int numbers = 0; numbers < 15; numbers++) // 1 thru 15
                {
                    if (this.Card[letters, numbers].Number == inNumber && this.Card[letters, numbers].IsPicked == false)
                    {
                        _return = false;
                        break;
                    }
                    else if (this.Card[letters, numbers].Number == inNumber && this.Card[letters, numbers].IsPicked == true)
                    {
                        _return = true;
                        break;
                    }
                }               
            }

            return _return;
        }

    }



    enum CardRange 
    { 
        min = 1,
        max = 75
    
    }


   
}
