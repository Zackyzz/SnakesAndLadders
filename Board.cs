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
        public List<Square> squaresList = new List<Square>();
        public void Show(Form f)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(175, 256), rnd.Next(175, 256), rnd.Next(175, 256));
                Square square = new Square
                {
                    color = randomColor,
                    width = Constants.width,
                    height = Constants.height,
                    number = i + 1,
                    x = i * 50 % 500,
                    y = i / 10 * 50
                };
                squaresList.Add(square);
                squaresList[i].createSquare(f);
            }
        }
    }
}
