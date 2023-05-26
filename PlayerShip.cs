using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

namespace AI
{
    class PlayerShip
    {
        MTP Ship1 = new MTP(33, 28, '/', ConsoleColor.Black, ConsoleColor.White, 1, MTP.dir.Left);
        MTP Ship2 = new MTP(34, 28, 'O', ConsoleColor.Black, ConsoleColor.Blue, 1, MTP.dir.Left);
        MTP Ship3 = new MTP(35, 28, ' ', ConsoleColor.Black, ConsoleColor.Black, 1, MTP.dir.Left);
        MTP Ship4 = new MTP(36, 28, 'O', ConsoleColor.Black, ConsoleColor.Blue, 1, MTP.dir.Left);
        MTP Ship5 = new MTP(37, 28, '\\', ConsoleColor.Black, ConsoleColor.White, 1, MTP.dir.Left);
        MTP Ship6 = new MTP(36, 27, '\\', ConsoleColor.Black, ConsoleColor.White, 1, MTP.dir.Left);
        MTP Ship7 = new MTP(34, 27, '/', ConsoleColor.Black, ConsoleColor.White, 1, MTP.dir.Left);
        MTP Bullet = new MTP(35, 28, '|', ConsoleColor.Yellow, ConsoleColor.Black, 1, MTP.dir.Up);

        bool IsShooting = false;
        public void MoveLeft()
        {
            UnDraw();
            Ship1.MoveLeft();

            Ship2.MoveLeft();

            Ship3.MoveLeft();

            Ship4.MoveLeft();

            Ship5.MoveLeft();

            Ship6.MoveLeft();

            Ship7.MoveLeft();
            if (!IsShooting)
                Bullet.MoveLeft();
            Draw();

        }
        public void MoveRight()
        {
            UnDraw();
            Ship1.MoveRight();

            Ship2.MoveRight();

            Ship3.MoveRight();

            Ship4.MoveRight();

            Ship5.MoveRight();

            Ship6.MoveRight();

            Ship7.MoveRight();
            if (!IsShooting)
                Bullet.MoveRight();
            Draw();

        }
        public void Draw()
        {

            Ship1.Draw();
            Ship2.Draw();
            Ship3.Draw();
            Ship4.Draw();
            Ship5.Draw();
            Ship6.Draw();
            Ship7.Draw();
            Bullet.Draw();


        }
        public void UnDraw()
        {
            Ship1.UnDraw();
            Ship2.UnDraw();
            Ship3.UnDraw();
            Ship4.UnDraw();
            Ship5.UnDraw();
            Ship6.UnDraw();
            Ship7.UnDraw();
            Bullet.UnDraw();
        }
        public int GetBuletX()
        {
            return this.Bullet.GetX();
        }
        public int GetBuletY()
        {
            return this.Bullet.GetY();
        }
        public bool GetIsShooting()
        {
            return this.IsShooting;
        }
        public void SetBUllety(int num)
        {
            Bullet.SetY(num);
        }
        public void Shoot()
        {
            this.Bullet.MoveOneStep();

        }
        public void SetIsShooting(bool bl)
        {
            this.IsShooting = bl;
        }
        public void UndrawBul()
        {
            this.Bullet.UnDraw();
        }
        public void SetBUlletx(int num)
        {
            Bullet.SetX(num);
        }
        public int GetCurBltX()
        {
            return Ship7.GetX() + 1;
        }
        public int GetShipLeftX()
        {
            return this.Ship1.GetX();
        }
        public int GetShipRightx()
        {
            return this.Ship1.GetX();
        }
        public int GetShipY(int ShipNum)
        {
            if (ShipNum == 1)
                return Ship1.GetY();
            if (ShipNum == 2)
                return Ship2.GetY();
            if (ShipNum == 3)
                return Ship3.GetY();
            if (ShipNum == 4)
                return Ship4.GetY();
            if (ShipNum == 5)
                return Ship5.GetY();
            if (ShipNum == 6)
                return Ship6.GetY();
            if (ShipNum == 7)
                return Bullet.GetY();
            return -1;
        }
        public int GetShipX(int ShipNum)
        {
            if (ShipNum == 1)
                return Ship1.GetX();
            if (ShipNum == 2)
                return Ship2.GetX();
            if (ShipNum == 3)
                return Ship3.GetX();
            if (ShipNum == 4)
                return Ship4.GetX();
            if (ShipNum == 5)
                return Ship5.GetX();
            if (ShipNum == 6)
                return Ship6.GetX();
            if (ShipNum == 7)
                return Bullet.GetX();
            return -1;

        }
        public void KillShip()
        {
            System.Media.SoundPlayer Kill = new System.Media.SoundPlayer(@"C:\Users\IDAN\Desktop\AI\sound effects\explosion.wav");
            Kill.Play();
            
            

        }
    }
}
