using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class MTP
    {
        public enum dir { Up, UpRight, Right, DownRight, Down, LeftDown, Left, LeftUp };
        int MaxX = 40; int MaxY = 40;
        int x; int y;
        char ch;
        ConsoleColor Cool;
        ConsoleColor bcolor;
        dir direction = dir.Up;
        int speed;
        bool Edge = false;
        static public Random rnd = new Random();
        
        public bool OnEdge()
        {
            if (this.x >= MaxX || this.x <= -MaxX || this.y >= MaxY || this.y <= -MaxY)
                return true;
            return false;

        }
        
        public MTP(int x, int y, char ch, ConsoleColor cool, ConsoleColor bcolor, int speed, dir direction = dir.Up)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
            this.Cool = cool;
            this.speed = speed;
            this.direction = direction;
            this.bcolor = bcolor;
        }
        public void Draw()
        {

            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = this.bcolor;
            Console.ForegroundColor = this.Cool;
            Console.Write(this.ch);

        }
        public void UnDraw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ");
            

        }
        public void MoveUp()
        {
            if (this.y - speed >= 0)
                this.y -= this.speed;
        }
        public void MoveDown()
        {

            this.y += this.speed;
        }
        public void MoveLeft()
        {
            if (this.x - speed >= 0)
                this.x -= this.speed;
        }
        public void MoveRight()
        {
            this.x += this.speed;
        }
        public void MoveUpRight()
        {
            if (this.y - speed >= 0)
                this.y -= -this.speed;
            this.x += this.speed;
        }
        public void MoveUpLeft()
        {
            if (this.y - speed >= 0)
                this.y -= -this.speed;
            if (this.x - speed >= 0)
                this.x -= -this.speed;
        }
        public void MoveDownRight()
        {
            this.y += this.speed;
            this.x += this.speed;
        }
        public void MoveDownLeft()
        {
            this.y += this.speed;
            if (this.x - speed >= 0)
                this.x -= -this.speed;
        }
        public void EdgeFlip()
        {
            if (Edge)
            {
                this.direction = (dir)((int)this.direction ^ 4);
                MoveOneStep();
            }
        }
        public void MoveOneStep()
        {
            UnDraw();
            switch (this.direction)
            {

                case dir.Up:
                    MoveUp();
                    break;
                case dir.UpRight:
                    MoveUpRight();
                    break;
                case dir.Right:
                    MoveRight();
                    break;
                case dir.DownRight:
                    MoveDownRight();
                    break;
                case dir.Down:
                    MoveDown();
                    break;
                case dir.LeftDown:
                    MoveDownLeft();
                    break;
                case dir.Left:
                    MoveLeft();
                    break;
                case dir.LeftUp:
                    MoveUpLeft();
                    break;
                default:
                    break;

            }
            Draw();
        }
        public bool Tauching(MTP dot)
        {
            if (dot.GetY() == this.y && dot.GetX() == this.x)
            {
                return true;
            }
            return false;
        }
        public int GetY()
        {
            return this.y;
        }
        public int GetX()
        {
            return this.x;
        }
        public void SetDirection(int Direction)
        {
            this.direction = (dir)Direction;
        }
        public dir GetDir()
        {
            return this.direction;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public int GetSpeed()
        {
            return this.speed;
        }
        public ConsoleColor GetColor()
        {
            return this.Cool;
        }
    }


}
