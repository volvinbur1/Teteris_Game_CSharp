using System;
using System.Drawing;
using System.Windows.Forms;
namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Figure //all information about the generated figure
        {
            public int type; //indicates for color and a type of the figure (1-7)
            public int state; //state of figure (1-4)
            public int x1, x2, x3, x4; //vertical figure coordinates (1-10)
            public int y1, y2, y3, y4; //horizontal figure coordinates (1-20)
        }

        TetrisLogic TL = new TetrisLogic();
        Figure figure;

        int[,] gameFieldArray = new int[23, 10]; //this array save info about game field. Elements (2-21):(0-9) will be drawn in a panel
        int score, burnedLines;

        bool isPossibleGenerateNewFigure = true, movingIsAllow = true;
        bool gameIsOn;

        private void newGameButton_Click(object sender, EventArgs e)
        {
            score = 0;
            burnedLines = 0;

            scoreTextBox.Text = score.ToString();
            linesTextBox.Text = burnedLines.ToString();

            label3.Visible = false;
            gameIsOn = true;
            isPossibleGenerateNewFigure = true;

            tetrisTableMethod();
            DrawingGridAndFigures();

            timer1.Interval = 400;

            timer1.Start();
        }

        private void tetrisTableMethod()
        {
            for (int i = 0; i < gameFieldArray.GetLength(0); i++)
                for (int j = 0; j < gameFieldArray.GetLength(1); j++)
                    gameFieldArray[i, j] = 0;

            for (int i = 0; i < gameFieldArray.GetLongLength(1); i++)
                gameFieldArray[22, i] = -1; // making the lower level equal "1" tell program that it isn`t possible move the figure down
        }

        private void DrawingGridAndFigures()
        {
            Pen colorPen = new Pen(Color.Black);
            Graphics g = gameFieldPanel.CreateGraphics();

            int panelWidth = gameFieldPanel.Width;
            for (int i = panelWidth / 10; i <= gameFieldPanel.Width; i += panelWidth / 10)
                g.DrawLine(colorPen, i, 0, i, gameFieldPanel.Height);  // drawing vertical lines

            int panelHeight = gameFieldPanel.Height;
            for (int i = panelHeight / 20; i <= gameFieldPanel.Height; i += panelHeight / 20)
                g.DrawLine(colorPen, 0, i, gameFieldPanel.Width, i);  //drawing horizontal lines


            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 2; i < gameFieldArray.GetLength(0) - 1; i++)
                for (int j = 0; j < gameFieldArray.GetLength(1); j++)
                {
                    switch (gameFieldArray[i, j])  //choosing a color of figure according its number Figure.type 
                    {
                        case 0:
                            {
                                brush = new SolidBrush(Color.White);

                                g.FillRectangle(brush, (((j + 1) * gameFieldPanel.Height / 20) - gameFieldPanel.Height / 20) + 1,(((i - 1)  * gameFieldPanel.Width / 10) - gameFieldPanel.Width / 10) + 1, gameFieldPanel.Width / 10 - 1, gameFieldPanel.Height / 20 - 1);
                                break;
                            }
                        case 1:
                                brush = new SolidBrush(Color.Blue);
                                break;
                        case 2:
                                brush = new SolidBrush(Color.DarkBlue);
                                break;
                        case 3: 
                                brush = new SolidBrush(Color.Orange);
                                break;
                        case 4:
                                brush = new SolidBrush(Color.Yellow);
                                break;
                        case 5:
                                brush = new SolidBrush(Color.Green);
                                break;
                        case 6:
                                brush = new SolidBrush(Color.Purple);
                                break;
                        case 7:
                                brush = new SolidBrush(Color.Red);
                                break;
                    }
                    if(gameFieldArray[i, j] != 0)
                        g.FillRectangle(brush, (((j + 1) * gameFieldPanel.Height / 20) - gameFieldPanel.Height / 20) + 1, (((i - 1) * gameFieldPanel.Width / 10) - gameFieldPanel.Width / 10) + 1, gameFieldPanel.Width / 10 - 1, gameFieldPanel.Height / 20 - 1);
                }
            g.Dispose();
        }

        private bool pausedGame; 

        private void PauseContinueButton_Click(object sender, EventArgs e)
        {
            if (gameIsOn)
                if (!pausedGame)
                {
                    pauseContinueButton.Text = @"Continue";
                    pausedGame = true;
                    timer1.Stop();
                }
                else
                {
                    pauseContinueButton.Text = @"Pause";
                    pausedGame = false;
                    timer1.Start();
                }
        }

        private void MainKeyDownMethod(object sender, KeyEventArgs e)
        {
            if (movingIsAllow && (e.KeyData == Keys.A || e.KeyData == Keys.Left))
            {
                TL.moveFigureLeft(ref gameFieldArray, ref figure.x1, ref figure.y1, ref figure.x2, ref figure.y2, ref figure.x3, ref figure.y3, ref figure.x4, ref figure.y4, figure.type, figure.state);
                DrawingGridAndFigures();
            }
            if (movingIsAllow && (e.KeyData == Keys.D || e.KeyData == Keys.Right))
            { 
                TL.moveFigureRight(ref gameFieldArray, ref figure.x1, ref figure.y1, ref figure.x2, ref figure.y2, ref figure.x3, ref figure.y3, ref figure.x4, ref figure.y4, figure.type, figure.state);
                DrawingGridAndFigures();
            }
            if (movingIsAllow && (e.KeyData == Keys.W || e.KeyData == Keys.Up))
            {
                TL.rotateFigure(ref gameFieldArray, ref figure.x1, ref figure.y1, ref figure.x2, ref figure.y2, ref figure.x3, ref figure.y3, ref figure.x4, ref figure.y4, figure.type, ref figure.state);
                DrawingGridAndFigures();
            }
            if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
                timer1.Interval = 1;
        }  

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPossibleGenerateNewFigure)
            {
                TL.figureGenerating(ref gameFieldArray, out figure.x1, out figure.y1, out figure.x2, out figure.y2, out figure.x3, out figure.y3, out figure.x4, out figure.y4, out figure.type, out figure.state);
                isPossibleGenerateNewFigure = false;
            }

            bool comeDown = TL.isComeDownPossible(gameFieldArray, figure.x1, figure.y1, figure.x2, figure.y2, figure.x3, figure.y3, figure.x4, figure.y4, figure.type, figure.state);

            if (comeDown)
            {
                TL.moveFigureDown(ref gameFieldArray, ref figure.x1, ref figure.y1, ref figure.x2, ref figure.y2, ref figure.x3, ref figure.y3, ref figure.x4, ref figure.y4, figure.state);

                DrawingGridAndFigures();
                movingIsAllow = true;
            }
            else
            {
                CountingScores();
                movingIsAllow = false;
                isPossibleGenerateNewFigure = true;
                timer1.Interval = 400;
            }

            //to end the game
            for (int i = 0; i < gameFieldArray.GetLength(1); i++)
                if (gameFieldArray[0, i] != 0 && !comeDown)  // end the game when there is no-wight square in the hightest level and it isn`t possible move it down 
                {
                    isPossibleGenerateNewFigure = false;
                    timer1.Stop();

                    figure.x1 = 0;
                    figure.x2 = 0;
                    figure.x3 = 0;
                    figure.x4 = 0;

                    figure.y1 = 0;
                    figure.y2 = 0;
                    figure.y3 = 0;
                    figure.y4 = 0;

                    gameIsOn = false;

                    label3.Text = @"Game Over... Your score: " + score.ToString() + "\nYou can do it again. Just press\nthe button.";
                    label3.Visible = true;

                    score = 0;
                    burnedLines = 0;

                    linesTextBox.Text = burnedLines.ToString();
                    scoreTextBox.Text = score.ToString();
                    gameFieldPanel.Invalidate();
                    timer1.Stop();
                    break;
                }
        }

        private void CountingScores()
        {
            int countRows = 0;
            for (int i = gameFieldArray.GetLength(0) - 2; i >= 2; i--)
            {
                int elementNotZero = 0;
                for (int j = 0; j < gameFieldArray.GetLength(1); j++)
                    if (gameFieldArray[i, j] != 0)
                        elementNotZero++;

                if (elementNotZero == gameFieldArray.GetLength(1))
                {
                    countRows++;
                    for(int k = i; k > 0; k --)
                        for (int j = 0; j < gameFieldArray.GetLength(1); j++)
                        {
                            gameFieldArray[k, j] = 0;

                            int buf = gameFieldArray[k, j];
                            gameFieldArray[k, j] = gameFieldArray[k - 1, j];
                            gameFieldArray[k - 1, j] = buf;
                        }
                    i++;
                }
            }

            DrawingGridAndFigures();

            burnedLines += countRows;
            if (countRows == 1)
                score += 100;
            else
                if (countRows == 2)
                score += 300;
            else
                if (countRows == 3)
                score += 700;
            else
                if (countRows == 4)
                score += 1500;
            else
                if (countRows >= 5)
                score += countRows * 400;
             
            linesTextBox.Text = burnedLines.ToString();
            scoreTextBox.Text = score.ToString();
        }
        
    }
}