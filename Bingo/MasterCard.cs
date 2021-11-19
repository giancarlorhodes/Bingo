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

    }


   
}
