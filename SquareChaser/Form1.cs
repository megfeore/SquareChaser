using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SquareChaser
{
    public partial class Form1 : Form
    {
        //declaring the rectangles for the shapes
        Rectangle player1 = new Rectangle(20, 150, 20, 20);
        Rectangle player2 = new Rectangle(300, 150, 20, 20);
        Rectangle square = new Rectangle(180, 40, 10, 10);
        Rectangle boostSquare = new Rectangle(180, 260, 10, 10);
        Rectangle gameBoard = new Rectangle(0, 0, 370, 316);
        Rectangle gameOutline = new Rectangle(0, 0, 370, 316);
        Rectangle bluePower = new Rectangle(50, 50, 15, 15);

        //setting the brushes and pens
        SolidBrush purple = new SolidBrush(Color.Purple);
        SolidBrush orange = new SolidBrush(Color.Orange);
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush black = new SolidBrush(Color.Black);
        Pen whitePen = new Pen(Color.White, 10);
        //SolidBrush blue = new SolidBrush(Color.Blue);

        //setting speeds
        int player1Speed = 5;
        int player2Speed = 5;

        //initializing keys that will be used to control the player
        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        // create a random number generator 
        Random randGen = new Random();

        // variables to hold values for two random numbers 
        int randomX = 0;
        int randomY = 0;

        //setting integer to track the player and their score
        int playerTurn = 0;
        int player1Score = 0;
        int player2Score = 0;

        //declare sounds
        SoundPlayer whiteSound = new SoundPlayer(Properties.Resources.Collide);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.Swoosh);
        SoundPlayer wallSound = new SoundPlayer(Properties.Resources.Blop);

        ////blue power square values
        //int time = 0;
        //int bluePower.X = -100;
        //int bluePower.Y = -100;


        public Form1()
        {
            InitializeComponent();
            //time = randGen.Next(50, 300);
            
            //text on instruction label
            textLabel.Text = "To win the game you must collect the white square 5 times. " +
                "You can gain speed by collecting the yellow square. " +
                "Move Player 1 with keys w, s, a, d. Move Player 2 with key arrows, " +
                "up, down, left and right." +
                " Hit the start button to play. ";

            MoveSquare();
            MoveBoostSquare();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //get rid of the starting page 
            startButton.Visible = false;
            textLabel.Visible = false;
            startLabel.Visible = false;
            purpleLabel.Visible = false;
            orangeLabel.Visible = false;

            //start the game engine
            gameTimer.Enabled = true;
            this.Focus();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player 1 up and down
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;

                if (player1.Y <= 7)
                {
                    wallSound.Play();
                    player1.Y = 5;
                }
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;

                if (player1.Y >= 291)
                {
                    wallSound.Play();
                    player1.Y = 291;
                }
            }


            // move player 1 left and right
            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;

                if (player1.X <= 6)
                {
                    wallSound.Play();
                    player1.X = 5;
                }

            }


            if (dDown == true && player1.X < 345)
            {
                player1.X += player1Speed;

                if (player1.X >= 340)
                {
                    wallSound.Play();
                }
            }

            //move player 2 up and down
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;

                if (player2.Y <= 7)
                {
                    wallSound.Play();
                    player2.Y = 5;
                }
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;

                if (player2.Y >= 291)
                {
                    wallSound.Play();
                    player2.Y = 291;
                }
            }

            //move player 2 left and right
            if (leftDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;

                if (player2.X <= 6)
                {
                    wallSound.Play();
                    player2.X = 5;
                }
            }

            if (rightDown == true && player2.X <= 345)
            {
                player2.X += player2Speed;

                if (player2.X >= 340)
                {
                    wallSound.Play();
                    player2.X = 345;
                }
            }

            //A point is scored when the player collides with the white square 
            if (player1.IntersectsWith(square))
            {
                whiteSound.Play();
                square.X = player1.X + square.Width;
                MoveSquare();
                MovePlayer1();
                player1Score++;
                player1ScoreLabel.Text = $"{player1Score}";
            }
            else if (player2.IntersectsWith(square))
            {
                whiteSound.Play();
                square.X = player2.X - square.Width;
                MoveSquare();
                MovePlayer2();
                player2Score++;
                player2ScoreLabel.Text = $"{player2Score}";
            }

            //player speed increases if it collides with yellow boost
            if (player1.IntersectsWith(boostSquare))
            {
                yellowSound.Play();
                boostSquare.X = player1.X + boostSquare.Width;
                MoveBoostSquare();
                MovePlayer1();
                player1Speed++;
            }
            else if (player2.IntersectsWith(boostSquare))
            {
                yellowSound.Play();
                boostSquare.X = player2.X - boostSquare.Width;
                MoveBoostSquare();
                MovePlayer2();
                player2Speed++;
            }

            //if player gets to 5 points they win
            if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                winnerLabel.Visible = true;
                winnerLabel.Text = "Player 1  Wins!!";
            }
            else if (player2Score == 5)
            {
                gameTimer.Enabled = false;
                winnerLabel.Visible = true;
                winnerLabel.Text = "Player 2  Wins!!";
            }

            ////making the blue power square appear on screen for different times
            //time--;
            //if (time == 250)
            //{
            //    blueX = -100;
            //    blueY = -100;
            //}

            //if (time == 0)
            //{
            //    time = randGen.Next(50, 500);
            //    bluePower.X = randGen.Next(0, 320);
            //    bluePower.Y = randGen.Next(0, 260);
            //}

            ////setting the power up for the blue square
            //if (player1.IntersectsWith(bluePower))
            //{
            //    if (time != 0)
            //    {
            //        player2.X = -100;
            //        player2.Y = -100;
            //        boostSquare.X = -100;
            //        boostSquare.Y = -100;
            //        bluePower.X = -100;
            //        bluePower.Y = -100;
            //    }
            //}
            //else if (time == 0)
            //{
            //    MoveSquare();
            //    MoveBoostSquare();
            //    BluePowerMove();
            //    MovePlayer2();
            //}

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(black, gameBoard);
            e.Graphics.FillRectangle(purple, player1);
            e.Graphics.FillRectangle(orange, player2);
            e.Graphics.FillRectangle(white, square);
            e.Graphics.FillRectangle(yellow, boostSquare);
            e.Graphics.DrawRectangle(whitePen, gameOutline);
            //e.Graphics.FillRectangle(Brushes.DodgerBlue, bluePower);
        }

        public void MoveSquare()
        {
            // get a random value for each and place them in the variables 
            randomX = randGen.Next(1, 340);
            randomY = randGen.Next(1, 290);

            square.X = randomX;
            square.Y = randomY;
        }

        //public void BluePowerMove()
        //{
        //    // get a random value for each and place them in the variables 
        //    randomX = randGen.Next(1, 340);
        //    randomY = randGen.Next(1, 290);

        //    bluePower.X = randomX;
        //    bluePower.Y = randomY;
        //}

        public void MoveBoostSquare()
        {
            // get a random value for each and place them in the variables 
            randomX = randGen.Next(10, 340);
            randomY = randGen.Next(10, 290);

            boostSquare.X = randomX;
            boostSquare.Y = randomY;
        }

        public void MovePlayer1()
        {
            randomX = randGen.Next(1, 349);
            randomY = randGen.Next(1, 295);

            player1.X = randomX;
            player1.Y = randomY;
        }

        public void MovePlayer2()
        {
            randomX = randGen.Next(1, 349);
            randomY = randGen.Next(1, 295);

            player2.X = randomX;
            player2.Y = randomY;
        }

    }
}
