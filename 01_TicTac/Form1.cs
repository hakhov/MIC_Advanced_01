using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TicTac
{
    public partial class Form1 : Form
    {
        sbyte pushCount = 0;
        bool push = true;
        bool isWinner = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (push)
                bt.Text = "X";
            else
                bt.Text = "O";

            push = !push;
            pushCount++;
            bt.Enabled = false;

            if (pushCount > 4)
                CheckWinner();
        }

        private void CheckWinner()
        {

            if ((btA1.Text == btB1.Text) && (btB1.Text == btC1.Text) && !btA1.Enabled)
                isWinner = true;

            if ((btA2.Text == btB2.Text) && (btB2.Text == btC2.Text) && !btA2.Enabled)
                isWinner = true;

            if ((btA3.Text == btB3.Text) && (btB3.Text == btC3.Text) && !btA3.Enabled)
                isWinner = true;

            char winnerSymbole = ' ';

            if (isWinner)
            {
                if (push)
                {
                    winnerSymbole = 'O';
                    lbOWinner.Text = (int.Parse(lbOWinner.Text) + 1).ToString();
                }
                else
                {
                    winnerSymbole = 'X';
                    lbXWinner.Text = (int.Parse(lbXWinner.Text) + 1).ToString();

                }

                MessageBox.Show(
               $"Winner is {winnerSymbole}",
               "Winner information",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
               );
                
                GetSound(winnerSymbole);

                StartNewGame();
            }

            else
            {
                if (pushCount == 9)
                {
                    MessageBox.Show(
                                  $"We don't have a Winner",
                                  "Winner information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning
                                  );
                    lbNoWinner.Text = (int.Parse(lbNoWinner.Text) + 1).ToString();

                    StartNewGame();
                }
            }
        }


        private void StartNewGame()
        {
            push = true;
            pushCount = 0;

            foreach (var item in Controls)
            {
                try
                {
                    Button bt = item as Button;
                    bt.Enabled = true;
                    bt.Text = "";
                }
                catch { }
            }
        }

        private void bt_Enter(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (bt.Enabled)
            {
                if (push)
                    bt.Text = "X";
                else
                    bt.Text = "O";
            }
        }

        private void bt_Leave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.Enabled)
            {
                bt.Text = "";
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
            lbXWinner.Text = "0";
            lbOWinner.Text = "0";
            lbNoWinner.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                                  $"This Game made by MIC group",
                                  "Winner information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information
                                  );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.
        }


        private void GetSound(char winnerSymbole)
        {
            if (isWinner)
            {
                axWindowsMediaPlayer1.URL();
                timer1.Start();
                Task.Delay(3000);
                timer1.Stop();
            }
            else
            {

            }
        }
    }
}
