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
        Game game = new Game();
        Button dice = new Button();
        Label label = new Label();
        int a, b;
        public mainForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Snakes & Ladders";
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.DarkGray;

            game.Start(this);


            dice.Location = new Point(500, 200);
            dice.Size = new Size(100, 100);
            dice.BackColor = Color.AliceBlue;
            dice.Text = "Press the dice!";
            dice.Click += new EventHandler(diceClick);
            this.Controls.Add(dice);

        }
        private void diceClick(object sender, EventArgs e)
        {
            hidePlayer(game.players[0]);

            Random rnd = new Random();
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 7);
            ((Button)sender).Text = "Dice 1: " + a.ToString() + "\n" + "Dice 2: " + b.ToString();
            showPlayer(game.players[0]);
        }
        private void showPlayer(Player player)
        {
            try
            {
                label.Text = player.name;
                label.Dock = DockStyle.Fill;
                label.Font = new Font("Segoe", 8);
                label.BackColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleCenter;

                player.position += a + b;
                game.board.squaresList[player.position - 1].panelPlayer.Controls.Add(label);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                game.board.squaresList[99].panelPlayer.Controls.Add(label);
                MessageBox.Show("Gata jocu! Castigatorul este " + player.name);
                dice.Enabled = false;
            }
        }
        private void hidePlayer(Player player)
        {
            try
            {
                game.board.squaresList[game.players[0].position].panelPlayer.Controls.Clear();
            }
            catch (System.ArgumentOutOfRangeException e)
            {
            }
        }
    }
}

