using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryController;

namespace snake
{
    public partial class SnakeGameForm : Form
    {
        private int IdAccount { get; set; }
        private static int timesScaleButton = 0, maxTimesScaleButton = 5;
        private static bool isAnimationUp = true;
        private static bool isMoveed = false;
        private static int sizeCell = 20;
        private static int sizeBord = 400;
        private readonly GameBord gameBord = new GameBord();
        private readonly Snake snake = new Snake();
        private readonly PictureBox fruit = new PictureBox { Size = new Size(sizeCell, sizeCell), BackColor = Color.Red };
        public SnakeGameForm(int IdAccount)
        {
            InitializeComponent();
            this.IdAccount = IdAccount;
            ShowMenu();
        }
        private void ShowMenu()
        {
            this.Controls.Clear();
            this.Controls.Add(StartButton);
            StartButton.Enabled = true;
            StartButton.Visible = true;
            timer.Tick -= Update;
            timer.Tick += new EventHandler(UpdateMenu);
            timer.Start();
        }
        private void UpdateMenu(object sender, EventArgs e)
        {
            int dir = isAnimationUp ? 1 : -1;
            timesScaleButton += dir;
            StartButton.Size = new Size(StartButton.Size.Width + dir, StartButton.Size.Height + dir);
            isAnimationUp = (timesScaleButton == maxTimesScaleButton || timesScaleButton == 0) ? !isAnimationUp : isAnimationUp;
        }
        private void StartGame()
        {
            this.Controls.Clear();
            timer.Tick -= UpdateMenu;
            label1.Visible = true;
            scoreLabel.Visible = true;
            this.Controls.Add(label1);
            this.Controls.Add(scoreLabel);
            this.Controls.AddRange(gameBord.HorizonLine);
            this.Controls.AddRange(gameBord.VerticalLine);
            this.Controls.AddRange(snake.Head);
            this.Controls.Add(fruit);
            ((Control) this).KeyDown += new KeyEventHandler(KeyDown);
            timer.Tick += new EventHandler(Update);
            timer.Start();
            GenFruit();
        }
        private void Update(object sender, EventArgs e)
        {
            isMoveed = false;
            snake.Move();
            if(IsEat())
            {
                snake.Eat();
                if (IsWin())
                {
                    ShowMenu();
                }
                this.Controls.Add(snake.Head[snake.Size - 1]);
                GenFruit();
            }
            if(IsMoveToBorder() || IsMoveToTail())
            {
                for (int i = 0; i < snake.Size; ++i)
                {
                    this.Controls.Remove(snake.Head[i]);
                }
                snake.Dead();
                ResultMessage();
                this.Controls.AddRange(snake.Head);
                GenFruit();
            }
            scoreLabel.Text = (snake.Size - 1).ToString();
        }

