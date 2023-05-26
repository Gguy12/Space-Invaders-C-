using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class Swarm
    {
        int count = 41;
        bool IsShooting;
        int ToDraw;
        Alien[] swarm;
        // 45 - 82
        MTP Bullet = new MTP(0, 0, ',', ConsoleColor.White, ConsoleColor.Black, 1);
        public Swarm(int lives)
        {
            swarm = new Alien[40];
            for (int i = 0; i < 40; i++)
            {
                int y = 2;
                if (i > 9 && i < 20)
                    y = 5;
                else if (i < 30 && i > 19)
                    y = 8;
                else if (i < 40 && i > 29)
                    y = 11;
                swarm[i] = new Alien(45 + (i % 10 * 4), y, i / 10, 5, lives);
            }
        }
        static Random rnd = new Random();
        public void Draw()
        {
            for (int i = 0; i < 40; i++)
            {
                if (swarm[i].GetIsAlive())
                    swarm[i].Draw();
            }

        }
        public void UnDraw()
        {
            for (int i = 0; i < 40; i++)
            {
                if (swarm[i].GetIsAlive())
                    swarm[i].UnDraw();
            }

        }
        public void MoveRight()
        {

            for (int i = 39; i >= 0; i--)
            {
                if (swarm[i].GetIsAlive())
                {
                    //Msound.Play();
                    swarm[i].MoveRight();


                }

            }


        }
        public void MoveLeft()
        {
            UnDraw();
            for (int i = 0; i < 40; i++)
            {
                if (swarm[i].GetIsAlive())
                    swarm[i].MoveLeft();
            }
            Draw();

        }
        public void SetIsShooting(bool ish)
        {
            this.IsShooting = ish;
        }
        public bool GetIsShooting()
        {
            return this.IsShooting;
        }
        public void DecCount()
        {
            this.count--;
        }
        public int GetCont()
        {
            return this.count;
        }
        public int GetRightX()
        {
            int big = 0;
            for (int i = 0; i < 39; i++)
            {
                if (swarm[i].GetRightX() > big)
                    if (swarm[i].GetIsAlive())
                        big = swarm[i].GetRightX();
            }
            return big;
        }
        public int GetLeftX()
        {
            int sml = 1000;
            for (int i = 0; i < 39; i++)
            {
                if (swarm[i].GetLeftX() < sml && swarm[i].GetIsAlive())
                    if (swarm[i].GetIsAlive())
                        sml = swarm[i].GetLeftX();
            }
            return sml;
        }
        public void MoveDown()
        {
            UnDraw();
            for (int i = 0; i > 39; i++)
            {
                if (swarm[i].GetIsAlive())
                    swarm[i].MoveDown();
            }
            Draw();

        }
        public bool TryToKillAlien(int x, int y)
        {
            for (int i = 0; i < 39; i++)
            {
                if (swarm[i].GetIsAlive())
                    if (swarm[i].GetLeftX() == x || swarm[i].GetMiddleX() == x || swarm[i].GetRightX() == x)
                    {
                        if (swarm[i].GetY() == y)
                        {
                            swarm[i].Kill();
                            
                            swarm[i].UnDraw();

                            return true;
                        }
                    }
            }
            return false;

        }
        public int GetCount()
        {
            return this.count;
        }
        public void StartShooting()
        {
            int rnum;
            while (true)
            {
                int rni = rnd.Next(0, 40);
                if (swarm[rni].GetIsAlive())
                {
                    rnum = rni;
                    break;
                }
            }
            ToDraw = rnum;
            this.IsShooting = true;
            Bullet.SetX(swarm[rnum].GetMiddleX());
            Bullet.SetY(swarm[rnum].GetMiddleY());

        }
        public void Shoot()
        {
            Bullet.UnDraw();
            Bullet.MoveDown();
            Bullet.Draw();

        }
        public void TryStopShooting()
        {
            if (Bullet.GetY() == 28)
            {
                this.IsShooting = false;
                Bullet.UnDraw();
            }
        }
        public void TryStopShooting(PlayerShip pl)
        {
            if (Bullet.GetY() == pl.GetBuletY() && Bullet.GetX() == pl.GetBuletX())
            {
                this.IsShooting = false;
                Bullet.UnDraw();
            }
        }
        public void ReDraw()
        {
            for (int i = 0; i < 39; i++)
            {
                if (swarm[i].GetMiddleX() == Bullet.GetX())
                {
                    if (swarm[i].GetLeftY() == Bullet.GetY() || swarm[i].GetMiddleY() == Bullet.GetY() + 1 || swarm[i].GetMiddleY() == Bullet.GetY() - 1 || swarm[i].GetLeftY() == Bullet.GetY() || swarm[i].GetLeftY() == Bullet.GetY() + 1 || swarm[i].GetLeftY() == Bullet.GetY() - 1 || swarm[i].GetRightY() == Bullet.GetY() || swarm[i].GetRightY() == Bullet.GetY() + 1 || swarm[i].GetRightY() == Bullet.GetY() - 1)
                    {
                        if (swarm[i].GetIsAlive())
                        {
                            swarm[i].Draw();
                        }
                    }
                }

            }
        }
        public bool TryToKillPlayer(PlayerShip pl)
        {
            for (int i = 1; i < 8; i++)
            {
                if(pl.GetShipX(i) == Bullet.GetX() && pl.GetShipY(i) == Bullet.GetY())
                {
                    pl.KillShip();
                    Bullet.UnDraw();
                    StartShooting();
                    return true;
                }    

            }
            return false;
        }

    }
}
