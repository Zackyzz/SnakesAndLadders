using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeuriSiLaderuri
{
    class Player
    {
        public string name;
        public int position;

        public Player()
        {
            name = "qq";
            position = 0;
        }
        public Player(string name, int position)
        {
            this.name = name;
            this.position = position;
        }
    }
}