        private void ResultMessage()
        {
            timer.Stop();
            int Score = Convert.ToInt32(scoreLabel.Text);
            int TotalMoney = Score * Controller.PriceOneScore;
            switch (Controller.GiveMoneyForAccount(IdAccount, Score))
            {
                case true:
                    MessageBox.Show($"Вы заработали {TotalMoney} монет!");
                    break;
                case false:
                    MessageBox.Show($"Произошла какая-то ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            this.Close();
        }

        private bool IsEat()
        {
            return snake.Head[0].Location == fruit.Location;
        }
        private bool IsMoveToTail()
        {
            bool answer = false;
            for(int i = 1; i < snake.Size; ++i)
            {
                if(snake.Head[0].Location == snake.Head[i].Location)
                {
                    answer = true;
                }
            }
            return answer;
        }
        private bool IsMoveToBorder()
        {
            return snake.Head[0].Location.X > sizeBord - 1
                || snake.Head[0].Location.Y > sizeBord - 1
                || snake.Head[0].Location.X < 0
                || snake.Head[0].Location.Y < 0;
        }
        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (!isMoveed)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        snake.Dir = (snake.Dir.Y != 1) ? new Point(0, -1) : snake.Dir;
                        break;
                    case Keys.Down:
                        snake.Dir = (snake.Dir.Y != -1) ? new Point(0, 1) : snake.Dir;
                        break;
                    case Keys.Left:
                        snake.Dir = (snake.Dir.X != 1) ? new Point(-1, 0) : snake.Dir;
                        break;
                    case Keys.Right:
                        snake.Dir = (snake.Dir.X != -1) ? new Point(1, 0) : snake.Dir;
                        break;
                    case Keys.Escape:
                        ShowMenu();
                        break;
                }
                isMoveed = true;
            }
        }
        private class Snake
        {
            int sizeMax = sizeBord;
            public PictureBox[] Head { get; private set; }
            public int Size { get; private set; }
            public Point Dir{ get; set; }
            public Snake()
            {
                Initial();
            }
            private void Initial()
            {
                Size = 1;
                Head = new PictureBox[sizeMax];
                Head[0] = new PictureBox
                {
                    Size = new Size(sizeCell, sizeCell),
                    Location = new Point(sizeBord / 2, sizeBord / 2),
                    BackColor = Color.Lime
                };
                Dir = new Point(0, 0);
            }
            public void Move()
            {
                for(int i = Size - 1; i >= 1; --i)
                {
                    Head[i].Location = Head[i - 1].Location;
                }
                Head[0].Location = new Point(Head[0].Location.X + sizeCell * Dir.X, Head[0].Location.Y + sizeCell * Dir.Y);
            }
            public void Eat()
            {
                ++Size;
               
                Head[Size - 1] = new PictureBox
                {
                    Size = new Size(sizeCell, sizeCell),
                    Location = new Point(Head[Size - 2].Location.X - Dir.X, Head[Size - 2].Location.Y - Dir.Y),
                    BackColor = Color.Lime
                };
            }
            public void Dead()
            {
                Initial();
            }
        }
        private void GenFruit()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, sizeCell) * sizeCell;
            int y = rnd.Next(1, sizeCell) * sizeCell;
            fruit.Location = new Point(x, y);
            if (IsFruitInSnake())
            {
                GenFruit();
            }
            return;
        }
        private bool IsFruitInSnake()
        {
            bool answer = false;
            for(int i = 0; i < snake.Size; ++i)
            {
                if(fruit.Location == snake.Head[i].Location)
                {
                    answer = true;
                }
            }
            return answer;
        }
        private class GameBord
        {
            public PictureBox[] HorizonLine { get; }
            public PictureBox[] VerticalLine { get; }
            public GameBord()
            {
                HorizonLine = CreateLine((width, height) => new Size(width, height), (x, y) => new Point(y, x));
                VerticalLine = CreateLine((width, height) => new Size(height, width), (x, y) => new Point(x, y));

            }
            private delegate Size SizeLine(int width, int height);
            private delegate Point PointLine(int x, int y);
            private PictureBox[] CreateLine(SizeLine sizeLine, PointLine pointLine)
            {
                PictureBox[] line = new PictureBox[sizeCell];
                for(int i = 0, shift = 20; i < line.Length; ++i, shift += 20)
                {
                    line[i] = new PictureBox()
                    {
                        Size = sizeLine(sizeBord, 1),
                        Location = pointLine(shift, 0),
                        BackColor = Color.White
                    };
                }
                return line;
            }
        }

        private void SnakeGameForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Для пополнния баланса необходимо пройти мини игру. \r\n" +
                          "Эквивалент: \r\n" +
                          $">> 1 балл = {Controller.PriceOneScore} монет.\r\n" +
                          "Для старта:\r\n" +
                          ">>Нужно нажать одну из стрелок. Управление все происходит на стрелках.\r\n ";
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StartButton.Visible = false;
            label2.Visible = false;
            timer.Stop();
            StartGame();
        }

        private bool IsWin()
        {
            return snake.Size == sizeBord;
        }
    }
}
