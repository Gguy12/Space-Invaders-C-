using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    //        )o( }o{ ]o[ >o<
    class Alien
    {
        static Random rnd = new Random();
        int lives;
        int type;
        bool IsSHootig;
        ConsoleColor color;
        System.Media.SoundPlayer Adeath = new System.Media.SoundPlayer(@"C:\Users\IDAN\Desktop\AI\sound effects\invaderkilled.wav");
        MTP LeftPart;
        MTP MiddlePart;
        MTP RightPart;
        bool IsAlive = true;
        public Alien(int x, int y, int type, int speed,int lives)
        {
            if (type == 3)
            {
                LeftPart = new MTP(x, y, ')', (ConsoleColor)rnd.Next(1, 14), ConsoleColor.Black, speed, MTP.dir.Right);
                MiddlePart = new MTP(x + 1, y, 'o', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
                RightPart = new MTP(x + 2, y, '(', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
            }
            if (type == 2)
            {
                LeftPart = new MTP(x, y, '}', (ConsoleColor)rnd.Next(1, 14), ConsoleColor.Black, speed, MTP.dir.Right);
                MiddlePart = new MTP(x + 1, y, 'o', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
                RightPart = new MTP(x + 2, y, '{', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
            }
            if (type == 1)
            {
                LeftPart = new MTP(x, y, ']', (ConsoleColor)rnd.Next(1, 14), ConsoleColor.Black, speed, MTP.dir.Right);
                MiddlePart = new MTP(x + 1, y, 'o', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
                RightPart = new MTP(x + 2, y, '[', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
            }
            if (type == 0)
            {
                LeftPart = new MTP(x, y, '>', (ConsoleColor)rnd.Next(1, 14), ConsoleColor.Black, speed, MTP.dir.Right);
                MiddlePart = new MTP(x + 1, y, 'o', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
                RightPart = new MTP(x + 2, y, '<', LeftPart.GetColor(), ConsoleColor.Black, speed, MTP.dir.Right);
            }
            this.lives = lives;

        }
        public void MoveLeft()
        {

            UnDraw();
            LeftPart.MoveLeft();
            MiddlePart.MoveLeft();
            RightPart.MoveLeft();
            Draw();

        }
        public void MoveRight()
        {
            UnDraw();
            LeftPart.MoveRight();
            MiddlePart.MoveRight();
            RightPart.MoveRight();
            Draw();

        }
        public void MoveDown()
        {
            UnDraw();
            LeftPart.MoveDown();
            MiddlePart.MoveDown();
            RightPart.MoveDown();
            Draw();
        }
        public void Draw()
        {
            LeftPart.Draw();
            MiddlePart.Draw();
            RightPart.Draw();

        }
        public void UnDraw()
        {
            LeftPart.UnDraw();
            MiddlePart.UnDraw();
            RightPart.UnDraw();

        }
        public void SetSpeed(int speed)
        {
            LeftPart.SetSpeed(speed);
            MiddlePart.SetSpeed(speed);
            RightPart.SetSpeed(speed);
        }
        public int GetSpeed()
        {
            return LeftPart.GetSpeed();
        }
        public int GetRightX()
        {
            return RightPart.GetX();
        }
        public int GetLeftX()
        {
            return LeftPart.GetX();
        }
        public int GetMiddleX()
        {
            return MiddlePart.GetX();

        }
        public int GetMiddleY()
        {
            return MiddlePart.GetY();

        }
        public int GetY()
        {
            return MiddlePart.GetY();
        }

        public void Kill()

        {
            this.IsAlive = false;
            Adeath.Play();
        }
        public bool GetIsAlive()
        {
            return this.IsAlive;
        }
        public int GetLeftY()
        {
            return LeftPart.GetY();
        }
        public int GetRightY()
        {
            return RightPart.GetY();
        }
        public void SetLives(int b)
        {
            this.lives -= b;
        }
        public int GetLives()
        {
            return lives;
        }

    }

}
