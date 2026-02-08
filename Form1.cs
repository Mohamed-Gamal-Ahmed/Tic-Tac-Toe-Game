//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using Tic_Tac_Toe_Game.Properties;

//namespace Tic_Tac_Toe_Game
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            StartGame();
//        }

//        enum enPlayer
//        {
//            Player1,
//            Player2
//        }
//        enPlayer PlayerTurn;

//        enum enWinner
//        {
//            Player1,
//            Player2,
//            Draw,
//            GameInProgress
//        }

//        struct stGameStatus
//        {
//            public enWinner Winner;
//            public bool GameOver;
//            public short PlayCount;
//        }

//        stGameStatus GameStatus;

//        void StartGame()
//        {
//            PlayerTurn = enPlayer.Player1;
//            GameStatus = new stGameStatus
//            {
//                PlayCount = 0,
//                GameOver = false,
//                Winner = enWinner.GameInProgress
//            };

//            lbPlayerTurn.Text = "Player 1";
//            lbWinner.Text = "In Progress";
//        }


//        bool CheckValues(Button btn1, Button btn2, Button btn3)
//        {
//            if (btn1.Tag == null || btn2.Tag == null || btn3.Tag == null)
//                return false;

//            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
//            {
//                btn1.BackColor = Color.GreenYellow;
//                btn2.BackColor = Color.GreenYellow;
//                btn3.BackColor = Color.GreenYellow;

//                GameStatus.GameOver = true;
//                GameStatus.Winner = (btn1.Tag.ToString() == "X") ? enWinner.Player1 : enWinner.Player2;

//                EndGame();
//                return true;
//            }

//            return false;
//        }

//        void CheckWinner()
//        {
//            if (CheckValues(button1, button2, button3)) return;
//            if (CheckValues(button4, button5, button6)) return;
//            if (CheckValues(button7, button8, button9)) return;

//            if (CheckValues(button1, button4, button7)) return;
//            if (CheckValues(button2, button5, button8)) return;
//            if (CheckValues(button3, button6, button9)) return;

//            if (CheckValues(button1, button5, button9)) return;
//            if (CheckValues(button3, button5, button7)) return;

//            if (GameStatus.PlayCount == 9 && !GameStatus.GameOver)
//            {
//                GameStatus.GameOver = true;
//                GameStatus.Winner = enWinner.Draw;
//                EndGame();
//            }
//        }

//        void ChangeImage(Button btn)
//        {
//            if (GameStatus.GameOver)
//                return;

//            if (btn.Tag.ToString() != "?")
//            {
//                MessageBox.Show("Wrong Choice", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            if (PlayerTurn == enPlayer.Player1)
//            {
//                btn.Image = Resources.X;
//                btn.Tag = "X";
//                PlayerTurn = enPlayer.Player2;
//                lbPlayerTurn.Text = "Player 2";
//            }
//            else
//            {
//                btn.Image = Resources.O;
//                btn.Tag = "O";
//                PlayerTurn = enPlayer.Player1;
//                lbPlayerTurn.Text = "Player 1";
//            }

//            GameStatus.PlayCount++;
//            CheckWinner();
//        }

//        void EndGame()
//        {
//            lbPlayerTurn.Text = "Game Over";

//            switch (GameStatus.Winner)
//            {
//                case enWinner.Player1:
//                    lbWinner.Text = "Player 1";
//                    break;

//                case enWinner.Player2:
//                    lbWinner.Text = "Player 2";
//                    break;

//                default:
//                    lbWinner.Text = "Draw";
//                    break;
//            }

//            MessageBox.Show("Game Over", "Game Over",
//                MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }


//        void ResetButton(Button btn)
//        {
//            btn.Image = Resources.question_mark_96;
//            btn.Tag = "?";
//            btn.BackColor = Color.Transparent;
//        }

//        void RestartGame()
//        {
//            ResetButton(button1);
//            ResetButton(button2);
//            ResetButton(button3);
//            ResetButton(button4);
//            ResetButton(button5);
//            ResetButton(button6);
//            ResetButton(button7);
//            ResetButton(button8);
//            ResetButton(button9);

//            StartGame();
//        }

//        private void button_Click(object sender, EventArgs e)
//        {
//            ChangeImage((Button)sender);
//        }

//        private void btnRestartGame_Click(object sender, EventArgs e)
//        {
//            RestartGame();
//        }
//    }
//}
using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StyleAllButtons();
            StartGame();
        }

        enum enPlayer
        {
            Player1,
            Player2
        }
        enPlayer PlayerTurn;

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

        stGameStatus GameStatus;

        // ================= STYLE BUTTONS =================
        void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 3;
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.BackColor = Color.White;
        }

        void StyleAllButtons()
        {
            StyleButton(button1);
            StyleButton(button2);
            StyleButton(button3);
            StyleButton(button4);
            StyleButton(button5);
            StyleButton(button6);
            StyleButton(button7);
            StyleButton(button8);
            StyleButton(button9);
        }

        // ================= GAME =================
        void StartGame()
        {
            PlayerTurn = enPlayer.Player1;
            GameStatus = new stGameStatus
            {
                PlayCount = 0,
                GameOver = false,
                Winner = enWinner.GameInProgress
            };

            lbPlayerTurn.Text = "Player 1";
            lbWinner.Text = "In Progress";
        }

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag == null || btn2.Tag == null || btn3.Tag == null)
                return false;

            if (btn1.Tag.ToString() != "?" &&
                btn1.Tag.ToString() == btn2.Tag.ToString() &&
                btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                btn1.FlatAppearance.BorderColor =
                btn2.FlatAppearance.BorderColor =
                btn3.FlatAppearance.BorderColor = Color.Green;

                GameStatus.GameOver = true;
                GameStatus.Winner =
                    (btn1.Tag.ToString() == "X") ? enWinner.Player1 : enWinner.Player2;

                EndGame();
                return true;
            }

            return false;
        }

        void CheckWinner()
        {
            if (CheckValues(button1, button2, button3)) return;
            if (CheckValues(button4, button5, button6)) return;
            if (CheckValues(button7, button8, button9)) return;

            if (CheckValues(button1, button4, button7)) return;
            if (CheckValues(button2, button5, button8)) return;
            if (CheckValues(button3, button6, button9)) return;

            if (CheckValues(button1, button5, button9)) return;
            if (CheckValues(button3, button5, button7)) return;

            if (GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        void ChangeImage(Button btn)
        {
            if (GameStatus.GameOver)
                return;

            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerTurn == enPlayer.Player1)
            {
                btn.Image = Resources.X;
                btn.Tag = "X";
                PlayerTurn = enPlayer.Player2;
                lbPlayerTurn.Text = "Player 2";
            }
            else
            {
                btn.Image = Resources.O;
                btn.Tag = "O";
                PlayerTurn = enPlayer.Player1;
                lbPlayerTurn.Text = "Player 1";
            }

            GameStatus.PlayCount++;
            CheckWinner();
        }

        void EndGame()
        {
            lbPlayerTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lbWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lbWinner.Text = "Player 2";
                    break;
                default:
                    lbWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game Over",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.White;
            btn.FlatAppearance.BorderColor = Color.Black;
        }

        void RestartGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            StartGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
