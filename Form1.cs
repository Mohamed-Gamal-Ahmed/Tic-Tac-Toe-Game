using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        stGameStatus GameStatus;

        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {


            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;


        }

        void EndGame()
        {

            lbPlayerTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lbWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lbWinner.Text = "Player2";
                    break;

                default:

                    lbWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

            if (CheckValues(button4, button5, button6))
                return;

            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;

            if (CheckValues(button2, button5, button8))
                return;

            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button1, button5, button9))
                return;

            if (CheckValues(button3, button5, button7))
                return;
        }

        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lbPlayerTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbPlayerTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }

            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }

        private void RestartGame()
        {

            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lbPlayerTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lbWinner.Text = "In Progress";



        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }


        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
