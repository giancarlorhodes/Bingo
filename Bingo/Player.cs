using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    // player info and the cards the player have
    public class Player
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public List<PlayerCard> Cards { get; set; }

    }
}
