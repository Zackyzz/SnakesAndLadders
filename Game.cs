using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeuriSiLaderuri
{
    class Game
    {
        public Board board = new Board();
        public List<Player> players = new List<Player>();

        public void Start(Form form)
        {
            players.Add(new Player { name = "QQ", position = 0 });
            board.Show(form);
        }
    }
}
