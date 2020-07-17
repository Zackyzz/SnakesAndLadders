using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeuriSiLaderuri
{
    class Board
    {
        public void Show(Form form)
        {
            Square square = new Square
            {
                height = 100,
                width = 100,
                x = 0,
                y = 0,
                color = Color.Blue,
                number = 7
            };
            square.createSquare(form);
        }

    }
}
