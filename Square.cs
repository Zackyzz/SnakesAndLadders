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
        public int number;
        public int x, y;
        public int height, width;
        public Color color;

        public Panel panel;
        public Panel panelPlayer;
        public void createSquare(Form f)
        {
            panel = new Panel
            {
                BackColor = color,
                Width = width,
                Height = height,
                Top = y,
                Left = x
            };

            panelPlayer = new Panel
            {
                BackColor = color,
                Dock = DockStyle.Top,
                Height = height / 3
            };

            panel.Controls.Add(panelPlayer);

            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = number.ToString();
            label.Font = new Font("Segoe", 10);
            panel.Controls.Add(label);

            f.Controls.Add(panel);
        }
    }
}
