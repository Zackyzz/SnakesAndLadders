using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeuriSiLaderuri
{
    public class Square
    {
        public int number = 7;
        public int x, y;
        public int height, width;
        public Color color;

        public void createSquare(Form f)
        {
            Panel panel = new Panel
            {
                BackColor = color,
                Width = width,
                Height = height,
                Top = y,
                Left = x
            };
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = number.ToString();
            panel.Controls.Add(label);

            f.Controls.Add(panel);
        }
    }
}
