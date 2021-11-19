using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class CardSpot
    {
        public int Number { get; set; }
        public bool IsPicked { get; set; }

        public CardSpot(int inNumber, bool inIsPicked)
        {
            this.Number = inNumber;
            this.IsPicked = inIsPicked;
        }
    }
}
