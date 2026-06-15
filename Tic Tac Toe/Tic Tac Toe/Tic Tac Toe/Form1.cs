namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        public enum Player//??????????? ?? ???? enum ?? ????????
        {
            X, O
        }
        Player currentPlayer;
        Random Random = new Random();//????????? ?? ????? ? ?????? Random
        int playerwins = 0;//???????????? ?? ?????? ?? ???????? ?? ?????? 
        int AIwins = 0;//???????????? ?? ?????? ?? ???????? ?? ?????????
        List<PictureBox> pictureBoxes;

        private void AImove(object sender, EventArgs e)//????? ?? ???????? ?? ?????????
        {
            if (pictureBoxes.Count > 0)//??????? ????????? ?? ???????? ???? ??? ??? ???????? ??????
            {
                if ((pictureBox1.Tag == "X" && pictureBox2.Tag == "X" || pictureBox1.Tag == "O" && pictureBox2.Tag == "O") && pictureBox3.Tag != "O" && pictureBox3.Tag != "X")//??????? ????????? ?? ???????? ???? ???? ?? ????? ? ???????? ???? ?
                {
                    pictureBox3.Enabled = false;//?????? ? ????????????
                    currentPlayer = Player.O;//??????? ? ?
                    pictureBox3.Image = Properties.Resources.O1;//??????? ?? ?????? ?? ??????
                    pictureBox3.Tag = "O";//??????? ?? ???? ?? ???????? ????
                    pictureBoxes.Remove(pictureBox3);//????????? ?? ?????? ?? ???????
                    CheckGame();//???????? ?? ??????
                    AItimer.Stop();//??????? ?? ??????? ?? ?????????
                }
                //?????????? ??????? ????????? ?? ?? ?????????? ?????????? ?? ???????? ??????
                else if ((pictureBox1.Tag == "X" && pictureBox3.Tag == "X" || pictureBox1.Tag == "O" && pictureBox3.Tag == "O") && pictureBox2.Tag != "O" && pictureBox2.Tag != "X")
                {
                    pictureBox2.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox2.Image = Properties.Resources.O1;
                    pictureBox2.Tag = "O";
                    pictureBoxes.Remove(pictureBox2);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox2.Tag == "X" && pictureBox3.Tag == "X" || pictureBox2.Tag == "O" && pictureBox3.Tag == "O") && pictureBox1.Tag != "O" && pictureBox1.Tag != "X")
                {
                    pictureBox1.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox1.Image = Properties.Resources.O1;
                    pictureBox1.Tag = "O";
                    pictureBoxes.Remove(pictureBox1);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox4.Tag == "X" && pictureBox5.Tag == "X" || pictureBox4.Tag == "O" && pictureBox5.Tag == "O") && pictureBox6.Tag != "O" && pictureBox6.Tag != "X")
                {
                    pictureBox6.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox6.Image = Properties.Resources.O1;
                    pictureBox6.Tag = "O";
                    pictureBoxes.Remove(pictureBox6);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox6.Tag == "X" && pictureBox5.Tag == "X" || pictureBox6.Tag == "O" && pictureBox5.Tag == "O") && pictureBox4.Tag != "O" && pictureBox4.Tag != "X")
                {
                    pictureBox4.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox4.Image = Properties.Resources.O1;
                    pictureBox4.Tag = "O";
                    pictureBoxes.Remove(pictureBox4);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox4.Tag == "X" && pictureBox6.Tag == "X" || pictureBox4.Tag == "O" && pictureBox6.Tag == "O") && pictureBox5.Tag != "O" && pictureBox5.Tag != "X")
                {
                    pictureBox5.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox5.Image = Properties.Resources.O1;
                    pictureBox5.Tag = "O";
                    pictureBoxes.Remove(pictureBox5);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox7.Tag == "X" && pictureBox8.Tag == "X" || pictureBox7.Tag == "O" && pictureBox8.Tag == "O") && pictureBox9.Tag != "O" && pictureBox9.Tag != "X")
                {
                    pictureBox9.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox9.Image = Properties.Resources.O1;
                    pictureBox9.Tag = "O";
                    pictureBoxes.Remove(pictureBox9);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox9.Tag == "X" && pictureBox8.Tag == "X" || pictureBox9.Tag == "O" && pictureBox8.Tag == "O") && pictureBox7.Tag != "O" && pictureBox7.Tag != "X")
                {
                    pictureBox7.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox7.Image = Properties.Resources.O1;
                    pictureBox7.Tag = "O";
                    pictureBoxes.Remove(pictureBox7);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox9.Tag == "X" && pictureBox7.Tag == "X" || pictureBox9.Tag == "O" && pictureBox7.Tag == "O") && pictureBox8.Tag != "O" && pictureBox8.Tag != "X")
                {
                    pictureBox8.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox8.Image = Properties.Resources.O1;
                    pictureBox8.Tag = "O";
                    pictureBoxes.Remove(pictureBox8);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox1.Tag == "X" && pictureBox4.Tag == "X" || pictureBox1.Tag == "O" && pictureBox4.Tag == "O") && pictureBox7.Tag != "O" && pictureBox7.Tag != "X")
                {
                    pictureBox7.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox7.Image = Properties.Resources.O1;
                    pictureBox7.Tag = "O";
                    pictureBoxes.Remove(pictureBox7);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox7.Tag == "X" && pictureBox4.Tag == "X" || pictureBox7.Tag == "O" && pictureBox4.Tag == "O") && pictureBox1.Tag != "O" && pictureBox1.Tag != "X")
                {
                    pictureBox1.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox1.Image = Properties.Resources.O1;
                    pictureBox1.Tag = "O";
                    pictureBoxes.Remove(pictureBox1);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox1.Tag == "X" && pictureBox7.Tag == "X" || pictureBox1.Tag == "O" && pictureBox7.Tag == "O") && pictureBox4.Tag != "O" && pictureBox4.Tag != "X")
                {
                    pictureBox4.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox4.Image = Properties.Resources.O1;
                    pictureBox4.Tag = "O";
                    pictureBoxes.Remove(pictureBox4);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox2.Tag == "X" && pictureBox5.Tag == "X" || pictureBox2.Tag == "O" && pictureBox5.Tag == "O") && pictureBox8.Tag != "O" && pictureBox8.Tag != "X")
                {
                    pictureBox8.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox8.Image = Properties.Resources.O1;
                    pictureBox8.Tag = "O";
                    pictureBoxes.Remove(pictureBox8);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox8.Tag == "X" && pictureBox5.Tag == "X" || pictureBox8.Tag == "O" && pictureBox5.Tag == "O") && pictureBox2.Tag != "O" && pictureBox2.Tag != "X")
                {
                    pictureBox2.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox2.Image = Properties.Resources.O1;
                    pictureBox2.Tag = "O";
                    pictureBoxes.Remove(pictureBox2);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox2.Tag == "X" && pictureBox8.Tag == "X" || pictureBox2.Tag == "O" && pictureBox8.Tag == "O") && pictureBox5.Tag != "O" && pictureBox5.Tag != "X")
                {
                    pictureBox5.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox5.Image = Properties.Resources.O1;
                    pictureBox5.Tag = "O";
                    pictureBoxes.Remove(pictureBox5);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox3.Tag == "X" && pictureBox6.Tag == "X" || pictureBox3.Tag == "O" && pictureBox6.Tag == "O") && pictureBox9.Tag != "O" && pictureBox9.Tag != "X")
                {
                    pictureBox9.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox9.Image = Properties.Resources.O1;
                    pictureBox9.Tag = "O";
                    pictureBoxes.Remove(pictureBox9);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox9.Tag == "X" && pictureBox6.Tag == "X" || pictureBox9.Tag == "O" && pictureBox6.Tag == "O") && pictureBox3.Tag != "O" && pictureBox3.Tag != "X")
                {
                    pictureBox3.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox3.Image = Properties.Resources.O1;
                    pictureBox3.Tag = "O";
                    pictureBoxes.Remove(pictureBox3);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox3.Tag == "X" && pictureBox9.Tag == "X" || pictureBox3.Tag == "O" && pictureBox9.Tag == "O") && pictureBox6.Tag != "O" && pictureBox6.Tag != "X")
                {
                    pictureBox6.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox6.Image = Properties.Resources.O1;
                    pictureBox6.Tag = "O";
                    pictureBoxes.Remove(pictureBox6);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox1.Tag == "X" && pictureBox5.Tag == "X" || pictureBox1.Tag == "O" && pictureBox5.Tag == "O") && pictureBox9.Tag != "O" && pictureBox9.Tag != "X")
                {
                    pictureBox9.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox9.Image = Properties.Resources.O1;
                    pictureBox9.Tag = "O";
                    pictureBoxes.Remove(pictureBox9);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox1.Tag == "X" && pictureBox9.Tag == "X" || pictureBox1.Tag == "O" && pictureBox9.Tag == "O") && pictureBox5.Tag != "O" && pictureBox5.Tag != "X")
                {
                    pictureBox5.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox5.Image = Properties.Resources.O1;
                    pictureBox5.Tag = "O";
                    pictureBoxes.Remove(pictureBox5);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox5.Tag == "X" && pictureBox9.Tag == "X" || pictureBox5.Tag == "O" && pictureBox9.Tag == "O") && pictureBox1.Tag != "O" && pictureBox1.Tag != "X")
                {
                    pictureBox1.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox1.Image = Properties.Resources.O1;
                    pictureBox1.Tag = "O";
                    pictureBoxes.Remove(pictureBox1);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox3.Tag == "X" && pictureBox5.Tag == "X" || pictureBox3.Tag == "O" && pictureBox5.Tag == "O") && pictureBox7.Tag != "O" && pictureBox7.Tag != "X")
                {
                    pictureBox7.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox7.Image = Properties.Resources.O1;
                    pictureBox7.Tag = "O";
                    pictureBoxes.Remove(pictureBox7);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox7.Tag == "X" && pictureBox5.Tag == "X" || pictureBox7.Tag == "O" && pictureBox5.Tag == "O") && pictureBox3.Tag != "O" && pictureBox3.Tag != "X")
                {
                    pictureBox3.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox3.Image = Properties.Resources.O1;
                    pictureBox3.Tag = "O";
                    pictureBoxes.Remove(pictureBox3);
                    CheckGame();
                    AItimer.Stop();
                }
                else if ((pictureBox3.Tag == "X" && pictureBox7.Tag == "X" || pictureBox3.Tag == "O" && pictureBox7.Tag == "O") && pictureBox5.Tag != "O" && pictureBox5.Tag != "X")
                {
                    pictureBox5.Enabled = false;
                    currentPlayer = Player.O;
                    pictureBox5.Image = Properties.Resources.O1;
                    pictureBox5.Tag = "O";
                    pictureBoxes.Remove(pictureBox5);
                    CheckGame();
                    AItimer.Stop();
                }
                else
                {
                    int index = Random.Next(pictureBoxes.Count);//?????????? ?? ?????? Random ?? ????? ??????
                    pictureBoxes[index].Enabled = false;
                    currentPlayer = Player.O;
                    pictureBoxes[index].Image = Properties.Resources.O1;
                    pictureBoxes[index].Tag = "O";
                    pictureBoxes.RemoveAt(index);
                    CheckGame();
                    AItimer.Stop();
                }
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)//????? ?? ???????? ?? ??????
        {
            var player = (PictureBox)sender;//??????????? ???? ? ????????? ??? ????
            currentPlayer = Player.X;//?????? ? X
            player.Tag = "X";//??????? ?? ???? ?? ??????
            player.Enabled = false;//???????????? ?? ??????
            player.Image = Properties.Resources.X;//??????? ?? ????? ?? ??????
            pictureBoxes.Remove(player);//????????? ?? ?????? ?? ???????
            CheckGame();//???????? ?? ?????? ???? ????? ? ???????
            AItimer.Start();//?????????? ?? ??????? ?? ?????????
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();//???????????? ?? ??????
        }
        private void CheckGame()//????? ?? ???????? ???? ????? ? ??????? ? ??????
        {
            if (pictureBox1.Tag == "X" && pictureBox2.Tag == "X" && pictureBox3.Tag == "X" ||
                pictureBox4.Tag == "X" && pictureBox5.Tag == "X" && pictureBox6.Tag == "X" ||
                pictureBox7.Tag == "X" && pictureBox8.Tag == "X" && pictureBox9.Tag == "X" ||
                pictureBox1.Tag == "X" && pictureBox4.Tag == "X" && pictureBox7.Tag == "X" ||
                pictureBox2.Tag == "X" && pictureBox5.Tag == "X" && pictureBox8.Tag == "X" ||
                pictureBox3.Tag == "X" && pictureBox6.Tag == "X" && pictureBox9.Tag == "X" ||
                pictureBox1.Tag == "X" && pictureBox5.Tag == "X" && pictureBox9.Tag == "X" ||
                pictureBox3.Tag == "X" && pictureBox5.Tag == "X" && pictureBox7.Tag == "X")//??????? ????????? ???? ?????? X ? ???????
            {
                AItimer.Stop();//????? ??????? ?? ????????
                MessageBox.Show("You win!", "Congratulations!");//???????? ?? Messagebox
                playerwins++;//?????? ?? ????? ??????
                label1.Text = "Wins: " + Convert.ToString(playerwins);//??????? ?? ?????? ?? ???????
                RestartGame();//???????????? ?? ??????
            }
            else if (pictureBox1.Tag == "O" && pictureBox2.Tag == "O" && pictureBox3.Tag == "O" ||
                     pictureBox4.Tag == "O" && pictureBox5.Tag == "O" && pictureBox6.Tag == "O" ||
                     pictureBox7.Tag == "O" && pictureBox8.Tag == "O" && pictureBox9.Tag == "O" ||
                     pictureBox1.Tag == "O" && pictureBox4.Tag == "O" && pictureBox7.Tag == "O" ||
                     pictureBox2.Tag == "O" && pictureBox5.Tag == "O" && pictureBox8.Tag == "O" ||
                     pictureBox3.Tag == "O" && pictureBox6.Tag == "O" && pictureBox9.Tag == "O" ||
                     pictureBox1.Tag == "O" && pictureBox5.Tag == "O" && pictureBox9.Tag == "O" ||
                     pictureBox3.Tag == "O" && pictureBox5.Tag == "O" && pictureBox7.Tag == "O")//??????? ????????? ???? ?????? O ? ???????
            {
                AItimer.Stop();//??????? ?? ??????? ?? ?????????
                MessageBox.Show("You lose!", "Bad Luck! Try again.");//???????? ?? Messagebox
                AIwins++;//?????? ?? ????????? ?? ????? ??????
                label2.Text = "AI wins:  " + Convert.ToString(AIwins);
                RestartGame();//???????????? ?? ??????
            }
            else if (pictureBoxes.Count==0)
            {
                DialogResult offer =MessageBox.Show("Try Again!", "Draw!",MessageBoxButtons.RetryCancel);
                if(offer==DialogResult.Retry)
                {
                    RestartGame();
                }
                else if(offer==DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void RestartGame()
        {
            pictureBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };//??????? ?? ???????? ? ??????
            foreach (PictureBox b in pictureBoxes)//????? ?? ???????? ?? ????? ???? ? ??????????
            {
                b.Enabled = true;//?????????? ?? ????? ????
                b.Image = null;//???????? ?? ???????? ?? ????????
                b.Tag = null;//???????? ?? ???????? ?? ????????
                b.BackColor = Color.Turquoise;//?????? ?? ???????? ?? ???????????
            }

        }
    }
}