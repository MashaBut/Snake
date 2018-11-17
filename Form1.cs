using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace snake
{
    public partial class Tail : Form
    {
        SoundPlayer sp;//пожирание еды
        SoundPlayer exit;//врезание в стенку
        List<Rectangle> snake = new List<Rectangle>();//snake
        public int lenghtSnake;// long snake
        public enum Course { UP, DOWN, LEFT, RIGHT };
        public Course course;// направление движения
        public int addX, addY;//смещение координат
        Rectangle food = new Rectangle();//fuild foog
        List<Rectangle> empty_filed = new List<Rectangle>();//free point
        public Random rand = new Random();
        public bool fruit;
        int time;
        int mark;
        int t;
        public Tail()
        {
            InitializeComponent();
            sp = new SoundPlayer(@"sound.wav");
            exit = new SoundPlayer(@"mario.wav");
            message();
        }

        //snake
        private void DrawSnake()
        {
            Graphics graphics = Fuild.CreateGraphics();
            for (int i = 0; i < snake.Count; i++)
            {
                if (i == 0)
                {
                    graphics.FillEllipse(Brushes.Black, snake[i]);
                }
                else
                {
                    graphics.FillEllipse(Brushes.Green, snake[i]);
                }
            }
        }

        //fruit
        private void DrawFruit()
        {
            if (!fruit)
            {
                f:
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Rectangle point = new Rectangle(i * 20, j * 20, 20, 20);
                        if (snake.IndexOf(point) == -1)
                        {
                            empty_filed.Add(point);
                        }
                    }
                }
                food = empty_filed[rand.Next(0, empty_filed.Count - 1)];
                for(int i=0;i<snake.Count;i++)
                {
                    if (snake[i] == food)
                    {
                        goto f;
                    } 
                }
                empty_filed.Clear();
                Graphics g = Fuild.CreateGraphics();
                g.FillEllipse(Brushes.Red, food);
                fruit = true;
            }
            else
            {
                Graphics g = Fuild.CreateGraphics();
                g.FillEllipse(Brushes.Red, food);
            }
        }

        //последующие игры
        private void message()
        {
            time = 0;
            t = 0;
            TimerLabel.Text = t.ToString();
            mark = 0;
            textMark.Text = mark.ToString();
            Refresh();
            snake.Clear();
            empty_filed.Clear();
            course = Course.RIGHT;
            snake.Add(new Rectangle(320, 320, 20, 20));
            snake.Add(new Rectangle(300, 320, 20, 20));
            snake.Add(new Rectangle(280, 320, 20, 20));
            timer1.Interval = 210;
            lenghtSnake = 3;
            fruit = false;
            DrawSnake();
            DrawFruit();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        //ошибка змеи
        private void erorr()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            exit.Play();
            DialogResult result1 = MessageBox.Show(
                 "Желаете начать игру заново?", "Ой!",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1
                 );
            if (result1 == DialogResult.OK)
            {
                message();
            }
            else if (result1 == DialogResult.Cancel)
            {
                Close();
                return;
            }
        }

        private  void drove()
        {   Refresh();
            if (course == Course.UP)
            {
                addX = 0;
                addY = -20;
            }
            if (course == Course.DOWN)
            {
                addX = 0;
                addY = 20;
            }
            if (course == Course.LEFT)
            {
                addX = -20;
                addY = 0;
            }
            if (course == Course.RIGHT)
            {
                addX = 20;
                addY = 0;
            }
            Rectangle prev_segment = snake[0];
            Rectangle next_segment;
            for (int i = 0; i < snake.Count - 1; i++)
            {
                if (i == 0)
                {
                    snake[i] = new Rectangle(snake[i].X + addX, snake[i].Y + addY, 20, 20);
                }
                if (!(snake[i + 1].IsEmpty))
                {
                    next_segment = snake[i + 1];
                    snake[i + 1] = prev_segment;
                    prev_segment = next_segment;
                }
            }
            if (snake[0] == food)
            {
                snake.Add(food);
                lenghtSnake++;
                mark += 10;
                textMark.Text = Convert.ToString(mark);
                sp.Play();
                if (lenghtSnake % 7 == 0)
                {if (timer1.Interval >= 30)
                    {
                        timer1.Interval -= 30;
                    }
                }
                fruit = false;
            }
            for (int i = 1; i < snake.Count - 1; i++)
            {
                if (snake[0] == snake[i])
                {
                    erorr();
                }
            }
            if ((snake[0].X < 0 || snake[0].X > 460 || snake[0].Y < 0 || snake[0].Y > 500))
            {
                erorr();
            }
            DrawSnake();
            DrawFruit();
        }
        //время движения змейки
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            drove();
        }
        //время игры
        private void timer2_Tick(object sender, EventArgs e)
        {
            t++;
            TimerLabel.Text = t.ToString();
        }
        //работа клавиш
        private void Tail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && course != Course.DOWN)
            {
                course = Course.UP;
            }
            if (e.KeyCode == Keys.Down && course != Course.UP)
            {
                course = Course.DOWN;
            }
            if (e.KeyCode == Keys.Left && course != Course.RIGHT)
            {
                course = Course.LEFT;
            }
            if (e.KeyCode == Keys.Right && course != Course.LEFT)
            {
                course = Course.RIGHT;
            }
        }
    }
}