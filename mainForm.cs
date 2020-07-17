using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeuriSiLaderuri
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Snakes & Ladders";
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.DarkGray;
            Board board = new Board();
            board.Show(this);

            Button dice = new Button();
            dice.Location = new Point(500, 200);
            dice.Size = new Size(100, 100);
            dice.BackColor = Color.AliceBlue;
            dice.Click += new EventHandler(diceClick);
            this.Controls.Add(dice);
        }
        private void diceClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            /*Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;*/
            ((Button)sender).Text = "Dice 1 o dat: " + rnd.Next(1, 7).ToString() + "\n" + "Dice 2 o dat: " + rnd.Next(1, 7).ToString();
            //((Button)sender).Controls.Add(label);
        }
    }
}
